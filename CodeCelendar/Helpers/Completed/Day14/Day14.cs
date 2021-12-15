using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{

    public static class Day14Util
    {
        public static IEnumerable<string> SplitBy(this string str, int chunkLength)
        {
            if (String.IsNullOrEmpty(str)) throw new ArgumentException();
            if (chunkLength < 1) throw new ArgumentException();

            for (int i = 0; i < str.Length; i += chunkLength)
            {
                if (chunkLength + i > str.Length)
                    chunkLength = str.Length - i;

                yield return str.Substring(i, chunkLength);
            }
        }
    }
    public class Day14
    {
        string initialString = string.Empty;
        Dictionary<string, string> MatchingRule = new Dictionary<string, string>();
        public Day14(string[] input)
        {
            initialString = input[0];
            // just do the parsing like this ... it starts on the second line
            for (int i = 2; i < input.Length; i++)
            {
                if (!string.IsNullOrEmpty(input[i]))
                {
                    AddRule(input[i]);
                }
            }
        }

        private void AddRule(string rule)
        {
            rule = rule.Replace("-> ", "");
            string[] splitRule = rule.Split(' ');
            if (splitRule.Length == 2)
            {
                MatchingRule.Add(splitRule[0], splitRule[1]);
            }
        }

        private string ApplyRuleToString(string inputString)
        {
            for (var i = inputString.Length - 1; i > 0; i--)
            {
                string val = MatchingRule[inputString.Substring(i - 1, 2)];
                inputString = inputString.Insert(i, val);
            }
            return inputString;
        }

        public string RepeateApplyRule(int repititions)
        {
            var returnValue = initialString;
            for (int i = 0; i < repititions; i++)
            {
                string[] returnStrings = returnValue.SplitBy(500).ToArray();
                returnValue = string.Empty;
                for (int j = 0; j < returnStrings.Length; j++)
                {
                    returnValue += ApplyRuleToString(returnStrings[j]);
                    returnValue += j + 1 == returnStrings.Length ? "" : MatchingRule[returnStrings[j].Substring(returnStrings[j].Length - 1) + returnStrings[j + 1].Substring(0, 1)];
                }
                //returnValue = ApplyRuleToString(returnValue);
            }
            return returnValue;
        }

        public double GetResult(int repititions)
        {
            var outString = RepeateApplyRule(repititions);
            List<char> charsInString = outString.ToCharArray().ToList().Distinct().ToList();
            double minVal = double.MaxValue;
            double maxVal = double.MinValue;
            foreach (char stringChar in charsInString)
            {
                int freq = outString.Count(x => (x == stringChar));
                minVal = freq < minVal ? freq : minVal;
                maxVal = freq > maxVal ? freq : maxVal;
            }
            return maxVal - minVal;
        }

        public List<char> Method2(int repititions)
        {
            List<char> initial = initialString.ToCharArray().ToList();
            for (int i = 0; i < repititions; i++)
            {
                initial = Updated(initial);
            }
            return initial;
        }

        public List<char> Updated(List<char> input)
        {
            List<char> Output = new List<char>();

            for (int i = 0; i < input.Count - 1; i++)
            {
                Output.Add(input[i]);
                Output.Add(MatchingRule[$"{input[i]}{input[i + 1]}"].ToCharArray()[0]);
            }
            Output.Add(input[input.Count - 1]);
            return Output;
        }

        public string GetResultsPart1()
        {
            return GetResult(10).ToString();
        }

        public string GetResultsPart2()
        {

            return Method2(40).Count.ToString();
        }
    }

    public class Day14b
    {
        string initialString = string.Empty;
        Dictionary<string, string> MatchingRule = new Dictionary<string, string>();
        //Dictionary<string, string> MatchingRule = new Dictionary<string, string>();
        public Day14b(string[] input)
        {
            initialString = input[0];
            // just do the parsing like this ... it starts on the second line
            for (int i = 2; i < input.Length; i++)
            {
                if (!string.IsNullOrEmpty(input[i]))
                {
                    AddRule(input[i]);
                }
            }
        }

        private void AddRule(string rule)
        {
            rule = rule.Replace("-> ", "");
            string[] splitRule = rule.Split(' ');
            if (splitRule.Length == 2)
            {
                MatchingRule.Add(splitRule[0], splitRule[1]);
            }
        }


        public Dictionary<string, long> RepeateApplyRule(int repititions)
        {
            Dictionary<string, long> MatchingRuleCount = new Dictionary<string, long>();
            for (int i = 0; i < initialString.Length - 1; i++)
            {
                if (MatchingRuleCount.ContainsKey(initialString.Substring(i, 2)))
                {
                    MatchingRuleCount[initialString.Substring(i, 2)] += 1;
                }
                else
                {
                    MatchingRuleCount.Add(initialString.Substring(i, 2), 1);
                }
            }

            for (int i = 0; i < repititions; i++)
            {
                Dictionary<string, long> updated = new Dictionary<string, long>();
                foreach (KeyValuePair<string, long> keyValue in MatchingRuleCount)
                {
                    char[] keyParts = keyValue.Key.ToCharArray();
                    string newValue = MatchingRule[keyValue.Key];
                    if (updated.ContainsKey($"{keyParts[0]}{newValue}"))
                    {
                        updated[$"{keyParts[0]}{newValue}"] += keyValue.Value;
                    }
                    else
                    {
                        updated.Add($"{keyParts[0]}{newValue}", keyValue.Value);
                    }

                    if (updated.ContainsKey($"{newValue}{keyParts[1]}"))
                    {
                        updated[$"{newValue}{keyParts[1]}"] += keyValue.Value;
                    }
                    else
                    {
                        updated.Add($"{newValue}{keyParts[1]}", keyValue.Value);
                    }
                }
                MatchingRuleCount = updated;
            }

            return MatchingRuleCount;
        }

        public double GetResult(int repititions)
        {
            Dictionary<string, long> outString = RepeateApplyRule(repititions);
            Dictionary<char, long> occurencs = GetOccurencesOfChar(outString);

            return occurencs.Values.Max() - occurencs.Values.Min();
        }

        public Dictionary<char, long> GetOccurencesOfChar(Dictionary<string, long> input)
        {
            Dictionary<char, long> returnValue = new Dictionary<char, long>();
            foreach (KeyValuePair<string, long> keyValuePair in input)
            {
                char[] keyChar = keyValuePair.Key.ToCharArray();
                if (returnValue.ContainsKey(keyChar[0]))
                {
                    returnValue[keyChar[0]] += keyValuePair.Value;
                }
                else
                {
                    returnValue.Add(keyChar[0], keyValuePair.Value);
                }
            }
            returnValue[initialString.Last()]++;
            return returnValue;
        }

        public string GetResultsPart1()
        {
            return GetResult(10).ToString();
        }

        public string GetResultsPart2()
        {
            return GetResult(40).ToString();
        }
    }
}
