using System;
using BecomingDev.Algorithmics;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class StringOperation2Tests
    {
        [Test]
        public void IsPalindromShoudSucceed()
        {
            var palindrome = StringOperations2.IsPalindrom("Oko");
            Assert.IsTrue(palindrome);
        }

        [Test]
        public void ISAnagramShoudSucceed()
        {
            var anagram = StringOperations2.IsAnagram("kotek", "kkote");
            Assert.IsTrue(anagram);
        }

        [Test]
        public void PowerOfIntShouldGiveCorrectValue()
        {
            StringOperations2.PowerInt(6);
        }

        [Test]
        public void WordCountsTest()
        {
            string stringCandidate = "ala ma kota ma";

            var dictionary = StringOperations2.WordCounts(stringCandidate);

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}