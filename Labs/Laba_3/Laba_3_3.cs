using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_3
    {

        public void SortArray(int[] array1, int[] array2)
        {
            Console.WriteLine("No sorted");
            Output(array1);
            Array.Sort(array1);
            Console.WriteLine("Sorted");
            Output(array1);

            Console.WriteLine("No sorted");
            Output(array2);
            Array.Sort(array2);
            Console.WriteLine("Sorted");
            Output(array2);

            int[] array3 = array1.Concat(array2).ToArray();

            Console.WriteLine("No sorted");
            Output(array3);
            Array.Sort(array3);
            Console.WriteLine("Sorted");
            Output(array3);
        }

        static void Output(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }

        
    }
}
