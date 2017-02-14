using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvoiceItemTracker;

namespace InvoiceItemTrackerTests
{
    [TestClass]
    public class InvoiceItemTests
    {
        [TestMethod]
        public void TestCreatingAnItem()
        {

            //Arrange
            var item = new InvoiceItem();
            //Assert
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestOverdue1()
        {
            //Arrange
            var item = new InvoiceItem();
            //Assert
            Assert.IsFalse(item.IsOverdue()); //IsOverdue() is a method so we must call it
        }

        [TestMethod]
        public void TestOverdue2()
        {
            //Arrange
            var now = DateTime.Now;
            var then = now.AddMinutes(-3).AddSeconds(-59);
            var item = new InvoiceItem(then);
            //Assert
            Assert.IsFalse(item.IsOverdue());
        }

        [TestMethod]
        public void TestOverdue3()
        {
            //Arrange
            var fiveMinutes = new TimeSpan(0, 5, 0);
            var fiveMinutesAgo = DateTime.Now.Subtract(fiveMinutes);
            var item = new InvoiceItem(fiveMinutesAgo);

            //Assert
            Assert.IsTrue(item.IsOverdue());

        }
    }
}
