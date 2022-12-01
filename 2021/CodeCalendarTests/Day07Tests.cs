using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Helpers.Day6;
using CodeCelendar.Helpers.Day7;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day07Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("16,1,2,0,4,2,7,1,2,14", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(10, output.Length);
        }

        [TestMethod]
        public void Day7Part1()
        {
            string[] output = GetData();
            Day7 day = new Day7(output);

            Assert.AreEqual(37, day.GetSmallestPositionChange());
        }

        [TestMethod]
        public void Day7Part2()
        {
            string[] output = GetData();
            Day7 day = new Day7(output);

            Assert.AreEqual(168, day.GetSmallestPositionChange2());
        }


    }
}
