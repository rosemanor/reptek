using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PureMidi.CoreMmSystem
{
    /// <summary>
    /// Base class for methods stored in winmm.dll.
    /// </summary>
    public abstract class WindowsMultimediaDevice
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct MidiInCaps
        {
            public short mid;
            public short pid;
            public int driverVersion;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string name;
            public int support;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MidiOutCaps
        {
            public short mid;
            public short pid;
            public int driverVersion;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string name;
            public short technology;
            public short voices;
            public short notes;
            public short channelMask;
            public int support;
        }
        
        [DllImport("winmm.dll")]
        internal static extern int midiConnect(int handleA, int handleB, int reserved);

        [DllImport("winmm.dll")]
        internal static extern int midiDisconnect(int handleA, int handleB, int reserved);

        [DllImport("winmm.dll")]
        internal static extern int midiOutClose(int handle);

        [DllImport("winmm.dll")]
        internal static extern int midiOutOpen(ref int handle, int deviceId, MidiOutProc proc, int instance, int flags);

        [DllImport("winmm.dll")]
        internal static extern int midiInAddBuffer(int handle, IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        internal static extern int midiInClose(int handle);

        [DllImport("winmm.dll")]
        internal static extern int midiInGetDevCaps(int deviceId, ref MidiInCaps caps, int sizeOfMidiInCaps);

        [DllImport("winmm.dll")]
        internal static extern int midiInGetNumDevs();

        [DllImport("winmm.dll")]
        internal static extern int midiInOpen(ref int handle, int deviceId, MidiInProc proc, int instance, int flags);

        [DllImport("winmm.dll")]
        internal static extern int midiInPrepareHeader(int handle, IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        internal static extern int midiInReset(int handle);

        [DllImport("winmm.dll")]
        internal static extern int midiInStart(int handle);

        [DllImport("winmm.dll")]
        internal static extern int midiInStop(int handle);

        [DllImport("winmm.dll")]
        internal static extern int midiInUnprepareHeader(int handle, IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        internal static extern int midiOutGetDevCaps(int deviceId, ref MidiOutCaps caps, int sizeOfMidiOutCaps);

        [DllImport("winmm.dll")]
        internal static extern int midiOutGetNumDevs();

        [DllImport("winmm.dll")]
        internal static extern int midiOutLongMsg(int handle, IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        internal static extern int midiOutPrepareHeader(int handle, IntPtr headerPtr, int sizeOfMidiHeader);

        [DllImport("winmm.dll")]
        internal static extern int midiInGetErrorText(int errCode, StringBuilder errMsg, int sizeOfErrMsg);

        [DllImport("winmm.dll")]
        internal static extern int midiOutGetErrorText(int errCode, StringBuilder message, int sizeOfMessage);

        [DllImport("winmm.dll")]
        internal static extern int midiOutReset(int handle);

        [DllImport("winmm.dll")]
        internal static extern int midiOutShortMsg(int handle, int message);

        [DllImport("winmm.dll")]
        internal static extern int midiOutUnprepareHeader(int handle, IntPtr headerPtr, int sizeOfMidiHeader);

        #region Nested type: MidiInProc

        internal delegate void MidiInProc(int handle, int msg, int instance, int param1, int param2);

        #endregion

        #region Nested type: MidiOutProc

        internal delegate void MidiOutProc(int handle, int msg, int instance, int param1, int param2);

        #endregion
    }
}