using Delegates;

namespace DelegatesTest
{
    public class Tests
    {
        List<int> list;
        [SetUp]
        public void Setup()
        {
            list = new List<int>() { 1, 2, 3, 4, 5};
        }

        [Test]
        public void Test1()
        {
            FunctionCollector.Map(list, x => x + 2);
            Assert.AreEqual(3, list[0]);
            Assert.AreEqual(4, list[1]);
            Assert.AreEqual(5, list[2]);
            Assert.AreEqual(6, list[3]);
            Assert.AreEqual(7, list[4]);
        }

        [Test]
        public void Test2()
        {
            List<int> result = FunctionCollector.Filter(list, x => x % 2 == 0);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(16,FunctionCollector.Fold(list, 1, (x, y) => x + y));
            
        }
    }
}