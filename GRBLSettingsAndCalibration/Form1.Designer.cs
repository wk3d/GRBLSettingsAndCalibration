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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.btnStop = new System.Windows.Forms.Button();
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
            this.tpSquaring = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSquareMoveToTarget = new System.Windows.Forms.Button();
            this.btnSquareUnlock = new System.Windows.Forms.Button();
            this.btnSquareHome = new System.Windows.Forms.Button();
            this.btnSquareStop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCorrectionResult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nupYDistance = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nupXDistance = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalculateAdjustment = new System.Windows.Forms.Button();
            this.txtDiagonalDistanceExpected = new System.Windows.Forms.TextBox();
            this.cbUse345 = new System.Windows.Forms.CheckBox();
            this.txtXAxisLength = new System.Windows.Forms.TextBox();
            this.txtDiagonalDistanceActual = new System.Windows.Forms.TextBox();
            this.pbTriangle = new System.Windows.Forms.PictureBox();
            this.tpErrorCodes = new System.Windows.Forms.TabPage();
            this.dgvErrorCodes = new System.Windows.Forms.DataGridView();
            this.cmbGRBLVersion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nupStartDistFromOrigin = new System.Windows.Forms.NumericUpDown();
            this.tcMain.SuspendLayout();
            this.tpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).BeginInit();
            this.tpCalibration.SuspendLayout();
            this.pnlCalibrationForm.SuspendLayout();
            this.tpSquaring.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupYDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupXDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).BeginInit();
            this.tpErrorCodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStartDistFromOrigin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(827, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(361, 642);
            this.textBox1.TabIndex = 0;
            // 
            // cmbPortsToConnectTo
            // 
            this.cmbPortsToConnectTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortsToConnectTo.FormattingEnabled = true;
            this.cmbPortsToConnectTo.Location = new System.Drawing.Point(88, 14);
            this.cmbPortsToConnectTo.Name = "cmbPortsToConnectTo";
            this.cmbPortsToConnectTo.Size = new System.Drawing.Size(285, 26);
            this.cmbPortsToConnectTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // btnConnectToPort
            // 
            this.btnConnectToPort.Enabled = false;
            this.btnConnectToPort.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectToPort.Location = new System.Drawing.Point(88, 69);
            this.btnConnectToPort.Name = "btnConnectToPort";
            this.btnConnectToPort.Size = new System.Drawing.Size(81, 32);
            this.btnConnectToPort.TabIndex = 3;
            this.btnConnectToPort.Text = "Open";
            this.btnConnectToPort.UseVisualStyleBackColor = true;
            this.btnConnectToPort.Click += new System.EventHandler(this.btnConnectToPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud rate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbBaudRate.Location = new System.Drawing.Point(88, 41);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(285, 26);
            this.cmbBaudRate.TabIndex = 4;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.Location = new System.Drawing.Point(1052, 107);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(136, 33);
            this.btnSendCode.TabIndex = 6;
            this.btnSendCode.Text = "Send";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(827, 113);
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
            this.tcMain.Controls.Add(this.tpSquaring);
            this.tcMain.Controls.Add(this.tpErrorCodes);
            this.tcMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(12, 120);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(809, 670);
            this.tcMain.TabIndex = 8;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.btnSaveSettingsChanges);
            this.tpSetting.Controls.Add(this.dgvSettings);
            this.tpSetting.Location = new System.Drawing.Point(4, 27);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(801, 639);
            this.tpSetting.TabIndex = 0;
            this.tpSetting.Text = "Settings";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettingsChanges
            // 
            this.btnSaveSettingsChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettingsChanges.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettingsChanges.Location = new System.Drawing.Point(5, 595);
            this.btnSaveSettingsChanges.Name = "btnSaveSettingsChanges";
            this.btnSaveSettingsChanges.Size = new System.Drawing.Size(141, 35);
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
            this.dgvSettings.Location = new System.Drawing.Point(5, 7);
            this.dgvSettings.Name = "dgvSettings";
            this.dgvSettings.RowHeadersWidth = 51;
            this.dgvSettings.RowTemplate.Height = 24;
            this.dgvSettings.Size = new System.Drawing.Size(791, 581);
            this.dgvSettings.TabIndex = 0;
            this.dgvSettings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSettings_CellValueChanged);
            this.dgvSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvSettings_MouseUp);
            // 
            // tpCalibration
            // 
            this.tpCalibration.Controls.Add(this.pnlCalibrationForm);
            this.tpCalibration.Controls.Add(this.label4);
            this.tpCalibration.Controls.Add(this.cmbAxisToCalibrate);
            this.tpCalibration.Location = new System.Drawing.Point(4, 27);
            this.tpCalibration.Name = "tpCalibration";
            this.tpCalibration.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalibration.Size = new System.Drawing.Size(801, 639);
            this.tpCalibration.TabIndex = 1;
            this.tpCalibration.Text = "Calibration";
            this.tpCalibration.UseVisualStyleBackColor = true;
            // 
            // pnlCalibrationForm
            // 
            this.pnlCalibrationForm.Controls.Add(this.btnHome);
            this.pnlCalibrationForm.Controls.Add(this.btnUnlock);
            this.pnlCalibrationForm.Controls.Add(this.btnStop);
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
            this.pnlCalibrationForm.Location = new System.Drawing.Point(9, 66);
            this.pnlCalibrationForm.Name = "pnlCalibrationForm";
            this.pnlCalibrationForm.Size = new System.Drawing.Size(613, 468);
            this.pnlCalibrationForm.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(343, 104);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 57);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUnlock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.Location = new System.Drawing.Point(172, 104);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(167, 57);
            this.btnUnlock.TabIndex = 10;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(172, 167);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(341, 72);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveNewStepsPerMM
            // 
            this.btnSaveNewStepsPerMM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewStepsPerMM.Location = new System.Drawing.Point(172, 373);
            this.btnSaveNewStepsPerMM.Name = "btnSaveNewStepsPerMM";
            this.btnSaveNewStepsPerMM.Size = new System.Drawing.Size(109, 36);
            this.btnSaveNewStepsPerMM.TabIndex = 8;
            this.btnSaveNewStepsPerMM.Text = "Save";
            this.btnSaveNewStepsPerMM.UseVisualStyleBackColor = true;
            this.btnSaveNewStepsPerMM.Click += new System.EventHandler(this.btnSaveNewStepsPerMM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Distance (mm)";
            // 
            // txtNewStepsPerMM
            // 
            this.txtNewStepsPerMM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStepsPerMM.Location = new System.Drawing.Point(172, 344);
            this.txtNewStepsPerMM.Name = "txtNewStepsPerMM";
            this.txtNewStepsPerMM.ReadOnly = true;
            this.txtNewStepsPerMM.Size = new System.Drawing.Size(135, 26);
            this.txtNewStepsPerMM.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Current steps/mm";
            // 
            // btnCalculateSteps
            // 
            this.btnCalculateSteps.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSteps.Location = new System.Drawing.Point(172, 303);
            this.btnCalculateSteps.Name = "btnCalculateSteps";
            this.btnCalculateSteps.Size = new System.Drawing.Size(109, 36);
            this.btnCalculateSteps.TabIndex = 6;
            this.btnCalculateSteps.Text = "Calculate";
            this.btnCalculateSteps.UseVisualStyleBackColor = true;
            this.btnCalculateSteps.Click += new System.EventHandler(this.btnCalculateSteps_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ditance moved (mm)";
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBack.Location = new System.Drawing.Point(172, 41);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.Size = new System.Drawing.Size(167, 57);
            this.btnMoveBack.TabIndex = 3;
            this.btnMoveBack.Text = "<- Backward (-)";
            this.btnMoveBack.UseVisualStyleBackColor = true;
            this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "New steps/mm";
            // 
            // txtDistanceMoved
            // 
            this.txtDistanceMoved.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceMoved.Location = new System.Drawing.Point(172, 244);
            this.txtDistanceMoved.Name = "txtDistanceMoved";
            this.txtDistanceMoved.Size = new System.Drawing.Size(135, 26);
            this.txtDistanceMoved.TabIndex = 5;
            // 
            // cmbDistanceToMove
            // 
            this.cmbDistanceToMove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbDistanceToMove.Location = new System.Drawing.Point(172, 11);
            this.cmbDistanceToMove.Name = "cmbDistanceToMove";
            this.cmbDistanceToMove.Size = new System.Drawing.Size(135, 26);
            this.cmbDistanceToMove.TabIndex = 1;
            this.cmbDistanceToMove.SelectedIndexChanged += new System.EventHandler(this.cmbDistanceToMove_SelectedIndexChanged);
            // 
            // btnMoveForward
            // 
            this.btnMoveForward.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveForward.Location = new System.Drawing.Point(343, 41);
            this.btnMoveForward.Name = "btnMoveForward";
            this.btnMoveForward.Size = new System.Drawing.Size(170, 57);
            this.btnMoveForward.TabIndex = 2;
            this.btnMoveForward.Text = "Forward (+) ->";
            this.btnMoveForward.UseVisualStyleBackColor = true;
            this.btnMoveForward.Click += new System.EventHandler(this.btnMoveForward_Click);
            // 
            // txtCurrentStepsPerMM
            // 
            this.txtCurrentStepsPerMM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStepsPerMM.Location = new System.Drawing.Point(172, 273);
            this.txtCurrentStepsPerMM.Name = "txtCurrentStepsPerMM";
            this.txtCurrentStepsPerMM.ReadOnly = true;
            this.txtCurrentStepsPerMM.Size = new System.Drawing.Size(135, 26);
            this.txtCurrentStepsPerMM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Axis to calibrate";
            // 
            // cmbAxisToCalibrate
            // 
            this.cmbAxisToCalibrate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAxisToCalibrate.FormattingEnabled = true;
            this.cmbAxisToCalibrate.Items.AddRange(new object[] {
            "X-axis",
            "Y-axis",
            "Z-axis"});
            this.cmbAxisToCalibrate.Location = new System.Drawing.Point(132, 32);
            this.cmbAxisToCalibrate.Name = "cmbAxisToCalibrate";
            this.cmbAxisToCalibrate.Size = new System.Drawing.Size(135, 26);
            this.cmbAxisToCalibrate.TabIndex = 0;
            this.cmbAxisToCalibrate.SelectedIndexChanged += new System.EventHandler(this.cmbAxisToCalibrate_SelectedIndexChanged);
            // 
            // tpSquaring
            // 
            this.tpSquaring.Controls.Add(this.panel2);
            this.tpSquaring.Controls.Add(this.pbTriangle);
            this.tpSquaring.Location = new System.Drawing.Point(4, 27);
            this.tpSquaring.Name = "tpSquaring";
            this.tpSquaring.Size = new System.Drawing.Size(801, 639);
            this.tpSquaring.TabIndex = 3;
            this.tpSquaring.Text = "Squaring";
            this.tpSquaring.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCorrectionResult);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.nupStartDistFromOrigin);
            this.panel2.Controls.Add(this.nupYDistance);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.nupXDistance);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnCalculateAdjustment);
            this.panel2.Controls.Add(this.txtDiagonalDistanceExpected);
            this.panel2.Controls.Add(this.cbUse345);
            this.panel2.Controls.Add(this.txtXAxisLength);
            this.panel2.Controls.Add(this.txtDiagonalDistanceActual);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 628);
            this.panel2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "X distance to move (mm)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSquareMoveToTarget);
            this.panel1.Controls.Add(this.btnSquareUnlock);
            this.panel1.Controls.Add(this.btnSquareHome);
            this.panel1.Controls.Add(this.btnSquareStop);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 125);
            this.panel1.TabIndex = 9;
            // 
            // btnSquareMoveToTarget
            // 
            this.btnSquareMoveToTarget.BackColor = System.Drawing.Color.Transparent;
            this.btnSquareMoveToTarget.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareMoveToTarget.ForeColor = System.Drawing.Color.Black;
            this.btnSquareMoveToTarget.Location = new System.Drawing.Point(33, 9);
            this.btnSquareMoveToTarget.Name = "btnSquareMoveToTarget";
            this.btnSquareMoveToTarget.Size = new System.Drawing.Size(190, 50);
            this.btnSquareMoveToTarget.TabIndex = 8;
            this.btnSquareMoveToTarget.Text = "Move to target";
            this.btnSquareMoveToTarget.UseVisualStyleBackColor = false;
            this.btnSquareMoveToTarget.Click += new System.EventHandler(this.btnSquareMoveToTarget_Click);
            // 
            // btnSquareUnlock
            // 
            this.btnSquareUnlock.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSquareUnlock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareUnlock.ForeColor = System.Drawing.Color.White;
            this.btnSquareUnlock.Location = new System.Drawing.Point(229, 65);
            this.btnSquareUnlock.Name = "btnSquareUnlock";
            this.btnSquareUnlock.Size = new System.Drawing.Size(190, 50);
            this.btnSquareUnlock.TabIndex = 8;
            this.btnSquareUnlock.Text = "Unlock";
            this.btnSquareUnlock.UseVisualStyleBackColor = false;
            this.btnSquareUnlock.Click += new System.EventHandler(this.btnSquareUnlock_Click);
            // 
            // btnSquareHome
            // 
            this.btnSquareHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSquareHome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareHome.ForeColor = System.Drawing.Color.White;
            this.btnSquareHome.Location = new System.Drawing.Point(33, 65);
            this.btnSquareHome.Name = "btnSquareHome";
            this.btnSquareHome.Size = new System.Drawing.Size(190, 50);
            this.btnSquareHome.TabIndex = 8;
            this.btnSquareHome.Text = "Home";
            this.btnSquareHome.UseVisualStyleBackColor = false;
            this.btnSquareHome.Click += new System.EventHandler(this.btnSquareHome_Click);
            // 
            // btnSquareStop
            // 
            this.btnSquareStop.BackColor = System.Drawing.Color.Crimson;
            this.btnSquareStop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareStop.ForeColor = System.Drawing.Color.White;
            this.btnSquareStop.Location = new System.Drawing.Point(229, 9);
            this.btnSquareStop.Name = "btnSquareStop";
            this.btnSquareStop.Size = new System.Drawing.Size(190, 50);
            this.btnSquareStop.TabIndex = 8;
            this.btnSquareStop.Text = "Stop";
            this.btnSquareStop.UseVisualStyleBackColor = false;
            this.btnSquareStop.Click += new System.EventHandler(this.btnSquareStop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Y distance to move (mm)";
            // 
            // txtCorrectionResult
            // 
            this.txtCorrectionResult.BackColor = System.Drawing.Color.White;
            this.txtCorrectionResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectionResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCorrectionResult.Location = new System.Drawing.Point(42, 428);
            this.txtCorrectionResult.Multiline = true;
            this.txtCorrectionResult.Name = "txtCorrectionResult";
            this.txtCorrectionResult.ReadOnly = true;
            this.txtCorrectionResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCorrectionResult.Size = new System.Drawing.Size(386, 142);
            this.txtCorrectionResult.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Diagonal distance expected (d)";
            // 
            // nupYDistance
            // 
            this.nupYDistance.DecimalPlaces = 1;
            this.nupYDistance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupYDistance.Location = new System.Drawing.Point(369, 35);
            this.nupYDistance.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nupYDistance.Name = "nupYDistance";
            this.nupYDistance.Size = new System.Drawing.Size(95, 26);
            this.nupYDistance.TabIndex = 5;
            this.nupYDistance.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nupYDistance.ValueChanged += new System.EventHandler(this.nupYDistance_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "X-axis length from side to side (mm)";
            // 
            // nupXDistance
            // 
            this.nupXDistance.DecimalPlaces = 1;
            this.nupXDistance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupXDistance.Location = new System.Drawing.Point(369, 6);
            this.nupXDistance.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nupXDistance.Name = "nupXDistance";
            this.nupXDistance.Size = new System.Drawing.Size(95, 26);
            this.nupXDistance.TabIndex = 5;
            this.nupXDistance.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupXDistance.ValueChanged += new System.EventHandler(this.nupXDistance_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Actual diagonal distance moved (d)";
            // 
            // btnCalculateAdjustment
            // 
            this.btnCalculateAdjustment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAdjustment.Location = new System.Drawing.Point(154, 373);
            this.btnCalculateAdjustment.Name = "btnCalculateAdjustment";
            this.btnCalculateAdjustment.Size = new System.Drawing.Size(160, 37);
            this.btnCalculateAdjustment.TabIndex = 4;
            this.btnCalculateAdjustment.Text = "Calculate Adjustment";
            this.btnCalculateAdjustment.UseVisualStyleBackColor = true;
            this.btnCalculateAdjustment.Click += new System.EventHandler(this.btnCalculateAdjustment_Click);
            // 
            // txtDiagonalDistanceExpected
            // 
            this.txtDiagonalDistanceExpected.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagonalDistanceExpected.Location = new System.Drawing.Point(369, 119);
            this.txtDiagonalDistanceExpected.Name = "txtDiagonalDistanceExpected";
            this.txtDiagonalDistanceExpected.ReadOnly = true;
            this.txtDiagonalDistanceExpected.Size = new System.Drawing.Size(96, 26);
            this.txtDiagonalDistanceExpected.TabIndex = 2;
            this.txtDiagonalDistanceExpected.Text = "500";
            // 
            // cbUse345
            // 
            this.cbUse345.AutoSize = true;
            this.cbUse345.Checked = true;
            this.cbUse345.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUse345.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUse345.Location = new System.Drawing.Point(303, 64);
            this.cbUse345.Name = "cbUse345";
            this.cbUse345.Size = new System.Drawing.Size(178, 22);
            this.cbUse345.TabIndex = 3;
            this.cbUse345.Text = "Use 3-4-5 ratio triangle";
            this.cbUse345.UseVisualStyleBackColor = true;
            this.cbUse345.CheckedChanged += new System.EventHandler(this.cbUse345_CheckedChanged);
            // 
            // txtXAxisLength
            // 
            this.txtXAxisLength.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAxisLength.Location = new System.Drawing.Point(370, 90);
            this.txtXAxisLength.Name = "txtXAxisLength";
            this.txtXAxisLength.Size = new System.Drawing.Size(95, 26);
            this.txtXAxisLength.TabIndex = 2;
            this.txtXAxisLength.Text = "600";
            // 
            // txtDiagonalDistanceActual
            // 
            this.txtDiagonalDistanceActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagonalDistanceActual.Location = new System.Drawing.Point(370, 326);
            this.txtDiagonalDistanceActual.Name = "txtDiagonalDistanceActual";
            this.txtDiagonalDistanceActual.Size = new System.Drawing.Size(93, 26);
            this.txtDiagonalDistanceActual.TabIndex = 2;
            // 
            // pbTriangle
            // 
            this.pbTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pbTriangle.Image")));
            this.pbTriangle.Location = new System.Drawing.Point(485, 15);
            this.pbTriangle.Name = "pbTriangle";
            this.pbTriangle.Size = new System.Drawing.Size(313, 353);
            this.pbTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTriangle.TabIndex = 0;
            this.pbTriangle.TabStop = false;
            // 
            // tpErrorCodes
            // 
            this.tpErrorCodes.Controls.Add(this.dgvErrorCodes);
            this.tpErrorCodes.Location = new System.Drawing.Point(4, 27);
            this.tpErrorCodes.Name = "tpErrorCodes";
            this.tpErrorCodes.Size = new System.Drawing.Size(801, 639);
            this.tpErrorCodes.TabIndex = 2;
            this.tpErrorCodes.Text = "Error codes";
            this.tpErrorCodes.UseVisualStyleBackColor = true;
            // 
            // dgvErrorCodes
            // 
            this.dgvErrorCodes.AllowUserToAddRows = false;
            this.dgvErrorCodes.AllowUserToDeleteRows = false;
            this.dgvErrorCodes.AllowUserToOrderColumns = true;
            this.dgvErrorCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvErrorCodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvErrorCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorCodes.Location = new System.Drawing.Point(3, 3);
            this.dgvErrorCodes.Name = "dgvErrorCodes";
            this.dgvErrorCodes.RowHeadersWidth = 51;
            this.dgvErrorCodes.RowTemplate.Height = 24;
            this.dgvErrorCodes.Size = new System.Drawing.Size(795, 629);
            this.dgvErrorCodes.TabIndex = 0;
            // 
            // cmbGRBLVersion
            // 
            this.cmbGRBLVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGRBLVersion.FormattingEnabled = true;
            this.cmbGRBLVersion.Location = new System.Drawing.Point(493, 14);
            this.cmbGRBLVersion.Name = "cmbGRBLVersion";
            this.cmbGRBLVersion.Size = new System.Drawing.Size(121, 26);
            this.cmbGRBLVersion.TabIndex = 9;
            this.cmbGRBLVersion.SelectedIndexChanged += new System.EventHandler(this.cmbGRBLVersion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "GRBL version";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(263, 69);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(109, 32);
            this.btnRefreshList.TabIndex = 10;
            this.btnRefreshList.Text = "Refersh";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(823, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Send code";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "Starting point distance from X origin (S)";
            // 
            // nupStartDistFromOrigin
            // 
            this.nupStartDistFromOrigin.DecimalPlaces = 3;
            this.nupStartDistFromOrigin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupStartDistFromOrigin.Location = new System.Drawing.Point(370, 151);
            this.nupStartDistFromOrigin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nupStartDistFromOrigin.Name = "nupStartDistFromOrigin";
            this.nupStartDistFromOrigin.Size = new System.Drawing.Size(95, 26);
            this.nupStartDistFromOrigin.TabIndex = 5;
            this.nupStartDistFromOrigin.ValueChanged += new System.EventHandler(this.nupYDistance_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 828);
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
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1218, 875);
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
            this.tpSquaring.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupYDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupXDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).EndInit();
            this.tpErrorCodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStartDistFromOrigin)).EndInit();
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
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSaveSettingsChanges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TabPage tpErrorCodes;
        private System.Windows.Forms.DataGridView dgvErrorCodes;
        private System.Windows.Forms.TabPage tpSquaring;
        private System.Windows.Forms.CheckBox cbUse345;
        private System.Windows.Forms.TextBox txtDiagonalDistanceExpected;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbTriangle;
        private System.Windows.Forms.Button btnCalculateAdjustment;
        private System.Windows.Forms.TextBox txtDiagonalDistanceActual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtXAxisLength;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nupYDistance;
        private System.Windows.Forms.NumericUpDown nupXDistance;
        private System.Windows.Forms.TextBox txtCorrectionResult;
        private System.Windows.Forms.Button btnSquareUnlock;
        private System.Windows.Forms.Button btnSquareStop;
        private System.Windows.Forms.Button btnSquareHome;
        private System.Windows.Forms.Button btnSquareMoveToTarget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nupStartDistFromOrigin;
    }
}

