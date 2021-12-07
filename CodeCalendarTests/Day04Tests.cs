using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day4;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day04Tests
    {

        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("7,4,9,5,11,17,23,2,0,14,21,24,10,16,13,6,15,25,12,22,18,20,8,19,3,26,1||22 13 17 11  0| 8  2 23  4 24|21  9 14 16  7| 6 10  3 18  5| 1 12 20 15 19|| 3 15  0  2 22| 9 18 13 17  5|19  8  7 25 23|20 11 10 24  4|14 21 16 12  6||14 21 17 24  4|10 16 15  9 19|18  8 23 26 20|22 11 13  6  5| 2  0 12  3  7", '|');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateCard()
        {
            string[] output = GetData();
            Assert.AreEqual(output.Length, 19);
        }

        [TestMethod]
        public void CardResultCheck()
        {
            string[] output = GetData();
            Day4_Bingo bingo = new Day4_Bingo(output);
            Bingo_Card card = bingo.GetWinningCard();
            Assert.AreEqual(188, card.CalculateBordScore(false));
            Assert.AreEqual(24, bingo.GetLastCalledNumber());
            Assert.AreEqual(4512, card.CalculateBordScore(false) * bingo.GetLastCalledNumber());
        }

        [TestMethod]
        public void CardResultCheckLose()
        {
            string[] output = GetData();
            Day4_Bingo bingo = new Day4_Bingo(output);
            Bingo_Card card = bingo.GetLoosingCard();
            Assert.AreEqual(148, card.CalculateBordScore(false));
            Assert.AreEqual(13, bingo.GetLastCalledNumber());
            Assert.AreEqual(1924, card.CalculateBordScore(false) * bingo.GetLastCalledNumber());
        }
    }
}
