using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17248_Darko_Milicevic_prvi_domaci
{
    class CRC
    {
        UInt32[] table;

        public CRC()
        {
            UInt32 poly = 0xedb88320;
            table = new UInt32[256];
            UInt32 temp = 0;
            for (UInt32 i = 0; i < table.Length; ++i)
            {
                temp = i;
                for (int j = 8; j > 0; --j)
                {
                    if ((temp & 1) == 1)
                    {
                        temp = (UInt32)((temp >> 1) ^ poly);
                    }
                    else
                    {
                        temp >>= 1;
                    }
                }
                table[i] = temp;
            }
        }

        public UInt32 ComputeChecksum(Byte[] bytes)
        {
            UInt32 crc = 0xffffffff;
            for (int i = 0; i < bytes.Length; ++i)
            {
                Byte index = (Byte)(((crc) & 0xff) ^ bytes[i]);
                crc = (UInt32)((crc >> 8) ^ table[index]);
            }
            return ~crc;
        }
    }
}
