namespace PureMidi.CoreMmSystem.MidiIO.Exceptions
{
    internal class MidiDeviceException : DeviceException
    {
        public const int MidierrBadopenmode = 70;
        public const int MidierrDontContinue = 0x47;
        public const int MidierrInvalidsetup = 0x45;
        public const int MidierrLasterror = 0x47;
        public const int MidierrNodevice = 0x44;
        public const int MidierrNomap = 0x42;
        public const int MidierrNotready = 0x43;
        public const int MidierrStillplaying = 0x41;
        public const int MidierrUnprepared = 0x40;

        public MidiDeviceException(int errCode) : base(errCode)
        {
        }
    }
}