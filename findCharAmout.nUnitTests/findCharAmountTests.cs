using NUnit.Framework;
using findCharAmount;
namespace findCharAmout.nUnitTests
{
    public class Tests
    {
        private FindFreq _findFreq { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _findFreq = new FindFreq();
        }


        [Test]
        public void getCharNum_NotNull()
        {
            var input = "aaabbb";
            var output = _findFreq.getCharNum(input);
            Assert.That(output, !Is.EqualTo(null));
        }

        [TestCase("ababab")]
        [TestCase("M T M T M T")]
        public void getCharNum_AreEqual(string input)
        {
            var output = _findFreq.getCharNum(input);
            Assert.AreEqual(3, output[0]);
            Assert.AreEqual(3, output[1]);        }

        [TestCase("aaaa")]
        [TestCase("55555")]
        public void getCharNum_NotEqualTest(string input)
        {
            var output = _findFreq.getCharNum(input);
            
            Assert.AreNotEqual(3, output[0]);
            Assert.AreNotEqual(1, output[0]);
        }
    }
}