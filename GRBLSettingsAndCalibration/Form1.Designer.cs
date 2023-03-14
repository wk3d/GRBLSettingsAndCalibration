namespace GRBLSettingsAndCofiguration
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbPortsToConnectTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectToPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.btnSaveSettingsChanges = new System.Windows.Forms.Button();
            this.dgvSettings = new System.Windows.Forms.DataGridView();
            this.tpCalibration = new System.Windows.Forms.TabPage();
            this.pnlCalibrationForm = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveNewStepsPerMM = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewStepsPerMM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateSteps = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMoveBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDistanceMoved = new System.Windows.Forms.TextBox();
            this.cmbDistanceToMove = new System.Windows.Forms.ComboBox();
            this.btnMoveForward = new System.Windows.Forms.Button();
            this.txtCurrentStepsPerMM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAxisToCalibrate = new System.Windows.Forms.ComboBox();
            this.cmbGRBLVersion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).BeginInit();
            this.tpCalibration.SuspendLayout();
            this.pnlCalibrationForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(827, 153);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(361, 571);
            this.textBox1.TabIndex = 0;
            // 
            // cmbPortsToConnectTo
            // 
            this.cmbPortsToConnectTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortsToConnectTo.FormattingEnabled = true;
            this.cmbPortsToConnectTo.Location = new System.Drawing.Point(88, 12);
            this.cmbPortsToConnectTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPortsToConnectTo.Name = "cmbPortsToConnectTo";
            this.cmbPortsToConnectTo.Size = new System.Drawing.Size(285, 28);
            this.cmbPortsToConnectTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // btnConnectToPort
            // 
            this.btnConnectToPort.Enabled = false;
            this.btnConnectToPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectToPort.Location = new System.Drawing.Point(88, 80);
            this.btnConnectToPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnectToPort.Name = "btnConnectToPort";
            this.btnConnectToPort.Size = new System.Drawing.Size(81, 28);
            this.btnConnectToPort.TabIndex = 3;
            this.btnConnectToPort.Text = "Open";
            this.btnConnectToPort.UseVisualStyleBackColor = true;
            this.btnConnectToPort.Click += new System.EventHandler(this.btnConnectToPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud rate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(88, 46);
            this.cmbBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(285, 28);
            this.cmbBaudRate.TabIndex = 4;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.Location = new System.Drawing.Point(1052, 118);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(136, 30);
            this.btnSendCode.TabIndex = 6;
            this.btnSendCode.Text = "Send";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(827, 121);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "$$";
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpSetting);
            this.tcMain.Controls.Add(this.tpCalibration);
            this.tcMain.Location = new System.Drawing.Point(12, 128);
            this.tcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(809, 596);
            this.tcMain.TabIndex = 8;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.btnSaveSettingsChanges);
            this.tpSetting.Controls.Add(this.dgvSettings);
            this.tpSetting.Location = new System.Drawing.Point(4, 25);
            this.tpSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSetting.Size = new System.Drawing.Size(801, 567);
            this.tpSetting.TabIndex = 0;
            this.tpSetting.Text = "Settings";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettingsChanges
            // 
            this.btnSaveSettingsChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettingsChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettingsChanges.Location = new System.Drawing.Point(5, 530);
            this.btnSaveSettingsChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveSettingsChanges.Name = "btnSaveSettingsChanges";
            this.btnSaveSettingsChanges.Size = new System.Drawing.Size(141, 31);
            this.btnSaveSettingsChanges.TabIndex = 1;
            this.btnSaveSettingsChanges.Text = "Save Changes";
            this.btnSaveSettingsChanges.UseVisualStyleBackColor = true;
            this.btnSaveSettingsChanges.Click += new System.EventHandler(this.btnSaveSettingsChanges_Click);
            // 
            // dgvSettings
            // 
            this.dgvSettings.AllowUserToAddRows = false;
            this.dgvSettings.AllowUserToDeleteRows = false;
            this.dgvSettings.AllowUserToOrderColumns = true;
            this.dgvSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSettings.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSettings.Location = new System.Drawing.Point(5, 6);
            this.dgvSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSettings.Name = "dgvSettings";
            this.dgvSettings.RowHeadersWidth = 51;
            this.dgvSettings.RowTemplate.Height = 24;
            this.dgvSettings.Size = new System.Drawing.Size(791, 518);
            this.dgvSettings.TabIndex = 0;
            this.dgvSettings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSettings_CellValueChanged);
            this.dgvSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvSettings_MouseUp);
            // 
            // tpCalibration
            // 
            this.tpCalibration.Controls.Add(this.pnlCalibrationForm);
            this.tpCalibration.Controls.Add(this.label4);
            this.tpCalibration.Controls.Add(this.cmbAxisToCalibrate);
            this.tpCalibration.Location = new System.Drawing.Point(4, 25);
            this.tpCalibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCalibration.Name = "tpCalibration";
            this.tpCalibration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCalibration.Size = new System.Drawing.Size(801, 567);
            this.tpCalibration.TabIndex = 1;
            this.tpCalibration.Text = "Calibration";
            this.tpCalibration.UseVisualStyleBackColor = true;
            // 
            // pnlCalibrationForm
            // 
            this.pnlCalibrationForm.Controls.Add(this.btnHome);
            this.pnlCalibrationForm.Controls.Add(this.btnUnlock);
            this.pnlCalibrationForm.Controls.Add(this.button2);
            this.pnlCalibrationForm.Controls.Add(this.btnSaveNewStepsPerMM);
            this.pnlCalibrationForm.Controls.Add(this.label5);
            this.pnlCalibrationForm.Controls.Add(this.txtNewStepsPerMM);
            this.pnlCalibrationForm.Controls.Add(this.label7);
            this.pnlCalibrationForm.Controls.Add(this.btnCalculateSteps);
            this.pnlCalibrationForm.Controls.Add(this.label6);
            this.pnlCalibrationForm.Controls.Add(this.btnMoveBack);
            this.pnlCalibrationForm.Controls.Add(this.label8);
            this.pnlCalibrationForm.Controls.Add(this.txtDistanceMoved);
            this.pnlCalibrationForm.Controls.Add(this.cmbDistanceToMove);
            this.pnlCalibrationForm.Controls.Add(this.btnMoveForward);
            this.pnlCalibrationForm.Controls.Add(this.txtCurrentStepsPerMM);
            this.pnlCalibrationForm.Enabled = false;
            this.pnlCalibrationForm.Location = new System.Drawing.Point(9, 59);
            this.pnlCalibrationForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCalibrationForm.Name = "pnlCalibrationForm";
            this.pnlCalibrationForm.Size = new System.Drawing.Size(613, 416);
            this.pnlCalibrationForm.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(343, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 50);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.Location = new System.Drawing.Point(172, 100);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(167, 50);
            this.btnUnlock.TabIndex = 10;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(172, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveNewStepsPerMM
            // 
            this.btnSaveNewStepsPerMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewStepsPerMM.Location = new System.Drawing.Point(172, 358);
            this.btnSaveNewStepsPerMM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveNewStepsPerMM.Name = "btnSaveNewStepsPerMM";
            this.btnSaveNewStepsPerMM.Size = new System.Drawing.Size(109, 32);
            this.btnSaveNewStepsPerMM.TabIndex = 8;
            this.btnSaveNewStepsPerMM.Text = "Save";
            this.btnSaveNewStepsPerMM.UseVisualStyleBackColor = true;
            this.btnSaveNewStepsPerMM.Click += new System.EventHandler(this.btnSaveNewStepsPerMM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Distance (mm)";
            // 
            // txtNewStepsPerMM
            // 
            this.txtNewStepsPerMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStepsPerMM.Location = new System.Drawing.Point(172, 326);
            this.txtNewStepsPerMM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewStepsPerMM.Name = "txtNewStepsPerMM";
            this.txtNewStepsPerMM.ReadOnly = true;
            this.txtNewStepsPerMM.Size = new System.Drawing.Size(135, 26);
            this.txtNewStepsPerMM.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Current steps/mm";
            // 
            // btnCalculateSteps
            // 
            this.btnCalculateSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSteps.Location = new System.Drawing.Point(172, 288);
            this.btnCalculateSteps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateSteps.Name = "btnCalculateSteps";
            this.btnCalculateSteps.Size = new System.Drawing.Size(109, 32);
            this.btnCalculateSteps.TabIndex = 6;
            this.btnCalculateSteps.Text = "Calculate";
            this.btnCalculateSteps.UseVisualStyleBackColor = true;
            this.btnCalculateSteps.Click += new System.EventHandler(this.btnCalculateSteps_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ditance moved (mm)";
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBack.Location = new System.Drawing.Point(172, 44);
            this.btnMoveBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.Size = new System.Drawing.Size(167, 50);
            this.btnMoveBack.TabIndex = 3;
            this.btnMoveBack.Text = "<- Backward (-)";
            this.btnMoveBack.UseVisualStyleBackColor = true;
            this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "New steps/mm";
            // 
            // txtDistanceMoved
            // 
            this.txtDistanceMoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceMoved.Location = new System.Drawing.Point(172, 224);
            this.txtDistanceMoved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistanceMoved.Name = "txtDistanceMoved";
            this.txtDistanceMoved.Size = new System.Drawing.Size(135, 26);
            this.txtDistanceMoved.TabIndex = 5;
            // 
            // cmbDistanceToMove
            // 
            this.cmbDistanceToMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistanceToMove.FormattingEnabled = true;
            this.cmbDistanceToMove.Items.AddRange(new object[] {
            "300",
            "200",
            "100",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0.5",
            "0.4",
            "0.3",
            "0.2",
            "0.1"});
            this.cmbDistanceToMove.Location = new System.Drawing.Point(172, 10);
            this.cmbDistanceToMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDistanceToMove.Name = "cmbDistanceToMove";
            this.cmbDistanceToMove.Size = new System.Drawing.Size(135, 28);
            this.cmbDistanceToMove.TabIndex = 1;
            this.cmbDistanceToMove.SelectedIndexChanged += new System.EventHandler(this.cmbDistanceToMove_SelectedIndexChanged);
            // 
            // btnMoveForward
            // 
            this.btnMoveForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveForward.Location = new System.Drawing.Point(343, 44);
            this.btnMoveForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveForward.Name = "btnMoveForward";
            this.btnMoveForward.Size = new System.Drawing.Size(170, 50);
            this.btnMoveForward.TabIndex = 2;
            this.btnMoveForward.Text = "Forward (+) ->";
            this.btnMoveForward.UseVisualStyleBackColor = true;
            this.btnMoveForward.Click += new System.EventHandler(this.btnMoveForward_Click);
            // 
            // txtCurrentStepsPerMM
            // 
            this.txtCurrentStepsPerMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStepsPerMM.Location = new System.Drawing.Point(172, 256);
            this.txtCurrentStepsPerMM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentStepsPerMM.Name = "txtCurrentStepsPerMM";
            this.txtCurrentStepsPerMM.ReadOnly = true;
            this.txtCurrentStepsPerMM.Size = new System.Drawing.Size(135, 26);
            this.txtCurrentStepsPerMM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Axis to calibrate";
            // 
            // cmbAxisToCalibrate
            // 
            this.cmbAxisToCalibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAxisToCalibrate.FormattingEnabled = true;
            this.cmbAxisToCalibrate.Items.AddRange(new object[] {
            "X-axis",
            "Y-axis",
            "Z-axis"});
            this.cmbAxisToCalibrate.Location = new System.Drawing.Point(141, 25);
            this.cmbAxisToCalibrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAxisToCalibrate.Name = "cmbAxisToCalibrate";
            this.cmbAxisToCalibrate.Size = new System.Drawing.Size(135, 28);
            this.cmbAxisToCalibrate.TabIndex = 0;
            this.cmbAxisToCalibrate.SelectedIndexChanged += new System.EventHandler(this.cmbAxisToCalibrate_SelectedIndexChanged);
            // 
            // cmbGRBLVersion
            // 
            this.cmbGRBLVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGRBLVersion.FormattingEnabled = true;
            this.cmbGRBLVersion.Location = new System.Drawing.Point(493, 12);
            this.cmbGRBLVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGRBLVersion.Name = "cmbGRBLVersion";
            this.cmbGRBLVersion.Size = new System.Drawing.Size(121, 28);
            this.cmbGRBLVersion.TabIndex = 9;
            this.cmbGRBLVersion.SelectedIndexChanged += new System.EventHandler(this.cmbGRBLVersion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GRBL version";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(263, 80);
            this.btnRefreshList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(109, 28);
            this.btnRefreshList.TabIndex = 10;
            this.btnRefreshList.Text = "Refersh";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Send code";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 736);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.cmbGRBLVersion);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.btnConnectToPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPortsToConnectTo);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "GRBL Settings and Configuration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).EndInit();
            this.tpCalibration.ResumeLayout(false);
            this.tpCalibration.PerformLayout();
            this.pnlCalibrationForm.ResumeLayout(false);
            this.pnlCalibrationForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbPortsToConnectTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectToPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.TabPage tpCalibration;
        private System.Windows.Forms.DataGridView dgvSettings;
        private System.Windows.Forms.ComboBox cmbGRBLVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAxisToCalibrate;
        private System.Windows.Forms.ComboBox cmbDistanceToMove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMoveBack;
        private System.Windows.Forms.Button btnMoveForward;
        private System.Windows.Forms.TextBox txtDistanceMoved;
        private System.Windows.Forms.TextBox txtCurrentStepsPerMM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateSteps;
        private System.Windows.Forms.TextBox txtNewStepsPerMM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCalibrationForm;
        private System.Windows.Forms.Button btnSaveNewStepsPerMM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveSettingsChanges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnHome;
    }
}

