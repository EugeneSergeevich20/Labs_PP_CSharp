using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_8
    {

        static void Eight_fillmas(ref int[][,] m)
        {
            Random r = new Random();
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    m[0][i, j] = r.Next(0, 255);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                    m[1][i, j] = r.Next(0, 255);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    m[2][i, j] = r.Next(0, 255);

        }
        static void Eight_getmaxes(int[][,] m)
        {
            int[] maxes = new int[8];
            int c = 0;
            for (int i = 0; i < 2; i++)
            {
                int max = Int32.MinValue;
                for (int j = 0; j < 2; j++)
                {
                    if (max < m[0][j, i]) max = m[0][j, i];
                }
                Console.WriteLine("Максимум {1} столбца 1 матрицы = {0}", max, i + 1);
                maxes[c + i] = max;
            }
            c = 3;
            for (int i = 0; i < 2; i++)
            {
                int max = Int32.MinValue;
                for (int j = 0; j < 3; j++)
                {
                    if (max < m[1][j, i]) max = m[1][j, i];
                }
                Console.WriteLine("Максимум {1} столбца 2 матрицы = {0}", max, i + 1);
                maxes[c + i] = max;
            }
            c = 5;
            for (int i = 0; i < 3; i++)
            {
                int max = Int32.MinValue;
                for (int j = 0; j < 2; j++)
                {
                    if (max < m[2][j, i]) max = m[2][j, i];
                }
                Console.WriteLine("Максимум {1} столбца 3 матрицы = {0}", max, i + 1);
                maxes[c + i] = max;
            }
            c = 0;
            foreach (int i in maxes)
            {
                c += i;
            }
            Console.WriteLine("Сумма максимумов = {0}", c);
        }
        public void Eighth()
        {
            int[][,] A = new int[3][,];
            A[0] = new int[2, 2];
            A[1] = new int[3, 2];
            A[2] = new int[2, 3];

            Eight_fillmas(ref A);
            Eight_getmaxes(A);

        }

    }
}
