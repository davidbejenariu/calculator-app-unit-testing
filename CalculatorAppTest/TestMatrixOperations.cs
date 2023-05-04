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
            try
            {
                var result = calculator.Add(a, b);
                Assert.AreEqual(new Matrix<float>(new float[2, 2] { { 3, 3 }, { 3, 3 } }), result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Matrices don't have the same dimension.", ex.Message);
            }
        }
    }
}
