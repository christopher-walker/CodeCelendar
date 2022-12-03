using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day3
{

    public class Day3_2022
    {
        List<Packages_2022> packages = new List<Packages_2022>();
        public Day3_2022(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                packages.Add(new Packages_2022(input[i]));
            }
        }

        public double GetValues()
        {
            return packages.Sum(x => x.CharValue);
        }

        public double GetBadgeValue()
        {
            double returnValue = 0;
            for (int j = 0; j < packages.Count / 3; j++)
            {
                int i = j == 0 ? 0 : j * 3;
                foreach(char ch in packages[i].AllItems)
                {
                    if (packages[i + 1].AllItems.Contains(ch) && packages[i + 2].AllItems.Contains(ch))
                    {
                        int charValue = (int)ch;
                        if (charValue > 96)
                        {
                            returnValue = returnValue + charValue - 96;
                        }
                        else
                        {
                            returnValue = returnValue + charValue - 38;
                        }
                        break;
                    }
                }
            }

            return returnValue;
        }
    }

    public class Packages_2022
    {
        HashSet<char> CompartmentOne = new HashSet<char>();
        public HashSet<char> AllItems = new HashSet<char>();
        //HashSet<char> CompartmentTwo = new HashSet<char>();

        public char matchingChar;

        public int CharValue
        {
            get
            {
                int charValue = (int)matchingChar;
                if (charValue > 96)
                {
                    return charValue - 96;
                }
                return charValue - 38;
            }
        }
        public Packages_2022(string input)
        {
            var first = input.Substring(0, (int)(input.Length / 2));
            var last = input.Substring((int)(input.Length / 2), (int)(input.Length / 2));

            foreach(char a in first)
            {
                if (!CompartmentOne.Contains(a))
                {
                    CompartmentOne.Add(a);
                    AllItems.Add(a);
                }
            }

            foreach (char a in last)
            {
                if (CompartmentOne.Contains(a))
                {
                    // found the match
                    matchingChar = a;
                }
                if (!AllItems.Contains(a))
                {
                    AllItems.Add(a);
                }
            }

        }

    }

}