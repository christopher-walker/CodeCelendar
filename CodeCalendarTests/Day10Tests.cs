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
    public class Day10Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("2199943210,3987894921,9856789892,8767896789,9899965678", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(5, output.Length);
        }

        [TestMethod]
        public void Day10Part1()
        {
            string[] output = GetData();
            Day10 day = new Day10(output);
            Assert.AreEqual(string.Empty, day.GetResultsPart1());

        }

        [TestMethod]
        public void Day10Part2()
        {
            string[] output = GetData();
            Day10 day = new Day10(output);
            Assert.AreEqual(string.Empty, day.GetResultsPart2());
        }


    }
}
