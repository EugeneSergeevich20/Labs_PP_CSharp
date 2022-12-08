using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_2
{
    internal class Laba_2_1
    {

        public int MaxDigit(int n)
        {
            int max = 0;
            int tempMax = 0;

            while (n != 0)
            {
                tempMax = n % 10;
                if (tempMax > max)
                {
                    max = tempMax;
                }
                n = n / 10;
            }

            return max;

        }

    }
}
