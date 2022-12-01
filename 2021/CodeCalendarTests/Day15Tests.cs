using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day08;
using CodeCelendar.Helpers.Day09;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Helpers.Day6;
using CodeCelendar.Helpers.Day7;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day15Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("1163751742,1381373672,2136511328,3694931569,7463417111,1319128137,1359912421,3125421639,1293138521,2311944581", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(10, output.Length);
        }

        [TestMethod]
        public void Day15Part1()
        {
            string[] output = GetData();
            Day15 day = new Day15(output);
            Assert.AreEqual("40", day.GetResultsPart1());
        }

        [TestMethod]
        public void Day15Part2()
        {
            string[] output = GetData();
            Day15 day = new Day15(output);
            Assert.AreEqual("315", day.GetResultsPart2());
        }


    }
}
