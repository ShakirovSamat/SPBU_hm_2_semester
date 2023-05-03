namespace SkipListTests
{
    public class Tests
    {
        SkipList<int> skipList;
        [SetUp]
        public void Setup()
        {
            skipList = new SkipList<int>();
        }

        [Test]
        public void AddTest()
        {
            skipList.Add(1);
            Assert.IsTrue(skipList.Contains(1));
        }

        [Test]
        public void RemoveTest()
        {
            skipList.Add(1);
            Assert.IsTrue(skipList.Contains(1));
            skipList.Remove(1);
            Assert.IsFalse(skipList.Contains(1));
        }

        [Test]
        public void IndxexOfTest()
        {
            skipList.Add(1);
            Assert.AreEqual(0, skipList.IndexOf(1));
        }

        [Test]
        public void RemoveAtTest()
        {
            skipList.Add(2);
            skipList.Add(1);
            skipList.Add(3);
            skipList.RemoveAt(2);
            Assert.IsFalse(skipList.Contains(3));
        }

        [Test]
        public void ContainsTest()
        {
            skipList.Add(1);
            Assert.IsTrue(skipList.Contains(1));
            Assert.IsFalse(skipList.Contains(2));
        }

        [Test]
        public void ForeachTest()
        {
            skipList.Add(3);
            skipList.Add(2);
            skipList.Add(12);
            skipList.Add(7);
            int sum = 0;
            foreach (int x in skipList)
            {
                sum += x;
            }
            Assert.AreEqual(24, sum);
        }
    }
}