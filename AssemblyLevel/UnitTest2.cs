using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyLevel
{
    [TestClass]
   public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Running UnitTest2 ClassInitialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running UnitTest2 ClassCleanup");
        }
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running UnitTest2 TestInitialize");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running UnitTest2 TestCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Running UnitTest2 TestMethod1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("Running UnitTest2 TestMethod2");
        }
    }
}
