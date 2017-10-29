using System;
using System.IO;
using System.Windows.Forms;
using PureMidi.CoreMmSystem.MidiIO;
using PureMidi.CoreMmSystem.MidiIO.Data;
using PureMidi.CoreMmSystem.MidiIO.Definitions;
using PureMidi.CoreMmSystem.MidiIO.DeviceInfo;
using PureMidi.Monitor.Properties;

namespace PureMidi.Monitor
{
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
        }

        private InputDevice _inputDevice;

        private OutputDevice _outptDevice;

        private bool _isMonitorOn;

        private TextWriter _logWriter;

        private static int GetMaxVisibleItems(ListBox lb)
        {
            return lb.Size.Height/lb.ItemHeight;
        }

        private void LockSettings()
        {
            groupBoxMidiDevices.Enabled = false;
            groupBoxMonitorSettings.Enabled = false;
            buttonDevicesOpenClose.Text = Resources.Monitor_LockSettings_Close;
        }

        private void UnlockSettings()
        {
            groupBoxMidiDevices.Enabled = true;
            groupBoxMonitorSettings.Enabled = true;
            buttonDevicesOpenClose.Text = Resources.Monitor_UnlockSettings_Open;
        }

        private void SwitchMonitorOn()
        {
            SwitchMonitorOff();
            if (!string.IsNullOrEmpty(textBoxLogFileName.Text))
            {
                _logWriter = new StreamWriter(textBoxLogFileName.Text, true);
                _logWriter.WriteLine(string.Empty);
                _logWriter.WriteLine("----------------------------------------------------");
                _logWriter.WriteLine("Log started at: " + DateTime.Now);
                _logWriter.WriteLine(GetLogHeader());
                _logWriter.WriteLine(string.Empty);
            }
            listBoxMidiLog.Items.Clear();
            listBoxMidiLog.Items.Add(GetLogHeader());
            listBoxMidiLog.Items.Add("-----------------------------------------------------");
            if (comboBoxInputDevices.SelectedIndex > 0)
            {
                _inputDevice = new InputDevice(comboBoxInputDevices.SelectedIndex - 1);
                _inputDevice.OnMidiEvent += OnMidiEventHandle;
                _inputDevice.Start();

                if (comboBoxOutputDevices.SelectedIndex > 0)
                {
                    _outptDevice = new OutputDevice(comboBoxOutputDevices.SelectedIndex-1);
                }
                LockSettings();
                _isMonitorOn = true;
            }
            else
            {
                MessageBox.Show(Resources.Monitor_SwitchMonitorOn_Input_device_must_be_selected_);
                
            }
        }

        private static string GetShortMessageDescription(MidiEvent ev)
        {
            return string.Empty;
        }

        private static string EventToLogFormat(MidiEvent ev)
        {
            if (ev.MidiEventType == EMidiEventType.Short)
            {
                return ev.Hex + "|  " 
                       + ev.Status.ToString("X2").ToUpper() + "  |  " +
                       (ev.Status & 0xF0).ToString("X2").ToUpper() + " | " +
                       (ev.Status & 0x0F).ToString("X2").ToUpper() + " |  " +
                       ev.AllData[1].ToString("X2").ToUpper() + "   |  " +
                       ev.AllData[2].ToString("X2").ToUpper() + "   | " + 
                       GetShortMessageDescription(ev);
            }
            return ev.Hex + "|  SYSEX";
        }

        private static string GetLogHeader()
        {
            return "DATA  | STS  | CMD | CH | DATA1 | DATA2 | DESCRIPTION";
        }

        private delegate void SetTextCallback(ListBox tb, string text);

        private void SafeSetText(ListBox lb, string text)
        {
            if (lb.InvokeRequired)
            {
                var d = new SetTextCallback(SafeSetText);
                Invoke(d, new object[] { lb, text });

            }
            else
            {
                if (lb.Items.Count == GetMaxVisibleItems(lb))
                {
                    lb.Items.RemoveAt(lb.Items.Count-1);
                }
                lb.Items.Insert(2,text);
            }
        }

        private void LogEvent(MidiEvent ev)
        {
            var logElem = EventToLogFormat(ev);
            if (_logWriter != null)
            {
                _logWriter.WriteLine(logElem);
            }
            SafeSetText(listBoxMidiLog, logElem);
        }

        private void OnMidiEventHandle(MidiEvent ev)
        {
            if (_outptDevice != null && !_outptDevice.IsDisposed) _outptDevice.Send(ev);
            LogEvent(ev);
        }

        private void SwitchMonitorOff()
        {
            if (_inputDevice != null && !_inputDevice.IsDisposed) _inputDevice.Dispose();
            if (_outptDevice != null && !_outptDevice.IsDisposed) _outptDevice.Dispose();
            UnlockSettings();
            if (_logWriter != null)
            {
                _logWriter.Close();
                _logWriter.Dispose();
                _logWriter = null;
            }
            _isMonitorOn = false;
        }

        private void MonitorLoad(object sender, EventArgs e)
        {
            comboBoxInputDevices.Items.Add("Select input device");
            comboBoxOutputDevices.Items.Add("Select output device");
            comboBoxInputDevices.SelectedIndex = 0;
            comboBoxOutputDevices.SelectedIndex = 0;
            var inp = MidiInInfo.Informations;
            foreach (var midiInInfo in inp)
            {
                comboBoxInputDevices.Items.Add(midiInInfo);
            }

            var outp = MidiOutInfo.Informations;
            foreach (var midiOutInfo in outp)
            {
                comboBoxOutputDevices.Items.Add(midiOutInfo);
            }
            UnlockSettings();
        }

        private void SelctLogFilename()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxLogFileName.Text = saveFileDialog1.FileName;
            }
        }

        private void ButtonDevicesOpenCloseClick(object sender, EventArgs e)
        {
            if (!_isMonitorOn)
            {
                SwitchMonitorOn();
            }
            else
            {
                SwitchMonitorOff();
            }
        }

        private void ButtonSelectLogFileNameClick(object sender, EventArgs e)
        {
            SelctLogFilename();
        }
    }
}