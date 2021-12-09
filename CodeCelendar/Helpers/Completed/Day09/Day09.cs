using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day09
{
    public class Day09
    {
        HeightMap[,] heightMapArray;
        public Day09(string[] input)
        {
            heightMapArray = new HeightMap[input.Length, input[0].Length];
            for (int i = 0; i < input.Length; i++)
            {
                char[] heights = input[i].ToCharArray();
                for (int j = 0; j < heights.Length; j++)
                {
                    heightMapArray[i, j] = new HeightMap() { height = int.Parse(heights[j].ToString()), lowPoint = false };
                }
            }
        }

        private void MapLowPoints()
        {
            for(int x = 0; x < heightMapArray.GetLength(0); x++)
            {
                for (int y = 0; y < heightMapArray.GetLength(1); y++)
                {
                    List<int> adjacentHeights = GetHeights(x, y);
                    List<int> smallerAdjacentValues = adjacentHeights.Where(v => v <= heightMapArray[x, y].height).ToList();
                    heightMapArray[x, y].lowPoint = smallerAdjacentValues.Count == 0;
                }
            }
        }

        private int CalculateLowPointRisk()
        {
            int lowPointTotal = 0;
            for (int x = 0; x < heightMapArray.GetLength(0); x++)
            {
                for (int y = 0; y < heightMapArray.GetLength(1); y++)
                {
                    if (heightMapArray[x, y].lowPoint)
                    {
                        lowPointTotal += heightMapArray[x, y].height + 1;
                    }
                }
            }
            return lowPointTotal;
        }

        private int CalculateAllPointBasinSize()
        {
            
            Dictionary<int, List<Coordinate>> basins = new Dictionary<int, List<Coordinate>>();
            for (int x = 0; x < heightMapArray.GetLength(0); x++)
            {
                for (int y = 0; y < heightMapArray.GetLength(1); y++)
                {
                    if (heightMapArray[x, y].lowPoint)
                    {
                        List<Coordinate> potentialBasin = CalculateBasinSize(x, y).Keys.ToList();
                        bool newBasin = true;
                        foreach(List<Coordinate> existingBasin in basins.Values)
                        {
                            if (existingBasin.Contains(potentialBasin[0]))
                            {
                                newBasin = false;
                            }
                        }
                        if (newBasin)
                        {
                            basins.Add(basins.Count, potentialBasin);
                        }
                    }
                }
            }
            List<int> basonSizes = new List<int>();
            foreach (List<Coordinate> existingBasin in basins.Values)
            {
                List<Coordinate> basinValues = existingBasin.Where(x => x.positionValue != 9).ToList();
                basonSizes.Add(basinValues.Count);
                //if (returnValue == 0)
                //{
                //    returnValue = basinValues.Count;
                //}
                //else
                //{
                //    returnValue = returnValue * basinValues.Count;
                //}
            }
            basonSizes = basonSizes.OrderByDescending(x => x).ToList();
            return basonSizes[0] * basonSizes[1] * basonSizes[2]; // coordinateList.Where(x => x.positionValue != 9).Distinct().Count();
        }

        private Dictionary<Coordinate, Direction> CalculateBasinSize(int x, int y)
        {
            Dictionary<Coordinate, Direction> coordinates = new Dictionary<Coordinate, Direction>();
            coordinates.Add(new Coordinate(x, y, heightMapArray[x, y].height), new Direction());
            bool basinFound = false;
            while (!basinFound)
            {
                basinFound = true;
                Dictionary<Coordinate, Direction> newCoordinates = new Dictionary<Coordinate, Direction>();
                for (var i = 0; i < coordinates.Keys.Count; i++)
                {
                    KeyValuePair<Coordinate, Direction> cD = coordinates.ElementAt(i);
                    if (cD.Key.positionValue < 9 && !cD.Value.AllDirectionsChecked())
                    {
                        // some directions on this element have not been checked
                        basinFound = false;
                        if (!cD.Value.North) {
                            int coordinateValue = GetPositionValue(cD.Key.x - 1, cD.Key.y);
                            if (!coordinates.ContainsKey(new Coordinate(cD.Key.x - 1, cD.Key.y, coordinateValue)) && !newCoordinates.ContainsKey(new Coordinate(cD.Key.x - 1, cD.Key.y, coordinateValue)))
                            {
                                newCoordinates.Add(new Coordinate(cD.Key.x - 1, cD.Key.y, coordinateValue), new Direction());
                            }
                        }
                        if (!cD.Value.South) {
                            int coordinateValue = GetPositionValue(cD.Key.x + 1, cD.Key.y);
                            if (!coordinates.ContainsKey(new Coordinate(cD.Key.x + 1, cD.Key.y, coordinateValue)) && !newCoordinates.ContainsKey(new Coordinate(cD.Key.x + 1, cD.Key.y, coordinateValue)))
                            {
                                newCoordinates.Add(new Coordinate(cD.Key.x + 1, cD.Key.y, coordinateValue), new Direction());
                            }
                        }
                        if (!cD.Value.East) {
                            int coordinateValue = GetPositionValue(cD.Key.x, cD.Key.y + 1);
                            if (!coordinates.ContainsKey(new Coordinate(cD.Key.x, cD.Key.y + 1, coordinateValue)) && !newCoordinates.ContainsKey(new Coordinate(cD.Key.x, cD.Key.y + 1, coordinateValue)))
                            {
                                newCoordinates.Add(new Coordinate(cD.Key.x, cD.Key.y + 1, coordinateValue), new Direction());
                            }
                        }
                        if (!cD.Value.West) {
                            int coordinateValue = GetPositionValue(cD.Key.x, cD.Key.y - 1);
                            if (!coordinates.ContainsKey(new Coordinate(cD.Key.x, cD.Key.y - 1, coordinateValue)) && !newCoordinates.ContainsKey(new Coordinate(cD.Key.x, cD.Key.y - 1, coordinateValue)))
                            {
                                newCoordinates.Add(new Coordinate(cD.Key.x, cD.Key.y - 1, coordinateValue), new Direction());
                            }
                        }
                        coordinates[cD.Key].MarkAllAsChecked();
                    }
                }

                foreach(KeyValuePair<Coordinate, Direction> newCoordinate in newCoordinates)
                {
                    if (!coordinates.ContainsKey(newCoordinate.Key))
                    {
                        coordinates.Add(newCoordinate.Key, newCoordinate.Value);
                    }
                }
            }
            return coordinates;
        }

        private int GetPositionValue(int x, int y)
        {
            if (x < 0 || x >= heightMapArray.GetLength(0) || y < 0 || y >= heightMapArray.GetLength(1))
            {
                // if the value is out of bounds return 9
                return 9;
            }
            return heightMapArray[x, y].height;
        }

        private List<int> GetHeights(int x, int y)
        {
            List<int> adjacentValues = new List<int>();
            if (x-1 >= 0)
            {
                if (y - 1 >= 0)
                {
                    // Diagonal 
                    // adjacentValues.Add(heightMapArray[x - 1, y - 1].height);

                }
                adjacentValues.Add(heightMapArray[x - 1, y].height);
                if (y + 1 < heightMapArray.GetLength(1))
                {
                    // Diagonal
                    // adjacentValues.Add(heightMapArray[x - 1, y + 1].height);
                }
            }

            if (y - 1 >= 0)
            {
                adjacentValues.Add(heightMapArray[x, y - 1].height);
            }
            if (y + 1 < heightMapArray.GetLength(1))
            {
                adjacentValues.Add(heightMapArray[x, y + 1].height);
            }

            if (x+1 < heightMapArray.GetLength(0))
            {
                if (y - 1 >= 0)
                {
                    // Diagonal 
                    // adjacentValues.Add(heightMapArray[x + 1, y - 1].height);

                }
                adjacentValues.Add(heightMapArray[x + 1, y].height);
                if (y + 1 < heightMapArray.GetLength(1))
                {
                    // Diagonal
                    // adjacentValues.Add(heightMapArray[x + 1, y + 1].height);
                }
            }
            return adjacentValues;
        }

        public string GetResultsPart1()
        {
            MapLowPoints();

            return CalculateLowPointRisk().ToString();
        }

        public string GetResultsPart2()
        {
            MapLowPoints();
            return CalculateAllPointBasinSize().ToString();
        }
    }

    public class Direction {
        public bool North = false;
        public bool South = false;
        public bool East = false;
        public bool West = false;
        public Direction() { }

        public bool AllDirectionsChecked()
        {
            return North && South && East && West;
        }

        public void MarkAllAsChecked()
        {
            North = true;
            South = true;
            East = true;
            West = true;
        }
    }


    public class Coordinate
    {
        public int x;
        public int y;
        public int positionValue;
        public Coordinate(int xVal, int yVal, int value)
        {
            x = xVal;
            y = yVal;
            positionValue = value;
        }
        public override bool Equals(object obj)
        {
            bool returnValue = false;
            Coordinate newCoord = obj as Coordinate;
            if (newCoord != null)
            {
                if (newCoord.x.Equals(x) && newCoord.y.Equals(y))
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }
        public int GetWellValue()
        {
            if (positionValue == 9) { return 0; }
            return 1;
        }

        public override int GetHashCode()
        {
            return (x.ToString() + y.ToString()).GetHashCode();
        }
    }

    public class HeightMap
    {
        public int height { get; set; }
        public bool lowPoint { get; set; }
    }
}
