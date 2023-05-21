using program;
namespace ListTests
{
    //sHOULD ADD TESTS
    public class Tests
    {
        private static IEnumerable<TestCaseData> TypeOfList
        {
            get {
                yield return new TestCaseData(new program.List());
                yield return new TestCaseData(new UniqueList());
            }
        }

        UniqueList uniqueList;

        [SetUp]
        public void Setup()
        {
            uniqueList = new UniqueList();
        }

        [TestCaseSource(nameof(TypeOfList))]
        public void AddNumber(program.List list)
        {
            list.Add(1);
            Assert.IsTrue(list.Contains(1));
        }

        [TestCaseSource(nameof(TypeOfList))]
        public void AddSeveralNumbers(program.List list)
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(2));
            Assert.IsTrue(list.Contains(3));
        }

        [TestCaseSource(nameof(TypeOfList))]
        public void AddAndDeleteNumber(program.List list)
        {
            list.Add(1);
            list.Delete(1);
            Assert.IsTrue(!list.Contains(1));
        }

        [TestCaseSource(nameof(TypeOfList))]
        public void AddThreeNumbersAndDeleteOne(program.List list)
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Delete(2);
            Assert.IsTrue(!list.Contains(2));
            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(3));
        }

        [TestCaseSource(nameof(TypeOfList))]
        public void ResetNumbers(program.List list)
        {
            list.Add(1);
            list.Reset(0, 3);
            Assert.IsTrue(!list.Contains(1));
            Assert.IsTrue(list.Contains(3));
        }

        [Test]
        public void AddTwoSameNumbersToUniqueList()
        {
            uniqueList.Add(2);
            Assert.Throws<AddSameValueException>(() => uniqueList.Add(2));
        }
    }
}