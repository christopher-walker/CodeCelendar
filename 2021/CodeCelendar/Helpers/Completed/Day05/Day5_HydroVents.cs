using CodeCelendar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day5
{
    public class Day5_HydroVents
    {
        List<PointCoordinates> coordinateSets = new List<PointCoordinates>();
        Dictionary<string, int> coordinateMatched = new Dictionary<string, int>();

        public Day5_HydroVents(string[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                coordinateSets.Add(new PointCoordinates(input[i]));
            }
        }

        public int GetOverlaps(int numberOfOverlaps)
        {
            foreach(PointCoordinates coordinateSet in coordinateSets)
            {
                List<Coordinates> cords = coordinateSet.CalculateLinePoints();
                foreach(Coordinates cord in cords)
                {
                    if (coordinateMatched.ContainsKey($"{cord.x},{cord.y}"))
                    {
                        coordinateMatched[$"{cord.x},{cord.y}"]++;
                    }
                    else
                    {
                        coordinateMatched.Add($"{cord.x},{cord.y}", 1);
                    }
                }
            }
            return coordinateMatched.Where(x => x.Value >= numberOfOverlaps).Count();
        }

        public int GetOverlapsAllDirections(int numberOfOverlaps)
        {
            foreach (PointCoordinates coordinateSet in coordinateSets)
            {
                List<Coordinates> cords = coordinateSet.CalculateLinePointsAllDirections();
                foreach (Coordinates cord in cords)
                {
                    if (coordinateMatched.ContainsKey($"{cord.x},{cord.y}"))
                    {
                        coordinateMatched[$"{cord.x},{cord.y}"]++;
                    }
                    else
                    {
                        coordinateMatched.Add($"{cord.x},{cord.y}", 1);
                    }
                }
            }
            return coordinateMatched.Where(x => x.Value >= numberOfOverlaps).Count();
        }
    }

    public class Coordinates
    {
        public int x = -1;
        public int y = -1;
        public Coordinates() { }
        public Coordinates(string input)
        {
            string[] coords = input.Split(',');
            if (coords.Length == 2)
            {
                x = int.Parse(coords[0]);
                y = int.Parse(coords[1]);
            }
        }
        public Coordinates(int xVal, int yVal) { x = xVal; y = yVal; }
    }

    public class PointCoordinates
    {
        public Coordinates start = new Coordinates();
        public Coordinates end = new Coordinates();

        private List<Coordinates> coveredCoordinates = new List<Coordinates>();

        public PointCoordinates(string input)
        {
            input = input.Replace("->", " ");
            string[] numbers = input.Split(' ');
            for (int i = 0;  i < numbers.Length; i++)
            {
                if (!string.IsNullOrEmpty(numbers[i].Trim()))
                {
                    if (start.x == -1)
                    {
                        start = new Coordinates(numbers[i].Trim());
                    }
                    else
                    {
                        end = new Coordinates(numbers[i].Trim());
                    }
                }
            }
        }

        public int GetLargeXValue()
        {
            return start.x > end.x ? start.x : end.x;
        }
        public int GetSmallXValue()
        {
            return start.x > end.x ? end.x : start.x;
        }

        public int GetLargeYValue()
        {
            return start.y > end.y ? start.y : end.y;
        }
        public int GetSmallYValue()
        {
            return start.y > end.y ? end.y : start.y;
        }

        public List<Coordinates> CalculateLinePoints()
        {
            coveredCoordinates = new List<Coordinates>();
            if (start.x == end.x)
            {
                for (int i = GetSmallYValue(); i <= GetLargeYValue(); i++)
                {
                    coveredCoordinates.Add(new Coordinates(start.x, i));
                }
            } 
            else if(start.y == end.y)
            {
                for (int i = GetSmallXValue(); i <= GetLargeXValue(); i++)
                {
                    coveredCoordinates.Add(new Coordinates(i, start.y));
                }
            }
            return coveredCoordinates;
        }

        public List<Coordinates> CalculateLinePointsAllDirections()
        {
            coveredCoordinates = new List<Coordinates>();
            if (start.x == end.x)
            {
                for (int i = GetSmallYValue(); i <= GetLargeYValue(); i++)
                {
                    coveredCoordinates.Add(new Coordinates(start.x, i));
                }
            }
            else if (start.y == end.y)
            {
                for (int i = GetSmallXValue(); i <= GetLargeXValue(); i++)
                {
                    coveredCoordinates.Add(new Coordinates(i, start.y));
                }
            }
            else if (GetLargeXValue() - GetSmallXValue() == GetLargeYValue() - GetSmallYValue())
            {
                for(int i = 0; i <= GetLargeXValue() - GetSmallXValue(); i++)
                {
                    coveredCoordinates.Add(new Coordinates(GetNewX(i), GetNewY(i)));
                }
            }
            return coveredCoordinates;
        }

        public int GetNewX(int increment)
        {
            return start.x == GetLargeXValue() ? start.x - increment : start.x + increment;
        }

        public int GetNewY(int increment)
        {
            return start.y == GetLargeYValue() ? start.y - increment : start.y + increment;
        }
    }
}
