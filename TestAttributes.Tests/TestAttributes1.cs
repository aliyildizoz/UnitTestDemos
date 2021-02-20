using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes.Tests
{
    [TestClass]
    public class TestAttributes1
    {
        [Owner("Ali")]
        [TestMethod]
        [TestCategory("Tester")]
        [Priority(2)]
        [TestProperty("Updated","Salih")]
        public void TestMethod1()
        {
            Assert.AreEqual(1,1);
        }
        [TestCategory("Tester")]
        [Owner("Ali")]
        [Priority(4)]
        [TestProperty("Updated","Salih")]
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
        [TestCategory("Developper")]
        [TestProperty("Updated","Ali")]
        [TestProperty("Updated2","Salih")] 
        [Owner("Salih")]
        [Priority(5)]
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
        [TestProperty("Updated","Engin")]
        [TestCategory("Developper")]
        [Owner("Salih")]
        [Priority(3)]
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        [TestProperty("Updated","Engin")]
        [TestCategory("Developper")]
        [Priority(1)]
        [Owner("Salih")]
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
