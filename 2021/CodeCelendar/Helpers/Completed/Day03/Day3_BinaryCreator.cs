using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day3
{

    public class Day3_BinaryHandler
    {
        List<Day3_BinaryCreator> binaryValues = new List<Day3_BinaryCreator>();
        public Day3_BinaryHandler(string[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                binaryValues.Add(new Day3_BinaryCreator(input[i]));
            }
        }

        public int GetPowerConsumption()
        {
            return GetGammaRateValue() * GetEpsilonRateValue();
        }

        public Day3_BinaryCreator GetGammaRate()
        {
            return new Day3_BinaryCreator(GetGammaRateString());
        }

        public int GetGammaRateValue()
        {
            Day3_BinaryCreator returnValue = GetGammaRate();
            return returnValue.GetValue();
        }

        public Day3_BinaryCreator GetEpsilonRate()
        {
            return new Day3_BinaryCreator(GetEpsilonRateString());
        }

        public int GetEpsilonRateValue()
        {
            Day3_BinaryCreator returnValue = GetEpsilonRate();
            return returnValue.GetValue();
        }

        public string GetGammaRateString()
        {
            string returnValue = string.Empty;
            int length = binaryValues[0].GetNumberOfChars();
            for(int i=0; i < length; i++)
            {
                returnValue += GetGammaRatePosition(i+1);
            }
            return returnValue;
        }
        public string GetGammaRatePosition(int position)
        {
            int[] pArray = new int[2] { 0,0 };
            for (int i = 0; i < binaryValues.Count; i++)
            {
                pArray[binaryValues[i].GetSetting(position)] += 1;
            }
            return pArray[0] > pArray[1] ? "0" : "1";
        }

        public string GetOxygenRatePosition(int position, List<Day3_BinaryCreator> binaryValuesNew)
        {
            int[] pArray = new int[2] { 0, 0 };
            for (int i = 0; i < binaryValuesNew.Count; i++)
            {
                pArray[binaryValuesNew[i].GetSetting(position)] += 1;
            }
            return pArray[0] > pArray[1] ? "0" : "1";
        }

        public string GetEpsilonRateString()
        {
            string returnValue = string.Empty;
            int length = binaryValues[0].GetNumberOfChars();
            for (int i = 0; i < length; i++)
            {
                returnValue += GetEpsilonRatePosition(i + 1);
            }
            return returnValue;
        }

        public string GetEpsilonRatePosition(int position)
        {
            int[] pArray = new int[2] { 0, 0 };
            for (int i = 0; i < binaryValues.Count; i++)
            {
                pArray[binaryValues[i].GetSetting(position)] += 1;
            }
            return pArray[0] < pArray[1] ? "0" : "1";
        }

        public string GetCO2RatePosition(int position, List<Day3_BinaryCreator> binaryValuesNewa)
        {
            int[] pArray = new int[2] { 0, 0 };
            for (int i = 0; i < binaryValuesNewa.Count; i++)
            {
                pArray[binaryValuesNewa[i].GetSetting(position)] += 1;
            }
            return pArray[1] >= pArray[0] ? "0" : "1";
        }

        public string GetOxygenRateString()
        {
            List<Day3_BinaryCreator> localBinaryValues = binaryValues;
            int length = binaryValues[0].GetNumberOfChars();
            for (int i = 0; i < length; i++)
            {
                int cVal = int.Parse(GetOxygenRatePosition(i + 1, localBinaryValues));
                localBinaryValues = localBinaryValues.Where(x => x.GetSetting(i + 1) == cVal).ToList();
                if (localBinaryValues.Count() == 1)
                {
                    i = length + 1;
                }
            }
            return localBinaryValues[0].GetString();
        }

        public int GetOxygenRateValue()
        {
            Day3_BinaryCreator returnValue = GetOxygenRate();
            return returnValue.GetValue();
        }

        public Day3_BinaryCreator GetOxygenRate()
        {
            return new Day3_BinaryCreator(GetOxygenRateString());
        }


        public string GetCO2RateString()
        {
            List<Day3_BinaryCreator> localBinaryValues = binaryValues;
            int length = binaryValues[0].GetNumberOfChars();
            for (int i = 0; i < length; i++)
            {
                int cVal = int.Parse(GetCO2RatePosition(i + 1, localBinaryValues));
                localBinaryValues = localBinaryValues.Where(x => x.GetSetting(i + 1) == cVal).ToList();
                if (localBinaryValues.Count() == 1)
                {
                    i = length + 1;
                }
            }
            return localBinaryValues[0].GetString();
        }

        public int GetCO2RateValue()
        {
            Day3_BinaryCreator returnValue = GetCO2Rate();
            return returnValue.GetValue();
        }

        public Day3_BinaryCreator GetCO2Rate()
        {
            return new Day3_BinaryCreator(GetCO2RateString());
        }

        public int GetLifeSupportRating()
        {
            return GetCO2RateValue() * GetOxygenRateValue();
        }
    }

    public class Day3_BinaryCreator
    {
        char[] inputChars;
        public Day3_BinaryCreator(string input)
        {
            inputChars = input.ToCharArray();
        }

        public string GetString()
        {
            string returnValue = string.Empty;
            for (int i = 0; i < inputChars.Length; i++)
            {
                returnValue += inputChars[i];
            }
            return returnValue;
        }

        public int GetNumberOfChars()
        {
            return inputChars.Length;
        }

        public int GetValue()
        {
            int returnValue = 0;

            for (int i = 0; i < inputChars.Length; i++)
            {
                returnValue += GetValue(i+1);
            }

            return returnValue;
        }

        public int GetSetting(int location)
        {
            if (location > inputChars.Length)
            {
                return -1;
            }
            return int.Parse(inputChars[location - 1].ToString());
        }
        public int GetValue(int location)
        {
            if (location > inputChars.Length)
            {
                return 0;
            }
            else if (inputChars[location-1] == '0')
            {
                return 0;
            }
            return CalculateBinaryValue(location);
        }

        private int CalculateBinaryValue(int numberInput)
        {
            int returnNumber = 1;
            int number = inputChars.Length - numberInput + 1;
            if (number == 1)
            {
                return 1;
            }

            for(int i = number - 1; i>0; i--)
            {
                returnNumber = returnNumber * 2;
            }
            return returnNumber;
        }

    }
}
