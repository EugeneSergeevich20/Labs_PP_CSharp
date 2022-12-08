using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_2
{
    internal class Laba_2_2
    {

        public double Pow(int value, int pow)
        {
            if (pow > 0) return value * Pow(value, pow - 1);
            else if (pow == 0) return 1;
            else return 1 / (value * Pow(value, -pow - 1));
        }

    }
}
