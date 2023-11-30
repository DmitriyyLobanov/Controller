namespace ChinaTest.GUI_Forms
{
    partial class MainFormFull
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectCOMLabel = new Label();
            SelectCOMTextBox = new TextBox();
            SelectCOMButton = new Button();
            ConnectStatusLabel = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // SelectCOMLabel
            // 
            SelectCOMLabel.AutoSize = true;
            SelectCOMLabel.Location = new Point(18, 15);
            SelectCOMLabel.Name = "SelectCOMLabel";
            SelectCOMLabel.Size = new Size(113, 15);
            SelectCOMLabel.TabIndex = 0;
            SelectCOMLabel.Text = "Выбор COM порта:";
            // 
            // SelectCOMTextBox
            // 
            SelectCOMTextBox.Location = new Point(137, 12);
            SelectCOMTextBox.Name = "SelectCOMTextBox";
            SelectCOMTextBox.Size = new Size(37, 23);
            SelectCOMTextBox.TabIndex = 1;
            // 
            // SelectCOMButton
            // 
            SelectCOMButton.Location = new Point(180, 12);
            SelectCOMButton.Name = "SelectCOMButton";
            SelectCOMButton.Size = new Size(123, 23);
            SelectCOMButton.TabIndex = 2;
            SelectCOMButton.Text = "COM connect";
            SelectCOMButton.UseVisualStyleBackColor = true;
            SelectCOMButton.Click += SelectCOMButton_Click;
            // 
            // ConnectStatusLabel
            // 
            ConnectStatusLabel.AutoSize = true;
            ConnectStatusLabel.Location = new Point(317, 16);
            ConnectStatusLabel.Name = "ConnectStatusLabel";
            ConnectStatusLabel.Size = new Size(38, 15);
            ConnectStatusLabel.TabIndex = 3;
            ConnectStatusLabel.Text = "status";
            ConnectStatusLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(19, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 371);
            panel1.TabIndex = 4;
            // 
            // MainFormFull
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(ConnectStatusLabel);
            Controls.Add(SelectCOMButton);
            Controls.Add(SelectCOMTextBox);
            Controls.Add(SelectCOMLabel);
            Name = "MainFormFull";
            Text = "Главное окно";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectCOMLabel;
        private TextBox SelectCOMTextBox;
        private Button SelectCOMButton;
        private Label ConnectStatusLabel;
        private Panel panel1;
    }
}