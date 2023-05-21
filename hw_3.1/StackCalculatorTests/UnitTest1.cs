using NUnit.Framework;
using program;

namespace StackCalculatorTests
{
    public class Tests
    {
        private static IEnumerable<TestCaseData> TypeOfStack
        {
            get
            {
                yield return new TestCaseData(new StackBasedOnArray());
                yield return new TestCaseData(new StackBasedOnLinkedList());
            }
        }

        private static IEnumerable<TestCaseData> TypeOfStackCalculator
        {
            get
            {
                yield return new TestCaseData(new StackCalculator(new StackBasedOnArray()));
                yield return new TestCaseData(new StackCalculator(new StackBasedOnLinkedList()));
            }
        }

        double result;

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TypeOfStack))]
        public void PushAndPopShoulGetTheSameNumber(IStack stack)
        {
            stack.Push(15);
            (bool, double) res = stack.Pop();
            Assert.IsTrue(Math.Abs(res.Item2 - 15) < 0.0000001);
        }

        [TestCaseSource(nameof(TypeOfStack))]
        public void PushAndPopShouldBeEmptyStack(IStack stack)
        {

            stack.Push(15);
            stack.Pop();
            Assert.IsTrue(stack.isEmpty);

        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void Plus5And7ShouldReturn12(StackCalculator stackCalculator)
        {
            result = stackCalculator.Calculate("5 7 +");
            Assert.IsTrue(Math.Abs(result - 12) < 0.0000001);
        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void Substract9From99ShouldReturn90(StackCalculator stackCalculator)
        {
            result = stackCalculator.Calculate("99 9 -");
            Assert.IsTrue(Math.Abs(result - 90) < 0.0000001);
        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void Multiply5By9ShouldREturn45(StackCalculator stackCalculator)
        {
            result = stackCalculator.Calculate("5 9 *");
            Assert.IsTrue(Math.Abs(result - 45) < 0.0000001);
        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void DividingBy0ShouldReturnNotANumber(StackCalculator stackCalculator)
        {

            Assert.IsTrue(Double.IsNaN(stackCalculator.Calculate("1 0 /")));
        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void BadInputShouldRetunrNotANumber(StackCalculator stackCalculator)
        {
            Assert.IsTrue(Double.IsNaN(stackCalculator.Calculate("g 6 +")));
        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void Dividing5By10ShouldRetunr0dot5(StackCalculator stackCalculator)
        {
            result = stackCalculator.Calculate("5 10 /");
            Assert.IsTrue(Math.Abs(result - 0.5) < 0.0000001);
        }

        [TestCaseSource(nameof(TypeOfStackCalculator))]
        public void BigExpressionShouldRetunrRightResult(StackCalculator stackCalculator)
        {
            result = stackCalculator.Calculate("56 78 12 -54 1 -5 9 + / - + * +");
            Assert.IsTrue(Math.Abs(result - -3239.5) < 0.0000001);
        }
    }
}