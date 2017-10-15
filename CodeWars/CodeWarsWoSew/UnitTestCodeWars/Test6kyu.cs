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


    }
}