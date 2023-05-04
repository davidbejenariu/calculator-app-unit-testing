using CalculatorApp;

namespace CalculatorTest
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
    }
}