using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public static class Day10Util
    {
        public static Dictionary<char, char> InputOutput = new Dictionary<char, char>()
        {
            {'(', ')' },
            {'[', ']' },
            {'{', '}' },
            {'<', '>' }
        };

        public static Dictionary<char, int> OutputValue = new Dictionary<char, int>()
        {
            {')', 3 },
            {']', 57 },
            {'}', 1197 },
            {'>', 25137 }
        };

        public static Dictionary<char, int> AutoCompleteValue = new Dictionary<char, int>()
        {
            {')', 1 },
            {']', 2 },
            {'}', 3 },
            {'>', 4 }
        };
    }
    public class Day10
    {
        List<NavRows> rows = new List<NavRows>();
        public Day10(string[] input)
        {
            foreach(string inputLine in input)
            {
                rows.Add(new NavRows(inputLine));
            }
        }

        public string GetResultsPart1()
        {
            return CalculateValidityTotal().ToString();
        }

        private int CalculateValidityTotal()
        {
            int total = 0;
            for (int i = 0; i < rows.Count; i++)
            {
                rows[i].CalculateValidity();
                total += rows[i].GetIllegalValue();
            }

            return total;
        }

        private double CalculateCompletionTotal()
        {
            List<double> rowCompletion = new List<double>();
            for (int i = 0; i < rows.Count; i++)
            {
                rowCompletion.Add(rows[i].CalculateCompletion());
            }

            rowCompletion = rowCompletion.Where(x => x > 0).ToList();
            rowCompletion.Sort();
            // take the middle value
            int middleValue = (rowCompletion.Count - 1) / 2;

            return rowCompletion[middleValue];
        }

        public string GetResultsPart2()
        {
            CalculateValidityTotal();

            return CalculateCompletionTotal().ToString();
        }
    }

    public class NavRows
    {
        string row = string.Empty;
        bool inComplete = false;
        int completionValue = 0;
        int illegalValue = 0;
        Stack<char> closeStackEnd = new Stack<char>();
        List<char> closeList = new List<char>();
        public NavRows(string input)
        {
            row = input;
        }
        public int GetIllegalValue()
        {
            return illegalValue;
        }

        public double CalculateCompletion()
        {
            double returnValue = 0;
            if (closeStackEnd.Count == 0) { return 0; }

            while(closeStackEnd.Count > 0)
            {
                char closeChar = closeStackEnd.Pop();
                returnValue = returnValue * 5;
                returnValue += Day10Util.AutoCompleteValue[closeChar];
            }
            return returnValue;
        }

        public void CalculateValidity()
        {
            Stack<char> closeStack = new Stack<char>();
            char[] rowChars = row.ToArray();
            for(var i = 0; i < rowChars.Count(); i++)
            {
                if (Day10Util.InputOutput.ContainsKey(rowChars[i]))
                {
                    closeStack.Push(Day10Util.InputOutput[rowChars[i]]);
                }
                else
                {
                    // its a close char
                    char expectedOutput = closeStack.Pop();
                    if(rowChars[i] != expectedOutput)
                    {
                        // this is invalid
                        illegalValue = Day10Util.OutputValue[rowChars[i]];
                        i = rowChars.Count();
                    }
                    else
                    {
                        // this is fine do nothing for now
                    }
                }
            }
            if (illegalValue == 0)
            {
                closeStackEnd = closeStack;
            }
        }
    }
}
