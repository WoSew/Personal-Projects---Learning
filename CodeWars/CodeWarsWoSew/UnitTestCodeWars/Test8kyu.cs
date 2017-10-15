using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test8kyu
    {
        [TestMethod]
        public void Digitize()
        {
            Assert.AreEqual(new long [] {1,3,2,5,3}, kyu8.Digitize(35231));
        }

        [TestMethod]
        public void Remove_char()
        {
           Assert.AreEqual("loquen",kyu8.Remove_char("eloquent"));
           Assert.AreEqual("ountr",kyu8.Remove_char("country"));
           Assert.AreEqual("erso", kyu8.Remove_char("person"));
           Assert.AreEqual("",kyu8.Remove_char("ok"));
         }

    }
}