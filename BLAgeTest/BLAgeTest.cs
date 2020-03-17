using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussinessLayer;

namespace BLAgeTest
{
    [TestClass]
    public class BLAgeTest
    {
        [TestMethod]
        public void AgeTest()
        {
            BLAge A = new BLAge();
            DateTime db = DateTime.Parse("05-07-1997");
            int actual = A.Age(db);
            int ex = 22;
            Assert.AreEqual(ex, actual);
        }
        [TestMethod]
        public void Greater()
        {
            BLAge A = new BLAge();
            DateTime db = DateTime.Parse("05-07-1945");
            var ex = Assert.ThrowsException<CustomException>(() => A.Age(db));
            Assert.AreEqual("age should be <60", ex.Message);
        }
        [TestMethod]
        public void Less()
        {
            BLAge A = new BLAge();
            DateTime db = DateTime.Parse("05-07-2010");
            var ex = Assert.ThrowsException<CustomException>(() => A.Age(db));
            Assert.AreEqual("age should be >18", ex.Message);
        }
    }
}
