using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_6
    {

        public int CountWords(string source)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i].Equals(' ') || i == source.Length - 1)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
