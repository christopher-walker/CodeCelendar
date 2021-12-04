using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day3;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        public void TestCorrectNumberOfColumns()
        {
            IDataInput dataInput = new StringInput("00100,11110,10110,10111,10101,01111,00111,11100,10000,11001,00010,01010");
            string[] output = dataInput.GetData();
            Assert.AreEqual(output.Length, 12);
        }

        [TestMethod]
        public void TestBinaryCreator()
        {
            Day3_BinaryCreator bc = new Day3_BinaryCreator("11111");
            Assert.AreEqual(bc.GetValue(1), 1);
            Assert.AreEqual(bc.GetValue(2), 2);
            Assert.AreEqual(bc.GetValue(3), 4);
            Assert.AreEqual(bc.GetValue(4), 8);
            Assert.AreEqual(bc.GetValue(5), 16);
            Assert.AreEqual(bc.GetValue(6), -1);

            Day3_BinaryCreator bca = new Day3_BinaryCreator("00000");
            Assert.AreEqual(bca.GetValue(1), 0);
            Assert.AreEqual(bca.GetValue(2), 0);
            Assert.AreEqual(bca.GetValue(3), 0);
            Assert.AreEqual(bca.GetValue(4), 0);
            Assert.AreEqual(bca.GetValue(5), 0);
            Assert.AreEqual(bca.GetValue(6), -1);
        }

        [TestMethod]
        public void Day3_BinaryHandlerTests()
        {
            IDataInput dataInput = new StringInput("00100,11110,10110,10111,10101,01111,00111,11100,10000,11001,00010,01010");
            // IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day3.txt");
            string[] output = dataInput.GetData();
            Day3_BinaryHandler bh = new Day3_BinaryHandler(output);
            
            Assert.AreEqual(bh.GetGammaRateString(), "10110");
            Assert.AreEqual(bh.GetGammaRateValue(), 22);

            Assert.AreEqual(bh.GetEpsilonRateString(), "01001");
            Assert.AreEqual(bh.GetEpsilonRateValue(), 9);

            Assert.AreEqual(bh.GetPowerConsumption(), 198);

            Assert.AreEqual(bh.GetOxygenRateString(), "10111");
            Assert.AreEqual(bh.GetOxygenRateValue(), 23);

            Assert.AreEqual(bh.GetCO2RateString(), "01010");
            Assert.AreEqual(bh.GetCO2RateValue(), 10);

            // GetLifeSupportRating()
            Assert.AreEqual(bh.GetLifeSupportRating(), 230);
        }
    }
}