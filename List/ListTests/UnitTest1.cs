using List;
namespace ListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNumber()
        {
            List.List list = new List.List();
            list.Add(1);

            Assert.IsTrue(list.Contains(1));
        }

        [Test]
        public void AddSeveralNumbers()
        {
            List.List list = new List.List();
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
            List.List list = new List.List();
            list.Add(1);
            list.Delete(1);
            Assert.IsTrue(!list.Contains(1));
        }

        [Test]
        public void AddThreeNumbersAndDeleteOne()
        {
            List.List list = new List.List();
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