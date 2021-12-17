using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{

    public static class Day16Util
    {
        public static Dictionary<char, string> binaryConversion = new Dictionary<char, string>{
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'A', "1010" },
            { 'B', "1011" },
            { 'C', "1100" },
            { 'D', "1101" },
            { 'E', "1110" },
            { 'F', "1111" }
        };

        public enum PacketType
        {
            Sum = 0,
            Product = 1,
            Minumum = 2,
            Maximum = 3,
            LiteralValue = 4,
            GreaterThan = 5,
            LessThan = 6,
            EqualTo = 7
        }
    }
    public class Day16
    {
        public char[] hexChars;
        public Day16(string[] input)
        {
            hexChars = input[0].ToUpper().ToCharArray();
        }

        public string ConvertHexToBinary(char[] hexChars)
        {
            string returnValue = string.Empty;
            for(int i = 0; i < hexChars.Length; i++)
            {
                returnValue += Day16Util.binaryConversion[hexChars[i]];
            }
            return returnValue;
        }

        public int GetPacketVersion(string packet)
        {
            return Convert.ToInt32(packet.Substring(0, 3), 2);
        }

        public int GetPackageTypeId(string packet)
        {
            return Convert.ToInt32(packet.Substring(3, 3), 2);
        }

        //public LiteralInstruction GetLiteralInstruction(string packet)
        //{
        //    return new LiteralInstruction(packet);
        //}

        public bool IsOperator(int packetTypeId)
        {
            return packetTypeId == (int)Day16Util.PacketType.LiteralValue;
        }

        public string[] GetGroups(string packet, int start = 6, int length = 5)
        {
            List<string> returnValue = new List<string>();
            string firstValue = "1";
            while(firstValue == "1")
            {
                string group = packet.Substring(start, length);
                firstValue = group.Substring(0, 1);
                returnValue.Add(group.Substring(1, 4));
                start += length;
            }
            return returnValue.ToArray();
        }
    }

    public class Instruction
    {
        public string initialInstruction = string.Empty;
        public Day16Util.PacketType type;
        public int version;
        string remainingString;
        int totalLengthOfString = 0;

        List<Instruction> subInstructions = new List<Instruction>();
        public Instruction(string instructionInput)
        {
            initialInstruction = instructionInput;
            GetPackageTypeId();
            GetPacketVersion();
            if (type == Day16Util.PacketType.LiteralValue)
            {
                string[] groups = GetGroups(initialInstruction);
                totalLengthOfString = 6 + (groups.Length * 5);
            }
            else
            {
                ProcessSubPackets();
            }
        }
        
        public long Calculate()
        {
            long returnValue = -1;
            switch (type)
            {
                case Day16Util.PacketType.LiteralValue:
                    returnValue = GetGroupValue();
                    break;
                case Day16Util.PacketType.Sum:
                    returnValue = subInstructions.Sum(x => x.Calculate());
                    break;
                case Day16Util.PacketType.Product:
                    returnValue = GetProductOfChildren();
                    break;
                case Day16Util.PacketType.Minumum:
                    returnValue = subInstructions.Min(x => x.Calculate());
                    break;
                case Day16Util.PacketType.Maximum:
                    returnValue = subInstructions.Max(x => x.Calculate());
                    break;
                case Day16Util.PacketType.LessThan:
                    returnValue = subInstructions[0].Calculate() < subInstructions[1].Calculate() ? 1 : 0;
                    break;
                case Day16Util.PacketType.GreaterThan:
                    returnValue = subInstructions[0].Calculate() > subInstructions[1].Calculate() ? 1 : 0;
                    break;
                case Day16Util.PacketType.EqualTo:
                    returnValue = subInstructions[0].Calculate() == subInstructions[1].Calculate() ? 1 : 0;
                    break;
                default:
                    break;
            }
            return returnValue;
        }
        public long GetProductOfChildren()
        {
            long returnValue = -1;
            for (int i = 0; i < subInstructions.Count; i++)
            {
                if (returnValue < 0)
                {
                    returnValue = subInstructions[i].Calculate();
                }
                else
                {
                    returnValue = returnValue * subInstructions[i].Calculate();
                }
                
            }
            return returnValue;
        }

        void GetPackageTypeId()
        {
            type = (Day16Util.PacketType)Convert.ToInt32(initialInstruction.Substring(3, 3), 2);
        }

        void GetPacketVersion()
        {
            version = Convert.ToInt32(initialInstruction.Substring(0, 3), 2);
        }

        public int GetLengthType()
        {
            return int.Parse(initialInstruction.Substring(6, 1));
        }

        public string GetRemainingString()
        {
            if (string.IsNullOrEmpty(remainingString))
            {
                remainingString = initialInstruction.Substring(totalLengthOfString);
            }
            return remainingString;
        }

        public void ProcessSubPackets()
        {
            if (GetLengthType() == 0)
            {
                // If the length type ID is 0, then the next 15 bits are a number that represents the total length in bits of the sub-packets contained by this packet.
                int following = 15;
                int LengthOfAllSubPackets = Convert.ToInt32(initialInstruction.Substring(7, following), 2);
                totalLengthOfString = 7 + following + LengthOfAllSubPackets;
                remainingString = initialInstruction.Substring(totalLengthOfString);
                if (string.IsNullOrEmpty(remainingString) || !remainingString.Contains("1"))
                {
                    totalLengthOfString = initialInstruction.Length;
                }
                ProcessSubPacketsByTotalLength(7 + following, LengthOfAllSubPackets);
            }
            else
            {
                // If the length type ID is 1, then the next 11 bits are a number that represents the number of sub-packets immediately contained by this packet.
                int following = 11;
                int numberOfSubPackets = Convert.ToInt32(initialInstruction.Substring(7, following), 2);
                ProcessSubPacketsByNumberOfPackets(numberOfSubPackets, 7 + following);
            }
        }

        private void ProcessSubPacketsByTotalLength(int startPosition, int endPosition)
        {
            string toBeProcessed = initialInstruction.Substring(startPosition, endPosition);
            // Handles the rubbish 0000's at the end of the string
            while (toBeProcessed.Contains("1"))
            {
                Instruction newInstruction = new Instruction(toBeProcessed);
                int subInstuctionCount = newInstruction.subInstructions.Count();
                toBeProcessed = newInstruction.GetRemainingString();
                subInstructions.Add(newInstruction);
            }
        }

        private void ProcessSubPacketsByNumberOfPackets(int numberOfPackets, int startPosition)
        {
            string toBeProcessed = initialInstruction.Substring(startPosition);
            for(int i = 0; i < numberOfPackets; i++)
            {
                Instruction newInstruction = new Instruction(toBeProcessed);
                toBeProcessed = newInstruction.GetRemainingString();
                if (string.IsNullOrEmpty(toBeProcessed))
                {
                    i = numberOfPackets;
                }
                subInstructions.Add(newInstruction);
                
            }
            if (string.IsNullOrEmpty(toBeProcessed) && totalLengthOfString == 0)
            {
                totalLengthOfString = initialInstruction.Length;
            }
            else
            {
                remainingString = toBeProcessed;
            }
        }
        
        public long GetGroupValue()
        {
            string[] groups = GetGroups(initialInstruction);
            string binary = string.Empty;
            foreach (string group in groups)
            {
                binary += group;
            }
            return Convert.ToInt64(binary, 2);
        }
        private string[] GetGroups(string packet, int start = 6, int length = 5)
        {
            List<string> returnValue = new List<string>();
            string firstValue = "1";
            while (firstValue == "1")
            {
                string group = packet.Substring(start, length);
                firstValue = group.Substring(0, 1);
                returnValue.Add(group.Substring(1, 4));
                start += length;
            }
            return returnValue.ToArray();
        }

        public int GetTotalVersionNumber()
        {
            int returnValue = version;
            foreach(Instruction instruction in subInstructions)
            {
                returnValue += instruction.GetTotalVersionNumber();
            }
            return returnValue;
        }
    }
}