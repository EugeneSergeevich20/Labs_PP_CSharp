using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_7
    {

        static char[] dict = "abcdefgh1234567?!;".ToCharArray();
        static Random rand = new Random();

        public string MakeString(int len)
        {
            char[] letters = new char[len];
            for (int i = 0; i < len; ++i)
                letters[i] = dict[rand.Next(dict.Length)];
            return new string(letters);
        }

        public void Text()
        {
            Console.Write("Length: ");
            int len = Convert.ToInt32(Console.ReadLine());

            if (len > 0)
            {
                string str = MakeString(len);
                Console.WriteLine("String:  " + str);

                StringBuilder sb = new StringBuilder(str);

                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == ';')
                    {
                        sb[i] = '_';
                    }
                }

                str = sb.ToString();

                Console.WriteLine("Changed: " + str);
            }
            else
                Console.WriteLine("Need some natural number.");
        }

    }
}
