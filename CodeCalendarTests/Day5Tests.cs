using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day5Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("0,9 -> 5,9|8,0 -> 0,8|9,4 -> 3,4|2,2 -> 2,1|7,0 -> 7,4|6,4 -> 2,0|0,9 -> 2,9|3,4 -> 1,4|0,0 -> 8,8|5,5 -> 8,2", '|');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(10, output.Length);
        }

        [TestMethod]
        public void Day5Part1Test()
        {
            string[] output = GetData();
            Day5_HydroVents day = new Day5_HydroVents(output);
            Assert.AreEqual(5, day.GetOverlaps(2));
            //Bingo_Card card = bingo.GetWinningCard();
            //Assert.AreEqual(188, card.CalculateBordScore(false));
            //Assert.AreEqual(24, bingo.GetLastCalledNumber());
            //Assert.AreEqual(4512, card.CalculateBordScore(false) * bingo.GetLastCalledNumber());
        }

        // CalculateLinePointsAllDirections()
        [TestMethod]
        public void Day5Part2Test()
        {
            string[] output = GetData();
            Day5_HydroVents day = new Day5_HydroVents(output);
            Assert.AreEqual(12, day.GetOverlapsAllDirections(2));
            //Bingo_Card card = bingo.GetWinningCard();
            //Assert.AreEqual(188, card.CalculateBordScore(false));
            //Assert.AreEqual(24, bingo.GetLastCalledNumber());
            //Assert.AreEqual(4512, card.CalculateBordScore(false) * bingo.GetLastCalledNumber());
        }

    }
}
