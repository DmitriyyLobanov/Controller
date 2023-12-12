﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        private short _port;

        private AxisModel? _axisDataX;
        private AxisModel? _axisDataY;
        private AxisModel? _axisDataZ;

        private List<AxisModel> usableAxis;

        public MainFormFull()
        {
            _controller = new Controller();
            _fileIOService = new FileIOService();
            usableAxis = new List<AxisModel>();

            InitializeComponent();
            UpdateComponents();
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

            DeserializeExistAxes();
        }

        /*
         * TODO:Заполение комбобоксов десериализованными значениями.
         * Как вариант передавать из DeserializeExistAxes() массив с объектами осей и другом методе заполнять
         * комбо боксы.
         */
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

            }
            _axisDataY = _fileIOService.LoadMotor(PathY);
            if (_axisDataY != null)
            {
                SetAxis(_axisDataY);
                Set_Y_RadioButton.ForeColor = Color.Green;
                _deserializedAxes += " Y";
                usableAxis.Add(_axisDataY);
            }
            _axisDataZ = _fileIOService.LoadMotor(PathZ);
            if (_axisDataZ != null)
            {
                SetAxis(_axisDataZ);
                Set_Z_RadioButton.ForeColor = Color.Green;
                _deserializedAxes += " Z";
                usableAxis.Add(_axisDataZ);
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

        /*
         * TODO: Реализовать заполнение комбобоксов десериализованными знач. Но по НЕСКОЛЬКИМ осям
         * заполнение должно зависеть от активного радиобаттона.
         */
        private void FillComboBoxes(AxisModel axis)
        {
            StageTypeComboBox.SelectedItem = axis.StageType;
            RunningUnitComboBox.SelectedItem = axis.RuningUnit;
            StepperAngleComboBox.SelectedItem = axis.StepperAngle;
            SubdivisionComboBox.SelectedItem = axis.Subdivision;
            ScrewLeadComboBox.SelectedItem = axis.ScrewLead;
            TransmissionRatioComboBox.SelectedItem = axis.TransmissonRatio;
            TravelRangeComboBox.SelectedItem = axis.TravelRange;
        }
        private void SetAxis(AxisModel axis)
        {
            _controller.SetAxisValue(axis);
        }


        private void SelectCOMButton_Click(object sender, EventArgs e)
        {
            _controller.Connect.ConnectPort(_port);
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
            else
            {
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
                    }
                }
                else
                {
                    axisModel.Name = "X";
                    _fileIOService.SaveData(axisModel, PathX);
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
                    }
                }
                else
                {
                    axisModel.Name = "Y";
                    _fileIOService.SaveData(axisModel, PathY);
                }
            }
            if (Set_Z_RadioButton.Checked)
            {
                //Реализовать выставление None, чтобы не использовать одну из осей
                throw new NotImplementedException();
            }
        }
    }
}
