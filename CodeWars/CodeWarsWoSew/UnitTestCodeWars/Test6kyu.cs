using System.Collections.Generic;
using CodeWars.Kyu6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test6kyu
    {
        [TestMethod]
        public void PersistentBugger()
        {
            Assert.AreEqual(3, PersistenceKyu6.Persistence(39)); // because 3*9 = 27, 2*7 = 14, 1*4=4
            Assert.AreEqual(0, PersistenceKyu6.Persistence(4)); // because 4 is already a one-digit number
            Assert.AreEqual(2, PersistenceKyu6.Persistence(25));
            Assert.AreEqual(4, PersistenceKyu6.Persistence(999)); // because 9*9*9 = 729, 7*2*9 = 126,
        }

        [TestMethod]
        public void Divisors()
        {
            CollectionAssert.AreEqual(new int[] { 3, 5 }, DivisorsKyu6.Divisors(15));
            CollectionAssert.AreEqual(new int[] { 2, 4, 8 }, DivisorsKyu6.Divisors(16));
            CollectionAssert.AreEqual(new int[] { 11, 23 }, DivisorsKyu6.Divisors(253));
            CollectionAssert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, DivisorsKyu6.Divisors(24));
        }

        [TestMethod]
        public void TribonacciSequence()
        {
            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 1, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 0, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0 }, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 0, 19, 5 }, 0));
            CollectionAssert.AreEqual(new double[] { 1 }, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 1, 1, 1 }, 1));
            CollectionAssert.AreEqual(new double[] { 1, 2 }, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 1, 2, 3 }, 2));
            CollectionAssert.AreEqual(new double[] { 1, 2, 3}, TribonacciSequenceKyu6.TribonacciSequence(new double[] { 1, 2, 3 }, 3));

        }

        [TestMethod]
        public void TribonacciSequenceRefactoring()
        {
            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 1, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 0, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 0, 19, 5 }, 0));
            CollectionAssert.AreEqual(new double[] { 1 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 1, 1, 1 }, 1));
            CollectionAssert.AreEqual(new double[] { 1, 2 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 1, 2, 3 }, 2));
            CollectionAssert.AreEqual(new double[] { 1, 2, 3 }, TribonacciSequence2Kyu6.TribonacciSequenceRefactiring(new double[] { 1, 2, 3 }, 3));
        }

        [TestMethod]
        public void UniqueInOrder()
        {
            CollectionAssert.AreEqual(new List<double> { 1.1, 2.2, 3.3 }, UniqueInOrderKyu6.UniqueInOrder(new List<double> { 1.1, 2.2, 2.2, 3.3 }));
        }

        [TestMethod]
        public void FindTheOddInt()
        {
            Assert.AreEqual(5,FindTheOddIntKyu6.FindTheOddInt(new[] { 20, 20, 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

    }
}