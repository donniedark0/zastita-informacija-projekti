using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17248_Darko_Milicevic_prvi_domaci
{
    class XTEAalg
    {
        public XTEAalg()
        {

        }
		public void Code(uint[] v, uint[] k)
		{
			uint y = v[0];
			uint z = v[1];
			uint sum = 0;
			uint delta = 0x9E3779B9;
			uint n = 32;

			while (n-- > 0)
			{
				y += (z << 4 ^ z >> 5) + z ^ sum + k[sum & 3];
				sum += delta;
				z += (y << 4 ^ y >> 5) + y ^ sum + k[sum >> 11 & 3];
			}

			v[0] = y;
			v[1] = z;

		}

		public void Decode(uint[] v, uint[] k)
		{
			uint y = v[0];
			uint z = v[1];
			uint sum = 0xC6EF3720;
			uint delta = 0x9E3779B9;
			uint n = 32;

			while (n-- > 0)
			{
				z -= (y << 4 ^ y >> 5) + y ^ sum + k[sum >> 11 & 3];
				sum -= delta;
				y -= (z << 4 ^ z >> 5) + z ^ sum + k[sum & 3];
			}

			v[0] = y;
			v[1] = z;

		}
	}
}
