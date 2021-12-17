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
    public class Day16Tests
    {
        private string[] GetDataA()
        {
            IDataInput dataInput = new StringInput("D2FE28", ',');
            return dataInput.GetData();
        }

        private string[] GetDataB()
        {
            IDataInput dataInput = new StringInput("38006F45291200", ',');
            return dataInput.GetData();
        }

        //private string[] GetDataB()
        //{
        //    IDataInput dataInput = new StringInput("VVVTTTILLLLLLLLLLLLLLLAAAAAAAAAAABBBBBBBBBBBBBBBB", ',');
        //    return dataInput.GetData();
        //}

        //private string[] GetDataC()
        //{
        //    IDataInput dataInput = new StringInput("VVVTTTILLLLLLLLLLLAAAAAAAAAAABBBBBBBBBBBCCCCCCCCCCC", ',');
        //    return dataInput.GetData();
        //}

        //[TestMethod]
        //public void OperationalInstruction()
        //{
        //    OperationInstruction inst = new OperationInstruction("11101110000000001101010000001100100000100011000001100000");
        //    Assert.AreEqual(3, inst.NumberOfSubPackets());

        //    OperationInstruction inst2 = new OperationInstruction("00111000000000000110111101000101001010010001001000000000");
        //    Assert.AreEqual(27, inst2.NumberOfSubPackets());
        //}

        [TestMethod]
        public void TestingPart2()
        {
            Day16 day = new Day16("C200B40A82".Split(','));
            string binary = day.ConvertHexToBinary(day.hexChars);

            Instruction instruction = new Instruction(binary);
            Assert.AreEqual(3, instruction.Calculate());

            // 04005AC33890
            day = new Day16("04005AC33890".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(54, instruction.Calculate());


            // 880086C3E88112
            day = new Day16("880086C3E88112".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(7, instruction.Calculate());

            // CE00C43D881120
            day = new Day16("CE00C43D881120".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(9, instruction.Calculate());


            // D8005AC2A8F0
            day = new Day16("D8005AC2A8F0".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(1, instruction.Calculate());

            // F600BC2D8F
            day = new Day16("F600BC2D8F".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(0, instruction.Calculate());

            // 9C005AC2F8F0
            day = new Day16("9C005AC2F8F0".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(0, instruction.Calculate());

            // 9C0141080250320F1802104A08
            day = new Day16("9C0141080250320F1802104A08".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(1, instruction.Calculate());

        }

        [TestMethod]
        public void TestingPart1()
        {
            //Day16 sixteen = new Day16("8A004A801A8002F478".Split(','));
            //string binary = sixteen.ConvertHexToBinary(sixteen.hexChars);

            //OperationInstruction inst = new OperationInstruction(binary);
            //string subPackets = inst.GetSubPackets();

            //OperationInstruction inst2 = new OperationInstruction(subPackets);
            //string subSub = inst2.GetSubPackets();


            //Day16 sixteen = new Day16("C0015000016115A2E0802F182340".Split(','));
            //string binary = sixteen.ConvertHexToBinary(sixteen.hexChars);

            //OperationInstruction inst = new OperationInstruction(binary);
            //string subPackets = inst.GetSubPackets();

            //OperationInstruction inst2 = new OperationInstruction(subPackets);
            //string subSub = inst2.GetSubPackets();

            Day16 day = new Day16("A0016C880162017C3686B18A3D4780".Split(','));
            string binary = day.ConvertHexToBinary(day.hexChars);

            Instruction instruction = new Instruction(binary);
            Assert.AreEqual(31, instruction.GetTotalVersionNumber());

            day = new Day16("C0015000016115A2E0802F182340".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(23, instruction.GetTotalVersionNumber());


            day = new Day16("620080001611562C8802118E34".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(12, instruction.GetTotalVersionNumber());

            day = new Day16("8A004A801A8002F478".Split(','));
            binary = day.ConvertHexToBinary(day.hexChars);

            instruction = new Instruction(binary);
            Assert.AreEqual(16, instruction.GetTotalVersionNumber());

            //Puzzle16 puzzel = new Puzzle16("C0015000016115A2E0802F182340");
            //puzzel.Setup();
        }

        // A0016C880162017C3686B18A3D4780

        [TestMethod]
        public void PopulateDataA()
        {
            string[] output = GetDataA();
            Assert.AreEqual(1, output.Length);
            Day16 day = new Day16(output);
            string packet = day.ConvertHexToBinary(day.hexChars);
            Assert.AreEqual("110100101111111000101000", packet);
            Assert.AreEqual(6, day.GetPacketVersion(packet));
            Assert.AreEqual(4, day.GetPackageTypeId(packet));
            Assert.AreEqual(true, day.IsOperator(day.GetPackageTypeId(packet)));
            string[] groups = day.GetGroups(packet);
            Assert.AreEqual(3, groups.Length);
            Assert.AreEqual("0111", groups[0]);
            Assert.AreEqual("1110", groups[1]);
            Assert.AreEqual("0101", groups[2]);

            //LiteralInstruction instruction = day.GetLiteralInstruction(packet);
            //Assert.AreEqual(day.GetPacketVersion(packet), instruction.version);
            //Assert.AreEqual(day.GetPackageTypeId(packet), instruction.type);
            //Assert.AreEqual(2021, instruction.GetValue());
        }

        [TestMethod]
        public void PopulateDataB()
        {
            string[] output = GetDataB();
            Assert.AreEqual(1, output.Length);
            Day16 day = new Day16(output);
            string packet = day.ConvertHexToBinary(day.hexChars);
            Assert.AreEqual("00111000000000000110111101000101001010010001001000000000", packet);
            Assert.AreEqual(1, day.GetPacketVersion(packet));
            Assert.AreEqual(6, day.GetPackageTypeId(packet));
        }

        [TestMethod]
        public void Day16Part1()
        {
            string[] output = GetDataA();
            Day16 day = new Day16(output);
            //Assert.AreEqual("40", day.GetResultsPart1());
        }

        [TestMethod]
        public void Day16Part2()
        {
            string[] output = GetDataA();
            Day16 day = new Day16(output);
            //Assert.AreEqual("315", day.GetResultsPart2());
        }


    }
}
