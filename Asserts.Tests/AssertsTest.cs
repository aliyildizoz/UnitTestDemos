using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asserts.Tests
{
    [TestClass]
    public class AssertsTest
    {
        [TestMethod]
        public void AreEqualWithMessage()
        {
            const double value = 25;
            const double excepted = 5;
            double actual = Math.Sqrt(value);

            Assert.AreEqual(excepted, actual, "the square root of {0} must be {1}", value, excepted);
        }
        [TestMethod]
        public void AreEqualWithDelta()
        {
            const double value = 10;
            const double excepted = 3.1622;
            //formula : |excepted - actual| <= delta
            double delta = 0.0001;

            double actual = Math.Sqrt(value);

            Assert.AreEqual(excepted, actual, delta);
        }
        [TestMethod]
        public void AreEqualWithIgnoreCase()
        {
            string excepted = "HELLO";
            string actual = "hello";
            //default: false
            Assert.AreEqual(excepted, actual, true);
        }
        [TestMethod]
        public void AreNotEqual()
        {
            const double notExcepted = 0;
            var actual = Math.Pow(5, 0);
            Assert.AreNotEqual(notExcepted, actual);
        }
        [TestMethod]
        public void AreSame()
        {
            var numbers = new byte[] { 1, 2, 3, 4, 5, 6 };
            var otherNumbers = numbers;
            numbers[0] = 7;
            Assert.AreSame(numbers, otherNumbers);
        }
        [TestMethod]
        public void AreNotSame()
        {
            int a = 10;
            int b = a;
            Assert.AreNotSame(a, b, "AreSame become failed");
            Assert.AreEqual(a, b, "AreEqual become failed");
        }
        [TestMethod]
        public void Inconclusive()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("This test not enough");
        }
        [TestMethod]
        public void IsNotInstanceOfType()
        {
            var number = 5;
            Assert.IsNotInstanceOfType(number, typeof(decimal));
        }
        [TestMethod]
        public void IsInstanceOfType()
        {
            var number = 5m;
            Assert.IsInstanceOfType(number, typeof(decimal));
        }
        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(10 % 2 == 0);
        }
        [TestMethod]
        public void IsFalse()
        {
            Assert.IsFalse(10 % 2 == 1);
        }
        [TestMethod]
        public void IsNull()
        {
            List<string> names = new List<string> { "Salih", "Ali", "Ahmet" };
            var firstNameStartWithC = names.FirstOrDefault(s => s.StartsWith("C"));

            Assert.IsNull(firstNameStartWithC, "IsNull become failed");
        }
        [TestMethod]
        public void IsNotNull()
        {
            List<string> names = new List<string> { "Salih", "Ali", "Ahmet" };
            var firstNameStartWithS = names.FirstOrDefault(s => s.StartsWith("S"));

            Assert.IsNotNull(firstNameStartWithS, "IsNotNull become failed");
        }
        [TestMethod]
        public void Fail()
        {
            try
            {
                var number = 5;
                var res = number / 0;

            }
            catch (DivideByZeroException e)
            {
                Assert.Fail("The test become failed");
            }
        }
    }
}
