using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public static class Day13Util
    {
        
    }
    public class Day13
    {
        Dictionary<VisibleCoordinate, bool> coordinates = new Dictionary<VisibleCoordinate, bool>();
        List<Fold> folds = new List<Fold>();
        public Day13(string[] input)
        {
            bool reachedFolds = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (string.IsNullOrEmpty(input[i].Trim())) {
                    reachedFolds = true;
                }
                else if (reachedFolds)
                {
                    // Add folds to the list
                    folds.Add(new Fold(input[i]));
                }
                else
                {
                    // add items
                    coordinates.Add(new VisibleCoordinate(input[i]), true);
                }
            }
        }

        public int GetFolds()
        {
            return folds.Count();
        }
        public int GetCoordinates()
        {
            return coordinates.Count();
        }

        public Dictionary<VisibleCoordinate, bool> PerformFold(Dictionary<VisibleCoordinate, bool> coords, Fold fold)
        {
            Dictionary<VisibleCoordinate, bool> returnValue;
            Dictionary<VisibleCoordinate, bool> foldValues;
            if (fold.axis.ToLower() == "x")
            {
                int largestXValPreFold = coords.Keys.Max(x => x.x);
                int largestXValPostFold = largestXValPreFold - fold.value;
                returnValue = coords.Where(x => x.Key.x < fold.value).ToDictionary(x => x.Key, x => x.Value);
                
                foldValues = coords.Where(x => x.Key.x >= fold.value).ToDictionary(x => x.Key, x => x.Value);
                foreach (KeyValuePair<VisibleCoordinate, bool> coorPair in foldValues) {
                    int numberLargerThanFold = coorPair.Key.x - fold.value;
                    if (!returnValue.ContainsKey(new VisibleCoordinate(fold.value - numberLargerThanFold, coorPair.Key.y)))
                    {
                        returnValue.Add(new VisibleCoordinate(fold.value - numberLargerThanFold, coorPair.Key.y), coorPair.Value);
                    }
                }
            }
            else
            {
                int largestYVal = coords.Keys.Max(x => x.y);
                int largestYValPostFold = largestYVal - fold.value;
                returnValue = coords.Where(x => x.Key.y < fold.value).ToDictionary(x => x.Key, x => x.Value);
                foldValues = coords.Where(x => x.Key.y >= fold.value).ToDictionary(x => x.Key, x => x.Value);
                foreach (KeyValuePair<VisibleCoordinate, bool> coorPair in foldValues)
                {
                    int numberLargerThanFold = coorPair.Key.y - fold.value;
                    if (!returnValue.ContainsKey(new VisibleCoordinate(coorPair.Key.x, fold.value - numberLargerThanFold)))
                    {
                        returnValue.Add(new VisibleCoordinate(coorPair.Key.x, fold.value - numberLargerThanFold), coorPair.Value);
                    }
                }
            }
            return returnValue;
        }

        public string GetResultsPart1()
        {
            Dictionary<VisibleCoordinate, bool> coords = PerformFold(coordinates, folds[0]);
            return coords.Count.ToString();
        }

        public string GetResultsPart2()
        {
            Dictionary<VisibleCoordinate, bool> coords = coordinates;
            for (var i = 0; i < folds.Count(); i++)
            {
                coords = PerformFold(coords, folds[i]);
            }
            return PlotToString(coords);
        }

        public string PlotToString(Dictionary<VisibleCoordinate, bool> coords)
        {
            string returnValue = string.Empty;
            int largestXVal = coords.Keys.Max(x => x.x);
            int largestYVal = coords.Keys.Max(x => x.y);
            for (int y = 0; y <= largestYVal; y++)
            {
                for(int x = 0; x <= largestXVal; x++)
                {
                    returnValue += coords.ContainsKey(new VisibleCoordinate(x, y)) ? "#" : ".";
                }
                returnValue += Environment.NewLine;
            }
            return returnValue;
        }
    }
    public class Fold
    {
        public string axis = string.Empty;
        public int value = -1;
        public Fold(string foldInfo)
        {
            string[] foldSplit = foldInfo.Replace("fold along ", "").Split('=');
            axis = foldSplit[0];
            value = int.Parse(foldSplit[1]);
        }
    }
    public class VisibleCoordinate
    {
        public int x;
        public int y;

        public VisibleCoordinate(string coordinates)
        {
            string[] cordsArray = coordinates.Split(',');
            x = int.Parse(cordsArray[0]);
            y = int.Parse(cordsArray[1]);
        }
        public VisibleCoordinate(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }
        public override bool Equals(object obj)
        {
            bool returnValue = false;
            VisibleCoordinate newCoord = obj as VisibleCoordinate;
            if (newCoord != null)
            {
                if (newCoord.x.Equals(x) && newCoord.y.Equals(y))
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        public override int GetHashCode()
        {
            return (x.ToString() + y.ToString()).GetHashCode();
        }
    }
}
