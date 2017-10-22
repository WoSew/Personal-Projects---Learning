﻿using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test7kyu
    {

        [TestMethod]
        public void TestPrinterError()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Kyu7.PrinterError(s);
            Assert.AreEqual("3/56", Kyu7.PrinterError(s));
        }

        [TestMethod]
        public void NbDig()
        {
            Assert.AreEqual(Kyu7.NbDig(5750, 0), 4700);
            Assert.AreEqual(Kyu7.NbDig(11011, 2), 9481);
            Assert.AreEqual(Kyu7.NbDig(12224, 8), 7733);
            Assert.AreEqual(Kyu7.NbDig(11549, 1), 11905);
        }

        [TestMethod]
        public void Calc()
        {
            //implementation with:

            //for loop
            Assert.AreEqual(31, Kyu7.Calc(new[] {0, 2, 1, -6, -3, 3}));
            Assert.AreEqual(0, Kyu7.Calc(new[] {0}));
            Assert.AreEqual(5, Kyu7.Calc(new[] {1,1,1,1,1}));

            //linq
            Assert.AreEqual(31, Kyu7.CalcLinq(new[] { 0, 2, 1, -6, -3, 3 }));
            Assert.AreEqual(0, Kyu7.CalcLinq(new[] { 0 }));
            Assert.AreEqual(5, Kyu7.CalcLinq(new[] { 1, 1, 1, 1, 1 }));

        }

    }
}