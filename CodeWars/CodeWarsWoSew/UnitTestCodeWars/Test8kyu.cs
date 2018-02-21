using CodeWars;
using CodeWars.Kyu8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test8kyu
    {


        [TestMethod]
        public void Remove_char()
        {
           Assert.AreEqual("loquen", RemoveCharKyu8.RemoveChar("eloquent"));
           Assert.AreEqual("ountr", RemoveCharKyu8.RemoveChar("country"));
           Assert.AreEqual("erso", RemoveCharKyu8.RemoveChar("person"));
           Assert.AreEqual("", RemoveCharKyu8.RemoveChar("ok"));
         }

    }
}