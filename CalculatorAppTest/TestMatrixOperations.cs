using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorAppTest
{
    [TestClass]
    public class TestMatrixOperations
    {
        public Calculator<Matrix<float>> calculator = new Calculator<Matrix<float>>();

        [TestMethod]
        public void AddSameDimensionMatrices()
        {
            // Arrange
            Matrix<float> a = new Matrix<float>(new float[2, 2] { { 1, 1 }, { 1, 1 } });
            Matrix<float> b = new Matrix<float>(new float[2, 2] { { 2, 2 }, { 2, 2 } });

            // Act
            var result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(new Matrix<float>(new float[2, 2] { { 3, 3 }, { 3, 3 } }), result);
        }

        [TestMethod]
        public void AddDifferentDimensionMatrices()
        {
            // Arrange
            Matrix<float> a = new Matrix<float>(new float[2, 2] { { 1, 1 }, { 1, 1 } });
            Matrix<float> b = new Matrix<float>(new float[2, 3] { { 2, 2, 2 }, { 2, 2, 2 } });

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(
                () => calculator.Add(a, b), "Matrices don't have the same dimension."
            );
        }

        [TestMethod]
        public void SubtractSameDimensionMatrices()
        {
            // Arrange
            Matrix<float> a = new Matrix<float>(new float[2, 2] { { 3, 3 }, { 1, 1 } });
            Matrix<float> b = new Matrix<float>(new float[2, 2] { { 2, 2 }, { 2, 2 } });

            // Act
            var result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(new Matrix<float>(new float[2, 2] { { 1, 1 }, { -1, -1 } }), result);
        }

        [TestMethod]
        public void SubtractDifferentDimensionMatrices()
        {
            // Arrange
            Matrix<float> a = new Matrix<float>(new float[2, 2] { { 1, 1 }, { 1, 1 } });
            Matrix<float> b = new Matrix<float>(new float[2, 3] { { 2, 2, 2 }, { 2, 2, 2 } });

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(
                () => calculator.Subtract(a, b), "Matrices don't have the same dimension."
            );
        }

        [TestMethod]
        public void MultiplyAppropriateMatrices()
        {
            // Arrange
            Matrix<float> a = new Matrix<float>(new float[2, 3] { { 1, 2, 0 }, { 1, 0, 1 } });
            Matrix<float> b = new Matrix<float>(new float[3, 2] { { 2, 1 }, { 0, 2 }, { 1, 2 } });

            // Act
            var result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(new Matrix<float>(new float[2, 2] { { 2, 5 }, { 3, 3 } }), result);
        }

        [TestMethod]
        public void MultiplyInappropriateMatrices()
        {
            // Arrange
            Matrix<float> a = new Matrix<float>(new float[2, 2] { { 1, 2 }, { 1, 0 } });
            Matrix<float> b = new Matrix<float>(new float[3, 2] { { 2, 1 }, { 0, 2 }, { 1, 2 } });

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(
                () => calculator.Multiply(a, b), "Matrices cannot be multiplied."
            );
        }
    }
}
