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
            Assert.AreEqual(new long [] {1,3,2,5,3}, Kyu8.Digitize(35231));
        }

        [TestMethod]
        public void Remove_char()
        {
           Assert.AreEqual("loquen",Kyu8.Remove_char("eloquent"));
           Assert.AreEqual("ountr",Kyu8.Remove_char("country"));
           Assert.AreEqual("erso", Kyu8.Remove_char("person"));
           Assert.AreEqual("",Kyu8.Remove_char("ok"));
         }

    }
}