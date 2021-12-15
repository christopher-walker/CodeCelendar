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
    public class Day14Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("NNCB,,CH -> B,HH -> N,CB -> H,NH -> C,HB -> C,HC -> B,HN -> C,NN -> C,BH -> H,NC -> B,NB -> B,BN -> B,BB -> N,BC -> B,CC -> N,CN -> C", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(18, output.Length);
        }

        [TestMethod]
        public void Day14Part1()
        {
            string[] output = GetData();
            Day14 day = new Day14(output);
            Assert.AreEqual("1588", day.GetResultsPart1());
        }

        [TestMethod]
        public void Day14Part1MethodB()
        {
            string[] output = GetData();
            Day14b day = new Day14b(output);
            Assert.AreEqual("1588", day.GetResultsPart1());
        }

        [TestMethod]
        public void Day14Part2()
        {
            string[] output = GetData();
            Day14b day = new Day14b(output);
            Assert.AreEqual("2188189693529", day.GetResultsPart2());
        }


    }
}
