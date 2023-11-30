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
            // StageTypeComboBox
            // 
            StageTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StageTypeComboBox.FormattingEnabled = true;
            StageTypeComboBox.Items.AddRange(new object[] { "None", "TranslationStage", "RotaryStage", "GoniometrStage" });
            StageTypeComboBox.Location = new Point(161, 66);
            StageTypeComboBox.Name = "StageTypeComboBox";
            StageTypeComboBox.Size = new Size(109, 23);
            StageTypeComboBox.TabIndex = 5;
            // 
            // TravelRangeLabel
            // 
            TravelRangeLabel.AutoSize = true;
            TravelRangeLabel.Location = new Point(28, 246);
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
            TransmissionRatioLabel.Location = new Point(27, 210);
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
            StageTypeLabel.Location = new Point(27, 69);
            StageTypeLabel.Name = "StageTypeLabel";
            StageTypeLabel.Size = new Size(85, 15);
            StageTypeLabel.TabIndex = 0;
            StageTypeLabel.Text = "Тип подвижки";
            // 
            // ScrewLeadLabel
            // 
            ScrewLeadLabel.AutoSize = true;
            ScrewLeadLabel.Location = new Point(27, 182);
            ScrewLeadLabel.Name = "ScrewLeadLabel";
            ScrewLeadLabel.Size = new Size(63, 15);
            ScrewLeadLabel.TabIndex = 4;
            ScrewLeadLabel.Text = "Шаг винта";
            // 
            // RunningUnitLabel
            // 
            RunningUnitLabel.AutoSize = true;
            RunningUnitLabel.Location = new Point(27, 101);
            RunningUnitLabel.Name = "RunningUnitLabel";
            RunningUnitLabel.Size = new Size(116, 15);
            RunningUnitLabel.TabIndex = 1;
            RunningUnitLabel.Text = "Единица измерения";
            // 
            // StepperAngleLabel
            // 
            StepperAngleLabel.AutoSize = true;
            StepperAngleLabel.Location = new Point(27, 131);
            StepperAngleLabel.Name = "StepperAngleLabel";
            StepperAngleLabel.Size = new Size(147, 15);
            StepperAngleLabel.TabIndex = 2;
            StepperAngleLabel.Text = "Угол шагового двигателя";
            // 
            // SubdivisionLabel
            // 
            SubdivisionLabel.AutoSize = true;
            SubdivisionLabel.Location = new Point(27, 156);
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
    }
}