using CalculatorApi.Interfaces;
using System;

namespace CalculatorApi.Services
{
    public class CalculatorService<T> : ICalculatorService<T> where T : struct
    {
        public T Add(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }

        public T Subtract(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 - num2;
        }

        public T Multiply(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 * num2;
        }

        public T Divide(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }
    }
}