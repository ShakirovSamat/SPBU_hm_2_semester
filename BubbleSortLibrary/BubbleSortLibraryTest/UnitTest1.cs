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
            var expectedNames = new List<string>() { "Alex", "Anna", "Bob", "Steve" };
            var names = new List<string>() { "Anna", "Bob", "Steve", "Alex" };
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            var sortedNames = SortHandler.BubbleSort(names, stringComparer);
            for (int i = 0; i < sortedNames.Count; ++i)
            {
                Assert.AreEqual(expectedNames[i], sortedNames[i]);
            }
        }

        [Test]
        public void IntSortTest()
        {
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var array = new List<int>() { 2, 3, 1, 5, 4, 6 };
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            var sortedArray = SortHandler.BubbleSort(array, Comparer<int>.Default);
            for (int i = 0; i < sortedArray.Count; ++i)
            {
                Assert.AreEqual(expected[i], sortedArray[i]);
            }
        }
    }
}