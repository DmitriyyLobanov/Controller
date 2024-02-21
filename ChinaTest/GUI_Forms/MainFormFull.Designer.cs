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
            components = new System.ComponentModel.Container();
            SelectCOMLabel = new Label();
            SelectCOMTextBox = new TextBox();
            SelectCOMButton = new Button();
            StagesParametersPanel = new Panel();
            SaveParametersButton = new Button();
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
            ConnectionOkPictureBox = new PictureBox();
            ConncetionFailedPictureBox = new PictureBox();
            MoveModesPanel = new Panel();
            ContinousModeHomeButton = new Button();
            ContinousModeComboBox = new ComboBox();
            ContinousModeAxisLabel = new Label();
            Z_backvardButton = new Button();
            Z_forvardButton = new Button();
            X_forvardButton = new Button();
            X_backvardButton = new Button();
            Y_backvardButton = new Button();
            Y_forvardButton = new Button();
            CancelZeroButton = new Button();
            SetZeroButton = new Button();
            HomeButton = new Button();
            StopButton = new Button();
            IncrementModeComboBox = new ComboBox();
            IncrementModeAxisLabel = new Label();
            RunIncrementModeButton = new Button();
            IncrementModeTextBox = new TextBox();
            IncrementModeLabel = new Label();
            TargetModeComboBox = new ComboBox();
            TargetModeAxisLabel = new Label();
            RunTargetModeButton = new Button();
            TargetModeTextBox = new TextBox();
            TargetCoordLabel = new Label();
            ContinousModeRadioButton = new RadioButton();
            IncrementModeRadioButton = new RadioButton();
            TargetModeRadioButton = new RadioButton();
            CurrentCoordsPanel = new Panel();
            CurrentUnitLabel_Z = new Label();
            CurrentUnitLabel_Y = new Label();
            CurrentUnitLabel_X = new Label();
            CurrentZ_TextBox = new TextBox();
            CurrentY_TextBox = new TextBox();
            CurrentX_TextBox = new TextBox();
            Current_Z_label = new Label();
            Current_Y_label = new Label();
            Current_X_label = new Label();
            CurrenntCoordsLabel = new Label();
            SetSpeedLabel = new Label();
            SpeedLabel = new Label();
            SetSpeedTextBox = new TextBox();
            SetSpeedButton = new Button();
            ControllerTimer = new System.Windows.Forms.Timer(components);
            StagesParametersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConnectionOkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConncetionFailedPictureBox).BeginInit();
            MoveModesPanel.SuspendLayout();
            CurrentCoordsPanel.SuspendLayout();
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
            // StagesParametersPanel
            // 
            StagesParametersPanel.BorderStyle = BorderStyle.FixedSingle;
            StagesParametersPanel.Controls.Add(SaveParametersButton);
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
            StagesParametersPanel.Size = new Size(285, 315);
            StagesParametersPanel.TabIndex = 4;
            // 
            // SaveParametersButton
            // 
            SaveParametersButton.Location = new Point(3, 276);
            SaveParametersButton.Name = "SaveParametersButton";
            SaveParametersButton.Size = new Size(277, 23);
            SaveParametersButton.TabIndex = 13;
            SaveParametersButton.Text = "Сохранить параметры";
            SaveParametersButton.UseVisualStyleBackColor = true;
            SaveParametersButton.Click += SaveParametersButton_Click;
            // 
            // TravelRangeComboBox
            // 
            TravelRangeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TravelRangeComboBox.FormattingEnabled = true;
            TravelRangeComboBox.Items.AddRange(new object[] { "20", "25", "35", "50", "100", "250", "300", "400", "500", "600", "850", "1000" });
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
            StageTypeComboBox.Items.AddRange(new object[] { "TranslationStage", "RotaryStage", "GoniometrStage" });
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
            Set_Z_RadioButton.CheckedChanged += Set_Z_RadioButton_CheckedChanged;
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
            Set_Y_RadioButton.CheckedChanged += Set_Y_RadioButton_CheckedChanged;
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
            Set_X_RadioButton.CheckedChanged += Set_X_RadioButton_CheckedChanged;
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
            // ConnectionOkPictureBox
            // 
            ConnectionOkPictureBox.Image = Properties.Resources.green_ball1;
            ConnectionOkPictureBox.Location = new Point(309, 12);
            ConnectionOkPictureBox.Name = "ConnectionOkPictureBox";
            ConnectionOkPictureBox.Size = new Size(33, 26);
            ConnectionOkPictureBox.TabIndex = 5;
            ConnectionOkPictureBox.TabStop = false;
            // 
            // ConncetionFailedPictureBox
            // 
            ConncetionFailedPictureBox.Image = Properties.Resources.red_ball;
            ConncetionFailedPictureBox.Location = new Point(309, 12);
            ConncetionFailedPictureBox.Name = "ConncetionFailedPictureBox";
            ConncetionFailedPictureBox.Size = new Size(36, 24);
            ConncetionFailedPictureBox.TabIndex = 6;
            ConncetionFailedPictureBox.TabStop = false;
            // 
            // MoveModesPanel
            // 
            MoveModesPanel.BorderStyle = BorderStyle.FixedSingle;
            MoveModesPanel.Controls.Add(ContinousModeHomeButton);
            MoveModesPanel.Controls.Add(ContinousModeComboBox);
            MoveModesPanel.Controls.Add(ContinousModeAxisLabel);
            MoveModesPanel.Controls.Add(Z_backvardButton);
            MoveModesPanel.Controls.Add(Z_forvardButton);
            MoveModesPanel.Controls.Add(X_forvardButton);
            MoveModesPanel.Controls.Add(X_backvardButton);
            MoveModesPanel.Controls.Add(Y_backvardButton);
            MoveModesPanel.Controls.Add(Y_forvardButton);
            MoveModesPanel.Controls.Add(CancelZeroButton);
            MoveModesPanel.Controls.Add(SetZeroButton);
            MoveModesPanel.Controls.Add(HomeButton);
            MoveModesPanel.Controls.Add(StopButton);
            MoveModesPanel.Controls.Add(IncrementModeComboBox);
            MoveModesPanel.Controls.Add(IncrementModeAxisLabel);
            MoveModesPanel.Controls.Add(RunIncrementModeButton);
            MoveModesPanel.Controls.Add(IncrementModeTextBox);
            MoveModesPanel.Controls.Add(IncrementModeLabel);
            MoveModesPanel.Controls.Add(TargetModeComboBox);
            MoveModesPanel.Controls.Add(TargetModeAxisLabel);
            MoveModesPanel.Controls.Add(RunTargetModeButton);
            MoveModesPanel.Controls.Add(TargetModeTextBox);
            MoveModesPanel.Controls.Add(TargetCoordLabel);
            MoveModesPanel.Controls.Add(ContinousModeRadioButton);
            MoveModesPanel.Controls.Add(IncrementModeRadioButton);
            MoveModesPanel.Controls.Add(TargetModeRadioButton);
            MoveModesPanel.Location = new Point(351, 15);
            MoveModesPanel.Name = "MoveModesPanel";
            MoveModesPanel.Size = new Size(459, 452);
            MoveModesPanel.TabIndex = 7;
            // 
            // ContinousModeHomeButton
            // 
            ContinousModeHomeButton.Location = new Point(336, 312);
            ContinousModeHomeButton.Name = "ContinousModeHomeButton";
            ContinousModeHomeButton.Size = new Size(100, 23);
            ContinousModeHomeButton.TabIndex = 25;
            ContinousModeHomeButton.Text = "HOME";
            ContinousModeHomeButton.UseVisualStyleBackColor = true;
            ContinousModeHomeButton.Click += ContinousModeHomeButton_Click;
            // 
            // ContinousModeComboBox
            // 
            ContinousModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ContinousModeComboBox.FormattingEnabled = true;
            ContinousModeComboBox.Items.AddRange(new object[] { "X", "Y", "Z" });
            ContinousModeComboBox.Location = new Point(336, 278);
            ContinousModeComboBox.Name = "ContinousModeComboBox";
            ContinousModeComboBox.Size = new Size(100, 23);
            ContinousModeComboBox.TabIndex = 24;
            // 
            // ContinousModeAxisLabel
            // 
            ContinousModeAxisLabel.AutoSize = true;
            ContinousModeAxisLabel.Location = new Point(302, 281);
            ContinousModeAxisLabel.Name = "ContinousModeAxisLabel";
            ContinousModeAxisLabel.Size = new Size(28, 15);
            ContinousModeAxisLabel.TabIndex = 23;
            ContinousModeAxisLabel.Text = "Ось";
            // 
            // Z_backvardButton
            // 
            Z_backvardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Z_backvardButton.Location = new Point(226, 388);
            Z_backvardButton.Name = "Z_backvardButton";
            Z_backvardButton.Size = new Size(48, 38);
            Z_backvardButton.TabIndex = 22;
            Z_backvardButton.Text = "Z-";
            Z_backvardButton.UseVisualStyleBackColor = true;
            // 
            // Z_forvardButton
            // 
            Z_forvardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Z_forvardButton.Location = new Point(226, 278);
            Z_forvardButton.Name = "Z_forvardButton";
            Z_forvardButton.Size = new Size(48, 38);
            Z_forvardButton.TabIndex = 21;
            Z_forvardButton.Text = "Z+";
            Z_forvardButton.UseVisualStyleBackColor = true;
            // 
            // X_forvardButton
            // 
            X_forvardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            X_forvardButton.Location = new Point(226, 331);
            X_forvardButton.Name = "X_forvardButton";
            X_forvardButton.Size = new Size(48, 38);
            X_forvardButton.TabIndex = 20;
            X_forvardButton.Text = "X+";
            X_forvardButton.UseVisualStyleBackColor = true;
            X_forvardButton.KeyDown += X_forvardButton_KeyDown;
            X_forvardButton.KeyUp += X_forvardButton_KeyUp;
            // 
            // X_backvardButton
            // 
            X_backvardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            X_backvardButton.Location = new Point(118, 331);
            X_backvardButton.Name = "X_backvardButton";
            X_backvardButton.Size = new Size(48, 38);
            X_backvardButton.TabIndex = 19;
            X_backvardButton.Text = "X-";
            X_backvardButton.UseVisualStyleBackColor = true;
            // 
            // Y_backvardButton
            // 
            Y_backvardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Y_backvardButton.Location = new Point(172, 360);
            Y_backvardButton.Name = "Y_backvardButton";
            Y_backvardButton.Size = new Size(48, 38);
            Y_backvardButton.TabIndex = 18;
            Y_backvardButton.Text = "Y-";
            Y_backvardButton.UseVisualStyleBackColor = true;
            // 
            // Y_forvardButton
            // 
            Y_forvardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Y_forvardButton.Location = new Point(172, 302);
            Y_forvardButton.Name = "Y_forvardButton";
            Y_forvardButton.Size = new Size(48, 38);
            Y_forvardButton.TabIndex = 17;
            Y_forvardButton.Text = "Y+";
            Y_forvardButton.UseVisualStyleBackColor = true;
            // 
            // CancelZeroButton
            // 
            CancelZeroButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CancelZeroButton.Location = new Point(336, 176);
            CancelZeroButton.Name = "CancelZeroButton";
            CancelZeroButton.Size = new Size(100, 23);
            CancelZeroButton.TabIndex = 16;
            CancelZeroButton.Text = "CANCEL ZERO";
            CancelZeroButton.UseVisualStyleBackColor = true;
            // 
            // SetZeroButton
            // 
            SetZeroButton.Location = new Point(336, 147);
            SetZeroButton.Name = "SetZeroButton";
            SetZeroButton.Size = new Size(100, 23);
            SetZeroButton.TabIndex = 15;
            SetZeroButton.Text = "SET ZERO";
            SetZeroButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(336, 118);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(100, 23);
            HomeButton.TabIndex = 14;
            HomeButton.Text = "HOME";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(336, 89);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(100, 23);
            StopButton.TabIndex = 13;
            StopButton.Text = "STOP";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // IncrementModeComboBox
            // 
            IncrementModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IncrementModeComboBox.FormattingEnabled = true;
            IncrementModeComboBox.Items.AddRange(new object[] { "X", "Y", "Z" });
            IncrementModeComboBox.Location = new Point(139, 202);
            IncrementModeComboBox.Name = "IncrementModeComboBox";
            IncrementModeComboBox.Size = new Size(100, 23);
            IncrementModeComboBox.TabIndex = 12;
            // 
            // IncrementModeAxisLabel
            // 
            IncrementModeAxisLabel.AutoSize = true;
            IncrementModeAxisLabel.Location = new Point(105, 205);
            IncrementModeAxisLabel.Name = "IncrementModeAxisLabel";
            IncrementModeAxisLabel.Size = new Size(28, 15);
            IncrementModeAxisLabel.TabIndex = 11;
            IncrementModeAxisLabel.Text = "Ось";
            // 
            // RunIncrementModeButton
            // 
            RunIncrementModeButton.Location = new Point(245, 164);
            RunIncrementModeButton.Name = "RunIncrementModeButton";
            RunIncrementModeButton.Size = new Size(75, 23);
            RunIncrementModeButton.TabIndex = 10;
            RunIncrementModeButton.Text = "Run";
            RunIncrementModeButton.UseVisualStyleBackColor = true;
            RunIncrementModeButton.Click += RunIncrementModeButton_Click;
            // 
            // IncrementModeTextBox
            // 
            IncrementModeTextBox.Location = new Point(139, 164);
            IncrementModeTextBox.Name = "IncrementModeTextBox";
            IncrementModeTextBox.Size = new Size(100, 23);
            IncrementModeTextBox.TabIndex = 9;
            IncrementModeTextBox.TextChanged += IncrementModeTextBox_TextChanged;
            IncrementModeTextBox.KeyPress += IncrementModeTextBox_KeyPress;
            // 
            // IncrementModeLabel
            // 
            IncrementModeLabel.AutoSize = true;
            IncrementModeLabel.Location = new Point(41, 167);
            IncrementModeLabel.Name = "IncrementModeLabel";
            IncrementModeLabel.Size = new Size(92, 15);
            IncrementModeLabel.TabIndex = 8;
            IncrementModeLabel.Text = "Величина шага";
            // 
            // TargetModeComboBox
            // 
            TargetModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TargetModeComboBox.FormattingEnabled = true;
            TargetModeComboBox.Items.AddRange(new object[] { "X", "Y", "Z" });
            TargetModeComboBox.Location = new Point(139, 89);
            TargetModeComboBox.Name = "TargetModeComboBox";
            TargetModeComboBox.Size = new Size(100, 23);
            TargetModeComboBox.TabIndex = 7;
            // 
            // TargetModeAxisLabel
            // 
            TargetModeAxisLabel.AutoSize = true;
            TargetModeAxisLabel.Location = new Point(105, 92);
            TargetModeAxisLabel.Name = "TargetModeAxisLabel";
            TargetModeAxisLabel.Size = new Size(28, 15);
            TargetModeAxisLabel.TabIndex = 6;
            TargetModeAxisLabel.Text = "Ось";
            // 
            // RunTargetModeButton
            // 
            RunTargetModeButton.Location = new Point(245, 53);
            RunTargetModeButton.Name = "RunTargetModeButton";
            RunTargetModeButton.Size = new Size(75, 23);
            RunTargetModeButton.TabIndex = 5;
            RunTargetModeButton.Text = "Run";
            RunTargetModeButton.UseVisualStyleBackColor = true;
            RunTargetModeButton.Click += RunTargetModeButton_Click;
            // 
            // TargetModeTextBox
            // 
            TargetModeTextBox.Location = new Point(139, 53);
            TargetModeTextBox.MaxLength = 5;
            TargetModeTextBox.Name = "TargetModeTextBox";
            TargetModeTextBox.Size = new Size(100, 23);
            TargetModeTextBox.TabIndex = 4;
            TargetModeTextBox.TextChanged += TargetModeTextBox_TextChanged;
            TargetModeTextBox.KeyPress += TargetModeTextBox_KeyPress;
            // 
            // TargetCoordLabel
            // 
            TargetCoordLabel.AutoSize = true;
            TargetCoordLabel.Location = new Point(13, 56);
            TargetCoordLabel.Name = "TargetCoordLabel";
            TargetCoordLabel.Size = new Size(120, 15);
            TargetCoordLabel.TabIndex = 3;
            TargetCoordLabel.Text = "Целевая координата";
            // 
            // ContinousModeRadioButton
            // 
            ContinousModeRadioButton.AutoSize = true;
            ContinousModeRadioButton.Location = new Point(58, 248);
            ContinousModeRadioButton.Name = "ContinousModeRadioButton";
            ContinousModeRadioButton.Size = new Size(114, 19);
            ContinousModeRadioButton.TabIndex = 2;
            ContinousModeRadioButton.Text = "Continous mode";
            ContinousModeRadioButton.UseVisualStyleBackColor = true;
            ContinousModeRadioButton.CheckedChanged += ContinousModeRadioButton_CheckedChanged;
            ContinousModeRadioButton.KeyDown += ContinousModeRadioButton_KeyDown;
            ContinousModeRadioButton.KeyUp += ContinousModeRadioButton_KeyUp;
            // 
            // IncrementModeRadioButton
            // 
            IncrementModeRadioButton.AutoSize = true;
            IncrementModeRadioButton.Location = new Point(58, 132);
            IncrementModeRadioButton.Name = "IncrementModeRadioButton";
            IncrementModeRadioButton.Size = new Size(113, 19);
            IncrementModeRadioButton.TabIndex = 1;
            IncrementModeRadioButton.Text = "Increment mode";
            IncrementModeRadioButton.UseVisualStyleBackColor = true;
            IncrementModeRadioButton.CheckedChanged += IncrementModeRadioButton_CheckedChanged;
            // 
            // TargetModeRadioButton
            // 
            TargetModeRadioButton.AutoSize = true;
            TargetModeRadioButton.Location = new Point(58, 24);
            TargetModeRadioButton.Name = "TargetModeRadioButton";
            TargetModeRadioButton.Size = new Size(91, 19);
            TargetModeRadioButton.TabIndex = 0;
            TargetModeRadioButton.Text = "Target mode";
            TargetModeRadioButton.UseVisualStyleBackColor = true;
            TargetModeRadioButton.CheckedChanged += TargetModeRadioButton_CheckedChanged;
            // 
            // CurrentCoordsPanel
            // 
            CurrentCoordsPanel.BorderStyle = BorderStyle.FixedSingle;
            CurrentCoordsPanel.Controls.Add(CurrentUnitLabel_Z);
            CurrentCoordsPanel.Controls.Add(CurrentUnitLabel_Y);
            CurrentCoordsPanel.Controls.Add(CurrentUnitLabel_X);
            CurrentCoordsPanel.Controls.Add(CurrentZ_TextBox);
            CurrentCoordsPanel.Controls.Add(CurrentY_TextBox);
            CurrentCoordsPanel.Controls.Add(CurrentX_TextBox);
            CurrentCoordsPanel.Controls.Add(Current_Z_label);
            CurrentCoordsPanel.Controls.Add(Current_Y_label);
            CurrentCoordsPanel.Controls.Add(Current_X_label);
            CurrentCoordsPanel.Controls.Add(CurrenntCoordsLabel);
            CurrentCoordsPanel.Location = new Point(849, 15);
            CurrentCoordsPanel.Name = "CurrentCoordsPanel";
            CurrentCoordsPanel.Size = new Size(200, 183);
            CurrentCoordsPanel.TabIndex = 8;
            // 
            // CurrentUnitLabel_Z
            // 
            CurrentUnitLabel_Z.AutoSize = true;
            CurrentUnitLabel_Z.Location = new Point(115, 133);
            CurrentUnitLabel_Z.Name = "CurrentUnitLabel_Z";
            CurrentUnitLabel_Z.Size = new Size(45, 15);
            CurrentUnitLabel_Z.TabIndex = 9;
            CurrentUnitLabel_Z.Text = "ед/изм";
            // 
            // CurrentUnitLabel_Y
            // 
            CurrentUnitLabel_Y.AutoSize = true;
            CurrentUnitLabel_Y.Location = new Point(115, 96);
            CurrentUnitLabel_Y.Name = "CurrentUnitLabel_Y";
            CurrentUnitLabel_Y.Size = new Size(45, 15);
            CurrentUnitLabel_Y.TabIndex = 8;
            CurrentUnitLabel_Y.Text = "ед/изм";
            // 
            // CurrentUnitLabel_X
            // 
            CurrentUnitLabel_X.AutoSize = true;
            CurrentUnitLabel_X.Location = new Point(115, 57);
            CurrentUnitLabel_X.Name = "CurrentUnitLabel_X";
            CurrentUnitLabel_X.Size = new Size(45, 15);
            CurrentUnitLabel_X.TabIndex = 7;
            CurrentUnitLabel_X.Text = "ед/изм";
            // 
            // CurrentZ_TextBox
            // 
            CurrentZ_TextBox.Location = new Point(41, 128);
            CurrentZ_TextBox.Name = "CurrentZ_TextBox";
            CurrentZ_TextBox.ReadOnly = true;
            CurrentZ_TextBox.Size = new Size(68, 23);
            CurrentZ_TextBox.TabIndex = 6;
            CurrentZ_TextBox.Text = "...";
            CurrentZ_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CurrentY_TextBox
            // 
            CurrentY_TextBox.Location = new Point(41, 90);
            CurrentY_TextBox.Name = "CurrentY_TextBox";
            CurrentY_TextBox.ReadOnly = true;
            CurrentY_TextBox.Size = new Size(68, 23);
            CurrentY_TextBox.TabIndex = 5;
            CurrentY_TextBox.Text = "...";
            CurrentY_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CurrentX_TextBox
            // 
            CurrentX_TextBox.Location = new Point(41, 53);
            CurrentX_TextBox.Name = "CurrentX_TextBox";
            CurrentX_TextBox.ReadOnly = true;
            CurrentX_TextBox.Size = new Size(68, 23);
            CurrentX_TextBox.TabIndex = 4;
            CurrentX_TextBox.Text = "...";
            CurrentX_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Current_Z_label
            // 
            Current_Z_label.AutoSize = true;
            Current_Z_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Current_Z_label.Location = new Point(11, 128);
            Current_Z_label.Name = "Current_Z_label";
            Current_Z_label.Size = new Size(24, 21);
            Current_Z_label.TabIndex = 3;
            Current_Z_label.Text = "Z:";
            // 
            // Current_Y_label
            // 
            Current_Y_label.AutoSize = true;
            Current_Y_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Current_Y_label.Location = new Point(11, 91);
            Current_Y_label.Name = "Current_Y_label";
            Current_Y_label.Size = new Size(24, 21);
            Current_Y_label.TabIndex = 2;
            Current_Y_label.Text = "Y:";
            // 
            // Current_X_label
            // 
            Current_X_label.AutoSize = true;
            Current_X_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Current_X_label.Location = new Point(11, 53);
            Current_X_label.Name = "Current_X_label";
            Current_X_label.Size = new Size(24, 21);
            Current_X_label.TabIndex = 1;
            Current_X_label.Text = "X:";
            // 
            // CurrenntCoordsLabel
            // 
            CurrenntCoordsLabel.AutoSize = true;
            CurrenntCoordsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CurrenntCoordsLabel.Location = new Point(3, 1);
            CurrenntCoordsLabel.Name = "CurrenntCoordsLabel";
            CurrenntCoordsLabel.Size = new Size(184, 21);
            CurrenntCoordsLabel.TabIndex = 0;
            CurrenntCoordsLabel.Text = "Текущие координаты:";
            // 
            // SetSpeedLabel
            // 
            SetSpeedLabel.AutoSize = true;
            SetSpeedLabel.Location = new Point(72, 370);
            SetSpeedLabel.Name = "SetSpeedLabel";
            SetSpeedLabel.Size = new Size(178, 15);
            SetSpeedLabel.TabIndex = 9;
            SetSpeedLabel.Text = "Задать скорость перемещений";
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(50, 407);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(62, 15);
            SpeedLabel.TabIndex = 10;
            SpeedLabel.Text = "Скорость:";
            // 
            // SetSpeedTextBox
            // 
            SetSpeedTextBox.Location = new Point(111, 404);
            SetSpeedTextBox.Name = "SetSpeedTextBox";
            SetSpeedTextBox.Size = new Size(85, 23);
            SetSpeedTextBox.TabIndex = 11;
            // 
            // SetSpeedButton
            // 
            SetSpeedButton.Location = new Point(202, 404);
            SetSpeedButton.Name = "SetSpeedButton";
            SetSpeedButton.Size = new Size(70, 23);
            SetSpeedButton.TabIndex = 12;
            SetSpeedButton.Text = "Set";
            SetSpeedButton.UseVisualStyleBackColor = true;
            SetSpeedButton.Click += SetSpeedButton_Click;
            // 
            // MainFormFull
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 479);
            Controls.Add(SetSpeedButton);
            Controls.Add(SetSpeedTextBox);
            Controls.Add(SpeedLabel);
            Controls.Add(SetSpeedLabel);
            Controls.Add(CurrentCoordsPanel);
            Controls.Add(MoveModesPanel);
            Controls.Add(ConncetionFailedPictureBox);
            Controls.Add(ConnectionOkPictureBox);
            Controls.Add(StagesParametersPanel);
            Controls.Add(SelectCOMButton);
            Controls.Add(SelectCOMTextBox);
            Controls.Add(SelectCOMLabel);
            Name = "MainFormFull";
            Text = "Главное окно";
            FormClosed += MainFormFull_FormClosed;
            StagesParametersPanel.ResumeLayout(false);
            StagesParametersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ConnectionOkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConncetionFailedPictureBox).EndInit();
            MoveModesPanel.ResumeLayout(false);
            MoveModesPanel.PerformLayout();
            CurrentCoordsPanel.ResumeLayout(false);
            CurrentCoordsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectCOMLabel;
        private TextBox SelectCOMTextBox;
        private Button SelectCOMButton;
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
        private Button button2;
        private Button SaveParametersButton;
        private PictureBox ConnectionOkPictureBox;
        private PictureBox ConncetionFailedPictureBox;
        private Panel MoveModesPanel;
        private RadioButton ContinousModeRadioButton;
        private RadioButton IncrementModeRadioButton;
        private RadioButton TargetModeRadioButton;
        private TextBox TargetModeTextBox;
        private Label TargetCoordLabel;
        private Button RunTargetModeButton;
        private Label TargetModeAxisLabel;
        private ComboBox TargetModeComboBox;
        private Label IncrementModeLabel;
        private TextBox IncrementModeTextBox;
        private Button RunIncrementModeButton;
        private ComboBox IncrementModeComboBox;
        private Label IncrementModeAxisLabel;
        private Button StopButton;
        private Button CancelZeroButton;
        private Button SetZeroButton;
        private Button HomeButton;
        private Button Y_forvardButton;
        private Button Y_backvardButton;
        private Button X_forvardButton;
        private Button X_backvardButton;
        private Button Z_forvardButton;
        private Button Z_backvardButton;
        private ComboBox ContinousModeComboBox;
        private Label ContinousModeAxisLabel;
        private Button ContinousModeHomeButton;
        private Panel CurrentCoordsPanel;
        private Label Current_Z_label;
        private Label Current_Y_label;
        private Label Current_X_label;
        private Label CurrenntCoordsLabel;
        private TextBox CurrentZ_TextBox;
        private TextBox CurrentY_TextBox;
        private TextBox CurrentX_TextBox;
        private Label CurrentUnitLabel_X;
        private Label CurrentUnitLabel_Z;
        private Label CurrentUnitLabel_Y;
        private Label SetSpeedLabel;
        private Label SpeedLabel;
        private TextBox SetSpeedTextBox;
        private Button SetSpeedButton;
        private System.Windows.Forms.Timer ControllerTimer;
    }
}