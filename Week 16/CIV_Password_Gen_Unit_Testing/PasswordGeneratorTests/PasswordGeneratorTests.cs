using NUnit.Framework;
using PasswordGenerator;

namespace Tests {
    public class Tests
    {
        Generator generator;
        [SetUp]
        public void Setup () {
            generator = new Generator();
        }

        [Test]
        public void PasswordGenOneTest (string firstname, string lastname, int age, string ans) {
            Assert.Fail();
        }

        [Test]
        public void PasswordGenTwoTest (string firstname, string lastname, int age, string ans) {
            Assert.Fail();
        }

        [Test]
        public void PasswordGenThreeTest(int length) {
            Assert.Fail();
        }
    }
}