using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_4
    {

        public void Array()
        {
            int M = 4, N = 4;
            int[,] A = new int[M, N];

            Random gen = new Random();

            ArrayList listMinElements = new ArrayList();

            //нахождение минимальных элементов в массиве
            for (int i = 0; i < M; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = gen.Next(1, 20);
                    Console.Write("{0,4}", A[i, j]);
                    if (A[i, j] < min)
                        min = A[i, j];
                }
                listMinElements.Add(min);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < listMinElements.Count; i++)
            {
                Console.WriteLine("Минимальное значение в строк {0} равно {1}", i, listMinElements[i]);
            }

            //убираем максимальное и минимальное значение из массива
            int minElement = int.MaxValue;
            int maxElement = int.MinValue;
            foreach (int item in A)
            {
                if (item > maxElement)
                {
                    maxElement = item;
                }
                if (item < minElement)
                {
                    minElement = item;
                }
            }

            //находим среднее значение
            int sum = 0;
            int k = M * N;
            foreach (int item in A)
            {
                if (item != minElement && item != maxElement)
                {
                    sum += item;
                }
                else
                {
                    --k;
                }
            }
            double middle_value = (double)sum / k;
            Console.WriteLine("\nСреднее значение: " + middle_value);
        }

    }

}
