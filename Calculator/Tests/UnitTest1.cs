namespace Tests
{
    public class Tests
    {
        CalculatorLogic.CalculatorLogic calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new();
        }

        [TestCase(10, '+', 5, '+', "15 + ")]
        [TestCase(10, '-', 5, '+', "5 + ")]
        [TestCase(10, '*', 5, '+', "50 + ")]
        [TestCase(10, '/', 2, '+', "5 + ")]
        [TestCase(10, '-', -5, '+', "15 + ")]
        public void OperationTestShouldReturnExpected(int firstNum, char firstOperation, int secondNum, char secondOperation, string expected)
        {
            calculator.Calculate(firstNum, firstOperation);
            calculator.Calculate(secondNum, secondOperation);
            Assert.AreEqual(expected, calculator.CurrentOutput);
        }

        [Test]
        public void DividingByZeroTestShouldReturnException()
        {
            calculator.Calculate(10, '/');
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate(0, '+'));
        }

        [Test]
        public void ComplicatedExpressionTest()
        {
            calculator.Calculate(100, '+');
            calculator.Calculate(50, '*');
            calculator.Calculate(2, '-');
            calculator.Calculate(1000, '/');
            Assert.AreEqual("-700 / ", calculator.CurrentOutput);
        }
    }
}