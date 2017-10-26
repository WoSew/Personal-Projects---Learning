using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoSew.TrainingLibrary.Common.StringOperations;

namespace WoSew.TrainingLibrary.Test.Common.StringOperations
{
    [TestClass]
    public class DictionarySimpleTest
    {
        [TestMethod]
        public void IsAnagram()
        {
            Assert.IsTrue(DictionarySimple.IsAnagram("AAAbbb", "aaBBBa"));
            Assert.IsTrue(DictionarySimple.IsAnagram("Kasia", "SIaak"));
            Assert.IsTrue(DictionarySimple.IsAnagram("123asd", "sda132"));
            Assert.IsTrue(DictionarySimple.IsAnagram("zostaneJUNIORdevem", "DEVEMjuniorZostane"));
        }

        [TestMethod]
        public void IsPalindrom()
        {
            Assert.IsTrue(DictionarySimple.IsPalindrome("oko"));
            Assert.IsTrue(DictionarySimple.IsPalindrome("kajak"));
            Assert.IsTrue(DictionarySimple.IsPalindrome("123abccba321"));
            Assert.IsFalse(DictionarySimple.IsPalindrome("AAABBBCCC"));
        }

        [TestMethod]
        public void Wildcard()
        {
            Assert.IsTrue(DictionarySimple.Wildcard("malyTEST", "maly"));
            Assert.IsTrue(DictionarySimple.Wildcard("malyROWER", "maly"));
            Assert.IsTrue(DictionarySimple.Wildcard("maly123123123", "maly"));
            Assert.IsTrue(DictionarySimple.Wildcard("malysz", "maly"));

            Assert.IsFalse(DictionarySimple.Wildcard("duzymaly", "maly"));
            Assert.IsFalse(DictionarySimple.Wildcard("mal", "maly"));
            Assert.IsFalse(DictionarySimple.Wildcard("", "maly"));
           
        }
    }
}