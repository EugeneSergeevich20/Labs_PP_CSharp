using Labs.Laba_1;
using Labs.Laba_2;
using Labs.Laba_3;
using System;
using System.Diagnostics;

namespace Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region laba1_1
            Console.WriteLine("\tЛобораторная работа 1. Задание 1");
            Laba_1_1 laba1 = new Laba_1_1();

            double a = 2;
            double t = 2;
            double b = 2;
            double x = 2;
            double z = 2;

            double result1 = laba1.FunctionOne(a, t, b, x, z);

            int result2 = laba1.TimeYE();
            Console.WriteLine(result1);

            Console.WriteLine(result2 + " у.е.");
            #endregion

            #region laba1_2
            Console.WriteLine("\n\tЛобораторная работа 1. Задание 2");
            Laba_1_2 laba2 = new Laba_1_2();

            string[] y = new string[6];
            laba2.OPER(1, 1, y);

            #endregion

            #region laba2

            Console.WriteLine("\n\tЛобораторная работа 2. Задание 1");

            Laba_2_1 laba_2_1 = new Laba_2_1();

            int result = laba_2_1.MaxDigit(14483);

            Console.WriteLine("Max digit - " + result);

            var sw = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                int count = laba_2_1.MaxDigit(179);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("\n\tЛобораторная работа 2. Задание 2");

            Laba_2_2 laba_2_2 = new Laba_2_2();

            double result3 = laba_2_2.Pow(3, 2);

            Console.WriteLine("a^n = a * a^(n-1)\na^n = " + result3);

            #endregion

            #region laba3
            Console.WriteLine("\n\tЛобораторная работа 3. Задание 1");

            Laba_3_1 laba_3_1 = new Laba_3_1();

            int[] array = new int[15];

            laba_3_1.SetArray(array);
            Console.WriteLine("Кол-во чисел кратыне 3 - " + laba_3_1.MultiplesOfThree(array));
            Console.WriteLine("Сумма положительных чисел - " + laba_3_1.Summ(array));
            Console.WriteLine("Номер максимального положительного числа - " + laba_3_1.NumberMaxDigit(array));
            Console.WriteLine("Есть ли в массиве нулевое значение - " + laba_3_1.FindNull(array));
            Console.WriteLine("Вывод ячеек с четными индексами: ");
            laba_3_1.Output(array);

            Console.WriteLine("\n\tЛобораторная работа 3. Задание 2");

            Laba_3_2 laba_3_2 = new Laba_3_2();

            int[] array2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            laba_3_2.OutputArray(array2);
            laba_3_2.Exchange(array2);
            laba_3_2.OutputArray(array2);

            Console.WriteLine("\n\tЛобораторная работа 3. Задание 3");

            Laba_3_3 laba_3_3 = new Laba_3_3();

            int[] array_3_1 = { 2, 4, 1, 3, 0 };
            int[] array_3_2 = { 7, 5, 9, 6, 8 };

            laba_3_3.SortArray(array_3_1, array_3_2);

            Console.WriteLine("\n\tЛобораторная работа 3. Задание 4");

            Laba_3_4 laba_3_4 = new Laba_3_4();

            laba_3_4.Array();

            Console.WriteLine("\n\tЛобораторная работа 3. Задание 5");

            Laba_3_5 laba_3_5 = new Laba_3_5();

            laba_3_5.Сharacteristic();

            Console.WriteLine("\n\tЛобораторная работа 3. Задание 6");

            Laba_3_6 laba_3_6 = new Laba_3_6();

            string sourceText = @"Колличество слов в предложении";
            int countWords = laba_3_6.CountWords(sourceText);
            Console.WriteLine("Исходный текст - " + sourceText + "");
            Console.WriteLine("Кол-во слов:\t {0}", countWords);

            Console.WriteLine("\n\tЛобораторная работа 3. Задание 7");

            Laba_3_7 laba_3_7 = new Laba_3_7();

            laba_3_7.Text();

            #endregion

        }


    }
}
