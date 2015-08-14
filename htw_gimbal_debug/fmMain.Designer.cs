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
            this.btnServoSetValues = new System.Windows.Forms.Button();
            this.btnServoRead = new System.Windows.Forms.Button();
            this.cbxlistDevices = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslConnectedInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxMotionOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(16, 20);
            this.lblPorts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(69, 17);
            this.lblPorts.TabIndex = 0;
            this.lblPorts.Text = "COM Port";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(341, 47);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(155, 89);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "start search";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(0, 373);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(732, 258);
            this.txtLog.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(677, 12);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 28);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(421, 14);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 28);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(95, 14);
            this.cbxPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(237, 24);
            this.cbxPorts.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(341, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 28);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSTConnect
            // 
            this.btnSTConnect.Location = new System.Drawing.Point(745, 15);
            this.btnSTConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSTConnect.Name = "btnSTConnect";
            this.btnSTConnect.Size = new System.Drawing.Size(184, 28);
            this.btnSTConnect.TabIndex = 8;
            this.btnSTConnect.Text = "Connect";
            this.btnSTConnect.UseVisualStyleBackColor = true;
            this.btnSTConnect.Click += new System.EventHandler(this.btnSTConnect_Click);
            // 
            // btnSTDisableNotify
            // 
            this.btnSTDisableNotify.Location = new System.Drawing.Point(745, 86);
            this.btnSTDisableNotify.Margin = new System.Windows.Forms.Padding(4);
            this.btnSTDisableNotify.Name = "btnSTDisableNotify";
            this.btnSTDisableNotify.Size = new System.Drawing.Size(184, 28);
            this.btnSTDisableNotify.TabIndex = 9;
            this.btnSTDisableNotify.Text = "disable notify";
            this.btnSTDisableNotify.UseVisualStyleBackColor = true;
            this.btnSTDisableNotify.Click += new System.EventHandler(this.btnSTDisableNotify_Click);
            // 
            // btnSTEnableNotify
            // 
            this.btnSTEnableNotify.Location = new System.Drawing.Point(745, 50);
            this.btnSTEnableNotify.Margin = new System.Windows.Forms.Padding(4);
            this.btnSTEnableNotify.Name = "btnSTEnableNotify";
            this.btnSTEnableNotify.Size = new System.Drawing.Size(184, 28);
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
            this.labTempAmbient.Location = new System.Drawing.Point(745, 139);
            this.labTempAmbient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTempAmbient.Name = "labTempAmbient";
            this.labTempAmbient.Size = new System.Drawing.Size(184, 34);
            this.labTempAmbient.TabIndex = 11;
            this.labTempAmbient.Text = "0 °C";
            this.labTempAmbient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTempIR
            // 
            this.labTempIR.BackColor = System.Drawing.Color.Black;
            this.labTempIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempIR.ForeColor = System.Drawing.Color.Lime;
            this.labTempIR.Location = new System.Drawing.Point(745, 187);
            this.labTempIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTempIR.Name = "labTempIR";
            this.labTempIR.Size = new System.Drawing.Size(184, 34);
            this.labTempIR.TabIndex = 12;
            this.labTempIR.Text = "0 °C";
            this.labTempIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labHumidity
            // 
            this.labHumidity.BackColor = System.Drawing.Color.Black;
            this.labHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.Lime;
            this.labHumidity.Location = new System.Drawing.Point(745, 234);
            this.labHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(184, 34);
            this.labHumidity.TabIndex = 13;
            this.labHumidity.Text = "0 °C";
            this.labHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labBarometer
            // 
            this.labBarometer.BackColor = System.Drawing.Color.Black;
            this.labBarometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarometer.ForeColor = System.Drawing.Color.Lime;
            this.labBarometer.Location = new System.Drawing.Point(745, 284);
            this.labBarometer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBarometer.Name = "labBarometer";
            this.labBarometer.Size = new System.Drawing.Size(184, 34);
            this.labBarometer.TabIndex = 14;
            this.labBarometer.Text = "0 °C";
            this.labBarometer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labLuxometer
            // 
            this.labLuxometer.BackColor = System.Drawing.Color.Black;
            this.labLuxometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuxometer.ForeColor = System.Drawing.Color.Lime;
            this.labLuxometer.Location = new System.Drawing.Point(745, 331);
            this.labLuxometer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLuxometer.Name = "labLuxometer";
            this.labLuxometer.Size = new System.Drawing.Size(184, 34);
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
            this.dataGridView1.Location = new System.Drawing.Point(937, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 226);
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
            this.groupBox1.Controls.Add(this.btnServoSetValues);
            this.groupBox1.Controls.Add(this.btnServoRead);
            this.groupBox1.Location = new System.Drawing.Point(0, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(480, 97);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BLE Servo Control...";
            // 
            // btnServoSetValues
            // 
            this.btnServoSetValues.Location = new System.Drawing.Point(8, 23);
            this.btnServoSetValues.Margin = new System.Windows.Forms.Padding(4);
            this.btnServoSetValues.Name = "btnServoSetValues";
            this.btnServoSetValues.Size = new System.Drawing.Size(176, 28);
            this.btnServoSetValues.TabIndex = 8;
            this.btnServoSetValues.Text = "Set Values";
            this.btnServoSetValues.UseVisualStyleBackColor = true;
            this.btnServoSetValues.Click += new System.EventHandler(this.btnServoSetValues_Click);
            // 
            // btnServoRead
            // 
            this.btnServoRead.Location = new System.Drawing.Point(8, 59);
            this.btnServoRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnServoRead.Name = "btnServoRead";
            this.btnServoRead.Size = new System.Drawing.Size(160, 28);
            this.btnServoRead.TabIndex = 1;
            this.btnServoRead.Text = "Read Status";
            this.btnServoRead.UseVisualStyleBackColor = true;
            this.btnServoRead.Click += new System.EventHandler(this.btnServoRead_Click);
            // 
            // cbxlistDevices
            // 
            this.cbxlistDevices.CheckOnClick = true;
            this.cbxlistDevices.FormattingEnabled = true;
            this.cbxlistDevices.Location = new System.Drawing.Point(16, 47);
            this.cbxlistDevices.Margin = new System.Windows.Forms.Padding(4);
            this.cbxlistDevices.Name = "cbxlistDevices";
            this.cbxlistDevices.Size = new System.Drawing.Size(316, 89);
            this.cbxlistDevices.TabIndex = 14;
            this.cbxlistDevices.SelectedIndexChanged += new System.EventHandler(this.cbxlistDevices_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnectedInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1552, 25);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslConnectedInfo
            // 
            this.tsslConnectedInfo.Name = "tsslConnectedInfo";
            this.tsslConnectedInfo.Size = new System.Drawing.Size(151, 20);
            this.tsslConnectedInfo.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(599, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "show 3D cube session...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxMotionOnly
            // 
            this.cbxMotionOnly.AutoSize = true;
            this.cbxMotionOnly.Location = new System.Drawing.Point(936, 55);
            this.cbxMotionOnly.Name = "cbxMotionOnly";
            this.cbxMotionOnly.Size = new System.Drawing.Size(102, 21);
            this.cbxMotionOnly.TabIndex = 20;
            this.cbxMotionOnly.Text = "motion only";
            this.cbxMotionOnly.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 662);
            this.Controls.Add(this.cbxMotionOnly);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "hst ble session ";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnServoRead;
        private System.Windows.Forms.Button btnServoSetValues;
        private System.Windows.Forms.CheckedListBox cbxlistDevices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectedInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxMotionOnly;
    }
}

