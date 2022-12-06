using CodeCelendar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day5
{
    public class Day5_2022_SupplyStacks
    {
        List<Instruction2022> instructions = new List<Instruction2022>();
        Dictionary<int, Stack<char>> stackOrderInitial = new Dictionary<int, Stack<char>>();
        Dictionary<int, Stack<char>> stackOrderFinal = new Dictionary<int, Stack<char>>();
        public Day5_2022_SupplyStacks(string[] input)
        {
            bool startInstructions = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (startInstructions)
                {
                    instructions.Add(new Instruction2022(input[i]));
                }
                else if (string.IsNullOrEmpty(input[i].Trim()))
                {
                    startInstructions = true;
                }
                else if (input[i].Contains('['))
                {
                    // char 2
                    bool loop = true;
                    int position = 1;
                    while (loop)
                    {
                        if (input[i].Length <= position * 4 - 2)
                        {
                            loop = false;
                        }
                        else
                        {
                            char inputChar = input[i][position * 4 - 3];
                            if (!string.IsNullOrEmpty(inputChar.ToString().Trim()))
                            {
                                if (!stackOrderInitial.ContainsKey(position))
                                {
                                    stackOrderInitial.Add(position, new Stack<char>());
                                }
                                stackOrderInitial[position].Push(inputChar);
                            }
                        }
                        position++;
                    }
                }
            }

            // Reverse the stacks
            for (int i = 1; i <= stackOrderInitial.Count; i++)
            {
                stackOrderFinal.Add(i, new Stack<char>());
                while(stackOrderInitial[i].Count > 0)
                {
                    stackOrderFinal[i].Push(stackOrderInitial[i].Pop());
                }
            }
        }

        public string TopOfEachStack()
        {
            string returnValue = string.Empty;
            FollowInstructions();

            for(int i = 1; i <= stackOrderFinal.Count; i++)
            {
                returnValue += stackOrderFinal[i].Peek().ToString();
            }

            return returnValue;
        }

        public string TopOfEachStack2001()
        {
            string returnValue = string.Empty;
            FollowInstructions2001();

            for (int i = 1; i <= stackOrderFinal.Count; i++)
            {
                returnValue += stackOrderFinal[i].Peek().ToString();
            }

            return returnValue;
        }

        private void FollowInstructions()
        {
            foreach (Instruction2022 inst in instructions)
            {
                for (int i = 0; i < inst.Number; i++)
                {
                    char box = stackOrderFinal[inst.SourceColumn].Pop();
                    stackOrderFinal[inst.DestinationColumn].Push(box);
                }
            }
        }

        private void FollowInstructions2001()
        {
            foreach (Instruction2022 inst in instructions)
            {
                Stack<char> tempStack = new Stack<char>();
                for (int i = 0; i < inst.Number; i++)
                {
                    char box = stackOrderFinal[inst.SourceColumn].Pop();
                    tempStack.Push(box);
                    // stackOrderFinal[inst.DestinationColumn].Push(box);
                }
                while (tempStack.Count > 0)
                {
                    stackOrderFinal[inst.DestinationColumn].Push(tempStack.Pop());
                }
            }
        }
    }

    public class Instruction2022
    {
        public int SourceColumn { get; set; }
        public int DestinationColumn { get; set; }
        public int Number { get; set; }
        public Instruction2022(string input)
        {
                //  0    1 2    3 4  5
                //  move 4 from 9 to 1

            string[] splitInput = input.Split(' ');
            Number = int.Parse(splitInput[1]);
            SourceColumn = int.Parse(splitInput[3]);
            DestinationColumn = int.Parse(splitInput[5]);
        }
    }
}
