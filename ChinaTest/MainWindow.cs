using System.ComponentModel;
using System.Windows.Forms;

namespace ChinaTest
{
    public partial class MainWindow : Form
    {
        private readonly string PathX = $"{Environment.CurrentDirectory}\\motorSettingsX.json";
        private readonly string PathY = $"{Environment.CurrentDirectory}\\motorSettingsY.json";
        private readonly string PathZ = $"{Environment.CurrentDirectory}\\motorSettingsZ.json";

        private FileIOService _fileIOService = new FileIOService();

        private AxisModel? _axisDataX;
        private AxisModel? _axisDataY;
        private AxisModel? _axisDataZ;

        private Controller _controller = new Controller();
        private short _port;

        public MainWindow()
        {
            InitializeComponent();
            Main();
        }

        private void Main()
        {
            textBox1.TextChanged += textBox1_Port;
            _controller.Connect.EnabledConnaction += ConnectStaus;

            try
            {
                _axisDataX = _fileIOService.LoadMotor(PathX);
                _axisDataY = _fileIOService.LoadMotor(PathY);
                _axisDataZ = _fileIOService.LoadMotor(PathZ);

                SetAxis(_axisDataX);
                SetAxis(_axisDataY);
                SetAxis(_axisDataZ);
            }
            catch
            {
            }
        }

        private void button1_Connect(object sender, EventArgs e)
        {
            _controller.Connect.ConnectPort(_port);
        }

        private void textBox1_Port(object sender, EventArgs e)
        {
            try
            {
                _port = short.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "";
            }
        }

        private void ConnectStaus(bool status)
        {
            if (status)
            {
                label2.Text = "Успешно";
                label2.ForeColor = Color.Green;
                _controller.Connect.EnabledConnaction -= ConnectStaus;
                button1.Enabled = false;
            }
            else
            {
                label2.Text = "Нет конекта";
                label2.ForeColor = Color.Red;
            }
        }

        private void button2_OpenSttingsWindow(object sender, EventArgs e)
        {
            SettingsMotorWindow form = new SettingsMotorWindow();
            form.Show();
            form.GetController(_controller);
            form.GetService(_fileIOService);
        }

        private void button3_OpenMoveWindow(object sender, EventArgs e)
        {
            MoveWindow move = new MoveWindow();
            move.GetController(_controller);
            move.SetDefoultAxis();
            move.Show();
        }

        private void SetAxis(AxisModel axis)
        {
            _controller.SetAxisValue(axis);
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}