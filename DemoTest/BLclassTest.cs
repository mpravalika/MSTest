using System;
using BussinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class BLclassTest
    {
        [TestMethod]
        public void DivideTest()
        {
            //Arrange-Declare actuals and expected
            int numerator = 10;
            int denominator = 2;
            int Expected = 5;
            int Actual = 0;
            //Act-call the method and pass the actuals as parameters
            BLclass B = new BLclass();
            Actual = B.Divide((numerator).ToString(), (denominator).ToString());
            //Assert-check whether actuals are match with expected
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void DivideTest2()
        {
            //Arrange-Declare actuals and expected
            int numerator = 0;
            int denominator = 2;
            int Expected = 0;
            //Act-call the method and pass the actuals as parameters
            BLclass B = new BLclass();
            int Actual = B.Divide(numerator.ToString(), denominator.ToString());
            //Assert-check whether actuals are match with expected
            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod]
        public void DivideTest3()
        {
            BLclass B = new BLclass();
            int numerator = 10;
            int denominator = 0;
            var Ex = Assert.ThrowsException<DivideByZeroException>(() => B.Divide(numerator.ToString(), denominator.ToString()));
            Assert.AreEqual("cannot divide by 0", Ex.Message);
        }

        [TestMethod]
        public void DivideTest4()
        {
            BLclass B = new BLclass();
            var Ex = Assert.ThrowsException<FormatException>(() => B.Divide("abc", "xyz"));
            Assert.AreEqual("only numbers", Ex.Message);
        }
    }

}
