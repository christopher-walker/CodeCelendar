using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day6
{
    public class Day6
    {
        public List<Lanternfish> children = new List<Lanternfish>();
        public Day6(string[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                children.Add(new Lanternfish(int.Parse(input[i]), 1));
            }
        }


        [Obsolete("OldBreed is deprecated, this approack is not optimal as with expernential growth you will soon end up with memory issues.")]
        public void OldBreed()
        {
            //for (int i = 0; i < children.Count; i++)
            //{
            //    children[i].Breed();
            //}
            //if (breedDays == 0)
            //{
            //    children.Add(new Lanternfish(8));
            //    breedDays = 6;
            //}
            //else
            //{
            //    breedDays--;
            //}
        }

        public void Breed(int days)
        {
            
            for (int i = 0; i < days; i++)
            {
                double newFishValue = 0;
                for (int j = 0; j < children.Count; j++)
                {
                    if (children[j].breedDays == 0)
                    {
                        newFishValue += children[j].breedValue;
                    }
                }
                children = children.Where(x => x.breedDays != 0).ToList();
                bool isSevenDayChild = false;
                for (int j=0; j < children.Count; j++)
                {
                    children[j].breedDays--;
                    if (children[j].breedDays == 6)
                    {
                        children[j].breedValue += newFishValue;
                        isSevenDayChild = true;
                    }
                }
                if (!isSevenDayChild)
                {
                    children.Add(new Lanternfish(6, newFishValue));
                }
                if (newFishValue > 0)
                {
                    children.Add(new Lanternfish(8, newFishValue));
                }
                
            }
        }
        public double GetNumberOfFish()
        {
            double returnValue = 0;
            for (int i = 0; i < children.Count; i++)
            {
                returnValue += children[i].breedValue;
            }
            return returnValue;
        }
    }

    public class Lanternfish
    {
        public int breedDays;
        public double breedValue;
        public Lanternfish(int days, double value)
        {
            breedDays = days;
            breedValue = value;
        }

        [Obsolete("breed is deprecated, this approack is not optimal as with expernential growth you will soon end up with memory issues.")]
        public void breed()
        {
            //for (int i = 0; i < children.count; i++)
            //{
            //    children[i].breed();
            //    if (i > 20)
            //    {
            //        gcsettings.largeobjectheapcompactionmode = gclargeobjectheapcompactionmode.compactonce;
            //    }
            //}
            //if (breeddays == 0)
            //{
            //    children.add(new lanternfish(8));
            //    breeddays = 6;
            //}
            //else
            //{
            //    breeddays--;
            //}
        }

        [Obsolete("GetNumberOfFish is deprecated, this approack is not optimal as with expernential growth you will soon end up with memory issues.")]
        public int GetNumberOfFish()
        {
            return -1;
            //int returnValue = 0;
            //for (int i = 0; i < children.Count; i++)
            //{
            //    returnValue += children[i].GetNumberOfFish();
            //}
            //returnValue += children.Count;
            //return returnValue;
        }
    }
}
