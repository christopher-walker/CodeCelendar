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
    public class Day7Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("3,4,3,1,2", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(5, output.Length);
        }

        [TestMethod]
        public void Day7Part1()
        {
            string[] output = GetData();
            Day7 day = new Day7(output);

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Day7Part2()
        {
            string[] output = GetData();
            Day7 day = new Day7(output);

            Assert.AreEqual(1, 1);
        }


    }
}
