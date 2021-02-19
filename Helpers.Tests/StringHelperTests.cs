using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void RemoveBeginAndEndSpaceChar()
        {
            //Arrange
            var expression = "  Ali Yıldızöz  ";
            var expected = "Ali Yıldızöz";

            //Act
            var result = StringHelper.RemoveMuchSpace(expression);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void RemoveMuchSpaceChar()
        {
            //Arrange
            var expression = " Ali Yıldızöz   Ali Yıldızöz    Ali   Yıldızöz              Ali Yıldızöz ";
            var expected = "Ali Yıldızöz Ali Yıldızöz Ali Yıldızöz Ali Yıldızöz";

            //Act
            var result = StringHelper.RemoveMuchSpace(expression);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
