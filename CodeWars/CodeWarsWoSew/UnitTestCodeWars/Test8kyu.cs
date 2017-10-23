using CodeWars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test8kyu
    {


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