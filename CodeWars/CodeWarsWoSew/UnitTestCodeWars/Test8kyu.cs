using System.Collections.Generic;
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

        [TestMethod]
        public void NumberOfPeopleInTheBus()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, NumberOfPeopleInTheBusKyu8.NumberOfPeopleInTheBus(peopleList));

            List<int[]> peopleList2 = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, NumberOfPeopleInTheBusKyu8.NumberOfPeopleInTheBus(peopleList2));

            List<int[]> peopleList3 = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Assert.AreEqual(21, NumberOfPeopleInTheBusKyu8.NumberOfPeopleInTheBus(peopleList3));
        }

        [TestMethod]
        public void NumberOfPeopleInTheBusLinq()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, NumberOfPeopleInTheBusKyu8.NumberOfPeopleInTheBusLinq(peopleList));

            List<int[]> peopleList2 = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, NumberOfPeopleInTheBusKyu8.NumberOfPeopleInTheBusLinq(peopleList2));

            List<int[]> peopleList3 = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Assert.AreEqual(21, NumberOfPeopleInTheBusKyu8.NumberOfPeopleInTheBusLinq(peopleList3));
        }

        [TestMethod]
        public void OppositeNumber()
        {
            Assert.AreEqual(-1, OppositeNumberKyu8.Opposite(1));
        }

    }
}