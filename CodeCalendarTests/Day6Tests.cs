using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day6Tests
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
            
        }

        
        [TestMethod]
        public void Day5Part2Test()
        {
            string[] output = GetData();
            
        }

    }
}
