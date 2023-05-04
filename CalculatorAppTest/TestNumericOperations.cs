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
            // Acts
            float result = calculator.Add(2.0f, 3.0f);

            // Assert
            Assert.AreEqual(5.0f, result);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            // Acts
            float result = calculator.Subtract(20.0f, 5.5f);

            // Assert
            Assert.AreEqual(14.5f, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            // Acts
            float result = calculator.Multiply(2.0f, 6.5f);

            // Assert
            Assert.AreEqual(13.0f, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Acts
            float result = calculator.Divide(40.0f, 20.0f);

            // Assert
            Assert.AreEqual(2.0f, result);
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
            // Test a case where there is no real solution
            float a = 1.0f;
            float b = 1.0f;
            float c = 1.0f;
            Assert.ThrowsException<InvalidOperationException>(() => calculator.QuadraticEquationSolver((float)a, (float)b, (float)c), "Expected InvalidOperationException not thrown for a quadratic equation with no real solutions.");
        }
    }
}