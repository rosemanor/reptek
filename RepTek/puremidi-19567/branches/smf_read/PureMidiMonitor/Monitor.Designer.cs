namespace PureMidi.Monitor
{
    partial class Monitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.groupBoxMonitorSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxSysEx = new System.Windows.Forms.CheckBox();
            this.buttonSelectLogFileName = new System.Windows.Forms.Button();
            this.textBoxLogFileName = new System.Windows.Forms.TextBox();
            this.checkBoxLogToFile = new System.Windows.Forms.CheckBox();
            this.groupBoxChannelSelector = new System.Windows.Forms.GroupBox();
            this.checkBoxCh11 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh16 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh15 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh14 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh13 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh12 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh10 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh9 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh8 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh7 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh6 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh5 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh4 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh3 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCh1 = new System.Windows.Forms.CheckBox();
            this.groupBoxMonitorLog = new System.Windows.Forms.GroupBox();
            this.listBoxMidiLog = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDevicesOpenClose = new System.Windows.Forms.Button();
            this.groupBoxMidiDevices = new System.Windows.Forms.GroupBox();
            this.comboBoxOutputDevices = new System.Windows.Forms.ComboBox();
            this.comboBoxInputDevices = new System.Windows.Forms.ComboBox();
            this.groupBoxMonitorSettings.SuspendLayout();
            this.groupBoxChannelSelector.SuspendLayout();
            this.groupBoxMonitorLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMidiDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMonitorSettings
            // 
            this.groupBoxMonitorSettings.Controls.Add(this.checkBoxSysEx);
            this.groupBoxMonitorSettings.Controls.Add(this.buttonSelectLogFileName);
            this.groupBoxMonitorSettings.Controls.Add(this.textBoxLogFileName);
            this.groupBoxMonitorSettings.Controls.Add(this.checkBoxLogToFile);
            this.groupBoxMonitorSettings.Controls.Add(this.groupBoxChannelSelector);
            this.groupBoxMonitorSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMonitorSettings.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxMonitorSettings.Location = new System.Drawing.Point(4, 48);
            this.groupBoxMonitorSettings.Name = "groupBoxMonitorSettings";
            this.groupBoxMonitorSettings.Size = new System.Drawing.Size(719, 79);
            this.groupBoxMonitorSettings.TabIndex = 1;
            this.groupBoxMonitorSettings.TabStop = false;
            this.groupBoxMonitorSettings.Text = "Monitor settings";
            // 
            // checkBoxSysEx
            // 
            this.checkBoxSysEx.AutoSize = true;
            this.checkBoxSysEx.Checked = true;
            this.checkBoxSysEx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSysEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSysEx.Location = new System.Drawing.Point(8, 19);
            this.checkBoxSysEx.Name = "checkBoxSysEx";
            this.checkBoxSysEx.Size = new System.Drawing.Size(95, 17);
            this.checkBoxSysEx.TabIndex = 12;
            this.checkBoxSysEx.Text = "Listen to SysEx";
            this.checkBoxSysEx.UseVisualStyleBackColor = true;
            // 
            // buttonSelectLogFileName
            // 
            this.buttonSelectLogFileName.Location = new System.Drawing.Point(396, 50);
            this.buttonSelectLogFileName.Name = "buttonSelectLogFileName";
            this.buttonSelectLogFileName.Size = new System.Drawing.Size(25, 23);
            this.buttonSelectLogFileName.TabIndex = 11;
            this.buttonSelectLogFileName.Text = "...";
            this.buttonSelectLogFileName.UseVisualStyleBackColor = true;
            this.buttonSelectLogFileName.Click += new System.EventHandler(this.ButtonSelectLogFileNameClick);
            // 
            // textBoxLogFileName
            // 
            this.textBoxLogFileName.BackColor = System.Drawing.Color.Khaki;
            this.textBoxLogFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogFileName.Location = new System.Drawing.Point(83, 53);
            this.textBoxLogFileName.Name = "textBoxLogFileName";
            this.textBoxLogFileName.ReadOnly = true;
            this.textBoxLogFileName.Size = new System.Drawing.Size(307, 17);
            this.textBoxLogFileName.TabIndex = 10;
            // 
            // checkBoxLogToFile
            // 
            this.checkBoxLogToFile.AutoSize = true;
            this.checkBoxLogToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLogToFile.Location = new System.Drawing.Point(8, 53);
            this.checkBoxLogToFile.Name = "checkBoxLogToFile";
            this.checkBoxLogToFile.Size = new System.Drawing.Size(69, 17);
            this.checkBoxLogToFile.TabIndex = 9;
            this.checkBoxLogToFile.Text = "Log to file";
            this.checkBoxLogToFile.UseVisualStyleBackColor = true;
            this.checkBoxLogToFile.CheckedChanged += new System.EventHandler(this.CheckBoxLogToFileCheckedChanged);
            // 
            // groupBoxChannelSelector
            // 
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh11);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh16);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh15);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh14);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh13);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh12);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh10);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh9);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh8);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh7);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh6);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh5);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh4);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh3);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh2);
            this.groupBoxChannelSelector.Controls.Add(this.checkBoxCh1);
            this.groupBoxChannelSelector.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxChannelSelector.Location = new System.Drawing.Point(427, 11);
            this.groupBoxChannelSelector.Name = "groupBoxChannelSelector";
            this.groupBoxChannelSelector.Size = new System.Drawing.Size(289, 62);
            this.groupBoxChannelSelector.TabIndex = 0;
            this.groupBoxChannelSelector.TabStop = false;
            this.groupBoxChannelSelector.Text = "Channel listeners";
            // 
            // checkBoxCh11
            // 
            this.checkBoxCh11.AutoSize = true;
            this.checkBoxCh11.Checked = true;
            this.checkBoxCh11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh11.Location = new System.Drawing.Point(76, 42);
            this.checkBoxCh11.Name = "checkBoxCh11";
            this.checkBoxCh11.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh11.TabIndex = 15;
            this.checkBoxCh11.Text = "11";
            this.checkBoxCh11.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh16
            // 
            this.checkBoxCh16.AutoSize = true;
            this.checkBoxCh16.Checked = true;
            this.checkBoxCh16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh16.Location = new System.Drawing.Point(251, 42);
            this.checkBoxCh16.Name = "checkBoxCh16";
            this.checkBoxCh16.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh16.TabIndex = 14;
            this.checkBoxCh16.Text = "16";
            this.checkBoxCh16.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh15
            // 
            this.checkBoxCh15.AutoSize = true;
            this.checkBoxCh15.Checked = true;
            this.checkBoxCh15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh15.Location = new System.Drawing.Point(216, 42);
            this.checkBoxCh15.Name = "checkBoxCh15";
            this.checkBoxCh15.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh15.TabIndex = 13;
            this.checkBoxCh15.Text = "15";
            this.checkBoxCh15.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh14
            // 
            this.checkBoxCh14.AutoSize = true;
            this.checkBoxCh14.Checked = true;
            this.checkBoxCh14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh14.Location = new System.Drawing.Point(181, 42);
            this.checkBoxCh14.Name = "checkBoxCh14";
            this.checkBoxCh14.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh14.TabIndex = 12;
            this.checkBoxCh14.Text = "14";
            this.checkBoxCh14.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh13
            // 
            this.checkBoxCh13.AutoSize = true;
            this.checkBoxCh13.Checked = true;
            this.checkBoxCh13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh13.Location = new System.Drawing.Point(146, 42);
            this.checkBoxCh13.Name = "checkBoxCh13";
            this.checkBoxCh13.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh13.TabIndex = 11;
            this.checkBoxCh13.Text = "13";
            this.checkBoxCh13.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh12
            // 
            this.checkBoxCh12.AutoSize = true;
            this.checkBoxCh12.Checked = true;
            this.checkBoxCh12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh12.Location = new System.Drawing.Point(111, 42);
            this.checkBoxCh12.Name = "checkBoxCh12";
            this.checkBoxCh12.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh12.TabIndex = 10;
            this.checkBoxCh12.Text = "12";
            this.checkBoxCh12.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh10
            // 
            this.checkBoxCh10.AutoSize = true;
            this.checkBoxCh10.Checked = true;
            this.checkBoxCh10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh10.Location = new System.Drawing.Point(41, 42);
            this.checkBoxCh10.Name = "checkBoxCh10";
            this.checkBoxCh10.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh10.TabIndex = 9;
            this.checkBoxCh10.Text = "10";
            this.checkBoxCh10.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh9
            // 
            this.checkBoxCh9.AutoSize = true;
            this.checkBoxCh9.Checked = true;
            this.checkBoxCh9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh9.Location = new System.Drawing.Point(6, 42);
            this.checkBoxCh9.Name = "checkBoxCh9";
            this.checkBoxCh9.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh9.TabIndex = 8;
            this.checkBoxCh9.Text = "09";
            this.checkBoxCh9.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh8
            // 
            this.checkBoxCh8.AutoSize = true;
            this.checkBoxCh8.Checked = true;
            this.checkBoxCh8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh8.Location = new System.Drawing.Point(251, 19);
            this.checkBoxCh8.Name = "checkBoxCh8";
            this.checkBoxCh8.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh8.TabIndex = 7;
            this.checkBoxCh8.Text = "08";
            this.checkBoxCh8.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh7
            // 
            this.checkBoxCh7.AutoSize = true;
            this.checkBoxCh7.Checked = true;
            this.checkBoxCh7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh7.Location = new System.Drawing.Point(216, 19);
            this.checkBoxCh7.Name = "checkBoxCh7";
            this.checkBoxCh7.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh7.TabIndex = 6;
            this.checkBoxCh7.Text = "07";
            this.checkBoxCh7.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh6
            // 
            this.checkBoxCh6.AutoSize = true;
            this.checkBoxCh6.Checked = true;
            this.checkBoxCh6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh6.Location = new System.Drawing.Point(181, 19);
            this.checkBoxCh6.Name = "checkBoxCh6";
            this.checkBoxCh6.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh6.TabIndex = 5;
            this.checkBoxCh6.Text = "06";
            this.checkBoxCh6.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh5
            // 
            this.checkBoxCh5.AutoSize = true;
            this.checkBoxCh5.Checked = true;
            this.checkBoxCh5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh5.Location = new System.Drawing.Point(146, 19);
            this.checkBoxCh5.Name = "checkBoxCh5";
            this.checkBoxCh5.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh5.TabIndex = 4;
            this.checkBoxCh5.Text = "05";
            this.checkBoxCh5.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh4
            // 
            this.checkBoxCh4.AutoSize = true;
            this.checkBoxCh4.Checked = true;
            this.checkBoxCh4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh4.Location = new System.Drawing.Point(111, 19);
            this.checkBoxCh4.Name = "checkBoxCh4";
            this.checkBoxCh4.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh4.TabIndex = 3;
            this.checkBoxCh4.Text = "04";
            this.checkBoxCh4.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh3
            // 
            this.checkBoxCh3.AutoSize = true;
            this.checkBoxCh3.Checked = true;
            this.checkBoxCh3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh3.Location = new System.Drawing.Point(76, 19);
            this.checkBoxCh3.Name = "checkBoxCh3";
            this.checkBoxCh3.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh3.TabIndex = 2;
            this.checkBoxCh3.Text = "03";
            this.checkBoxCh3.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh2
            // 
            this.checkBoxCh2.AutoSize = true;
            this.checkBoxCh2.Checked = true;
            this.checkBoxCh2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh2.Location = new System.Drawing.Point(41, 19);
            this.checkBoxCh2.Name = "checkBoxCh2";
            this.checkBoxCh2.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh2.TabIndex = 1;
            this.checkBoxCh2.Text = "02";
            this.checkBoxCh2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCh1
            // 
            this.checkBoxCh1.AutoSize = true;
            this.checkBoxCh1.Checked = true;
            this.checkBoxCh1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCh1.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCh1.Name = "checkBoxCh1";
            this.checkBoxCh1.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCh1.TabIndex = 0;
            this.checkBoxCh1.Text = "01";
            this.checkBoxCh1.UseVisualStyleBackColor = true;
            // 
            // groupBoxMonitorLog
            // 
            this.groupBoxMonitorLog.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMonitorLog.Controls.Add(this.listBoxMidiLog);
            this.groupBoxMonitorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMonitorLog.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxMonitorLog.Location = new System.Drawing.Point(4, 127);
            this.groupBoxMonitorLog.Name = "groupBoxMonitorLog";
            this.groupBoxMonitorLog.Size = new System.Drawing.Size(719, 352);
            this.groupBoxMonitorLog.TabIndex = 2;
            this.groupBoxMonitorLog.TabStop = false;
            this.groupBoxMonitorLog.Text = "Midi log";
            // 
            // listBoxMidiLog
            // 
            this.listBoxMidiLog.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxMidiLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMidiLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMidiLog.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxMidiLog.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxMidiLog.FormattingEnabled = true;
            this.listBoxMidiLog.ItemHeight = 16;
            this.listBoxMidiLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxMidiLog.Name = "listBoxMidiLog";
            this.listBoxMidiLog.Size = new System.Drawing.Size(713, 333);
            this.listBoxMidiLog.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "log";
            this.saveFileDialog1.Title = "Select log file name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxMidiDevices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 44);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDevicesOpenClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(620, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonDevicesOpenClose
            // 
            this.buttonDevicesOpenClose.Location = new System.Drawing.Point(10, 16);
            this.buttonDevicesOpenClose.Name = "buttonDevicesOpenClose";
            this.buttonDevicesOpenClose.Size = new System.Drawing.Size(83, 20);
            this.buttonDevicesOpenClose.TabIndex = 0;
            this.buttonDevicesOpenClose.Text = "Open";
            this.buttonDevicesOpenClose.UseVisualStyleBackColor = true;
            this.buttonDevicesOpenClose.Click += new System.EventHandler(this.ButtonDevicesOpenCloseClick);
            // 
            // groupBoxMidiDevices
            // 
            this.groupBoxMidiDevices.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxMidiDevices.Controls.Add(this.comboBoxOutputDevices);
            this.groupBoxMidiDevices.Controls.Add(this.comboBoxInputDevices);
            this.groupBoxMidiDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMidiDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMidiDevices.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxMidiDevices.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMidiDevices.Margin = new System.Windows.Forms.Padding(8);
            this.groupBoxMidiDevices.Name = "groupBoxMidiDevices";
            this.groupBoxMidiDevices.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxMidiDevices.Size = new System.Drawing.Size(619, 44);
            this.groupBoxMidiDevices.TabIndex = 1;
            this.groupBoxMidiDevices.TabStop = false;
            this.groupBoxMidiDevices.Text = "Midi devices";
            // 
            // comboBoxOutputDevices
            // 
            this.comboBoxOutputDevices.BackColor = System.Drawing.Color.Khaki;
            this.comboBoxOutputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOutputDevices.FormattingEnabled = true;
            this.comboBoxOutputDevices.Location = new System.Drawing.Point(314, 15);
            this.comboBoxOutputDevices.Name = "comboBoxOutputDevices";
            this.comboBoxOutputDevices.Size = new System.Drawing.Size(300, 21);
            this.comboBoxOutputDevices.TabIndex = 1;
            // 
            // comboBoxInputDevices
            // 
            this.comboBoxInputDevices.BackColor = System.Drawing.Color.Khaki;
            this.comboBoxInputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInputDevices.FormattingEnabled = true;
            this.comboBoxInputDevices.Location = new System.Drawing.Point(8, 15);
            this.comboBoxInputDevices.Name = "comboBoxInputDevices";
            this.comboBoxInputDevices.Size = new System.Drawing.Size(300, 21);
            this.comboBoxInputDevices.TabIndex = 0;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(727, 483);
            this.Controls.Add(this.groupBoxMonitorLog);
            this.Controls.Add(this.groupBoxMonitorSettings);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Monitor";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pure Midi Monitor";
            this.Load += new System.EventHandler(this.MonitorLoad);
            this.groupBoxMonitorSettings.ResumeLayout(false);
            this.groupBoxMonitorSettings.PerformLayout();
            this.groupBoxChannelSelector.ResumeLayout(false);
            this.groupBoxChannelSelector.PerformLayout();
            this.groupBoxMonitorLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMidiDevices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMonitorSettings;
        private System.Windows.Forms.GroupBox groupBoxMonitorLog;
        private System.Windows.Forms.ListBox listBoxMidiLog;
        private System.Windows.Forms.GroupBox groupBoxChannelSelector;
        private System.Windows.Forms.CheckBox checkBoxCh11;
        private System.Windows.Forms.CheckBox checkBoxCh16;
        private System.Windows.Forms.CheckBox checkBoxCh15;
        private System.Windows.Forms.CheckBox checkBoxCh14;
        private System.Windows.Forms.CheckBox checkBoxCh13;
        private System.Windows.Forms.CheckBox checkBoxCh12;
        private System.Windows.Forms.CheckBox checkBoxCh10;
        private System.Windows.Forms.CheckBox checkBoxCh9;
        private System.Windows.Forms.CheckBox checkBoxCh8;
        private System.Windows.Forms.CheckBox checkBoxCh7;
        private System.Windows.Forms.CheckBox checkBoxCh6;
        private System.Windows.Forms.CheckBox checkBoxCh5;
        private System.Windows.Forms.CheckBox checkBoxCh4;
        private System.Windows.Forms.CheckBox checkBoxCh3;
        private System.Windows.Forms.CheckBox checkBoxCh2;
        private System.Windows.Forms.CheckBox checkBoxCh1;
        private System.Windows.Forms.TextBox textBoxLogFileName;
        private System.Windows.Forms.CheckBox checkBoxLogToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDevicesOpenClose;
        private System.Windows.Forms.GroupBox groupBoxMidiDevices;
        private System.Windows.Forms.ComboBox comboBoxOutputDevices;
        private System.Windows.Forms.ComboBox comboBoxInputDevices;
        private System.Windows.Forms.Button buttonSelectLogFileName;
        private System.Windows.Forms.CheckBox checkBoxSysEx;
    }
}

