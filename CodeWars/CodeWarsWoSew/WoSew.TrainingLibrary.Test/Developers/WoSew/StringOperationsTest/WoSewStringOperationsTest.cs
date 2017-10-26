using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoSew.TrainingLibrary.Developers.WoSew.StringOperations;

namespace WoSew.TrainingLibrary.Test.Developers.WoSew.StringOperationsTest
{
    [TestClass]
    public class WoSewStringOperationsTest
    {
        [TestMethod]
        public void StringDictionary()
        {
            WoSewStringOperations<string> soData = new WoSewStringOperations<string>
            {
                {"AAAbbb", "1"},
                {"Kasia", "2"},
                {"asiak", "2"},
                {"Kaias", "2"},
                {"KaSii", "2.5"},
                {"123asd", "3"},
                {"zostaneJUNIORdevem", "4"},
                {"oko", "5"},
                {"kajak", "6"},
                {"123abccba321", "7"},
                {"malyTEST", "8"},
                {"malyROWER", "9"},
                {"maly123123123", "10"},
                {"malysz", "11"},
                {"duzymaly", "12"},
                {"mal", "13"}
            };

            Dictionary<string, int> blabla = new Dictionary<string, int>();

            Assert.AreEqual(3, soData.GetAnagramSet("kasia").Count);
            Assert.AreEqual(1, soData.GetAnagramSet("sda132").Count);
            Assert.AreEqual(1, soData.GetAnagramSet("DEVEMjuniorZostane").Count);
            Assert.AreEqual(0, soData.GetAnagramSet("kajak000").Count);

            Assert.AreEqual(3, soData.GetPalindromSet().Count);

            CollectionAssert.AreEqual(new List<string>{"8","9","10","11"}, soData.GetWildcardSet("maly"));
            
        }

    }
}