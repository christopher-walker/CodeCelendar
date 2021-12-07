using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day08;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Helpers.Day6;
using CodeCelendar.Helpers.Day7;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day08Tests
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
        public void Day8Part1()
        {
            string[] output = GetData();
            Day08 day = new Day08(output);

            
        }

        [TestMethod]
        public void Day8Part2()
        {
            string[] output = GetData();
            Day08 day = new Day08(output);

            
        }


    }
}
