using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_5
    {

        public void Сharacteristic()
        {
            int M = 4, N = 4;
            int[,] A = new int[M, N];

            Random gen = new Random();

            int i, j;

            Console.WriteLine("Заполните матрицу");

            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    //Console.Write("Введите элемент [{0},{1}]: ", i, j);
                    A[i, j] = gen.Next(-50, 50);
                }
            }
            Console.WriteLine("Исходная матрица");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write(" {0} ", A[i, j]);
                }
                Console.WriteLine();
            }
            int flag = 1;
            while (flag == 1)
            {
                flag = 0;

                for (i = 0; i < M - 1; i++)
                {
                    double sum1 = 0, sum2 = 0;
                    for (j = 0; j < N; j++)
                    {
                        if (A[j, i] < 0 && A[j, i] % 2 != 0)
                        {
                            sum1 += Math.Abs(A[j, i]);
                        }
                        if (A[j, i + 1] < 0 && A[j, i + 1] % 2 != 0)
                        {
                            sum2 += Math.Abs(A[j, i + 1]);
                        }
                    }
                    if (sum1 > sum2)
                    {
                        for (j = 0; j < N; j++)
                        {
                            int tmp = A[j, i];
                            A[j, i] = A[j, i + 1];
                            A[j, i + 1] = tmp;
                        }
                        flag = 1;
                    }
                }
            }
            Console.WriteLine("Преобразованная матрица");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write(" {0} ", A[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i < M; i++)
            {
                double sum = 0;
                for (j = 0; j < N; j++)
                {
                    if (A[j, i] < 0)
                    {
                        for (j = 0; j < N; j++)
                        {
                            sum += A[j, i];
                        }
                    }
                }
                Console.WriteLine("Сумма {0}", sum);
            }
        }
    }

}
