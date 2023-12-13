using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChinaTest
{
    public partial class MoveWindow : Form
    {
        private Controller _controller;
        private Mover _mover;
        private Mover _moverX;
        private Mover _moverY;
        private Mover _moverZ;

        private double _point;
        private double _speed = 100;
        private double _maxSpeed = 255;

        public MoveWindow()
        {
            InitializeComponent();
            textBox2.TextChanged += textBox2_TextPoint;
            textBox1.TextChanged += textBox1_TextSpeed;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        public void GetController(object controller)
        {
            _controller = (Controller)controller;
        }

        public void SetDefoultAxis()
        {
            checkBox1.CheckState = CheckState.Checked;
        }

        private void CheckAxis()
        {
            if (_mover != null)
            {
                if (checkBox1.Checked == true)
                    _mover = _moverX;
                else if (checkBox2.Checked == true)
                    _mover = _moverY;
                else if (checkBox3.Checked == true)
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

        private void SetTime(bool isTime)
        {
            timer1.Enabled = isTime;
        }

        private void SetInterval(int value)
        {
            timer1.Interval = value;
        }

        private void button1_Home(object sender, EventArgs e)
        {
            if (_mover != null)
            {
                _mover.MoveToHome();
                CheckAxisPosition(_mover);
            }
        }

        private void checkBox1_X(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                CheckAxis();
            }
        }

        private void checkBox2_Y(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                CheckAxis();
            }
        }

        private void checkBox3_Z(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox1.CheckState = CheckState.Unchecked;
                CheckAxis();
            }
        }

        private void button3_Run(object sender, EventArgs e)
        {
            MoveAxis(_point);
        }

        private void textBox1_TextSpeed(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBox1.Text);

                if (value < _maxSpeed)
                {
                    _speed = value;
                }
                else
                {
                    _speed = _maxSpeed;
                    textBox1.Text = "255";
                }
            }
            catch
            {
                textBox1.Text = " ";
            }
        }

        private void textBox2_TextPoint(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox2.Text) < _mover.TravelRange)
                    _point = double.Parse(textBox2.Text);
                else
                    _point = _mover.TravelRange;

                textBox2.Text = _point.ToString();
            }
            catch
            {
                if (textBox2.Text != "-")
                    textBox2.Text = " ";
            }
        }

        private void button2_Stop(object sender, EventArgs e)
        {
            if (_mover != null)
            {
                _mover.StopMove();

                CheckAxisPosition(_mover);
            }
        }

        private void MoveAxis(double point)
        {
            if (_mover != null)
            {
                _controller.SetterSpeed = new SetterSpeed(_controller.Connect);
                _controller.SetterSpeed.SetSpeed(_speed.ToString());
                _mover.SetToPoint(point);
                CheckAxisPosition(_mover);
            }
        }

        private void CheckAxisPosition(Mover mover)
        {
            if (mover.AxisName == "X")
                label4.Text = mover.GetPoint().ToString() + "  " + mover.RunningUnit;
            else if (mover.AxisName == "Y")
                label5.Text = mover.GetPoint().ToString() + "  " + mover.RunningUnit;
            else if (mover.AxisName == "Z")
                label6.Text = mover.GetPoint().ToString() + "  " + mover.RunningUnit;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch ((double)keyData)
            {
                case 38:
                    CheckAxis();
                    MoveAxis(_point);
                    _controller.Connect.SetIsBusy(false);
                    return true;
                case 40:
                    CheckAxis();
                    MoveAxis(-_point);
                    return true;
                default:
                    return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _point = double.Parse(comboBox1.Text);
        }
    }
}