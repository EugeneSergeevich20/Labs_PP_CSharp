using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_1
{
    internal class Laba_1_2
    {

        public void OPER(int r, int k, string[] z)
        {

            if (k == 6)
            {
                if (r == 35)
                {
                    Console.Write("((((1 " + z[1] + " ");
                    for (int i = 2; i < 6; ++i)
                        Console.Write(i + ")" + z[i] + " ");
                    Console.WriteLine("6 = 35");
                }

            }
            else
            {
                z[k] = "+"; OPER(r + k + 1, k + 1, z);
                z[k] = "-"; OPER(r - k - 1, k + 1, z);
                z[k] = "*"; OPER(r * (k + 1), k + 1, z);
                z[k] = "/"; OPER(r / (k + 1), k + 1, z);
            }
        }

    }
}
