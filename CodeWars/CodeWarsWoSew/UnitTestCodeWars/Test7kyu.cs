using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test7kyu
    {

        [TestMethod]
        public void testPrinterError()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            kyu7.PrinterError(s);
            Assert.AreEqual("3/56", kyu7.PrinterError(s));
        }
    }
}