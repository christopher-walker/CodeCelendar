using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    
    public class Dec01_01_Calories
    {
        private List<Elf> elves;

        public Dec01_01_Calories(string[] input)
        {
            elves = new List<Elf>();
            bool newElf = true;
            Elf elf = new Elf();
            for(int i = 0; i < input.Length; i++)
            {
                if (string.IsNullOrEmpty(input[i]))
                {
                    if (newElf != true)
                    {
                        elves.Add(elf);
                    }
                    elf = new Elf();
                    newElf = true;
                }
                else
                {
                    newElf = false;
                    elf.AddCalories(int.Parse(input[i]));
                }
            }
            if (elf.Calories.Count > 0)
            {
                elves.Add(elf);
            }
        }

        public int GetMaxCals()
        {
            int returnValue = 0;
            foreach(Elf elf in elves)
            {
                int totalCals = elf.GetTotalCalories();
                if (totalCals > returnValue)
                {
                    returnValue = totalCals;
                }
            }
            return returnValue;
        }

        public int Top3Cals()
        {
            List<int> Cals = new List<int>();
            foreach (Elf elf in elves)
            {
                Cals.Add(elf.GetTotalCalories());
            }
            Cals.Sort();
            Cals.Reverse();
            return Cals[0] + Cals[1] + Cals[2];
        }

    }

    public class Elf
    {
        public Elf()
        {
            Calories = new List<int>();
        }
        public void AddCalories(int cals)
        {
            Calories.Add(cals);
        }
        public List<int> Calories { get; set; }

        public int GetTotalCalories()
        {
            return Calories.Take(Calories.Count).Sum();
        }
    }
}
