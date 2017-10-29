using System.Text;

namespace PureMidi.CoreMmSystem.MidiIO.Exceptions
{
    internal class InputDeviceException : MidiDeviceException
    {
        private readonly StringBuilder _errMsg;

        public InputDeviceException(int errCode) : base(errCode)
        {
            _errMsg = new StringBuilder(0x80);
            WindowsMultimediaDevice.midiInGetErrorText(errCode, _errMsg, _errMsg.Capacity);
        }

        
        public override string Message
        {
            get
            {
                return _errMsg.ToString();
            }
        }
    }
}

