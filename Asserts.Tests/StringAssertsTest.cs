using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Asserts.Tests
{
    [TestClass]
    public class StringAssertsTest
    {
        [TestMethod]
        public void Contains()
        {
            StringAssert.Contains("Hello world!", "orl");
        }
        [TestMethod]
        public void Matches()
        {
            StringAssert.Matches("Hello world!", new Regex(@"[a-zA-Z]"));
        }
        [TestMethod]
        public void DoesNotMatches()
        {
            StringAssert.DoesNotMatch("Hello world!", new Regex(@"[0-9]"));
        }
        [TestMethod]
        public void StartsWith()
        {
            StringAssert.StartsWith("Hello world!", "Hello");
        }
        [TestMethod]
        public void EndsWith()
        {
            StringAssert.EndsWith("Hello world!", "orld!");
        }
    }
}
