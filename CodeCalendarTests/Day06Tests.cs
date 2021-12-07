using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Helpers.Day6;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day06Tests
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
        public void FishAfter18Days()
        {
            string[] output = GetData();
            Day6 lfClass = new Day6(output);
            lfClass.Breed(18);
            Assert.AreEqual(26, lfClass.GetNumberOfFish());
        }

        [TestMethod]
        public void FishAfter80Days()
        {
            string[] output = GetData();
            Day6 lfClass = new Day6(output);
            lfClass.Breed(80);
            Assert.AreEqual(5934, lfClass.GetNumberOfFish());
        }


        [TestMethod]
        public void FishAfter256Days()
        {
            string[] output = GetData();
            Day6 lfClass = new Day6(output);
            lfClass.Breed(256);
            Assert.AreEqual(26984457539, lfClass.GetNumberOfFish());

        }

    }
}
