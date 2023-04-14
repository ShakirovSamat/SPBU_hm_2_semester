using NUnit.Framework;
using StackCalculator;

namespace StackCalculatorTests
{
    public class Tests
    {
        IStack[] stacks = { new StackBasedOnArray(), new StackBasedOnLinkedList() };
        StackCalculator.StackCalculator[] stackCalculators = { new StackCalculator.StackCalculator(new StackBasedOnArray()), new StackCalculator.StackCalculator(new StackBasedOnLinkedList()) };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PushAndPopShoulGetTheSameNumber()
        {
            for (int i = 0; i < stacks.Length; ++i)
            {
                stacks[i].Push(15);
                stacks[i].Pop(out double result);
                Assert.That(result, Is.EqualTo(15));
            }
        }

        [Test]
        public void PushAndPopShouldBeEmptyStack()
        {
            for (int i = 0; i < stacks.Length; ++i)
            {
                stacks[i].Push(15);
                stacks[i].Pop(out double result);
                Assert.IsTrue(stacks[i].isEmpty());
            }
        }

        [Test]
        public void Plus5And7ShouldReturn12()
        {
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.That(stackCalculators[i].Calculate("5 7 +"), Is.EqualTo(12));
            }
        }

        [Test]
        public void Substract9From99ShouldReturn90()
        {
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.That(stackCalculators[i].Calculate("99 9 -"), Is.EqualTo(90));
            }
        }

        [Test]
        public void Multiply5By9ShouldREturn45()
        {
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.That(stackCalculators[i].Calculate("5 9 *"), Is.EqualTo(45));
            }
        }

        [Test]
        public void DividingBy0ShouldReturnNotANumber()
        {
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.IsTrue(Double.IsNaN(stackCalculators[i].Calculate("1 0 /")));
            }
        }

        [Test]
        public void BadInputShouldRetunrNotANumber()
        {
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.IsTrue(Double.IsNaN(stackCalculators[i].Calculate("g 6 +")));
            }
        }

        [Test]
        public void Dividing5By10ShouldRetunr0dot5()
        { 
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.That(stackCalculators[i].Calculate("5 10 /"), Is.EqualTo(0.5));
            }
        }

        [Test]
        public void BigExpressionShouldRetunrRightResult()
        {
            for (int i = 0; i < stackCalculators.Length; ++i)
            {
                Assert.That(stackCalculators[i].Calculate("56 78 12 -54 1 -5 9 + / - + * +"), Is.EqualTo(-3239.5));
            }
        }

    }
}