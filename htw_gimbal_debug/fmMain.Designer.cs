namespace htw_gimbal_debug
{
    partial class fmMain
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
            this.lblPorts = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSTConnect = new System.Windows.Forms.Button();
            this.btnSTDisableNotify = new System.Windows.Forms.Button();
            this.btnSTEnableNotify = new System.Windows.Forms.Button();
            this.labTempAmbient = new System.Windows.Forms.Label();
            this.labTempIR = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.labBarometer = new System.Windows.Forms.Label();
            this.labLuxometer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxServoSlaveMode = new System.Windows.Forms.CheckBox();
            this.numServoB_degree = new System.Windows.Forms.NumericUpDown();
            this.numServoA_degree = new System.Windows.Forms.NumericUpDown();
            this.cbxServoAutoSet = new System.Windows.Forms.CheckBox();
            this.btnServoSetValues = new System.Windows.Forms.Button();
            this.btnServoCright = new System.Windows.Forms.Button();
            this.btnServoCstop = new System.Windows.Forms.Button();
            this.btnServoCleft = new System.Windows.Forms.Button();
            this.numServoB = new System.Windows.Forms.NumericUpDown();
            this.numServoA = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnServoRead = new System.Windows.Forms.Button();
            this.btnServoConnect = new System.Windows.Forms.Button();
            this.cbxlistDevices = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslConnectedInfo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServoB_degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoA_degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoA)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(12, 16);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(53, 13);
            this.lblPorts.TabIndex = 0;
            this.lblPorts.Text = "COM Port";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(443, 10);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(59, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(12, 132);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(541, 165);
            this.txtLog.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(508, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(381, 10);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(56, 23);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(71, 11);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(179, 21);
            this.cbxPorts.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSTConnect
            // 
            this.btnSTConnect.Location = new System.Drawing.Point(559, 12);
            this.btnSTConnect.Name = "btnSTConnect";
            this.btnSTConnect.Size = new System.Drawing.Size(138, 23);
            this.btnSTConnect.TabIndex = 8;
            this.btnSTConnect.Text = "Connect";
            this.btnSTConnect.UseVisualStyleBackColor = true;
            this.btnSTConnect.Click += new System.EventHandler(this.btnSTConnect_Click);
            // 
            // btnSTDisableNotify
            // 
            this.btnSTDisableNotify.Location = new System.Drawing.Point(703, 41);
            this.btnSTDisableNotify.Name = "btnSTDisableNotify";
            this.btnSTDisableNotify.Size = new System.Drawing.Size(110, 23);
            this.btnSTDisableNotify.TabIndex = 9;
            this.btnSTDisableNotify.Text = "disable notify";
            this.btnSTDisableNotify.UseVisualStyleBackColor = true;
            this.btnSTDisableNotify.Click += new System.EventHandler(this.btnSTDisableNotify_Click);
            // 
            // btnSTEnableNotify
            // 
            this.btnSTEnableNotify.Location = new System.Drawing.Point(559, 41);
            this.btnSTEnableNotify.Name = "btnSTEnableNotify";
            this.btnSTEnableNotify.Size = new System.Drawing.Size(138, 23);
            this.btnSTEnableNotify.TabIndex = 10;
            this.btnSTEnableNotify.Text = "cfg. sensors w notify";
            this.btnSTEnableNotify.UseVisualStyleBackColor = true;
            this.btnSTEnableNotify.Click += new System.EventHandler(this.btnSTEnableNotify_Click);
            // 
            // labTempAmbient
            // 
            this.labTempAmbient.BackColor = System.Drawing.Color.Black;
            this.labTempAmbient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempAmbient.ForeColor = System.Drawing.Color.Lime;
            this.labTempAmbient.Location = new System.Drawing.Point(559, 113);
            this.labTempAmbient.Name = "labTempAmbient";
            this.labTempAmbient.Size = new System.Drawing.Size(138, 28);
            this.labTempAmbient.TabIndex = 11;
            this.labTempAmbient.Text = "0 °C";
            this.labTempAmbient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTempIR
            // 
            this.labTempIR.BackColor = System.Drawing.Color.Black;
            this.labTempIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempIR.ForeColor = System.Drawing.Color.Lime;
            this.labTempIR.Location = new System.Drawing.Point(559, 152);
            this.labTempIR.Name = "labTempIR";
            this.labTempIR.Size = new System.Drawing.Size(138, 28);
            this.labTempIR.TabIndex = 12;
            this.labTempIR.Text = "0 °C";
            this.labTempIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHumidity
            // 
            this.labHumidity.BackColor = System.Drawing.Color.Black;
            this.labHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.Lime;
            this.labHumidity.Location = new System.Drawing.Point(559, 190);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(138, 28);
            this.labHumidity.TabIndex = 13;
            this.labHumidity.Text = "0 °C";
            this.labHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labBarometer
            // 
            this.labBarometer.BackColor = System.Drawing.Color.Black;
            this.labBarometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarometer.ForeColor = System.Drawing.Color.Lime;
            this.labBarometer.Location = new System.Drawing.Point(559, 231);
            this.labBarometer.Name = "labBarometer";
            this.labBarometer.Size = new System.Drawing.Size(138, 28);
            this.labBarometer.TabIndex = 14;
            this.labBarometer.Text = "0 °C";
            this.labBarometer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labLuxometer
            // 
            this.labLuxometer.BackColor = System.Drawing.Color.Black;
            this.labLuxometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuxometer.ForeColor = System.Drawing.Color.Lime;
            this.labLuxometer.Location = new System.Drawing.Point(559, 269);
            this.labLuxometer.Name = "labLuxometer";
            this.labLuxometer.Size = new System.Drawing.Size(138, 28);
            this.labLuxometer.TabIndex = 15;
            this.labLuxometer.Text = "0 °C";
            this.labLuxometer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSensor,
            this.colX,
            this.colY,
            this.colZ});
            this.dataGridView1.Location = new System.Drawing.Point(703, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 184);
            this.dataGridView1.TabIndex = 16;
            // 
            // colSensor
            // 
            this.colSensor.HeaderText = "Sensor";
            this.colSensor.Name = "colSensor";
            // 
            // colX
            // 
            this.colX.HeaderText = "X";
            this.colX.Name = "colX";
            // 
            // colY
            // 
            this.colY.HeaderText = "Y";
            this.colY.Name = "colY";
            // 
            // colZ
            // 
            this.colZ.HeaderText = "Z";
            this.colZ.Name = "colZ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxServoSlaveMode);
            this.groupBox1.Controls.Add(this.numServoB_degree);
            this.groupBox1.Controls.Add(this.numServoA_degree);
            this.groupBox1.Controls.Add(this.cbxServoAutoSet);
            this.groupBox1.Controls.Add(this.btnServoSetValues);
            this.groupBox1.Controls.Add(this.btnServoCright);
            this.groupBox1.Controls.Add(this.btnServoCstop);
            this.groupBox1.Controls.Add(this.btnServoCleft);
            this.groupBox1.Controls.Add(this.numServoB);
            this.groupBox1.Controls.Add(this.numServoA);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnServoRead);
            this.groupBox1.Controls.Add(this.btnServoConnect);
            this.groupBox1.Location = new System.Drawing.Point(15, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BLE Servo Control...";
            // 
            // cbxServoSlaveMode
            // 
            this.cbxServoSlaveMode.AutoSize = true;
            this.cbxServoSlaveMode.Location = new System.Drawing.Point(269, 129);
            this.cbxServoSlaveMode.Name = "cbxServoSlaveMode";
            this.cbxServoSlaveMode.Size = new System.Drawing.Size(83, 17);
            this.cbxServoSlaveMode.TabIndex = 12;
            this.cbxServoSlaveMode.Text = "Slave Mode";
            this.cbxServoSlaveMode.UseVisualStyleBackColor = true;
            // 
            // numServoB_degree
            // 
            this.numServoB_degree.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numServoB_degree.Location = new System.Drawing.Point(333, 74);
            this.numServoB_degree.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numServoB_degree.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numServoB_degree.Name = "numServoB_degree";
            this.numServoB_degree.Size = new System.Drawing.Size(73, 20);
            this.numServoB_degree.TabIndex = 11;
            // 
            // numServoA_degree
            // 
            this.numServoA_degree.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numServoA_degree.Location = new System.Drawing.Point(333, 48);
            this.numServoA_degree.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numServoA_degree.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numServoA_degree.Name = "numServoA_degree";
            this.numServoA_degree.Size = new System.Drawing.Size(73, 20);
            this.numServoA_degree.TabIndex = 10;
            // 
            // cbxServoAutoSet
            // 
            this.cbxServoAutoSet.AutoSize = true;
            this.cbxServoAutoSet.Location = new System.Drawing.Point(201, 129);
            this.cbxServoAutoSet.Name = "cbxServoAutoSet";
            this.cbxServoAutoSet.Size = new System.Drawing.Size(62, 17);
            this.cbxServoAutoSet.TabIndex = 9;
            this.cbxServoAutoSet.Text = "Autoset";
            this.cbxServoAutoSet.UseVisualStyleBackColor = true;
            // 
            // btnServoSetValues
            // 
            this.btnServoSetValues.Location = new System.Drawing.Point(195, 100);
            this.btnServoSetValues.Name = "btnServoSetValues";
            this.btnServoSetValues.Size = new System.Drawing.Size(132, 23);
            this.btnServoSetValues.TabIndex = 8;
            this.btnServoSetValues.Text = "Set Values";
            this.btnServoSetValues.UseVisualStyleBackColor = true;
            this.btnServoSetValues.Click += new System.EventHandler(this.btnServoSetValues_Click);
            // 
            // btnServoCright
            // 
            this.btnServoCright.Location = new System.Drawing.Point(287, 19);
            this.btnServoCright.Name = "btnServoCright";
            this.btnServoCright.Size = new System.Drawing.Size(40, 23);
            this.btnServoCright.TabIndex = 7;
            this.btnServoCright.Text = "Right";
            this.btnServoCright.UseVisualStyleBackColor = true;
            // 
            // btnServoCstop
            // 
            this.btnServoCstop.Location = new System.Drawing.Point(241, 19);
            this.btnServoCstop.Name = "btnServoCstop";
            this.btnServoCstop.Size = new System.Drawing.Size(40, 23);
            this.btnServoCstop.TabIndex = 6;
            this.btnServoCstop.Text = "Stop";
            this.btnServoCstop.UseVisualStyleBackColor = true;
            // 
            // btnServoCleft
            // 
            this.btnServoCleft.Location = new System.Drawing.Point(195, 19);
            this.btnServoCleft.Name = "btnServoCleft";
            this.btnServoCleft.Size = new System.Drawing.Size(40, 23);
            this.btnServoCleft.TabIndex = 5;
            this.btnServoCleft.Text = "Left";
            this.btnServoCleft.UseVisualStyleBackColor = true;
            // 
            // numServoB
            // 
            this.numServoB.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numServoB.Location = new System.Drawing.Point(195, 74);
            this.numServoB.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numServoB.Name = "numServoB";
            this.numServoB.Size = new System.Drawing.Size(132, 20);
            this.numServoB.TabIndex = 4;
            this.numServoB.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numServoA
            // 
            this.numServoA.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numServoA.Location = new System.Drawing.Point(195, 48);
            this.numServoA.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numServoA.Name = "numServoA";
            this.numServoA.Size = new System.Drawing.Size(132, 20);
            this.numServoA.TabIndex = 3;
            this.numServoA.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(412, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // btnServoRead
            // 
            this.btnServoRead.Location = new System.Drawing.Point(412, 19);
            this.btnServoRead.Name = "btnServoRead";
            this.btnServoRead.Size = new System.Drawing.Size(120, 23);
            this.btnServoRead.TabIndex = 1;
            this.btnServoRead.Text = "Read Status";
            this.btnServoRead.UseVisualStyleBackColor = true;
            this.btnServoRead.Click += new System.EventHandler(this.btnServoRead_Click);
            // 
            // btnServoConnect
            // 
            this.btnServoConnect.Location = new System.Drawing.Point(6, 19);
            this.btnServoConnect.Name = "btnServoConnect";
            this.btnServoConnect.Size = new System.Drawing.Size(100, 23);
            this.btnServoConnect.TabIndex = 0;
            this.btnServoConnect.Text = "Connect Servo";
            this.btnServoConnect.UseVisualStyleBackColor = true;
            // 
            // cbxlistDevices
            // 
            this.cbxlistDevices.FormattingEnabled = true;
            this.cbxlistDevices.Location = new System.Drawing.Point(12, 38);
            this.cbxlistDevices.Name = "cbxlistDevices";
            this.cbxlistDevices.Size = new System.Drawing.Size(238, 79);
            this.cbxlistDevices.TabIndex = 14;
            this.cbxlistDevices.SelectedIndexChanged += new System.EventHandler(this.cbxlistDevices_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnectedInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1164, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslConnectedInfo
            // 
            this.tsslConnectedInfo.Name = "tsslConnectedInfo";
            this.tsslConnectedInfo.Size = new System.Drawing.Size(118, 17);
            this.tsslConnectedInfo.Text = "toolStripStatusLabel1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 538);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbxlistDevices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labLuxometer);
            this.Controls.Add(this.labBarometer);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.labTempIR);
            this.Controls.Add(this.labTempAmbient);
            this.Controls.Add(this.btnSTEnableNotify);
            this.Controls.Add(this.btnSTDisableNotify);
            this.Controls.Add(this.btnSTConnect);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxPorts);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "hst ble session ";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServoB_degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoA_degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServoA)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSTConnect;
        private System.Windows.Forms.Button btnSTDisableNotify;
        private System.Windows.Forms.Button btnSTEnableNotify;
        private System.Windows.Forms.Label labTempAmbient;
        private System.Windows.Forms.Label labTempIR;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label labBarometer;
        private System.Windows.Forms.Label labLuxometer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnServoRead;
        private System.Windows.Forms.Button btnServoConnect;
        private System.Windows.Forms.Button btnServoSetValues;
        private System.Windows.Forms.Button btnServoCright;
        private System.Windows.Forms.Button btnServoCstop;
        private System.Windows.Forms.Button btnServoCleft;
        private System.Windows.Forms.NumericUpDown numServoB;
        private System.Windows.Forms.NumericUpDown numServoA;
        private System.Windows.Forms.CheckBox cbxServoAutoSet;
        private System.Windows.Forms.NumericUpDown numServoB_degree;
        private System.Windows.Forms.NumericUpDown numServoA_degree;
        private System.Windows.Forms.CheckBox cbxServoSlaveMode;
        private System.Windows.Forms.CheckedListBox cbxlistDevices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectedInfo;
    }
}

