using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorAppTest
{
    [TestClass]
    public class TestNumericOperations
    {
        public Calculator<float> calculator = new Calculator<float>();

        [TestMethod]
        public void TestAddition()
        {
            // Act
            float result = calculator.Add(2.0f, 3.0f);

            // Assert
            Assert.AreEqual(5.0f, result);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            // Act
            float result = calculator.Subtract(20.0f, 5.5f);

            // Assert
            Assert.AreEqual(14.5f, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            // Act
            float result = calculator.Multiply(2.0f, 6.5f);

            // Assert
            Assert.AreEqual(13.0f, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Act
            float result = calculator.Divide(40.0f, 20.0f);

            // Assert
            Assert.AreEqual(2.0f, result);
        }

        [TestMethod]
        // Test a case where there are two real solutions
        public void TestQuadraticEquationSolverTwoSolution()
        {
            // Arrange
            float a = 2.0f;
            float b = -5.0f;
            float c = 2.0f;

            // Act
            var expected = (2.0f / 1.0f, 1.0f / 2.0f);
            var actual = calculator.SolveQuadraticEquation((float)a, (float)b, (float)c);

            // Assert
            Assert.AreEqual(expected, actual, "Unexpected solution for a quadratic equation with two real solutions.");   
        }

        [TestMethod]
        // Test a case where there is only one real solution
        public void TestQuadraticEquationSolverOneSolution()
        {
            // Arrange
            float a = 1.0f;
            float b = -6.0f;
            float c = 9.0f;

            // Act
            var expected = (3.0f, 3.0f);
            var actual = calculator.SolveQuadraticEquation((float)a, (float)b, (float)c);

            // Assert
            Assert.AreEqual(expected, actual, "Unexpected solution for a quadratic equation with one real solution.");
        }

        [TestMethod]
        // Test a case where there is no real solution
        public void TestQuadraticEquationSolverNoSolution()
        {
            // Arrange
            float a = 1.0f;
            float b = 1.0f;
            float c = 1.0f;

            // Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => calculator.SolveQuadraticEquation((float)a, (float)b, (float)c), "Expected InvalidOperationException not thrown for a quadratic equation with no real solutions.");
        }
    }
}