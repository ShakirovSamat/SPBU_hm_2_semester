using BubbleSort;

namespace BubleSortTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringSortTest()
        {
            var expectedNames = new string[] { "Alex", "Anna", "Bob", "Steve" };
            var names = new string[] { "Anna", "Bob", "Steve", "Alex" };
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            var sortedNames = SortHandler.BubbleSort(names, stringComparer);
            for (int i = 0; i < sortedNames.Length; ++i)
            {
                Assert.AreEqual(expectedNames[i], sortedNames[i]);
            }
        }
    }
}