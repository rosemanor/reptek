using System.Text;
using PureMidi.CoreMmSystem.MidiIO.Definitions;

namespace PureMidi.CoreMmSystem.MidiIO.Data
{
    public struct MidiEvent
    {
        public MidiEvent(byte[] data)
        {
            _allData = data;
        }

        private readonly byte[] _allData;

        public byte[] AllData { get { return _allData; } }

        public string Hex
        {
            get
            {
                var sb = new StringBuilder();
                for (int i = 0; i < AllData.Length; i++)
                {
                    sb.Append(AllData[i].ToString("X2").ToUpper());
                }
                return sb.ToString();
            }
        }

        public byte Status { get { return AllData[0]; } }

        public EMidiEventType MidiEventType
        {
            get
            {
                switch (AllData[0])
                {
                    case 0xFF:
                        return EMidiEventType.Meta;
                    case 0xF0:
                        return EMidiEventType.Sysex;
                    case 0xF7:
                        return EMidiEventType.Sysex;
                    case 0:
                        return EMidiEventType.Empty;
                    default:
                        return EMidiEventType.Short;
                }
            }
        }

    }
}