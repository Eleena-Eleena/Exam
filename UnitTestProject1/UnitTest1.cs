using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Экзамен;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            uint number = 10;
            var expected = 5;

            var a = new A();
            int actual = a.FindSimple(number);
            actual = a.kol;

            Assert.AreEqual(expected, actual, "Неправильно подсчитано");

        }
    }
}
