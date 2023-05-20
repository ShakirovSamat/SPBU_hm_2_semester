using LZW;
namespace LZWTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyInputCompressTest()
        {
            Assert.AreEqual(LZW.LZW.Compress(String.Empty), String.Empty);
        }

        [Test]
        public void EmptyInputDecompressTest()
        {
            Assert.AreEqual(LZW.LZW.Decompress( null), String.Empty);
        }

        [Test]
        public void CompressTest()
        {
            Assert.AreEqual(LZW.LZW.Compress("WYS*WYGWYS*WYSWYSG"), "87 89 83 42 256 71 256 258 262 262 71");
        }

        [Test]
        public void DecompressTest()
        {
            int[] compressed = { 87, 89, 83, 42, 256, 71, 256, 258, 262, 262, 71 };
            Assert.AreEqual(LZW.LZW.Decompress(compressed), "WYS*WYGWYS*WYSWYSG");
        }
    }
}