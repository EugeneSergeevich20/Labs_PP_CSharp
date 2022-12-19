using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_6
    {

        /*
         В этом методе мы берём строку и перебираем её посимвольно
         Если встречается пробел, то мы в count прибавляем 1
         Или если было считано последний символ слова, которое стоит в конце строки, то мы тоже добавляем 1
         */
        public int CountWords(string source)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i].Equals(' ') || i == source.Length - 1)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
