using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using PureMidi.CoreMmSystem.MidiIO;
using PureMidi.CoreMmSystem.MidiIO.Data;
using PureMidi.CoreMmSystem.MidiIO.Definitions;
using PureMidi.CoreMmSystem.MidiIO.DeviceInfo;
using PureMidi.Monitor.Properties;
using UI.Forms;

namespace PureMidi.Monitor
{
    public partial class Monitor : Form
    {
        private readonly bool[] _channelListeners = new bool[16];

        private static void SplashFormCreate()
        {
            var newSplashForm = new SplashForm
                                    {
                                        Text = Resources.Monitor_SplashFormCreate_Pure_MIDI_Monitor
                                    };
            newSplashForm.ShowDialog();
            newSplashForm.Dispose();
        }

        public Monitor()
        {
            InitializeComponent();
            var t = new Thread(new ThreadStart(SplashFormCreate));
            t.Start();
            var i = 0;
            while(t.IsAlive && i < 100)
            {
                Thread.Sleep(100);
                i++;
            }
            t.Abort();
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
            _channelListeners[0] = checkBoxCh1.Checked;
            _channelListeners[1] = checkBoxCh2.Checked;
            _channelListeners[2] = checkBoxCh3.Checked;
            _channelListeners[3] = checkBoxCh4.Checked;
            _channelListeners[4] = checkBoxCh5.Checked;
            _channelListeners[5] = checkBoxCh6.Checked;
            _channelListeners[6] = checkBoxCh7.Checked;
            _channelListeners[7] = checkBoxCh8.Checked;
            _channelListeners[8] = checkBoxCh9.Checked;
            _channelListeners[9] = checkBoxCh10.Checked;
            _channelListeners[10] = checkBoxCh11.Checked;
            _channelListeners[11] = checkBoxCh12.Checked;
            _channelListeners[12] = checkBoxCh13.Checked;
            _channelListeners[13] = checkBoxCh14.Checked;
            _channelListeners[14] = checkBoxCh15.Checked;
            _channelListeners[15] = checkBoxCh16.Checked;
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
                    _outptDevice = new OutputDevice(comboBoxOutputDevices.SelectedIndex - 1);
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
            string retVal;
            var shortType = ev.Status & 0xF0;
            switch (shortType)
            {
                case 0x80:
                    retVal = "NoteOf " + GetKeyName(ev.AllData[1]) + " Velo=" + ev.AllData[2];
                    break;
                case 0x90:
                    retVal = "NoteOn " + GetKeyName(ev.AllData[1]) + " Velo=" + ev.AllData[2];
                    if (ev.AllData[2] == 0) retVal += " (mute)";
                    break;
                case 0xA0:
                    retVal = "PollyAftertouch " + GetKeyName(ev.AllData[1]) + " Val=" + ev.AllData[2];
                    break;
                case 0xB0:
                    retVal = "CNTL " + ((ControllerType) ev.AllData[1]) + " Val=" + ev.AllData[2];
                    break;
                case 0xC0:
                    retVal = "ProgramChange " + GetGeneralMidiInstrumentName(ev.AllData[1]);
                    break;
                default:
                    retVal = "unknown/invalid";
                    break;
            }

            return retVal;
        }

        private static string EventToLogFormat(MidiEvent ev)
        {
            if (ev.MidiEventType == EMidiEventType.Short)
            {
                return ev.Hex + "|  "
                       + ev.Status.ToString("X2").ToUpper() + "  |  " +
                       (ev.Status & 0xF0).ToString("X2").ToUpper() + " | " +
                       ((ev.Status & 0x0F) + 1).ToString("X2").ToUpper() + " |  " +
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
                Invoke(d, new object[] {lb, text});

            }
            else
            {
                if (lb.Items.Count == GetMaxVisibleItems(lb))
                {
                    lb.Items.RemoveAt(lb.Items.Count - 1);
                }
                lb.Items.Insert(2, text);
            }
        }

        private void LogEvent(MidiEvent ev)
        {
            var logElem = EventToLogFormat(ev);
            if (checkBoxLogToFile.Checked && _logWriter != null)
            {
                _logWriter.WriteLine(logElem);
            }
            SafeSetText(listBoxMidiLog, logElem);
        }

        private void OnMidiEventHandle(MidiEvent ev)
        {
            var handleEvent = ev.MidiEventType == EMidiEventType.Short
                                   ? _channelListeners[ev.Status & 0x0F]
                                   : checkBoxSysEx.Checked;
            if (!handleEvent) return;
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

        private void CheckBoxLogToFileCheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogToFile.Checked && string.IsNullOrEmpty(textBoxLogFileName.Text))
            {
                SelctLogFilename();
                if (string.IsNullOrEmpty(textBoxLogFileName.Text))
                {
                    checkBoxLogToFile.Checked = false;
                }
            }
        }

