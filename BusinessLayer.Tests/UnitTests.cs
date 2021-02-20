using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTests
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Users.xml", "User", DataAccessMethod.Sequential)]
        public void DataTest()
        {
            var manager = new UserManager();

            var name = TestContext.DataRow["name"].ToString();
            var phoneNumber = TestContext.DataRow["phoneNumber"].ToString();
            var email = TestContext.DataRow["email"].ToString();

            var result = manager.AddUser(name, phoneNumber, email);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataSource("MyDataSource")]
        public void DataTest2()
        {
            var manager = new MathManager();

            int x = Convert.ToInt16(TestContext.DataRow["x"]);
            int y = Convert.ToInt16(TestContext.DataRow["y"]);
            int expected = Convert.ToInt16(TestContext.DataRow["expected "]);

            var result = manager.Sum(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}
