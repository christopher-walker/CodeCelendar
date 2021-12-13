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
    public class Day13Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("6,10|0,14|9,10|0,3|10,4|4,11|6,0|6,12|4,1|0,13|10,12|3,4|3,0|8,4|1,10|2,14|8,10|9,0||fold along y=7|fold along x=5", '|');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(21, output.Length);
        }

        [TestMethod]
        public void Day13Part1()
        {
            string[] output = GetData();
            Day13 day = new Day13(output);
            Assert.AreEqual(2, day.GetFolds());
            Assert.AreEqual(18, day.GetCoordinates());
            Assert.AreEqual("17", day.GetResultsPart1());

        }

        [TestMethod]
        public void Day13Part2()
        {
            string[] output = GetData();
            Day13 day = new Day13(output);
            Assert.AreEqual("#####\r\n#...#\r\n#...#\r\n#...#\r\n#####\r\n", day.GetResultsPart2());
        }


    }
}
