using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day08
{
    public class Day08
    {
        List<NumberGroup> numberGroups = new List<NumberGroup>();
        public Day08(string[] input)
        {
            foreach(string row in input)
            {
                string[] rowItems = row.Split('|');
                if (rowItems.Length == 2)
                {
                    NumberGroup nog = new NumberGroup(rowItems[0]);
                    string[] numbers = rowItems[1].Split(' ');
                    
                    foreach (string number in numbers)
                    {
                        if (number.Trim().Length > 0)
                        {
                            nog.AddNumber(number.Trim());
                        }
                    }
                    numberGroups.Add(nog);
                }
            }
        }

        public int CalculateNumberOfSimpleValues()
        {
            int returnValue = 0;
            for (int i = 0; i < numberGroups.Count; i++)
            {
                returnValue += numberGroups[i].GetTotalOfSimpalNumbers();
            }
            return returnValue;
        }

        public int CalculateOutputs()
        {
            int returnValue = 0;
            for(int i = 0; i < numberGroups.Count; i++)
            {
                numberGroups[i].CalculateHardNumbers();
                returnValue += numberGroups[i].GetValue();
            }
            return returnValue;
        }
    }


    public class NumberGroup
    {
        List<NumberInput> groupNumbers = new List<NumberInput>();
        Dictionary<string, int> numberDefinitions = new Dictionary<string, int>();

        public NumberGroup(string numberDefinition)
        {
            string[] definitions = numberDefinition.Split(' ');
            for (int i = 0; i < definitions.Length; i++)
            {
                if (!string.IsNullOrEmpty(definitions[i].Trim()))
                {
                    numberDefinitions.Add(string.Concat(definitions[i].Trim().OrderBy(x => x)), -1);
                }
            }
            List<string> keys = numberDefinitions.Keys.ToList();
            foreach (string key in keys)
            {
                numberDefinitions[key] = CalculateNumber(key);
            }
            int hello = 1;
        }

        public void AddNumber(string startNumber)
        {
            string number = string.Concat(startNumber.Trim().OrderBy(x => x));
            groupNumbers.Add(new NumberInput(number.Trim(), -1));
        }

        private int CalculateNumber(string number)
        {
            int num = -1;
            switch (number.Length)
            {
                case 2:
                    num = 1;
                    break;
                case 3:
                    num = 7;
                    break;
                case 4:
                    num = 4;
                    break;
                case 7:
                    num = 8;
                    break;
                default:
                    num = -1;
                    break;
            }
            return num;
        }

        public int GetTotalOfSimpalNumbers()
        {
            for(int i = 0; i < groupNumbers.Count; i++)
            {
                groupNumbers[i].num = numberDefinitions[groupNumbers[i].numInput];
            }
            return groupNumbers.Where(x => x.num != -1).ToList().Count;
        }

        public void CalculateHardNumbers()
        {
            Match2();
            Match5();
            Match3();
            Match6();
            Match9();
            Match0();
        }

        private void MatchNumberOnNumberOfMatches(List<KeyValuePair<string, int>> values, string iNumber, int numberOfMatches, int finalValue)
        {
            if (iNumber != null)
            {
                char[] fourChars = iNumber.ToCharArray();
                for (int i = 0; i < values.Count; i++)
                {
                    int matches = 0;
                    foreach (char fourChar in fourChars)
                    {
                        if (values[i].Key.Contains(fourChar))
                        {
                            matches++;
                        }
                    }
                    if (matches == numberOfMatches)
                    {
                        numberDefinitions[values[i].Key] = finalValue;
                        i = values.Count;
                    }
                }
            }
        }

        private void Match2()
        {
            List<KeyValuePair<string, int>> values = numberDefinitions.Where(x => x.Value == -1 && x.Key.Length == 5).ToList();
            string iNumber = numberDefinitions.Where(x => x.Value == 4).FirstOrDefault().Key;
            int numberOfMatches = 2;
            int finalValue = 2;
            MatchNumberOnNumberOfMatches(values, iNumber, numberOfMatches, finalValue);
        }

        private void Match5()
        {
            List<KeyValuePair<string, int>> values = numberDefinitions.Where(x => x.Value == -1 && x.Key.Length == 5).ToList();
            //NumberInput iNumber = groupNumbers.Where(x => x.num == 1).FirstOrDefault();
            string iNumber = numberDefinitions.Where(x => x.Value == 1).FirstOrDefault().Key;
            int numberOfMatches = 1;
            int finalValue = 5;
            MatchNumberOnNumberOfMatches(values, iNumber, numberOfMatches, finalValue);
        }

        private void Match3()
        {
            List<KeyValuePair<string, int>> values = numberDefinitions.Where(x => x.Value == -1 && x.Key.Length == 5).ToList();
            //NumberInput iNumber = groupNumbers.Where(x => x.num == 1).FirstOrDefault();
            string iNumber = numberDefinitions.Where(x => x.Value == 1).FirstOrDefault().Key;
            int numberOfMatches = 2;
            int finalValue = 3;
            MatchNumberOnNumberOfMatches(values, iNumber, numberOfMatches, finalValue);
        }

        private void Match6()
        {
            List<KeyValuePair<string, int>> values = numberDefinitions.Where(x => x.Value == -1 && x.Key.Length == 6).ToList();
            //NumberInput iNumber = groupNumbers.Where(x => x.num == 1).FirstOrDefault();
            string iNumber = numberDefinitions.Where(x => x.Value == 1).FirstOrDefault().Key;
            int numberOfMatches = 1;
            int finalValue = 6;
            MatchNumberOnNumberOfMatches(values, iNumber, numberOfMatches, finalValue);
        }

        private void Match9()
        {
            List<KeyValuePair<string, int>> values = numberDefinitions.Where(x => x.Value == -1 && x.Key.Length == 6).ToList();
            //NumberInput iNumber = groupNumbers.Where(x => x.num == 4).FirstOrDefault();
            string iNumber = numberDefinitions.Where(x => x.Value == 4).FirstOrDefault().Key;
            int numberOfMatches = 4;
            int finalValue = 9;
            MatchNumberOnNumberOfMatches(values, iNumber, numberOfMatches, finalValue);
        }

        private void Match0()
        {
            // should only be one value left
            List<KeyValuePair<string, int>> values = numberDefinitions.Where(x => x.Value == -1).ToList();
            if (values.Count > 1)
            {
                throw new Exception("Has not managed to match other values");
            }
            numberDefinitions[values[0].Key] = 0;
        }

        public int GetValue()
        {
            string returnNumber = string.Empty;
            for(int i = 0; i < groupNumbers.Count; i++)
            {
                returnNumber += numberDefinitions[groupNumbers[i].numInput];
            }
            return int.Parse(returnNumber);
        }
    }

    public class NumberInput
    {
        public string numInput { get; set; }
        public int num { get; set; }
        public NumberInput(string input, int value)
        {
            numInput = string.Concat(input.OrderBy(x => x));
            num = value;
        }
    }

}
