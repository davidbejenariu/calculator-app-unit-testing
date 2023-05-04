using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorAppTest
{
    [TestClass]
    public class TestIntegerOperations
    {
        public Calculator<float> calculator = new Calculator<float>();

        [TestMethod]
        public void TestAddition()
        {
            // Arrange

            // ActS
            float result = calculator.Add(2.0f, 3.0f);

            // Assert
            Assert.AreEqual(5.0f, result);
        }

        [TestMethod]
        public void TestQuadraticEquationSolverTwoSolution()
        {
            // Test a case where there are two real solutions

            float a = 2.0f;
            float b = -5.0f;
            float c = 2.0f;
            var expected = (2.0f / 1.0f, 1.0f / 2.0f);
            var actual = calculator.QuadraticEquationSolver((float)a, (float)b, (float)c);
            Assert.AreEqual(expected, actual, "Unexpected solution for a quadratic equation with two real solutions.");   
        }

        [TestMethod]
        public void TestQuadraticEquationSolverOneSolution()
        {
            // Test a case where there is only one real solution
            float a = 1.0f;
            float b = -6.0f;
            float c = 9.0f;
            var expected = (3.0f, 3.0f);
            var actual = calculator.QuadraticEquationSolver((float)a, (float)b, (float)c);
            Assert.AreEqual(expected, actual, "Unexpected solution for a quadratic equation with one real solution.");
        }

        [TestMethod]
        public void TestQuadraticEquationSolverNoSolution()
        {
            // Test a case where there is only one real solution
            float a = 1.0f;
            float b = 1.0f;
            float c = 1.0f;
            Assert.ThrowsException<InvalidOperationException>(() => calculator.QuadraticEquationSolver((float)a, (float)b, (float)c), "Expected InvalidOperationException not thrown for a quadratic equation with no real solutions.");
        }
    }
}