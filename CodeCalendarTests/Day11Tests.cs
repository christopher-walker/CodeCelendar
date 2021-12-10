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
    public class Day11Tests
    {
        private string[] GetData()
        {
            IDataInput dataInput = new StringInput("[({(<(())[]>[[{[]{<()<>>,[(()[<>])]({[<{<<[]>>(,{([(<{}[<>[]}>{[]{[(<()>,(((({<>}<{<{<>}{[]{[]{},[[<[([]))<([[{}[[()]]],[{[{({}]{}}([{[{{{}}([],{<[[]]>}<{[{[{[]{()[[[],[<(<(<(<{}))><([]([](),<{([([[(<>()){}]>(<<{{,<{([{{}}[<[[[<>{}]]]>[]]", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(10, output.Length);
        }

        [TestMethod]
        public void Day11Part1()
        {
            string[] output = GetData();
            Day11 day = new Day11(output);
            Assert.AreEqual("", day.GetResultsPart1());

        }

        [TestMethod]
        public void Day11Part2()
        {
            string[] output = GetData();
            Day11 day = new Day11(output);
            Assert.AreEqual("", day.GetResultsPart2());
        }


    }
}
