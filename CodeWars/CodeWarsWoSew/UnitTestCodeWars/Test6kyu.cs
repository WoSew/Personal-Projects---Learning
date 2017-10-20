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
            Assert.AreEqual(3, Kyu6.Persistence(39)); // because 3*9 = 27, 2*7 = 14, 1*4=4
            Assert.AreEqual(0, Kyu6.Persistence(4)); // because 4 is already a one-digit number
            Assert.AreEqual(2, Kyu6.Persistence(25));
            Assert.AreEqual(4, Kyu6.Persistence(999)); // because 9*9*9 = 729, 7*2*9 = 126,
        }

        [TestMethod]
        public void Divisors()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Kyu6.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Kyu6.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Kyu6.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kyu6.Divisors(24));
        }

    }
}