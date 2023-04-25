namespace CalculatorTests
{
    public class Tests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            calcualator.Calculate(5, '+');
            Assert.Pass();
        }
    }
}