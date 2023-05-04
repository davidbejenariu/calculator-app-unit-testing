using System;

namespace CalculatorApp
{
    public class Calculator<T>
    {
        public T Add(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;

            return dx + dy;
        }

        public T Subtract(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;

            return dx - dy;
        }

        public T Multiply(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;

            return dx * dy;
        }

        public T Divide(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;

            if(dy == 0)
            {
                throw new ArithmeticException("Attempted to divide by 0");
            }

            return dx / dy;
        }
    }
}
