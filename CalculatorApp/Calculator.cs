﻿using System;

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

            return dx / dy;
        }

        public (T, T) SolveQuadraticEquation(T a, T b, T c)
        {
            dynamic da = a;
            dynamic db = b;
            dynamic dc = c;

            dynamic delta = db * db - 4 * da * dc;

            if (delta < 0.0f)
            {
                throw new InvalidOperationException("The equation has no real solutions.");
            }

            dynamic x1 = (-db + (float)Math.Sqrt(delta)) / (2.0f * da);
            dynamic x2 = (-db - (float)Math.Sqrt(delta)) / (2.0f * da);

            return (x1, x2);
        }
    }
}
