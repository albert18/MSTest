using System;
namespace Calculator.Library
{
    public class Calculator
    {
        public static int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Denominator cannot be ZERO");
            
            int result = numerator / denominator;
            return result;
        }

        public int Add(int fn, int sn)
        {
            if (IsPositive(fn) && IsPositive(sn))
            {
                int result = fn + sn;
                return result;
            }
            else
            {
                throw new ArgumentException("Only positive numbers are allwoed");
            }
        }

        private bool IsPositive(int Number)
        {
            return Number > 0;
        }
    }
}