using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day08
{
    //public static class MissingNumbers
    //{
    //    public static char[] n0 = { 'c', 'a', 'g', 'e', 'd', 'b' };
    //    public static char[] n6 = { 'c', 'd', 'f', 'g', 'e', 'b' };
    //    public static char[] n9 = { 'c', 'e', 'f', 'a', 'd', 'b' };

        
        
    //}
    public class Day08
    {
        //List<NumberInput> nos = new List<NumberInput>();
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
                            //nos.Add(new NumberInput(rowItems[0], number.Trim()));
                        }
                    }
                    numberGroups.Add(nog);
                }
            }
        }

        //public int GetSetValues()
        //{
        //    List<NumberInput> setNumbers = nos.Where(x => x.num != -1).ToList();
        //    return setNumbers.Count;
        //}

        //public int CalculateOutputs()
        //{
        //    int outputNumber = 0;
        //    int j = 0;
        //    string number = string.Empty;
        //    for(int i = 0; i < nos.Count; i++)
        //    {
        //        number += nos[i].num2.ToString();
        //        if (j < 3) {
        //            j++;
        //        }
        //        else {
        //            outputNumber += int.Parse(number);
        //            number = string.Empty;
        //            j = 0;
        //        }
        //    }
        //    return outputNumber;
        //}

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


    public class NumberSets
    {
        public NumberSets(string input)
        {
            input.Split('|');
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

        public int GetSetValues()
        {
            List<NumberInput> values = groupNumbers.Where(x => x.num != -1).ToList();
            return values.Count;
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
        public string numInputPart2 { get; set; }
        public int num { get; set; }
        public int num2 { get; set; }
        public NumberInput(string input, int value)
        {
            numInput = string.Concat(input.OrderBy(x => x));
            num = value;
            //CalculateNumber();
            //CalculateNumberPart2();
        }

        //public void CalculateNumber()
        //{
        //    switch (numInput.Length) {
        //        case 2:
        //            num = 1;
        //            break;
        //        case 3:
        //            num = 7;
        //            break;
        //        case 4:
        //            num = 4;
        //            break;
        //        case 7:
        //            num = 8;
        //            break;
        //        default:
        //            num = -1;
        //            break;
        //    }
        //}

        //public void CalculateNumberPart2()
        //{
        //    switch (numInput.Length)
        //    {
        //        case 2:
        //            num2 = 1;
        //            break;
        //        case 3:
        //            num2 = 7;
        //            break;
        //        case 4:
        //            num2 = 4;
        //            break;
        //        case 7:
        //            num2 = 8;
        //            break;
        //        case 5:
        //            if (numInput.IndexOf("a") != -1)
        //            {
        //                if (numInput.IndexOf("b") != -1)
        //                {
        //                    num2 = 2;
        //                }
        //                else
        //                {
        //                    num2 = 5;
        //                }
        //            }
        //            else
        //            {
        //                num2 = 3;
        //            }
        //            //public static char[] n2 = { 'g', 'a' };
        //            //public static char[] n3 = { 'b', 'a', };
        //            //public static char[] n5 = { 'b', 'e' };
        //            break;
        //        case 6:
        //            if (numInput.IndexOf("a") != -1)
        //            {
        //                if (numInput.IndexOf("f") != -1)
        //                {
        //                    num2 = 6;
        //                }
        //                else
        //                {
        //                    num2 = 0;
        //                }
        //            }
        //            else
        //            {
        //                num2 = 9;
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }

}
