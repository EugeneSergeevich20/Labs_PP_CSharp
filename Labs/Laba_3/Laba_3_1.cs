using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_1
    {
        public int[] SetArray(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }

            return array;
        }

        public int MultiplesOfThree(int[] array)
        {
            int result = 0;

            foreach (int num in array)
            {
                if (num % 3 == 0)
                {
                    result++;
                }
            }

            return result;
        }

        public int Summ(int[] array)
        {
            int result = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    result += num;
                }
            }

            return result;
        }


        public int NumberMaxDigit(int[] array)
        {
            int result = 0;
            int max = 0;
            int i = 0;
            foreach (int num in array)
            {
                i += 1;
                if (num > max)
                {
                    max = num;
                    result = i;
                }
            }
            return result;
        }

        public string FindNull(int[] array)
        {
            bool result = false;
            foreach (int num in array)
            {
                if (num == 0) 
                { 
                    result = true; 
                    break; 
                }
            }
            if (result) 
            { 
                return "Есть"; 
            }
            else 
            { 
                return "Нету"; 
            }
        }

        public void Output(int[] array)
        {
            int i = -1;
            foreach (int num in array)
            {
                i += 1;
                if (i % 2 == 0)
                {
                    Console.WriteLine("a[" + i + "] = " + num);
                }
            }

        }
    }
}
