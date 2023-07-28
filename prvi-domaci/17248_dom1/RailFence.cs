using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17248_dom1
{
    class RailFence
    {
       /* private int key;

        public void SetKey(int key)
        {
            this.key = key;
        }*/

        public static char[] EncodeStream(char[] stream,int key)
        {
            char[] encodedStream = new char[stream.Length];
            int index = 0;
            for (int i = 0; i < key; i++)
            {
                int stepUp = 2 * i;
                int stepDown = 2 * (key - i - 1);
                int k = i;
                int direction = 0;//0-going down,1-going up
                while (k < stream.Length)
                {
                    encodedStream[index++] = stream[k];

                    if (stepDown == 0)
                    {
                        k += stepUp;
                        continue;
                    }
                    else if (stepUp == 0)
                    {
                        k += stepDown;
                        continue;
                    }

                    if (direction == 0)
                        k += stepDown;
                    else k += stepUp;
                    direction = (direction + 1) % 2;

                }

            }

            return encodedStream;
        }

        public static char[] DecodeStream(char[] codedStream, int key)
        {
            int[] elementsPerRow = new int[key];
            for (int i = 0; i < key; i++)
            {
                int upFrequency = 2 * i;
                int downFrequency = 2 * (key - i - 1);

                int cycleLength = upFrequency + downFrequency;
                int elementsPerCycle = (upFrequency == 0 || downFrequency == 0) == true ? 1 : 2;

                int remainder;

                elementsPerRow[i] = (int)Math.Floor((double)(codedStream.Length - 1 - i) / cycleLength) * elementsPerCycle;
                remainder = (codedStream.Length - 1 - i) % cycleLength;
                elementsPerRow[i]++;
                if (remainder >= downFrequency && downFrequency != 0)
                    elementsPerRow[i]++;


            }
            char[] decodedStream = new char[codedStream.Length];

            int[] rowOffsets = new int[key];
            for (int i = 0; i < key; i++)
                rowOffsets[i] = 0;

            int rowIndex = 0;
            int direction = 0;//0-down,1-up
            for (int i = 0; i < codedStream.Length; i++)
            {
                int k = 0;
                for (int l = 0; l < rowIndex; l++)
                    k += elementsPerRow[l];
                k += rowOffsets[rowIndex];

                decodedStream[i] = codedStream[k];
                rowOffsets[rowIndex]++;

                if (direction == 0)
                    rowIndex++;
                else if (direction == 1)
                    rowIndex--;


                if (rowIndex == key - 1 || rowIndex == 0)
                    direction = (direction + 1) % 2;
            }
            return decodedStream;
        }
    }
}
