using Delegates;
using System.Security.Cryptography.X509Certificates;

namespace DelegatesTest
{
    public class Tests
    {
        List<int> list;
        [SetUp]
        public void Setup()
        {
            list = new List<int>() { 1, 2, 3, 4, 5 };
        }

        [Test]
        public void MapFunctionTest()
        {
            var result = FunctionCollector.Map(list, x => x + 2);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(6, result[3]);
            Assert.AreEqual(7, result[4]);
        }

        [Test]
        public void FilterFunctionTest()
        {
            List<int> result = FunctionCollector.Filter(list, x => x % 2 == 0);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [Test]
        public void FoldFunctionDefaultTest()
        {
            Assert.AreEqual(16, FunctionCollector.Fold(list, 1, (x, y) => x + y));

        }

        [Test]
        public void FoldFunctionEmptyInputTest()
        {
            Assert.AreEqual(1, FunctionCollector.Fold(new List<int>(), 1, (x, y) => x + y));
        }
    }
}