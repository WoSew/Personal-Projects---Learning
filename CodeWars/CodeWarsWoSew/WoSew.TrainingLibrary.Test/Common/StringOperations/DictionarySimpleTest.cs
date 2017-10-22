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
            Assert.IsTrue(DictionarySimple.Wildcard("maly", "malyTEST"));
            Assert.IsTrue(DictionarySimple.Wildcard("maly", "malyROWER"));
            Assert.IsTrue(DictionarySimple.Wildcard("maly", "maly123123123"));
            Assert.IsTrue(DictionarySimple.Wildcard("maly", "malysz"));

            Assert.IsFalse(DictionarySimple.Wildcard("maly", "duzymaly"));
            Assert.IsFalse(DictionarySimple.Wildcard("maly", "mal"));
            Assert.IsFalse(DictionarySimple.Wildcard("maly", ""));
           
        }
    }
}