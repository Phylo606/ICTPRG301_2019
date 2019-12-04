using NUnit.Framework;
using StringProcessor;

namespace Tests
{
    public class Tests
    {
        Processor processor;
        [SetUp]
        public void Setup()
        {
            processor = new Processor();
        }

        [TestCase("Test", 't', 2)]
        [TestCase("abcdefg", 't', 0)]
        [TestCase("juice", 'c', 1)]
        [TestCase("anyway", 'y', 2)]
        [TestCase("vacuuuuum", 'u', 5)]
        [TestCase("userstory", 't', 1)]
        public void CountCharTest(string word, char c, int ans)
        {
            Assert.AreEqual(ans, processor.CountChar(word, c));
        }

        [TestCase("Test", "tseT")]
        [TestCase("abcdefg", "gfedcba")]
        [TestCase("juice", "eciuj")]
        [TestCase("anyway", "yawyna")]
        [TestCase("vacuuuuum", "muuuuucav")]
        public void ReverseTest(string word, string ans)
        {
            Assert.AreEqual(ans, processor.Reverse(word));
        }

        [TestCase("Te st", 't', "Tetst")]
        [TestCase("ab cd efg", '_', "ab_cd_efg")]
        [TestCase("ju ic e", 'c', "jucicce")]
        [TestCase("an yw a y", '|', "an|yw|a|y")]
        [TestCase("vacuuuuum", '-', "vacuuuuum")]
        public void ReplaceSpaceTest(string word, char c, string ans)
        {
            Assert.AreEqual(ans, processor.ReplaceSpace(word, c));
        }
    }
}
