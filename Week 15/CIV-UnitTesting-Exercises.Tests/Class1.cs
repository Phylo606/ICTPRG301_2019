using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIV_UnitTesting_Exercises.Tests
{
    public class RecursiveCalculationsTests
    {
        [Test]
        public void CanReturnFactorial()
        {
            var factorialrec = new RecursiveCalculations();

            var response = factorialrec.FactorialRec(5, 1);

            Assert.That(response, Is.EqualTo(120));
            
        }

        [Test]
        public void CanReturnFactorialOfZero()
        {
            var factorialrec = new RecursiveCalculations();

            var response = factorialrec.FactorialRec(0, 1);

            Assert.That(response, Is.EqualTo(1));
        }

        [Test]
        public void CanCheckFibonacciTrue()
        {
            var fibonaccicheck = new RecursiveCalculations();

            var response = fibonaccicheck.FibCheck(21);

            Assert.That(response, Is.EqualTo(true));
        }

        [Test]
        public void CanCheckFibonacciFalse()
        {
            var fibonaccicheck = new RecursiveCalculations();

            var response = fibonaccicheck.FibCheck(18);

            Assert.That(response, Is.EqualTo(false));
        }

        [Test]
        public void CanCheckPrimeTrue()
        {
            var primecheck = new RecursiveCalculations();

            var response = primecheck.PrimeCheckRec(3, 2);

            Assert.That(response, Is.EqualTo(true));
        }

        [Test]
        public void CanCheckHighPrimeTrue()
        {
            var primecheck = new RecursiveCalculations();

            var response = primecheck.PrimeCheckRec(61, 2);

            Assert.That(response, Is.EqualTo(true));
        }

        [Test]
        public void CanCheckPrimeFalse()
        {
            var primecheck = new RecursiveCalculations();

            var response = primecheck.PrimeCheckRec(33, 2);

            Assert.That(response, Is.EqualTo(false));
        }

        [Test]
        public void CanReturnNthFibonacciNum()
        {
            var nthfibrec = new RecursiveCalculations();

            var response = nthfibrec.FibonacciRec(0, 1, 1);

            Assert.That(response, Is.EqualTo(2));
        }
    }
}
