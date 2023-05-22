using program;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyTest()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            Assert.IsTrue(queue.Empty);
        }

        [Test]
        public void NotEmptyTest()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue("12", 1);
            Assert.IsFalse(queue.Empty);
        }

        [Test]
        public void SamePriorityTest()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue("dog", 1);
            queue.Enqueue("cat", 2);
            queue.Enqueue("pig", 2);
            queue.Enqueue("fish", 2);
            Assert.That(queue.Dequeue, Is.EqualTo("cat"));
        }

        [Test]
        public void SimpleQueueTest()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue("dog", 1);
            queue.Enqueue("cat", 2);
            queue.Enqueue("pig", 4);
            queue.Enqueue("fish", 3);
            Assert.That(queue.Dequeue, Is.EqualTo("pig"));
        }
    }
}