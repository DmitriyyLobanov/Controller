using System;
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


        public MainFormFull()
        {
            _controller = new Controller();
            _fileIOService = new FileIOService();

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
            //TODO: Заменить текстовую отбивку на два изображения - зелёная лампочка и красная (До подключения - красная)
            if (status)
            {
                ConnectStatusLabel.Visible = true;
                ConnectStatusLabel.ForeColor = Color.Green;

                ConnectStatusLabel.Text = "Успешное подключение";

                _controller.Connect.EnabledConnaction -= ConnectStatus;

            }
            else
            {
                ConnectStatusLabel.Visible = true;
                ConnectStatusLabel.ForeColor = Color.Red;
                ConnectStatusLabel.Text = "Нет подключения!";

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
                axisModel.Name = "X";
                _fileIOService.SaveData(axisModel, PathX);
            }
            if (Set_Y_RadioButton.Checked)
            {
                axisModel.Name = "Y";
                _fileIOService.SaveData(axisModel, PathY);
            }
            if (Set_Z_RadioButton.Checked)
            {
                //Реализовать выставление None, чтобы не использовать одну из осей
                throw new NotImplementedException();
            }


            MessageBox.Show(axisModel.ToString());
        }
    }
}
