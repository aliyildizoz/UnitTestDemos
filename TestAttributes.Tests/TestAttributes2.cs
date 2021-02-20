using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAttributes.Tests
{
    [TestClass]
    public class TestAttributes2
    {
        [TestMethod,Ignore]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod,Timeout(1000)]
        public void TestMethod2()
        {
            //System.Threading.Thread.Sleep(5000);
            Assert.AreEqual(1, 1);
        }
       
        [TestMethod,Timeout(TestTimeout.Infinite)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod, Ignore]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        
        [TestMethod,Description("this is a method that do a sqrt test")]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
