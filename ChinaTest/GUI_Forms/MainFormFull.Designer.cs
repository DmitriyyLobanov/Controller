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
            StagesParametersPanel = new Panel();
            TravelRangeComboBox = new ComboBox();
            TransmissionRatioComboBox = new ComboBox();
            ScrewLeadComboBox = new ComboBox();
            SubdivisionComboBox = new ComboBox();
            StepperAngleComboBox = new ComboBox();
            RunningUnitComboBox = new ComboBox();
            StageTypeComboBox = new ComboBox();
            TravelRangeLabel = new Label();
            Set_Z_RadioButton = new RadioButton();
            Set_Y_RadioButton = new RadioButton();
            TransmissionRatioLabel = new Label();
            Set_X_RadioButton = new RadioButton();
            StageTypeLabel = new Label();
            ScrewLeadLabel = new Label();
            RunningUnitLabel = new Label();
            StepperAngleLabel = new Label();
            SubdivisionLabel = new Label();
            StagesParametersPanel.SuspendLayout();
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
            // StagesParametersPanel
            // 
            StagesParametersPanel.BorderStyle = BorderStyle.FixedSingle;
            StagesParametersPanel.Controls.Add(TravelRangeComboBox);
            StagesParametersPanel.Controls.Add(TransmissionRatioComboBox);
            StagesParametersPanel.Controls.Add(ScrewLeadComboBox);
            StagesParametersPanel.Controls.Add(SubdivisionComboBox);
            StagesParametersPanel.Controls.Add(StepperAngleComboBox);
            StagesParametersPanel.Controls.Add(RunningUnitComboBox);
            StagesParametersPanel.Controls.Add(StageTypeComboBox);
            StagesParametersPanel.Controls.Add(TravelRangeLabel);
            StagesParametersPanel.Controls.Add(Set_Z_RadioButton);
            StagesParametersPanel.Controls.Add(Set_Y_RadioButton);
            StagesParametersPanel.Controls.Add(TransmissionRatioLabel);
            StagesParametersPanel.Controls.Add(Set_X_RadioButton);
            StagesParametersPanel.Controls.Add(StageTypeLabel);
            StagesParametersPanel.Controls.Add(ScrewLeadLabel);
            StagesParametersPanel.Controls.Add(RunningUnitLabel);
            StagesParametersPanel.Controls.Add(StepperAngleLabel);
            StagesParametersPanel.Controls.Add(SubdivisionLabel);
            StagesParametersPanel.Location = new Point(18, 41);
            StagesParametersPanel.Name = "StagesParametersPanel";
            StagesParametersPanel.Size = new Size(285, 377);
            StagesParametersPanel.TabIndex = 4;
            // 
            // TravelRangeComboBox
            // 
            TravelRangeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TravelRangeComboBox.FormattingEnabled = true;
            TravelRangeComboBox.Items.AddRange(new object[] { "20", "25", "50", "100", "250", "300", "400", "500", "600", "850", "1000" });
            TravelRangeComboBox.Location = new Point(161, 237);
            TravelRangeComboBox.Name = "TravelRangeComboBox";
            TravelRangeComboBox.Size = new Size(109, 23);
            TravelRangeComboBox.TabIndex = 12;
            // 
            // TransmissionRatioComboBox
            // 
            TransmissionRatioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransmissionRatioComboBox.FormattingEnabled = true;
            TransmissionRatioComboBox.Items.AddRange(new object[] { "72", "90", "180", "360", "252", "576", "6", "352", "400", "720" });
            TransmissionRatioComboBox.Location = new Point(161, 208);
            TransmissionRatioComboBox.Name = "TransmissionRatioComboBox";
            TransmissionRatioComboBox.Size = new Size(109, 23);
            TransmissionRatioComboBox.TabIndex = 11;
            // 
            // ScrewLeadComboBox
            // 
            ScrewLeadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ScrewLeadComboBox.FormattingEnabled = true;
            ScrewLeadComboBox.Items.AddRange(new object[] { "0.5", "1", "1.5", "4", "5" });
            ScrewLeadComboBox.Location = new Point(161, 179);
            ScrewLeadComboBox.Name = "ScrewLeadComboBox";
            ScrewLeadComboBox.Size = new Size(109, 23);
            ScrewLeadComboBox.TabIndex = 10;
            // 
            // SubdivisionComboBox
            // 
            SubdivisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubdivisionComboBox.FormattingEnabled = true;
            SubdivisionComboBox.Items.AddRange(new object[] { "8", "4", "2", "1" });
            SubdivisionComboBox.Location = new Point(161, 150);
            SubdivisionComboBox.Name = "SubdivisionComboBox";
            SubdivisionComboBox.Size = new Size(109, 23);
            SubdivisionComboBox.TabIndex = 9;
            // 
            // StepperAngleComboBox
            // 
            StepperAngleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StepperAngleComboBox.FormattingEnabled = true;
            StepperAngleComboBox.Items.AddRange(new object[] { "1.8", "0.9" });
            StepperAngleComboBox.Location = new Point(161, 121);
            StepperAngleComboBox.Name = "StepperAngleComboBox";
            StepperAngleComboBox.Size = new Size(109, 23);
            StepperAngleComboBox.TabIndex = 8;
            // 
            // RunningUnitComboBox
            // 
            RunningUnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RunningUnitComboBox.FormattingEnabled = true;
            RunningUnitComboBox.Items.AddRange(new object[] { "mm", "Degree", "Step" });
            RunningUnitComboBox.Location = new Point(161, 92);
            RunningUnitComboBox.Name = "RunningUnitComboBox";
            RunningUnitComboBox.Size = new Size(109, 23);
            RunningUnitComboBox.TabIndex = 7;
            // 
            // StageTypeComboBox
            // 
            StageTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StageTypeComboBox.FormattingEnabled = true;
            StageTypeComboBox.Items.AddRange(new object[] { "None", "TranslationStage", "RotaryStage", "GoniometrStage" });
            StageTypeComboBox.Location = new Point(161, 63);
            StageTypeComboBox.Name = "StageTypeComboBox";
            StageTypeComboBox.Size = new Size(109, 23);
            StageTypeComboBox.TabIndex = 5;
            // 
            // TravelRangeLabel
            // 
            TravelRangeLabel.AutoSize = true;
            TravelRangeLabel.Location = new Point(14, 240);
            TravelRangeLabel.Name = "TravelRangeLabel";
            TravelRangeLabel.Size = new Size(141, 15);
            TravelRangeLabel.TabIndex = 6;
            TravelRangeLabel.Text = "Диапазон перемещения";
            // 
            // Set_Z_RadioButton
            // 
            Set_Z_RadioButton.AutoSize = true;
            Set_Z_RadioButton.CheckAlign = ContentAlignment.BottomCenter;
            Set_Z_RadioButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Set_Z_RadioButton.Location = new Point(225, 3);
            Set_Z_RadioButton.Name = "Set_Z_RadioButton";
            Set_Z_RadioButton.Size = new Size(28, 42);
            Set_Z_RadioButton.TabIndex = 2;
            Set_Z_RadioButton.Text = "Z";
            Set_Z_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Set_Y_RadioButton
            // 
            Set_Y_RadioButton.AutoSize = true;
            Set_Y_RadioButton.CheckAlign = ContentAlignment.BottomCenter;
            Set_Y_RadioButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Set_Y_RadioButton.Location = new Point(118, 3);
            Set_Y_RadioButton.Name = "Set_Y_RadioButton";
            Set_Y_RadioButton.Size = new Size(28, 42);
            Set_Y_RadioButton.TabIndex = 1;
            Set_Y_RadioButton.Text = "Y";
            Set_Y_RadioButton.UseVisualStyleBackColor = true;
            // 
            // TransmissionRatioLabel
            // 
            TransmissionRatioLabel.AutoSize = true;
            TransmissionRatioLabel.Location = new Point(3, 211);
            TransmissionRatioLabel.Name = "TransmissionRatioLabel";
            TransmissionRatioLabel.Size = new Size(152, 15);
            TransmissionRatioLabel.TabIndex = 5;
            TransmissionRatioLabel.Text = "Передаточное отношение";
            // 
            // Set_X_RadioButton
            // 
            Set_X_RadioButton.AutoSize = true;
            Set_X_RadioButton.CheckAlign = ContentAlignment.BottomCenter;
            Set_X_RadioButton.Checked = true;
            Set_X_RadioButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Set_X_RadioButton.Location = new Point(19, 3);
            Set_X_RadioButton.Name = "Set_X_RadioButton";
            Set_X_RadioButton.Size = new Size(28, 42);
            Set_X_RadioButton.TabIndex = 0;
            Set_X_RadioButton.TabStop = true;
            Set_X_RadioButton.Text = "X";
            Set_X_RadioButton.UseVisualStyleBackColor = true;
            // 
            // StageTypeLabel
            // 
            StageTypeLabel.AutoSize = true;
            StageTypeLabel.Location = new Point(70, 66);
            StageTypeLabel.Name = "StageTypeLabel";
            StageTypeLabel.Size = new Size(85, 15);
            StageTypeLabel.TabIndex = 0;
            StageTypeLabel.Text = "Тип подвижки";
            // 
            // ScrewLeadLabel
            // 
            ScrewLeadLabel.AutoSize = true;
            ScrewLeadLabel.Location = new Point(92, 182);
            ScrewLeadLabel.Name = "ScrewLeadLabel";
            ScrewLeadLabel.Size = new Size(63, 15);
            ScrewLeadLabel.TabIndex = 4;
            ScrewLeadLabel.Text = "Шаг винта";
            // 
            // RunningUnitLabel
            // 
            RunningUnitLabel.AutoSize = true;
            RunningUnitLabel.Location = new Point(39, 95);
            RunningUnitLabel.Name = "RunningUnitLabel";
            RunningUnitLabel.Size = new Size(116, 15);
            RunningUnitLabel.TabIndex = 1;
            RunningUnitLabel.Text = "Единица измерения";
            // 
            // StepperAngleLabel
            // 
            StepperAngleLabel.AutoSize = true;
            StepperAngleLabel.Location = new Point(8, 124);
            StepperAngleLabel.Name = "StepperAngleLabel";
            StepperAngleLabel.Size = new Size(147, 15);
            StepperAngleLabel.TabIndex = 2;
            StepperAngleLabel.Text = "Угол шагового двигателя";
            // 
            // SubdivisionLabel
            // 
            SubdivisionLabel.AutoSize = true;
            SubdivisionLabel.Location = new Point(70, 153);
            SubdivisionLabel.Name = "SubdivisionLabel";
            SubdivisionLabel.Size = new Size(85, 15);
            SubdivisionLabel.TabIndex = 3;
            SubdivisionLabel.Text = "Деление шага";
            // 
            // MainFormFull
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StagesParametersPanel);
            Controls.Add(ConnectStatusLabel);
            Controls.Add(SelectCOMButton);
            Controls.Add(SelectCOMTextBox);
            Controls.Add(SelectCOMLabel);
            Name = "MainFormFull";
            Text = "Главное окно";
            StagesParametersPanel.ResumeLayout(false);
            StagesParametersPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectCOMLabel;
        private TextBox SelectCOMTextBox;
        private Button SelectCOMButton;
        private Label ConnectStatusLabel;
        private Panel StagesParametersPanel;
        private Label ScrewLeadLabel;
        private Label SubdivisionLabel;
        private Label StepperAngleLabel;
        private Label RunningUnitLabel;
        private Label StageTypeLabel;
        private Label TransmissionRatioLabel;
        private Label TravelRangeLabel;
        private RadioButton Set_X_RadioButton;
        private RadioButton Set_Y_RadioButton;
        private RadioButton Set_Z_RadioButton;
        private ComboBox StageTypeComboBox;
        private Label Set_Y_Label;
        private ComboBox RunningUnitComboBox;
        private ComboBox StepperAngleComboBox;
        private ComboBox SubdivisionComboBox;
        private ComboBox ScrewLeadComboBox;
        private ComboBox TransmissionRatioComboBox;
        private ComboBox TravelRangeComboBox;
    }
}