using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Example.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CanCalculateTotalOf3Numbers()
        {
            var vals = new List<int>();
            vals.Add(6);
            vals.Add(11);
            vals.Add(1);

            var calc = new Calculator(vals);

            var response = calc.Sum();

            Assert.That(response, Is.EqualTo(18));
            //Assert.Equals(response, 18);
        }

        [Test]
        public void CanCalculateNegativeNumbers()
        {
            var vals = new List<int>();
            vals.Add(-11);
            vals.Add(-9);
            vals.Add(-1);

            var calc = new Calculator(vals);

            var response = calc.Sum();

            Assert.That(response, Is.EqualTo(-21));
            //Assert.Equals(response, -21);
        }

        [Test]
        public void CanCalculateNullNumbers()
        {
            var vals = new List<int>();
            vals.Add(0);
            vals.Add(0);
            vals.Add(0);

            var calc = new Calculator(vals);

            var response = calc.Sum();

            Assert.That(response, Is.EqualTo(0));
            //Assert.Equals(response, 0);
        }
    }
}
