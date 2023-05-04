using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorAppTest
{
    [TestClass]
    public class TestIntegerOperations
    {
        public Calculator<int> calculator = new Calculator<int>();

        [TestMethod]
        public void TestAddition()
        {
            // Act
            float result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}