using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day4
{
    public class Day4_2022_Supplies
    {
        List<ElfRanges> elfRanges = new List<ElfRanges>();
        public Day4_2022_Supplies(string[] input)
        {
            int elfId = 0;
            foreach(string inputString in input)
            {
                string[] sections = inputString.Split(new char[] { ',' });
                elfRanges.Add(new ElfRanges(sections, elfId));
                elfId++;
            }
        }
        public double GetInternalContains()
        {
            double returnValue = 0;
            foreach (ElfRanges elfRanges in elfRanges)
            {
                returnValue += elfRanges.InternalRangeMatch();
            }
            return returnValue;
        }


        public double GetInternalOverlap()
        {
            double returnValue = 0;
            foreach (ElfRanges elfRanges in elfRanges)
            {
                returnValue += elfRanges.InternalRangeOverlap();
            }
            return returnValue;
        }

        //public double GetFullContains()
        //{
        //    double returnValue = 0;
        //    foreach (ElfRanges elfRange in elfRanges)
        //    {
        //        returnValue += GetFullContainsElf(elfRange);
        //    }
        //    return returnValue;
        //}

        //private double GetFullContainsElf(ElfRanges inputElfRanges)
        //{
        //    double returnValue = 0;

        //    foreach(ElfRanges elfRange in elfRanges)
        //    {
        //        returnValue = returnValue + elfRange.ContainsAllRanges(inputElfRanges);
        //        if (returnValue > 0) { break; }
        //    }

        //    return returnValue;
        //}
    }

    public class ElfRanges
    {
        public List<Range> ranges = new List<Range>();
        private int ElfId = 0;
        public ElfRanges(string[] inputRanges, int elfId)
        {
            int rangeId = 0;
            foreach (string range in inputRanges)
            {
                ranges.Add(new Range(range.Split(new char[] { '-' }), rangeId));
                rangeId++;
            }
            ElfId = elfId;
         }

        public double ContainsAllRanges(ElfRanges inputRanges)
        {
            double returnValue = 0;
            if (inputRanges.ElfId == ElfId) { return 0; }
            foreach(Range inputRange in inputRanges.ranges)
            {
                foreach(Range range in ranges)
                {
                    if (range.Start <= inputRange.Start && range.End >= inputRange.End)
                    {
                        returnValue++;
                    }
                }
            }
            return returnValue == inputRanges.ranges.Count ? 1 : 0;
            //return returnValue;
        }

        public double InternalRangeMatch()
        {
            double returnValue = 0;
            foreach (Range range in ranges)
            {
                foreach (Range compRange in ranges)
                {
                    if (range.RangeId != compRange.RangeId)
                    {
                        if (range.Start >= compRange.Start && range.End <= compRange.End)
                        {
                            return 1;
                        }
                    }
                }
            }
            return returnValue;
        }

        public double InternalRangeOverlap()
        {
            double returnValue = 0;
            foreach (Range range in ranges)
            {
                foreach (Range compRange in ranges)
                {
                    if (range.RangeId != compRange.RangeId)
                    {
                        if (range.End >= compRange.Start && range.End <= compRange.End) { return 1; }
                        if (range.Start <= compRange.End && range.Start >= compRange.Start) { return 1; }
                        //if (range.Start >= compRange.Start || range.End <= compRange.End)
                        //{
                        //    return 1;
                        //}
                    }
                }
            }
            return returnValue;
        }
        
    }

    public class Range
    {
        public int RangeId { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public Range(string[] startEnd, int rangeId)
        {
            this.RangeId = rangeId;
            this.Start = int.Parse(startEnd[0]);
            this.End = int.Parse(startEnd[1]);
        }
    }
}
