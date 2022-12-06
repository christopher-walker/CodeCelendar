using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day6_2020
{
    public class Day6_2022
    {
        char[] allChars = new char[0];
        public Day6_2022(string[] input)
        {
            allChars = input[0].ToCharArray();
        }

        public int GetPosition(int pos = 4)
        {
            int returnValue = 0;
            Queue<char> lastFour = new Queue<char>();
            for (int i = 0; i < allChars.Length; i++)
            {
                
                if (i > pos - 1)
                {
                    // Check to see if all chars are unique
                    HashSet<char> four = new HashSet<char>();
                    char[] fArray = lastFour.ToArray();
                    foreach(char c in fArray)
                    {
                        if (!four.Contains(c))
                        {
                            four.Add(c);
                        }
                    }
                    if (four.Count == pos)
                    {
                        return i;
                    }
                    // if all unique returnValue = i + 1;
                }

                lastFour.Enqueue(allChars[i]);
                if (lastFour.Count > pos) { lastFour.Dequeue(); }


            }

            return returnValue;
        }
    }
}
