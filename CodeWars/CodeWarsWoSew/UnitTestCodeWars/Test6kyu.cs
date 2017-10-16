using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test6kyu
    {
        [TestMethod]
        public void PersistentBugger()
        {
            Assert.AreEqual(3, kyu6.Persistence(39)); // because 3*9 = 27, 2*7 = 14, 1*4=4
            Assert.AreEqual(0, kyu6.Persistence(4)); // because 4 is already a one-digit number
            Assert.AreEqual(2, kyu6.Persistence(25));
            Assert.AreEqual(4, kyu6.Persistence(999)); // because 9*9*9 = 729, 7*2*9 = 126,
        }

        [TestMethod]
        public void Divisors()
        {
            Assert.AreEqual(new int[] { 3, 5 }, kyu6.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, kyu6.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, kyu6.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, kyu6.Divisors(24));
        }

    }
}