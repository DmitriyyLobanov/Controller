using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ChinaTest.GUI_Forms
{
    public partial class MainFormFull : Form
    {
        private readonly string PathX = $"{Environment.CurrentDirectory}\\motorSettingsX.json";
        private readonly string PathY = $"{Environment.CurrentDirectory}\\motorSettingsY.json";
        private readonly string PathZ = $"{Environment.CurrentDirectory}\\motorSettingsZ.json";

        private FileIOService _fileIOService;
        private Controller _controller;
        private SetterSpeed _setterSpeed;
        private short _port;

        private AxisModel? _axisDataX;
        private AxisModel? _axisDataY;
        private AxisModel? _axisDataZ;
        private double _defaultSpeed = 100;
        private double _maxSpeed = 255;

        private Mover _mover;
        private Mover _moverX;
        private Mover _moverY;
        private Mover _moverZ;
        private double _point;

        private List<AxisModel> usableAxis;

        public MainFormFull()
        {
            _controller = new Controller();
            _setterSpeed = new SetterSpeed(_controller.Connect);
            _fileIOService = new FileIOService();
            usableAxis = new List<AxisModel>();

            InitializeComponent();
            UpdateComponents();
            _moverX = new Mover(_controller.AxisModelX, _controller.Connect);
            _moverY = new Mover(_controller.AxisModelY, _controller.Connect);
            _moverZ = new Mover(_controller.AxisModelZ, _controller.Connect);
            _mover = _moverX;

            _mover.TimerEnabled += SetTime;
            _mover.TimerItntervaled += SetInterval;
        }


        private void UpdateComponents()
        {
            SelectCOMTextBox.TextChanged += SelectCOMTextBOX_Port;
            _controller.Connect.EnabledConnaction += ConnectStatus;


            StageTypeComboBox.SelectedIndex = 0;
            RunningUnitComboBox.SelectedIndex = 0;
            StepperAngleComboBox.SelectedIndex = 0;
            SubdivisionComboBox.SelectedIndex = 0;
            ScrewLeadComboBox.SelectedIndex = 1;
            TransmissionRatioComboBox.SelectedIndex = 0;
            TravelRangeComboBox.SelectedIndex = 3;

            TargetModeComboBox.SelectedIndex = 0;
            IncrementModeComboBox.SelectedIndex = 0;
            ContinousModeComboBox.SelectedIndex = 0;

            SetSpeedTextBox.Text = _defaultSpeed.ToString();

            MoveModesPanel.Enabled = false;

            DeserializeExistAxes();
            FirstInitialSet_X_Radiobutton();

        }


        #region [СOM connect ans set parameters region]
        private void DeserializeExistAxes()
        {
            string _deserializedAxes = "";

            _axisDataX = _fileIOService.LoadMotor(PathX);

            if (_axisDataX != null)
            {
                SetAxis(_axisDataX);
                Set_X_RadioButton.ForeColor = Color.Green;
                _deserializedAxes = "X ";
                usableAxis.Add(_axisDataX);

                CurrentUnitLabel_X.Text = _axisDataX.RuningUnit.ToString();

            }
            _axisDataY = _fileIOService.LoadMotor(PathY);
            if (_axisDataY != null)
            {
                SetAxis(_axisDataY);
                Set_Y_RadioButton.ForeColor = Color.Green;
                _deserializedAxes += " Y";
                usableAxis.Add(_axisDataY);

                CurrentUnitLabel_Y.Text = _axisDataY.RuningUnit.ToString();
            }
            _axisDataZ = _fileIOService.LoadMotor(PathZ);
            if (_axisDataZ != null)
            {
                SetAxis(_axisDataZ);
                Set_Z_RadioButton.ForeColor = Color.Green;
                _deserializedAxes += " Z";
                usableAxis.Add(_axisDataZ);

                CurrentUnitLabel_Z.Text = _axisDataZ.RuningUnit.ToString();
            }
            if (_deserializedAxes != "")
            {
                MessageBox.Show($"Параметры следующих осей успешно загружены: {_deserializedAxes}, подвижки готовы к работе.");
            }
            else
            {
                MessageBox.Show("Не обнаружены ранее сохраненные параметры осей, перед началом работы заполните параметры.");
            }



        }
        private void FirstInitialSet_X_Radiobutton()
        {
            if (usableAxis.Contains(_axisDataX))
            {
                FillComboBoxes(_axisDataX);
            }
        }


        private void FillComboBoxes(AxisModel axis)
        {
            StageTypeComboBox.SelectedItem = axis.StageType;
            RunningUnitComboBox.SelectedItem = axis.RuningUnit;
            StepperAngleComboBox.SelectedItem = axis.StepperAngle.ToString();
            SubdivisionComboBox.SelectedItem = axis.Subdivision.ToString();
            ScrewLeadComboBox.SelectedItem = axis.ScrewLead.ToString();
            TransmissionRatioComboBox.SelectedItem = axis.TransmissonRatio.ToString();
            TravelRangeComboBox.SelectedItem = axis.TravelRange.ToString();
        }

        private void SetAxis(AxisModel axis)
        {
            _controller.SetAxisValue(axis);
        }


        private void SelectCOMButton_Click(object sender, EventArgs e)
        {
            _controller.Connect.ConnectPort(_port);
            if (_controller.Connect._isConnect)
            {
                MoveModesPanel.Enabled = true;
            }
        }

        private void SelectCOMTextBOX_Port(object sender, EventArgs e)
        {
            try
            {
                _port = short.Parse(SelectCOMTextBox.Text);
            }
            catch
            {

                SelectCOMTextBox.Text = "";
            }
        }
        private void ConnectStatus(bool status)
        {

            if (status)
            {
                ConncetionFailedPictureBox.Visible = false;
                _controller.Connect.EnabledConnaction -= ConnectStatus;

            }
        }

        private void SaveParametersButton_Click(object sender, EventArgs e)
        {
            //TODO: проверка на тип подвижки(включение/отключение поля передаточного отношения)

            AxisModel axisModel = new AxisModel();
            axisModel.StageType = StageTypeComboBox.SelectedItem.ToString();
            axisModel.RuningUnit = RunningUnitComboBox.SelectedItem.ToString();
            axisModel.StepperAngle = Double.Parse(StepperAngleComboBox.SelectedItem.ToString());
            axisModel.Subdivision = Double.Parse(SubdivisionComboBox.SelectedItem.ToString());
            axisModel.ScrewLead = Double.Parse(ScrewLeadComboBox.SelectedItem.ToString());
            axisModel.TransmissonRatio = Double.Parse(TransmissionRatioComboBox.SelectedItem.ToString());
            axisModel.TravelRange = Double.Parse(TravelRangeComboBox.SelectedItem.ToString());

            if (Set_X_RadioButton.Checked)
            {
                if (File.Exists(PathX))
                {
                    DialogResult dialogResult = MessageBox.Show("Парметры оси Х уже заданы ранее, хотите перезаписать их?",
                        "Внимание!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    if (dialogResult == DialogResult.Yes)
                    {
                        axisModel.Name = "X";
                        _fileIOService.SaveData(axisModel, PathX);
                        CurrentUnitLabel_X.Text = axisModel.RuningUnit.ToString();
                    }
                }
                else
                {
                    axisModel.Name = "X";
                    _fileIOService.SaveData(axisModel, PathX);
                    CurrentUnitLabel_X.Text = axisModel.RuningUnit.ToString();
                }

            }
            if (Set_Y_RadioButton.Checked)
            {
                if (File.Exists(PathY))
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "Парметры оси Y уже заданы ранее, хотите перезаписать их?",
                        "Внимание!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    if (dialogResult == DialogResult.Yes)
                    {
                        axisModel.Name = "Y";
                        _fileIOService.SaveData(axisModel, PathY);
                        CurrentUnitLabel_Y.Text = axisModel.RuningUnit.ToString();
                    }
                }
                else
                {
                    axisModel.Name = "Y";
                    _fileIOService.SaveData(axisModel, PathY);
                    CurrentUnitLabel_Y.Text = axisModel.RuningUnit.ToString();
                }
            }
            if (Set_Z_RadioButton.Checked)
            {
                //Реализовать выставление None, чтобы не использовать одну из осей
                throw new NotImplementedException();
                //CurrentUnitLabel_Z.Text = axisModel.RuningUnit.ToString();
            }
        }

        private void Set_X_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton? rb = sender as System.Windows.Forms.RadioButton;
            if (rb.Checked && _axisDataX != null)
            {
                FillComboBoxes(_axisDataX);
            }
        }

        private void Set_Y_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton? rb = sender as System.Windows.Forms.RadioButton;
            if (rb.Checked && _axisDataY != null)
            {
                FillComboBoxes(_axisDataY);
            }
        }

        private void Set_Z_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton? rb = sender as System.Windows.Forms.RadioButton;
            if (rb.Checked && _axisDataZ != null)
            {
                FillComboBoxes(_axisDataZ);
            }
        }

        private void SetSpeedButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(SetSpeedTextBox.Text);

                if (value < _maxSpeed)
                {
                    _setterSpeed.SetSpeed(value.ToString());
                }
                else
                {
                    _setterSpeed.SetSpeed(_maxSpeed.ToString());
                    SetSpeedTextBox.Text = "255";
                }
            }
            catch
            {
                SetSpeedTextBox.Text = _defaultSpeed.ToString();
            }

        }
        #endregion

        #region[moving stages region]
        private void SetTime(bool isTime)
        {
            ControllerTimer.Enabled = isTime;
        }

        private void SetInterval(int value)
        {
            ControllerTimer.Interval = value;
        }
        private void CheckAxisTargetMode()
        {
            if (_mover != null)
            {
                if (TargetModeComboBox.SelectedItem.ToString() == "X")
                    _mover = _moverX;
                else if (TargetModeComboBox.SelectedItem.ToString() == "Y")
                    _mover = _moverY;
                else if (TargetModeComboBox.SelectedItem.ToString() == "Z")
                    _mover = _moverZ;
                return;
            }

            _moverX = new Mover(_controller.AxisModelX, _controller.Connect);
            _moverY = new Mover(_controller.AxisModelY, _controller.Connect);
            _moverZ = new Mover(_controller.AxisModelZ, _controller.Connect);
            _mover = _moverX;

            _mover.TimerEnabled += SetTime;
            _mover.TimerItntervaled += SetInterval;

        }
        private void CheckAxisIncrementMode()
        {
            if (_mover != null)
            {
                if (IncrementModeComboBox.SelectedItem.ToString() == "X")
                    _mover = _moverX;
                else if (IncrementModeComboBox.SelectedItem.ToString() == "Y")
                    _mover = _moverY;
                else if (IncrementModeComboBox.SelectedItem.ToString() == "Z")
                    _mover = _moverZ;
                return;
            }

            _moverX = new Mover(_controller.AxisModelX, _controller.Connect);
            _moverY = new Mover(_controller.AxisModelY, _controller.Connect);
            _moverZ = new Mover(_controller.AxisModelZ, _controller.Connect);
            _mover = _moverX;

            _mover.TimerEnabled += SetTime;
            _mover.TimerItntervaled += SetInterval;

        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            CheckAxisTargetMode();
            if (_mover != null)
            {
                _mover.MoveToHome();
                CheckAxisPosition(_mover);
            }
        }
        private void CheckAxisPosition(Mover mover)
        {
            if (mover.AxisName == "X")
                CurrentX_TextBox.Text = mover.GetPoint().ToString();
            else if (mover.AxisName == "Y")
                CurrentY_TextBox.Text = mover.GetPoint().ToString();
            else if (mover.AxisName == "Z")
                CurrentZ_TextBox.Text = mover.GetPoint().ToString();
        }

        private void TargetModeTextBox_TextChanged(object sender, EventArgs e)
        {
            //CheckAxisTargetMode();

            //try
            //{
            //    if (double.Parse(TargetModeTextBox.Text) < _mover.TravelRange)
            //    {
            //        _point = double.Parse(TargetModeTextBox.Text);
            //    }
            //    else
            //    {
            //        _point = _mover.TravelRange;
            //    }

            //    TargetModeTextBox.Text = _point.ToString();
            //}
            //catch
            //{
            //    TargetModeTextBox.Text = "";
            //}
        }
        private void TargetModeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckAxisTargetMode();
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 46) //цифры, клавиша BackSpace. точка и запятая ASCII
            {
                e.Handled = true;
            }
        }
        private void RunTargetModeButton_Click(object sender, EventArgs e)
        {
            if ((Double.Parse(TargetModeTextBox.Text) + _mover.GetPoint()) >= _mover.TravelRange)
            {
                MessageBox.Show("Превышено значение диапазона перемещения!");
                TargetModeTextBox.Text = "";
                return;
            }
            CheckAxisTargetMode();
            MoveAxis(Double.Parse(TargetModeTextBox.Text));
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            //CheckAxis();
            if (_mover != null)
            {
                _mover.StopMove();

                CheckAxisPosition(_mover);
            }
        }
        private void IncrementModeTextBox_TextChanged(object sender, EventArgs e)
        {
            //CheckAxisIncrementMode();
            //try
            //{
            //    if (double.Parse(IncrementModeTextBox.Text) < _mover.TravelRange)
            //    {
            //        _point = double.Parse(IncrementModeTextBox.Text);
            //    }
            //    else
            //    {
            //        _point = _mover.TravelRange;
            //    }

            //    IncrementModeTextBox.Text = _point.ToString();
            //}
            //catch
            //{
            //    IncrementModeTextBox.Text = "";
            //}
        }
        private void IncrementModeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckAxisIncrementMode();
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 46) //цифры, клавиша BackSpace. точка и запятая ASCII
            {
                e.Handled = true;
            }
        }

        private void RunIncrementModeButton_Click(object sender, EventArgs e)
        {
            CheckAxisIncrementMode();
            double currentCoord = 0;
            double stepValue = Double.Parse(IncrementModeTextBox.Text);
            if ((_mover.GetPoint() + stepValue) >= _mover.TravelRange)
            {
                MessageBox.Show("Первышено значение диапазона перемещения!");
                IncrementModeTextBox.Text = "";
                return;
            }
            MoveAxis(currentCoord += stepValue);
        }
        private void MoveAxis(double point)
        {
            if (_mover != null)
            {
                _setterSpeed.SetSpeed(SetSpeedTextBox.Text);
                _mover.SetToPoint(point);
                CheckAxisPosition(_mover);
            }
        }

        #endregion

        private void TargetModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton? rb = sender as System.Windows.Forms.RadioButton;
            if (rb.Checked && _axisDataX != null)
            {
                TargetModeTextBox.Enabled = true;
                TargetModeComboBox.Enabled = true;
                RunTargetModeButton.Enabled = true;
                IncrementModeTextBox.Enabled = false;
                RunIncrementModeButton.Enabled = false;
                IncrementModeComboBox.Enabled = false;
                ContinousModeComboBox.Enabled = false;
                ContinousModeHomeButton.Enabled = false;
                X_forvardButton.Enabled = false;
                X_backvardButton.Enabled = false;
                Y_forvardButton.Enabled = false;
                Y_backvardButton.Enabled = false;
                Z_forvardButton.Enabled = false;
                Z_backvardButton.Enabled = false;
            }
        }
        private void IncrementModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton? rb = sender as System.Windows.Forms.RadioButton;
            if (rb.Checked && _axisDataX != null)
            {
                TargetModeTextBox.Enabled = false;
                TargetModeComboBox.Enabled = false;
                RunTargetModeButton.Enabled = false;
                IncrementModeTextBox.Enabled = true;
                RunIncrementModeButton.Enabled = true;
                IncrementModeComboBox.Enabled = true;
                ContinousModeComboBox.Enabled = false;
                ContinousModeHomeButton.Enabled = false;
                X_forvardButton.Enabled = false;
                X_backvardButton.Enabled = false;
                Y_forvardButton.Enabled = false;
                Y_backvardButton.Enabled = false;
                Z_forvardButton.Enabled = false;
                Z_backvardButton.Enabled = false;
            }
        }
        private void ContinousModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton? rb = sender as System.Windows.Forms.RadioButton;
            if (rb.Checked && _axisDataX != null)
            {
                TargetModeTextBox.Enabled = false;
                TargetModeComboBox.Enabled = false;
                RunTargetModeButton.Enabled = false;
                IncrementModeTextBox.Enabled = false;
                RunIncrementModeButton.Enabled = false;
                IncrementModeComboBox.Enabled = false;
                ContinousModeComboBox.Enabled = true;
                ContinousModeHomeButton.Enabled = true;
                X_forvardButton.Enabled = true;
                X_backvardButton.Enabled = true;
                Y_forvardButton.Enabled = true;
                Y_backvardButton.Enabled = true;
                Z_forvardButton.Enabled = true;
                Z_backvardButton.Enabled = true;
            }
        }


        #region[ContinousMode region]
        private void CheckAxisContinousMode()
        {
            if (_mover != null)
            {
                if (ContinousModeComboBox.SelectedItem.ToString() == "X")
                    _mover = _moverX;
                else if (ContinousModeComboBox.SelectedItem.ToString() == "Y")
                    _mover = _moverY;
                else if (ContinousModeComboBox.SelectedItem.ToString() == "Z")
                    _mover = _moverZ;
                return;
            }

            _moverX = new Mover(_controller.AxisModelX, _controller.Connect);
            _moverY = new Mover(_controller.AxisModelY, _controller.Connect);
            _moverZ = new Mover(_controller.AxisModelZ, _controller.Connect);
            _mover = _moverX;

            _mover.TimerEnabled += SetTime;
            _mover.TimerItntervaled += SetInterval;

        }

        private void ContinousModeHomeButton_Click(object sender, EventArgs e)
        {
            CheckAxisContinousMode();
            if (_mover != null)
            {
                _mover.MoveToHome();
                CheckAxisPosition(_mover);
            }

        }

        private void ContinousModeRadioButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (_mover != null)
            {
                switch (e.KeyCode.ToString())
                {
                    case "NumPad6":
                        _mover = new Mover(_controller.AxisModelX, _controller.Connect);
                        _mover.SetToPoint(_mover.TravelRange);
                        CheckAxisPosition(_mover);
                        break;
                    case "NumPad4":
                        _mover = new Mover(_controller.AxisModelX, _controller.Connect);
                        _mover.SetToPoint(-(_mover.TravelRange));
                        CheckAxisPosition(_mover);
                        break;
                    case "NumPad8":
                        _mover = new Mover(_controller.AxisModelY, _controller.Connect);
                        _mover.SetToPoint(_mover.TravelRange);
                        CheckAxisPosition(_mover);
                        break;
                    case "NumPad2":
                        _mover = new Mover(_controller.AxisModelY, _controller.Connect);
                        _mover.SetToPoint(-(_mover.TravelRange));
                        CheckAxisPosition(_mover);
                        break;
                    case "NumPad9":
                        _mover = new Mover(_controller.AxisModelZ, _controller.Connect);
                        _mover.SetToPoint(_mover.TravelRange);
                        CheckAxisPosition(_mover);
                        break;
                    case "NumPad3":
                        _mover = new Mover(_controller.AxisModelZ, _controller.Connect);
                        _mover.SetToPoint(-(_mover.TravelRange));
                        CheckAxisPosition(_mover);
                        break;
                }
                e.Handled = true;
            }
            e.Handled = true;
        }

        private void ContinousModeRadioButton_KeyUp(object sender, KeyEventArgs e)
        {
            _mover.StopMove();
            e.Handled = true;
        }

        private void X_forvardButton_KeyDown(object sender, KeyEventArgs e)
        {
            //int keyCode = e.KeyValue;
            //if () 
            //{
            //    e.Handled = true;
            //}
        }

        private void X_forvardButton_KeyUp(object sender, KeyEventArgs e)
        {
            //char number = e.KeyChar;
            //if () 
            //{
            //    e.Handled = true;
            //}
        }




        #endregion



        private void MainFormFull_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

}