        private static string GetGeneralMidiInstrumentName(byte val)
        {
            switch (val)
            {
                case 0: return "GmAcousticGrandPiano";
                case 1: return "GmBrightAcousticPiano";
                case 2: return "GmElectricGrandPiano";
                case 3: return "GmHonkyTonkPiano";
                case 4: return "GmElectricPiano1";
                case 5: return "GmElectricPiano2";
                case 6: return "GmHarpsichord";
                case 7: return "GmClavinet";
                case 8: return "GmCelesta";
                case 9: return "GmGlockenspiel";
                case 10: return "GmMusicBox";
                case 11: return "GmVibraphone";
                case 12: return "GmMarimba";
                case 13: return "GmXylophone";
                case 14: return "GmTubularBells";
                case 15: return "GmDulcimer";
                case 16: return "GmDrawbarOrgan";
                case 17: return "GmPercussiveOrgan";
                case 18: return "GmRockOrgan";
                case 19: return "GmChurchOrgan";
                case 20: return "GmReedOrgan";
                case 21: return "GmAccordion";
                case 22: return "GmHarmonica";
                case 23: return "GmTangoAccordion";
                case 24: return "GmAcousticGuitarNylon";
                case 25: return "GmAcousticGuitarSteel";
                case 26: return "GmElectricGuitarJazz";
                case 27: return "GmElectricGuitarClean";
                case 28: return "GmElectricGuitarMuted";
                case 29: return "GmOverdrivenGuitar";
                case 30: return "GmDistortionGuitar";
                case 31: return "GmGuitarHarmonics";
                case 32: return "GmAcousticBass";
                case 33: return "GmElectricBassFinger";
                case 34: return "GmElectricBassPick";
                case 35: return "GmFretlessBass";
                case 36: return "GmSlapBass1";
                case 37: return "GmSlapBass2";
                case 38: return "GmSynthBass1";
                case 39: return "GmSynthBass2";
                case 40: return "GmViolin";
                case 41: return "GmViola";
                case 42: return "GmCello";
                case 43: return "GmContrabass";
                case 44: return "GmTremoloStrings";
                case 45: return "GmPizzicatoStrings";
                case 46: return "GmOrchestralHarp";
                case 47: return "GmTimpani";
                case 48: return "GmStringEnsemble1";
                case 49: return "GmStringEnsemble2";
                case 50: return "GmSynthStrings1";
                case 51: return "GmSynthStrings2";
                case 52: return "GmChoirAahs";
                case 53: return "GmVoiceOohs";
                case 54: return "GmSynthVoice";
                case 55: return "GmOrchestraHit";
                case 56: return "GmTrumpet";
                case 57: return "GmTrombone";
                case 58: return "GmTuba";
                case 59: return "GmMutedTrumpet";
                case 60: return "GmFrenchHorn";
                case 61: return "GmBrassSection";
                case 62: return "GmSynthBrass1";
                case 63: return "GmSynthBrass2";
                case 64: return "GmSopranoSax";
                case 65: return "GmAltoSax";
                case 66: return "GmTenorSax";
                case 67: return "GmBaritoneSax";
                case 68: return "GmOboe";
                case 69: return "GmEnglishHorn";
                case 70: return "GmBassoon";
                case 71: return "GmClarinet";
                case 72: return "GmPiccolo";
                case 73: return "GmFlute";
                case 74: return "GmRecorder";
                case 75: return "GmPanFlute";
                case 76: return "GmBlownBottle";
                case 77: return "GmShakuhachi";
                case 78: return "GmWhistle";
                case 79: return "GmOcarina";
                case 80: return "GmLead1Square";
                case 81: return "GmLead2Sawtooth";
                case 82: return "GmLead3Calliope";
                case 83: return "GmLead4Chiff";
                case 84: return "GmLead5Charang";
                case 85: return "GmLead6Voice";
                case 86: return "GmLead7Fifths";
                case 87: return "GmLead8BassAndLead";
                case 88: return "GmPad1NewAge";
                case 89: return "GmPad2Warm";
                case 90: return "GmPad3Polysynth";
                case 91: return "GmPad4Choir";
                case 92: return "GmPad5Bowed";
                case 93: return "GmPad6Metallic";
                case 94: return "GmPad7Halo";
                case 95: return "GmPad8Sweep";
                case 96: return "GmFx1Rain";
                case 97: return "GmFx2Soundtrack";
                case 98: return "GmFx3Crystal";
                case 99: return "GmFx4Atmosphere";
                case 100: return "GmFx5Brightness";
                case 101: return "GmFx6Goblins";
                case 102: return "GmFx7Echoes";
                case 103: return "GmFx8SciFi";
                case 104: return "GmSitar";
                case 105: return "GmBanjo";
                case 106: return "GmShamisen";
                case 107: return "GmKoto";
                case 108: return "GmKalimba";
                case 109: return "GmBagPipe";
                case 110: return "GmFiddle";
                case 111: return "GmShanai";
                case 112: return "GmTinkleBell";
                case 113: return "GmAgogo";
                case 114: return "GmSteelDrums";
                case 115: return "GmWoodblock";
                case 116: return "GmTaikoDrum";
                case 117: return "GmMelodicTom";
                case 118: return "GmSynthDrum";
                case 119: return "GmReverseCymbal";
                case 120: return "GmGuitarFretNoise";
                case 121: return "GmBreathNoise";
                case 122: return "GmSeashore";
                case 123: return "GmBirdTweet";
                case 124: return "GmTelephoneRing";
                case 125: return "GmHelicopter";
                case 126: return "GmApplause";
                case 127: return "GmGunshot";
                default: return "Unknown/Undefined";
            }
        }

        private static string  GetKeyName(byte val)
        {
            var noteNum = val%12;
            string retVal = string.Empty;
            switch (noteNum)
            {
                case 0: 
                    retVal = "C";
                    break;
              case 1: 
                    retVal = "C#";
                    break;
              case 2: 
                    retVal = "D";
                    break;
              case 3: 
                    retVal = "D#";
                    break;
              case 4: 
                    retVal = "E";
                    break;
              case 5: 
                    retVal = "F";
                    break;
              case 6: 
                    retVal = "F#";
                    break;
              case 7: 
                    retVal = "G";
                    break;
              case 8: 
                    retVal = "G#";
                    break;
              case 9: 
                    retVal = "A";
                    break;
              case 10: 
                    retVal = "A#";
                    break;
              case 11: 
                    retVal = "H/B";
                    break;
            }
            return retVal + (val/12);
        }
    }
}