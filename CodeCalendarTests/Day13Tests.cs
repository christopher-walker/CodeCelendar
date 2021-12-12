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
            IDataInput dataInput = new StringInput("fs-end,he-DX,fs-he,start-DX,pj-DX,end-zg,zg-sl,zg-pj,pj-he,RW-he,fs-DX,pj-RW,zg-RW,start-pj,he-WI,zg-he,pj-fs,start-RW", ',');
            return dataInput.GetData();
        }

        private string[] GetDataA()
        {
            IDataInput dataInput = new StringInput("start-A,start-b,A-c,A-b,b-d,A-end,b-end", ',');
            return dataInput.GetData();
        }

        private string[] GetDataB()
        {
            IDataInput dataInput = new StringInput("dc-end,HN-start,start-kj,dc-start,dc-HN,LN-dc,HN-end,kj-sa,kj-HN,kj-dc", ',');
            return dataInput.GetData();
        }

        [TestMethod]
        public void PopulateData()
        {
            string[] output = GetData();
            Assert.AreEqual(18, output.Length);
        }

        [TestMethod]
        public void Day13Part1()
        {
            string[] output = GetData();
            Day13 day = new Day13(output);
            //Assert.AreEqual("226", day.GetResultsPart1());

        }

        [TestMethod]
        public void Day13Part2()
        {
            string[] output = GetData();
            Day13 day = new Day13(output);
            //Assert.AreEqual("3509", day.GetResultsPart2());
        }


    }
}
