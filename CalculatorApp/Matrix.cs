using System;
using System.Runtime.CompilerServices;

namespace CalculatorApp
{
    public class Matrix<T> : IEquatable<Matrix<T>>
    {
        private T[,] matrix;

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
        }

        public bool Equals(Matrix<T> other)
        {
            if (matrix.GetLength(0) != other.matrix.GetLength(0) || matrix.GetLength(1) != other.matrix.GetLength(1))
            {
                return false;
            }

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((dynamic) matrix[i, j] != other.matrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Matrix<T>);
        }

        public override int GetHashCode()
        {
            int hash = 17;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    hash = hash * 31 + (dynamic) matrix[i, j];
                }
            }

            return hash;
        }

        public static bool operator ==(Matrix<T> a, Matrix<T> b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Matrix<T> a, Matrix<T> b)
        {
            return !a.Equals(b);
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices don't have the same dimension.");
            }
            
            int n = a.matrix.GetLength(0);
            int m = a.matrix.GetLength(1);
            T[,] result = new T[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = (dynamic)a.matrix[i, j] + b.matrix[i, j];
                }
            }

            return new Matrix<T>(result);
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {

        }
    }
}
