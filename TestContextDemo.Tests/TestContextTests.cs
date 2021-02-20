using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextDemo.Tests
{
    [TestClass]
    public class TestContextTests
    {
        //set at runtime
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--TestInitialize--\n");
            TestContext.WriteLine("Test name: {0}", TestContext.TestName);
            TestContext.WriteLine("Test state: {0}\n\n", TestContext.CurrentTestOutcome);
            TestContext.Properties["info"] = "this is a extra information";
        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--\n");
            TestContext.WriteLine("Test name: {0}", TestContext.TestName);
            TestContext.WriteLine("Test state: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test info: {0}", TestContext.Properties["info"]);

        }
        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("--TestMethod1--\n");
            TestContext.WriteLine("Test name: {0}", TestContext.TestName);
            TestContext.WriteLine("Test state: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test class: {0}", TestContext.FullyQualifiedTestClassName); 
            TestContext.WriteLine("Test info: {0}\n\n", TestContext.Properties["info"]);

            Assert.AreEqual(1,1);
        }
    }
}
