using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int a = 5;
            int b = 3;
            int expected = 8;

            int result = _calculator.Add(a, b);

            Assert.AreEqual(expected, result, "The sum of 5 and 3 should be 8.");
        }
    }
}