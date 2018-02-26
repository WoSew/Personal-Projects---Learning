using System;
using CodeWars.Kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test5kyu
    {
        [TestMethod]
        public void ValidParentheses()
        {
            Assert.IsFalse(ValidParenthesesKyu5.ValidParentheses("To jest test () napiasow )(, ))) ((("));
            Assert.IsFalse(ValidParenthesesKyu5.ValidParentheses("To) jest test () napiasow )(, ))) ((()"));
            Assert.IsTrue(ValidParenthesesKyu5.ValidParentheses("()"));
            Assert.IsFalse(ValidParenthesesKyu5.ValidParentheses("))"));
        }

        [TestMethod]
        public void SimplePigLatin()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatinKyu5.SimplePigLatin("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatinKyu5.SimplePigLatin("This is my string"));
        }
    }
}