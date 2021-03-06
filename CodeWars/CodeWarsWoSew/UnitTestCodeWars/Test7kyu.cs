﻿using System;
using System.Collections.Generic;
using CodeWars.Kyu7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCodeWars
{
    [TestClass]
    public class Test7kyu
    {

        [TestMethod]
        public void TestPrinterError()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            PrinterErrorKyu7.PrinterError(s);
            Assert.AreEqual("3/56", PrinterErrorKyu7.PrinterError(s));
        }

        [TestMethod]
        public void NbDig()
        {
            Assert.AreEqual(NbDigKyu7.NbDig(5750, 0), 4700);
            Assert.AreEqual(NbDigKyu7.NbDig(12224, 8), 7733);
            Assert.AreEqual(NbDigKyu7.NbDig(11549, 1), 11905);
            Assert.AreEqual(NbDigKyu7.NbDig(11011, 2), 9481);
        }

        [TestMethod]
        public void Calc()
        {
            //implementation with:

            //for loop
            Assert.AreEqual(31, CalcKyu7.Calc(new[] {0, 2, 1, -6, -3, 3}));
            Assert.AreEqual(0, CalcKyu7.Calc(new[] {0}));
            Assert.AreEqual(5, CalcKyu7.Calc(new[] {1,1,1,1,1}));

            //linq
            Assert.AreEqual(31, CalcLinqKyu7.CalcLinq(new[] { 0, 2, 1, -6, -3, 3 }));
            Assert.AreEqual(0, CalcLinqKyu7.CalcLinq(new[] { 0 }));
            Assert.AreEqual(5, CalcLinqKyu7.CalcLinq(new[] { 1, 1, 1, 1, 1 }));

        }

        [TestMethod]
        public void SortByLength()
        {
            CollectionAssert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, SortByLengthKyu7.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
            CollectionAssert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, SortByLengthKyu7.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
            CollectionAssert.AreEqual(new string[] { "Short", "Longer", "Longest" }, SortByLengthKyu7.SortByLength(new string[] { "Longer", "Longest", "Short" }));
        }

        [TestMethod]
        public void CountingArrayElements()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "a", 2 }, { "b", 3 } }, CountingArrayElementsKyu7.CountingArrayElements(new List<string> { "a", "b", "b", "a", "b" }));
        }

        [TestMethod]
        public void SumDigits()
        {
            Assert.AreEqual(5, SumDigitsKyu7.SumDigits(32));
            Assert.AreEqual(12, SumDigitsKyu7.SumDigits(75));
            Assert.AreEqual(5, SumDigitsKyu7.SumDigits(-32));
            Assert.AreEqual(1, SumDigitsKyu7.SumDigits(100));
        }

        [TestMethod]
        public void RverseStringsLinq()
        {
            Assert.AreEqual("dlrow", ReversedStringsKyu7.ReversedStringsLinq("world"));
        }

        [TestMethod]
        public void RverseStringsLoop()
        {
            Assert.AreEqual("dlrow", ReversedStringsKyu7.ReversedStringsLoop("world"));
        }

        [TestMethod]
        public void SumOfArraySingles()
        {
            Assert.AreEqual(15, SumOfArraySinglesKyu7.SumOfArraySingles(new List<int>{ 4, 5, 7, 5, 4, 8 }));
            Assert.AreEqual(19, SumOfArraySinglesKyu7.SumOfArraySingles(new List<int> { 9, 10, 19, 13, 19, 13 }));
            Assert.AreEqual(12, SumOfArraySinglesKyu7.SumOfArraySingles(new List<int> { 16, 0, 11, 4, 8, 16, 0, 11 }));
            Assert.AreEqual(22, SumOfArraySinglesKyu7.SumOfArraySingles(new List<int> { 5, 17, 18, 11, 13, 18, 11, 13 }));
            Assert.AreEqual(24, SumOfArraySinglesKyu7.SumOfArraySingles(new List<int> { 5, 10, 19, 13, 10, 13 }));
        }

        [TestMethod]
        public void LoveVsFriendship()
        {
            Assert.AreEqual(100, LoveVsFriendshipKyu7.LoveVeFriendshipLinq("attitude"));
            Assert.AreEqual(75, LoveVsFriendshipKyu7.LoveVsFriendship("friends"));
            Assert.AreEqual(66, LoveVsFriendshipKyu7.LoveVsFriendship("family"));
            Assert.AreEqual(99, LoveVsFriendshipKyu7.LoveVsFriendship("selfness"));
            Assert.AreEqual(96, LoveVsFriendshipKyu7.LoveVsFriendship("knowledge"));
        }

        [TestMethod]
        public void StringEndWith()
        {
            Assert.AreEqual(true, StringEndsWithKyu7.StringEndWith("SewerynWojciech", "Wojciech"));
            Assert.AreEqual(false, StringEndsWithKyu7.StringEndWith("SewerynWojciech", "Seweryn"));
        }

        [TestMethod]
        public void StringEndWithSecond()
        {
            Assert.AreEqual(true, StringEndsWithKyu7.StringEndWithSecond("SewerynWojciech", "Wojciech"));
            Assert.AreEqual(false, StringEndsWithKyu7.StringEndWithSecond("SewerynWojciech", "Seweryn"));
        }

        [TestMethod]
        public void GetTHeMiddleCharacter()
        {
            Assert.AreEqual("es", GetTheMiddleCharacterKyu7.GetMiddle("test"));
            Assert.AreEqual("t", GetTheMiddleCharacterKyu7.GetMiddle("testing"));
            Assert.AreEqual("dd", GetTheMiddleCharacterKyu7.GetMiddle("middle"));
            Assert.AreEqual("A", GetTheMiddleCharacterKyu7.GetMiddle("A"));
        }

        [TestMethod]
        public void Accum()
        {
            Assert.AreEqual(MumbligKyu7.Accum("abcd"), "A-Bb-Ccc-Dddd");
            Assert.AreEqual(MumbligKyu7.Accum("RqaEzty"), "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy");
            Assert.AreEqual(MumbligKyu7.Accum("ZpglnRxqenU"), "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
            Assert.AreEqual(MumbligKyu7.Accum("NyffsGeyylB"), "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
            Assert.AreEqual(MumbligKyu7.Accum("MjtkuBovqrU"), "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
            Assert.AreEqual(MumbligKyu7.Accum("EvidjUnokmM"), "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
            Assert.AreEqual(MumbligKyu7.Accum("HbideVbxncC"), "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
        }

        [TestMethod]
        public void DescendingOrder()
        {
            Assert.AreEqual(0, DescendingOrderKyu7.DescendingOrder(0));
        }

        [TestMethod]
        public void HighestAndLowestNumbersTest()
        {
            Assert.AreEqual("42 -9", HighestAndLowestKyu7.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

        }
    }
}