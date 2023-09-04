using ArithmeticTree;
using ArithmeticTree.Exceptions;

namespace TreeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumOperationTest()
        {
            Tree tree = new Tree("(+ 4 23)");
            Assert.AreEqual(tree.Calculate(), 27);
        }

        [Test]
        public void SubtractionOperationTest()
        {
            Tree tree = new Tree("(- 5 15)");
            Assert.AreEqual(tree.Calculate(), -10);
        }

        [Test]
        public void MultiplicationOperationTest()
        {
            Tree tree = new Tree("(* 13 13)");
            Assert.AreEqual(tree.Calculate(), 169);
        }

        [Test]
        public void DivisionOperationTest()
        {
            Tree tree = new Tree("(/ 10 100)");
            Assert.AreEqual(tree.Calculate(), 0.1);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            Tree tree = new Tree("(/ 13 0)");
            Assert.Throws<DivideByZeroException>(()=> tree.Calculate());
        }

        [Test]
        public void BadInputOperationTest()
        {
            Tree tree = new Tree("(g 13 0)");
            Assert.Throws<BadArithmeticExpressionException>(() => tree.Calculate());
        }

        [Test]
        public void BigExpressionTest()
        {
            Tree tree = new Tree("+ (* (5 6) (/ (- 5 1) (+ 1 1)))");
            Assert.AreEqual(tree.Calculate(), 32);
        }


    }
}