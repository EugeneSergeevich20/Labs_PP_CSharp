using System;
using System.Collections.Generic;
using System.Text;


namespace Labs.Laba_1
{
    internal class Laba_1_1
    {
        public double FunctionOne(double a, double t, double b, double x, double z)
        {
            double one =  Math.Sin((Math.Log(a * Math.Pow(t, 2))) + Math.Log10(b));
            double two = Math.Cos(Math.Log(a * Math.Pow(t, 2))) * Math.Cos(Math.Log10(b));
            double three = Math.Pow(Math.Sin(2 * x * Math.Pow(z, t)), 2);
            double four = Math.Pow(Math.Cos(2 * x * Math.Pow(z, t)), 2);

            double result = (one / two) * (three + four);

            return result;
        }

        public int TimeYE()
        {
            int prisvaivanie = 6;
            int slozhenie = 2 * 3;
            int ymnozhenie = 8 * 5;
            int delenie = 7;
            int vizov = 13;

            int result = prisvaivanie + slozhenie + ymnozhenie + delenie + vizov;
            return result;
        }

    }
}
