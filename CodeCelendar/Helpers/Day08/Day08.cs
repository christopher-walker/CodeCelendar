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
        List<NumberInput> nos = new List<NumberInput>();
        public Day08(string[] input)
        {
            foreach(string row in input)
            {
                string[] rowItems = row.Split('|');
                if (rowItems.Length == 2)
                {
                    string[] numbers = rowItems[1].Split(' ');
                    foreach (string number in numbers)
                    {
                        if (number.Trim().Length > 0)
                        {
                            nos.Add(new NumberInput(number.Trim()));
                        }
                    }
                }
            }
        }

        public int GetSetValues()
        {
            List<NumberInput> setNumbers = nos.Where(x => x.num != -1).ToList();
            return setNumbers.Count;
        }

        public int CalculateOutputs()
        {
            int outputNumber = 0;
            int j = 0;
            string number = string.Empty;
            for(int i = 0; i < nos.Count; i++)
            {
                number += nos[i].num2.ToString();
                if (j < 3) {
                    j++;
                }
                else {
                    outputNumber += int.Parse(number);
                    number = string.Empty;
                    j = 0;
                }
            }
            return outputNumber;
        }
    }


    public class NumberSets
    {
        public NumberSets(string input)
        {
            input.Split('|');
        }
    }

    public class NumberInput
    {
        public string numInput { get; set; }
        public string numInputPart2 { get; set; }
        public int num { get; set; }
        public int num2 { get; set; }
        public NumberInput(string input)
        {
            numInput = input;
            CalculateNumber();
            //CalculateNumberPart2();
        }

        public void CalculateNumber()
        {
            switch (numInput.Length) {
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
        }

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
