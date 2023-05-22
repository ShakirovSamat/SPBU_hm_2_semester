using Microsoft.VisualStudio.TestPlatform.TestHost;
using program;
using System.Text;

namespace EncodeDecodeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleEncodeTest()
        {
            byte[] array = new byte[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            (byte[] encoded, double d) res = EncodeDecode.Encode(array);
            for (int i = 0; i < res.encoded.Length; i += 2)
            {
                Assert.That(res.encoded[i], Is.EqualTo((i + 2) / 2));
            }
        }

        [Test]
        public void SimpleDecodeTest()
        {
            byte[] array = new byte[] { 1, 1, 2, 2, 3, 3, 4, 4 };
            byte[] shoulBeGet = new byte[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            byte[] decoded = EncodeDecode.Decode(array);
            for (int i = 0; i < decoded.Length; ++i)
            {
                Assert.That(decoded[i], Is.EqualTo(shoulBeGet[i]))
;
            }
        }

        [Test]
        public void OverflowEncodeTest()
        {
            byte[] array = new byte[400];
            for (int i = 0; i < 400; ++i)
            {
                array[i] = 5;
            }
            (byte[] encoded, double d) res = EncodeDecode.Encode(array);
            byte[] shoulBeGet = new byte[] { 255, 5, 145, 5 };
            for (int i = 0; i < res.encoded.Length; ++i)
            {
                Assert.That(res.encoded[i], Is.EqualTo(shoulBeGet[i]))
;
            }
        }
    }
}