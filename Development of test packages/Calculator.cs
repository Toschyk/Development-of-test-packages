using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorSolution
{
    public class Calculator
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;

        public static double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо.");
            return (double)a / b;
        }
    }
}