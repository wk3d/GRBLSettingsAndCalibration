using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GRBLSettingsAndCofiguration
{
    public partial class frmMain : Form
    {
        SerialPort sp = new SerialPort();
        string TargetVersion = "";
        bool WaitingForResponse = false;
        string NextAction = "";
        bool OpeningConnection = false;
        bool SettingsUpdated = false;
        string GRBLCurrentSelectedVersion = "";

        delegate void SetTextCallback(string text);
        delegate void UpdateSettingsDGVCallback(DataTable dtSettings);
        delegate void SetCurrentStepsPerMM(string Value);
        delegate void SetCurrentStepsPerMMAfterSave();


        List<int> lChangedRows = new List<int>();

        private void UpdateSettingsDGV(DataTable dtSettings)
        {
            if (dgvSettings.InvokeRequired)
            {
                UpdateSettingsDGVCallback us = new UpdateSettingsDGVCallback(UpdateSettingsDGV);
                this.Invoke(us, new object[] { dtSettings });
            }
            else
            {
                dgvSettings.DataSource = dtSettings;
                dgvSettings.Refresh();
                //dgvSettings.CellValueChanged += DgvSettings_CellValueChanged;
                
                string[][] SettingsDetails = GRBLSettingsConfigs.GetSettings(GRBLSettingsConfigs.GRBLVersions[cmbGRBLVersion.SelectedItem.ToString()]);

                for (int r = 0; r < dgvSettings.Rows.Count; r++)
                {
                    for (int c = 0; c < dgvSettings.Columns.Count; c++)
                    {
                        if (dgvSettings.Columns[c].Name == "Value") { continue; }
                        dgvSettings.Rows[r].Cells[c].ReadOnly = true;
                    }
                }

                string[] DropDowns = new string[] { "axismask", "YesNo", "EnableDisable", "OnOff" };

                // mask options
                DataTable axismasks = GRBLSettingsConfigs.AxisMasks;
                // Yes/No Options
                DataTable dtYesNo = new DataTable();
                dtYesNo.Columns.Add("Value");
                dtYesNo.Columns.Add("Description");
                dtYesNo.Rows.Add("0", "No");
                dtYesNo.Rows.Add("1", "Yes");
                // enable/disable options
                DataTable dtEnableDisable = new DataTable();
                dtEnableDisable.Columns.Add("Value");
                dtEnableDisable.Columns.Add("Description");
                dtEnableDisable.Rows.Add("0", "Disable");
                dtEnableDisable.Rows.Add("1", "Enable");
                // On/Off options
                DataTable dtOnOff = new DataTable();
                dtOnOff.Columns.Add("Value");
                dtOnOff.Columns.Add("Description");
                dtOnOff.Rows.Add("0", "Off");
                dtOnOff.Rows.Add("1", "On");

                for (int r = 0; r < dgvSettings.Rows.Count; r++)
                {
                    string CurrCode = dgvSettings.Rows[r].Cells[0].Value.ToString();
                    foreach(string[] s in SettingsDetails)
                    {
                        if (s[0] == CurrCode)
                        {
                            // handle item
                            if (DropDowns.Contains(s[2]))
                            {
                                string currValue = dgvSettings.Rows[r].Cells[2].Value.ToString();
                                // create dropdown in the cell
                                dgvSettings.Rows[r].Cells[2].Value = null; //this is important.
                                DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();
                                
                                
                                if(s[2] == "axismask")
                                {
                                    c.DataSource = axismasks;
                                    c.ValueMember = "Mask";
                                    c.DisplayMember = "Description";
                                }
                                else if(s[2] == "YesNo")
                                {
                                    c.DataSource = dtYesNo;
                                    c.ValueMember = "Value";
                                    c.DisplayMember = "Description";
                                }
                                else if(s[2] == "EnableDisable")
                                {
                                    c.DataSource = dtEnableDisable;
                                    c.ValueMember = "Value";
                                    c.DisplayMember = "Description";
                                }

                                else if (s[2] == "OnOff")
                                {
                                    c.DataSource = dtOnOff;
                                    c.ValueMember = "Value";
                                    c.DisplayMember = "Description";
                                }

                                dgvSettings.Rows[r].Cells[2] = c;
                                dgvSettings.Rows[r].Cells[2].Value = currValue;
                            }
                        }
                    }
                }


                SettingsUpdated = true;
                


            }
        }

        private void DgvSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!SettingsUpdated)
            {
                return;
            }
            if(e.ColumnIndex == 2)
            {
                // modify the background
                if (!lChangedRows.Contains(e.RowIndex))
                {
                    lChangedRows.Add(e.RowIndex);
                }
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBox1.AppendText(text);
            }
        }

        private void SetTextStepsPerMM(string value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtCurrentStepsPerMM.InvokeRequired)
            {
                SetCurrentStepsPerMM d = new SetCurrentStepsPerMM(SetTextStepsPerMM);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                txtCurrentStepsPerMM.Text = value;
            }
        }

        private void SetTextCurrentStepsPerMMAfterSave()
        {
            if (txtCurrentStepsPerMM.InvokeRequired)
            {
                SetCurrentStepsPerMMAfterSave d = new SetCurrentStepsPerMMAfterSave(SetTextCurrentStepsPerMMAfterSave);
                this.Invoke(d);
            }
            else
            {
                txtCurrentStepsPerMM.Text = txtNewStepsPerMM.Text;
            }
            
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // load grbl versions in settings
            cmbGRBLVersion.Items.Clear();
            foreach(string sa in GRBLSettingsConfigs.GRBLVersions.Keys)
            {
                cmbGRBLVersion.Items.Add(sa);
            }

            if(cmbGRBLVersion.Items.Count > 0)
            {
                cmbGRBLVersion.SelectedIndex = 0;
                TargetVersion = cmbGRBLVersion.SelectedItem.ToString();
            }

            // get the available ports
            EnumeratePorts();


            // prepare calibration values
            cmbDistanceToMove.SelectedIndex = 6;


            

        }

        private void EnumeratePorts()
        {
            ManagementObjectCollection ManObjReturn;
            ManagementObjectSearcher ManObjSearch;
            ManObjSearch = new ManagementObjectSearcher("Select * from Win32_SerialPort");
            ManObjReturn = ManObjSearch.Get();

            cmbPortsToConnectTo.Items.Clear();

            foreach (ManagementObject ManObj in ManObjReturn)
            {

                cmbPortsToConnectTo.Items.Add(ManObj["DeviceID"] + " (" + ManObj["Name"] + ")");

            }

            if (cmbPortsToConnectTo.Items.Count > 0)
            {
                cmbPortsToConnectTo.SelectedIndex = 0;
                btnConnectToPort.Enabled = true;
            }
            cmbBaudRate.SelectedIndex = 7;


        }

        private void btnConnectToPort_Click(object sender, EventArgs e)
        {

            if (btnConnectToPort.Text == "Open")
            {


                if (cmbPortsToConnectTo.SelectedIndex >= 0)
                {
                    if (cmbBaudRate.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please select a baud rate.");
                        return;
                    }

                    string SelectedItem = cmbPortsToConnectTo.SelectedItem.ToString();
                    SelectedItem = SelectedItem.Substring(0, SelectedItem.IndexOf("("));
                    sp = new SerialPort(SelectedItem, int.Parse(cmbBaudRate.SelectedItem.ToString()));
                    sp.Parity = Parity.None;
                    sp.Handshake = Handshake.None;
                    sp.DataBits = 8;
                    sp.StopBits = StopBits.One;
                    sp.RtsEnable = true;
                    sp.DtrEnable = true;
                    sp.WriteTimeout = 30000;
                    sp.ReadTimeout = 30000;
                    sp.DataReceived += Sp_DataReceived;
                    sp.ErrorReceived += Sp_ErrorReceived;
                    sp.DtrEnable = true;
                    try
                    {
                        sp.Open();
                        WaitingForResponse = true;
                        NextAction = "LoadSettings";
                        OpeningConnection = true;

                        //btnConnectToPort.Enabled = false;
                        btnConnectToPort.Text = "Close";
                        textBox1.Text += "Connection opened" + Environment.NewLine;
                        //btnLoadSettings.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        textBox1.Text += ex.Message + Environment.NewLine;
                    }

                }
                else
                {
                    MessageBox.Show("Please select a port.");
                }

            }
            else
            {
                // close the connection
                sp.Close();
                textBox1.Text += "Connection closed" + Environment.NewLine;
                btnConnectToPort.Text = "Open";
                //btnLoadSettings.Enabled = false;
            }





        }

        private void Sp_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            SetText("ERROR:" + Environment.NewLine + sp.ReadExisting() + Environment.NewLine);
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            string DataReceived = "";
            bool EndReached = false;
            bool IsError = false;

            while (!EndReached || sp.BytesToRead > 0)
            {
                var valueOfPort = sp.ReadExisting();
                DataReceived += valueOfPort;
                if(Regex.IsMatch(DataReceived.Trim(), "(ok)$") ||
                   Regex.IsMatch(DataReceived.Trim(), "^(error:\\d+)") ||
                   OpeningConnection)
                {
                    EndReached = true;
                    OpeningConnection = false;
                }
            }

            // get error code if found
            string ErrorCode = "";
            int iErrorCode = 0;
            if (Regex.IsMatch(DataReceived.Trim(), "^(error:\\d+)"))
            {
                IsError = true;
                // extract the code
                ErrorCode = DataReceived.Replace("error:", "").Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0].Trim();
                int.TryParse(ErrorCode, out iErrorCode);
            }

            if (WaitingForResponse)
            {
                // check if there is an action needed
                if(NextAction == "LoadSettings")
                {
                    // call load settings function
                    sp.Write("$$" + Environment.NewLine);
                    NextAction = "ParseSettings";
                    SetText(DataReceived + Environment.NewLine);
                }
                else if(NextAction == "ParseSettings")
                {
                    // parse the settings and show in datagridview
                    ParseSettings(DataReceived);
                    NextAction = "";
                    WaitingForResponse = false;
                }
                else if (NextAction == "SavingNewStepsPerMM")
                {
                    SetTextCurrentStepsPerMMAfterSave();// txtCurrentStepsPerMM.Text = txtNewStepsPerMM.Text;
                    WaitingForResponse = false;
                    NextAction = "";
                }
                else if (NextAction == "GetXStepsPerMM" ||
                    NextAction == "GetYStepsPerMM" ||
                    NextAction == "GetZStepsPerMM"
                    )
                {

                    // code numbers
                    Dictionary<char, string> dCodes = new Dictionary<char, string>()
                    {
                        ['X'] = "$100",
                        ['Y'] = "$101",
                        ['Z'] = "$102"
                    };

                    // get the  DataReceived
                    //string TargetAxis = NextAction.Replace("Get", "").Replace("StepsPerMM", "");
                    string TargetCode = dCodes[NextAction[3]];
                    // find the code
                    string[] ResponseParts = DataReceived.Split(new string[] { TargetCode }, StringSplitOptions.None);
                    int startpos = DataReceived.IndexOf(TargetCode) + 4;
                    int endpos = DataReceived.IndexOf("$", startpos) - startpos;
                    string valuepart = DataReceived.Substring(startpos, endpos).Trim().Replace("=", "");

                    SetTextStepsPerMM(valuepart);
                    WaitingForResponse = false;
                    NextAction = "";
                }
                else
                {
                    SetText(DataReceived + Environment.NewLine);
                    if (IsError && iErrorCode > 0)
                    {
                        try
                        {
                            SetText(GRBLSettingsConfigs.GetErrorForCode(iErrorCode, GRBLCurrentSelectedVersion) + Environment.NewLine);
                        }
                        catch
                        {

                        }

                    }
                    WaitingForResponse = false;
                }
            }
        }

        private void ParseSettings(string SettingsString)
        {
            DataTable dtSettings = new DataTable();
            dtSettings.Columns.Add("Code");
            dtSettings.Columns.Add("Name");
            dtSettings.Columns.Add("Value");
            
            string[][] TargetSettings = GRBLSettingsConfigs.GetSettings(GRBLSettingsConfigs.GRBLVersions[TargetVersion]);
            string[] SettingsParts = SettingsString.Split('$');
            foreach (string SettingsPart in SettingsParts)
            {
                int equalSignIndex = SettingsPart.IndexOf('=');
                if(equalSignIndex < 0)
                {
                    continue;
                }
                // get the setting number
                string settingNum = SettingsPart.Substring(0, equalSignIndex);
                int CurrNumber = -1;
                if(int.TryParse(settingNum, out CurrNumber)){



                    foreach (string[] cfgLine in TargetSettings)
                    {
                        if (cfgLine[0] == ("$" + settingNum))
                        {
                            string[] currLineParts = SettingsPart.Split('=');
                            if(currLineParts.Length != 2)
                            {
                                continue;
                            }

                            string Value = currLineParts[1].Trim();
                            if(Value.IndexOf("\n") > -1)
                            {
                                Value = Value.Substring(0, Value.IndexOf("\n"));
                            }
                            if (Value.IndexOf("\r") > -1)
                            {
                                Value = Value.Substring(0, Value.IndexOf("\r"));
                            }
                            if (Value.EndsWith("ok"))
                            {
                                Value = Value.Replace("ok", "");
                            }

                            // add to the list
                            DataRow rCurrent = dtSettings.NewRow();
                            rCurrent["Code"] = cfgLine[0];
                            rCurrent["Name"] = cfgLine[1]; 
                            rCurrent["Value"] = Value.Trim();


                            dtSettings.Rows.Add(rCurrent);
                            
                        }
                    }
                }
            }

            UpdateSettingsDGV(dtSettings);


        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            sp.Write("$$" +Environment.NewLine);
            WaitingForResponse = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            sp.Write(textBox2.Text + Environment.NewLine);
            WaitingForResponse = true;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            ManagementObjectCollection ManObjReturn;
            ManagementObjectSearcher ManObjSearch;
            ManObjSearch = new ManagementObjectSearcher("Select * from Win32_SerialPort");
            ManObjReturn = ManObjSearch.Get();

            string SelectedValue = "";
            if (cmbPortsToConnectTo.Items.Count > 0 && cmbPortsToConnectTo.SelectedIndex > -1)
            {
                SelectedValue = cmbPortsToConnectTo.SelectedItem.ToString(); ;
            }
            
            cmbPortsToConnectTo.Items.Clear();

            foreach (ManagementObject ManObj in ManObjReturn)
            {
                string ItemText = ManObj["DeviceID"] + " (" + ManObj["Name"] + ")";
                cmbPortsToConnectTo.Items.Add(ItemText);
                if(ItemText == SelectedValue)
                {
                    cmbPortsToConnectTo.SelectedIndex = cmbPortsToConnectTo.Items.Count - 1;
                }
            }



            if (cmbPortsToConnectTo.Items.Count > 0)
            {
                btnConnectToPort.Enabled = true;
            }
        }

        private void cmbAxisToCalibrate_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmbAxisToCalibrate.SelectedIndex > -1)
            {
                if (!sp.IsOpen)
                {
                    MessageBox.Show("The connection is not open.");
                    cmbAxisToCalibrate.SelectedIndex = -1;
                    return;
                }
                pnlCalibrationForm.Enabled = true;

                // get the target value
                WaitingForResponse = true;
                NextAction = "Get" + cmbAxisToCalibrate.SelectedItem.ToString().Replace("-axis", "") + "StepsPerMM";
                txtCurrentStepsPerMM.Text = "";
                try
                {
                    sp.Write("$$" + Environment.NewLine);
                }
                catch
                {
                    WaitingForResponse = false;
                    NextAction = "";
                    return;
                }


                // clear the related controls
                txtDistanceMoved.Text = "";
                txtNewStepsPerMM.Text = "";
                
            }

        }

        private void btnMoveBack_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            string TargetAxis = "";
            if(cmbAxisToCalibrate.SelectedIndex > -1)
            {
                TargetAxis = cmbAxisToCalibrate.SelectedItem.ToString().Replace("-axis", "");
            }
            sp.Write("G91" + Environment.NewLine);
            sp.Write("G0" + TargetAxis + "-" + cmbDistanceToMove.SelectedItem.ToString() + Environment.NewLine);
            sp.Write("G90" + Environment.NewLine);
            SetText("G91" + Environment.NewLine);
            SetText("G0" + TargetAxis + "-" + cmbDistanceToMove.SelectedItem.ToString() + Environment.NewLine);
            SetText("G90" + Environment.NewLine);

            WaitingForResponse = true;
        }

        private void btnMoveForward_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            string TargetAxis = "";
            if (cmbAxisToCalibrate.SelectedIndex > -1)
            {
                TargetAxis = cmbAxisToCalibrate.SelectedItem.ToString().Replace("-axis", "");
            }
            sp.Write("G91" + Environment.NewLine);
            sp.Write("G0" + TargetAxis + cmbDistanceToMove.SelectedItem.ToString() + Environment.NewLine);
            sp.Write("G90" + Environment.NewLine);
            SetText("G91" + Environment.NewLine);
            SetText("G0" + TargetAxis + cmbDistanceToMove.SelectedItem.ToString() + Environment.NewLine);
            SetText("G90" + Environment.NewLine);

            WaitingForResponse = true;
        }

        private void btnCalculateSteps_Click(object sender, EventArgs e)
        {
            // calculate the new value based on the number chosen
            double dTargetDistance = 0;
            double dActualDistance = 0;
            double dCurrentSetting = 0;
            double dTargetSetting = 0;

            if (!double.TryParse(cmbDistanceToMove.SelectedItem.ToString(), out dTargetDistance))
            {
                MessageBox.Show("Invalid distance.");
                return;
            }

            if(!double.TryParse(txtDistanceMoved.Text, out dActualDistance))
            {
                MessageBox.Show("Invalid distance moved.");
                return;
            }

            if(!double.TryParse(txtCurrentStepsPerMM.Text, out dCurrentSetting))
            {
                MessageBox.Show("Invalid current steps/mm");
                return;
            }

            dTargetSetting = (dTargetDistance / dActualDistance) * dCurrentSetting;
            txtNewStepsPerMM.Text = dTargetSetting.ToString("####.###");


        }

        private void cmbDistanceToMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDistanceMoved.Text = "";
            txtNewStepsPerMM.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            sp.Write((char)24 + Environment.NewLine);
            SetText("" + Environment.NewLine);
            WaitingForResponse = true;

        }

        private void btnSaveNewStepsPerMM_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            double ValueToSave = 0;
            if (!double.TryParse(txtNewStepsPerMM.Text, out ValueToSave))
            {
                MessageBox.Show("Invalid value");
                return;
            }
            // code numbers
            Dictionary<char, string> dCodes = new Dictionary<char, string>()
            {
                ['X'] = "$100",
                ['Y'] = "$101",
                ['Z'] = "$102"
            };

            
            try
            {
                WaitingForResponse = true;
                NextAction = "SavingNewStepsPerMM";
                sp.Write(dCodes[cmbAxisToCalibrate.SelectedItem.ToString()[0]] + "=" + txtNewStepsPerMM.Text + Environment.NewLine);
            }
            catch
            {
                WaitingForResponse = false;
                NextAction = "";
            }
            
            SetText(dCodes[cmbAxisToCalibrate.SelectedItem.ToString()[0]] + "=" + txtNewStepsPerMM.Text + Environment.NewLine);
            
        }

        private void btnSaveSettingsChanges_Click(object sender, EventArgs e)
        {

            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection is not open");
                return;
            }

            foreach(int rowNum in lChangedRows)
            {
                WaitingForResponse = true;
                try
                {
                    sp.Write(dgvSettings.Rows[rowNum].Cells[0].Value.ToString() + "=" +
                         dgvSettings.Rows[rowNum].Cells[2].Value.ToString() +
                         Environment.NewLine
                    );
                    SetText(dgvSettings.Rows[rowNum].Cells[0].Value.ToString() + "=" +
                         dgvSettings.Rows[rowNum].Cells[2].Value.ToString() +
                         Environment.NewLine);
                }
                catch
                {
                    MessageBox.Show("Error while trying to write new value(s).");
                    WaitingForResponse = false;
                    return;
                }
                
            }

            lChangedRows.Clear();

        }

        private void dgvSettings_KeyUp(object sender, KeyEventArgs e)
        {
            SetText(dgvSettings.CurrentCell.RowIndex.ToString() + Environment.NewLine);
        }

        private void dgvSettings_MouseUp(object sender, MouseEventArgs e)
        {
            if(dgvSettings.CurrentCell != null)
            {
                if(dgvSettings.CurrentCell.GetType() == typeof(DataGridViewComboBoxCell))
                {
                    dgvSettings.CurrentCell.Selected = false;
                }
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            sp.Write("$X" + Environment.NewLine);
            SetText("$X" + Environment.NewLine);
            WaitingForResponse = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("Connection not open.");
                return;
            }
            sp.Write("$H" + Environment.NewLine);
            SetText("$H" + Environment.NewLine);
            WaitingForResponse = true;
        }

        private void cmbGRBLVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGRBLVersion.SelectedIndex > -1)
            {
                GRBLCurrentSelectedVersion = cmbGRBLVersion.SelectedItem.ToString();
            }
            else
            {
                GRBLCurrentSelectedVersion = "";
            }
        }
    }
}
