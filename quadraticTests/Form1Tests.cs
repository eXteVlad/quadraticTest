using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace quadraticTests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Disc_321_1()
        {
            int a = 2;
            int b = 3;
            int c = 1;
            int expected = 1;

            quadratic.Form1 f = new quadratic.Form1();
            double actual = f.Disc(a, b, c);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Disc_111_neg3()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            int expected = -3;

            quadratic.Form1 f = new quadratic.Form1();
            double actual = f.Disc(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
