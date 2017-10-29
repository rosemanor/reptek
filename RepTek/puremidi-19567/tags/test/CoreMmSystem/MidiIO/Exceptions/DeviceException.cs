using System;

namespace PureMidi.CoreMmSystem.MidiIO.Exceptions
{
    internal class DeviceException : ApplicationException
    {
        private readonly int _errorCode;
        public const int MmsyserrAllocated = 4;
        public const int MmsyserrBaddb = 14;
        public const int MmsyserrBaddeviceid = 2;
        public const int MmsyserrBaderrnum = 9;
        public const int MmsyserrDeleteerror = 0x12;
        public const int MmsyserrError = 1;
        public const int MmsyserrHandlebusy = 12;
        public const int MmsyserrInvalflag = 10;
        public const int MmsyserrInvalhandle = 5;
        public const int MmsyserrInvalidalias = 13;
        public const int MmsyserrInvalparam = 11;
        public const int MmsyserrKeynotfound = 15;
        public const int MmsyserrLasterror = 20;
        public const int MmsyserrNodriver = 6;
        public const int MmsyserrNodrivercb = 20;
        public const int MmsyserrNoerror = 0;
        public const int MmsyserrNomem = 7;
        public const int MmsyserrNotenabled = 3;
        public const int MmsyserrNotsupported = 8;
        public const int MmsyserrReaderror = 0x10;
        public const int MmsyserrValnotfound = 0x13;
        public const int MmsyserrWriteerror = 0x11;

        public DeviceException(int errorCode)
        {
            _errorCode = errorCode;
        }

        public int ErrorCode
        {
            get
            {
                return _errorCode;
            }
        }
    }
}

