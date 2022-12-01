using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day3;
using CodeCelendar.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCalendarTests
{
    [TestClass]
    public class Day03Tests
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
            Assert.AreEqual(16,bc.GetValue(1));
            Assert.AreEqual(8, bc.GetValue(2));
            Assert.AreEqual(4, bc.GetValue(3));
            Assert.AreEqual(2, bc.GetValue(4));
            Assert.AreEqual(1, bc.GetValue(5));
            Assert.AreEqual(0, bc.GetValue(6));
            Assert.AreEqual(-1, bc.GetSetting(6));

            Day3_BinaryCreator bca = new Day3_BinaryCreator("00000");
            Assert.AreEqual(0, bca.GetValue(1));
            Assert.AreEqual(0, bca.GetValue(2));
            Assert.AreEqual(0, bca.GetValue(3));
            Assert.AreEqual(0, bca.GetValue(4));
            Assert.AreEqual(0, bca.GetValue(5));
            Assert.AreEqual(0, bca.GetValue(6));
            Assert.AreEqual(-1, bca.GetSetting(6));
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