namespace Tests
{
    public class Tests
    {
        CalculatorLogic.CalculatorLogic calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorLogic.CalculatorLogic();
        }

        [Test]
        public void SumTest()
        {
            calculator.Calculate(10, '+');
            calculator.Calculate(14, '+');
            Assert.AreEqual("24 + ", calculator.CurrentOutput);
        }

        [Test]
        public void SubstractionTest()
        {
            calculator.Calculate(10, '-');
            calculator.Calculate(5, '+');
            Assert.AreEqual("5 + ", calculator.CurrentOutput);
        }

        [Test]
        public void MultiplicationTest()
        {
            calculator.Calculate(10, '*');
            calculator.Calculate(5, '+');
            Assert.AreEqual("50 + ", calculator.CurrentOutput);
        }

        [Test]
        public void DivisionTest()
        {
            calculator.Calculate(10, '/');
            calculator.Calculate(2, '+');
            Assert.AreEqual("5 + ", calculator.CurrentOutput);
        }
    }
}