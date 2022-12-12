using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Laba_3
{
    internal class Laba_3_6
    {
        
        public int CountWords(string source)
        {
            int index = source.IndexOfAny(new char[] { '\r', '\n' });
            if (index != -1)
            {
                source = source.Remove(index);
            }
            return source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
