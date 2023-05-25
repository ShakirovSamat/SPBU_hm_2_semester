namespace ListTests
{
    public class UniqueListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNumber()
        {
            UniqueList list = new UniqueList();
            list.Add(1);

            Assert.IsTrue(list.Contains(1));
        }

        [Test]
        public void AddSeveralNumbers()
        {
            UniqueList list = new UniqueList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(2));
            Assert.IsTrue(list.Contains(3));
        }

        [Test]
        public void AddAndDeleteNumber()
        {
            UniqueList list = new UniqueList();
            list.Add(1);
            list.Delete(1);
            Assert.IsTrue(!list.Contains(1));
        }

        [Test]
        public void AddThreeNumbersAndDeleteOne()
        {
            UniqueList list = new UniqueList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Delete(2);
            Assert.IsTrue(!list.Contains(2));
            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(3));
        }
    }
}