using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_2
    {

        public int[] Exchange(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] % 2 == 0)
                {
                    int num = array[i-1];
                    array[i-1] = array[i];
                    array[i] = num;
                    i++;
                }
            }
            return array;
        }

        public void OutputArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }

    }
}
