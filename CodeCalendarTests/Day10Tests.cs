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
        public void Day10Part1()
        {
            string[] output = GetData();
            Day10 day = new Day10(output);
            Assert.AreEqual("26397", day.GetResultsPart1());

        }

        [TestMethod]
        public void Day10Part2()
        {
            string[] output = GetData();
            Day10 day = new Day10(output);
            Assert.AreEqual("288957", day.GetResultsPart2());
        }


    }
}
