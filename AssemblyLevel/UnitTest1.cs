using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Debug.WriteLine("Running AssemblyInitialize");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running AssemblyCleanup");
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Running UnitTest1 ClassInitialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running UnitTest1 ClassCleanup");
        }
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running UnitTest1 TestInitialize");
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running UnitTest1 TestCleanup");
        }
       
        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Running UnitTest1 TestMethod1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("Running UnitTest1 TestMethod2");
        }
    }
}
