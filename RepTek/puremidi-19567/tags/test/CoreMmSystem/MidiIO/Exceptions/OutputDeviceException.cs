using System.Text;

namespace PureMidi.CoreMmSystem.MidiIO.Exceptions
{
    internal class OutputDeviceException : MidiDeviceException
    {
        private readonly StringBuilder _message;

        public OutputDeviceException(int errCode) : base(errCode)
        {
            _message = new StringBuilder(0x80);
            WindowsMultimediaDevice.midiOutGetErrorText(errCode, _message, _message.Capacity);
        }


        public override string Message
        {
            get { return _message.ToString(); }
        }
    }
}