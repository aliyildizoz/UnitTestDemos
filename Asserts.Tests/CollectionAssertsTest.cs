using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Asserts.Tests
{
    [TestClass]
    public class CollectionAssertsTest
    {
        private List<string> _users;

        [TestInitialize]
        public void CreateDate()
        {
            _users = new List<string> { "Ali", "Salih", "Ahmet" };
        }
        [TestMethod]
        public void ItemsAndOrderMustSame()
        {
            List<string> newUsers = new List<string> { "Ali", "Salih", "Ahmet" };
            CollectionAssert.AreEqual(_users, newUsers);
        }
        [TestMethod]
        public void ItemsSameButOrderMustNotSame()
        {
            List<string> newUsers = new List<string> { "Salih", "Ahmet", "Ali" };
            CollectionAssert.AreEquivalent(_users, newUsers);
        }
        [TestMethod]
        public void ItemsOrOrderMustNotSame()
        {
            List<string> newUsers = new List<string> { "Ahmet", "Ali", "Salih", "Mehmet" };
            CollectionAssert.AreNotEqual(_users, newUsers);
        }
        [TestMethod]
        public void ItemsAndOrderMustNotSame()
        {
            List<string> newUsers = new List<string> { "Salih", "Ahmet", "Ali", "Mehmet" };
            CollectionAssert.AreNotEquivalent(_users, newUsers);
        }

        [TestMethod]
        public void ItemsMustNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(_users);
        }

        [TestMethod]
        public void ItemsMustUnique()
        {
            CollectionAssert.AllItemsAreUnique(_users);
        }
        [TestMethod]
        public void AllItemsMustSameType()
        {
            CollectionAssert.AllItemsAreInstancesOfType(_users, typeof(string));
        }

        [TestMethod]
        public void IsSubsetOf()
        {
            List<string> newUsers = new List<string> { "Salih", "Ahmet" };
            CollectionAssert.IsSubsetOf(newUsers, _users);
        }
        [TestMethod]
        public void IsNotSubsetOf()
        {
            List<string> oldUser = new List<string> { "Salih", "Cevdet" };
            CollectionAssert.IsNotSubsetOf(oldUser, _users);
        }

        [TestMethod]
        public void Contains()
        {
            CollectionAssert.Contains(_users, "Ali");
        }
        [TestMethod]
        public void DoesNotContain()
        {
            CollectionAssert.DoesNotContain(_users, "Cevdet");
        }
    }
}
