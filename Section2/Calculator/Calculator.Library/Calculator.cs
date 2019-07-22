using System;

namespace Calculator.Library
{
    public class Calculator
    {
        public static int Divide(int numerator, int denominator)
        {
            //if (denominator == 0)
            //    throw new DivideByZeroException("Denominator cannot be zero");

            int result = numerator / denominator;
            return result;
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static int Add(int fn, int sn)
        {
            if (isPositive(fn) && isPositive(sn))
            {
                int result = fn + sn;
                return result;
            }
            else
            {
                throw new ArgumentException("Only Positve numbers are allowed");
            }

        }

        /// <summary>
        /// Unit Testing with private method
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        private static bool isPositive(int Number)
        {
            return Number > 0;
        }
    }
}