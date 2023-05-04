using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorAppTest
{
    [TestClass]
    public class TestIntegerOperations
    {
        public Calculator<int> calculator = new Calculator<int>();

        [TestMethod]
        public void TestAddition()
        {
            // Arrange

            // Act
            float result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            // Arrange

            // Act
            float result = calculator.Subtract(2, 3);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            // Arrange

            // Act
            float result = calculator.Multiply(2, 3);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Arrange

            // Act
            float result = calculator.Divide(8, 2);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void TestDivideBy0()
        {
            // Arrange

            // Act
            float result = calculator.Divide(8, 0);

            // Assert
            if(result == float.PositiveInfinity)
            {
                Assert.Fail();
            }

            //Assert.AreEqual(float.PositiveInfinity, result);
        }
    }
}