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

        private Controller _controller = new Controller();
        private short _port;


        public MainFormFull()
        {
            InitializeComponent();
            UpdateComponents();
        }


        private void UpdateComponents()
        {
            SelectCOMTextBox.TextChanged += SelectCOMTextBOX_Port;
            _controller.Connect.EnabledConnaction += ConnectStatus;
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

    }
}
