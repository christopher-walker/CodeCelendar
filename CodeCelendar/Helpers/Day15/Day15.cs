using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{

    public static class Day15Util
    {

    }
    public class Day15
    {
        int[,] riskMap;
        VisitedCoordinate start;
        VisitedCoordinate end;
        //static int V = 9;
        Dictionary<VisitedCoordinate, VisitedCoordinateValues> trackedCoordinates;

        public Day15(string[] input)
        {
            start = new VisitedCoordinate(0, 0);
            end = new VisitedCoordinate(input[0].Length - 1, input[1].Length - 1);
            riskMap = new int[input[0].Length, input.Length];

            
            for (int i = 0; i < input.Length; i++)
            {
                char[] items = input[i].ToCharArray();
                for(int j = 0; j < items.Length; j++)
                {
                    //trackedCoordinates.Add(new VisitedCoordinate(i, j), new VisitedCoordinateValues(i == 0 && j == 0 ? 0 : long.MaxValue));
                    riskMap[i, j] = int.Parse(items[j].ToString());
                }
            }
        }

        public void GetTrackedCoordinates(int[,] inputRiskMap)
        {
            trackedCoordinates = new Dictionary<VisitedCoordinate, VisitedCoordinateValues>();
            for (int x = 0; x < inputRiskMap.GetLength(0); x++)
            {
                for (int y =0; y<inputRiskMap.GetLength(1); y++)
                {
                    trackedCoordinates.Add(new VisitedCoordinate(x, y), new VisitedCoordinateValues(x == 0 && y == 0 ? 0 : int.MaxValue));
                }
            }
        }

        //int minDistance(int[] dist,
        //            bool[] sptSet)
        //{
        //    // Initialize min value
        //    int min = int.MaxValue, min_index = -1;

        //    for (int v = 0; v < V; v++)
        //        if (sptSet[v] == false && dist[v] <= min)
        //        {
        //            min = dist[v];
        //            min_index = v;
        //        }

        //    return min_index;
        //}

        //void dijkstra(int[,] graph, int src, int xCord, int yCord)
        //{
        //    int[] dist = new int[V]; // The output array. dist[i]
        //                             // will hold the shortest
        //                             // distance from src to i
        //    List<int> dist = new List<int>();
        //    // sptSet[i] will true if vertex
        //    // i is included in shortest path
        //    // tree or shortest distance from
        //    // src to i is finalized
        //    bool[] sptSet = new bool[V];

        //    // Initialize all distances as
        //    // INFINITE and stpSet[] as false
        //    for (int i = 0; i < V; i++)
        //    {
        //        dist[i] = int.MaxValue;
        //        sptSet[i] = false;
        //    }

        //    // Distance of source vertex
        //    // from itself is always 0
        //    dist[src] = 0;

        //    // Find shortest path for all vertices
        //    for (int count = 0; count < xCord; count++)
        //    {
        //        for (int countY = 0; countY < yCord; countY++)
        //        {
        //        // Pick the minimum distance vertex
        //        // from the set of vertices not yet
        //        // processed. u is always equal to
        //        // src in first iteration.
        //        int u = minDistance(dist, sptSet);

        //        // Mark the picked vertex as processed
        //        sptSet[u] = true;

        //        // Update dist value of the adjacent
        //        // vertices of the picked vertex.
        //        for (int v = 0; v < V; v++)

        //            // Update dist[v] only if is not in
        //            // sptSet, there is an edge from u
        //            // to v, and total weight of path
        //            // from src to v through u is smaller
        //            // than current value of dist[v]
        //            if (!sptSet[v] && graph[u, v] != 0 &&
        //                 dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
        //                dist[v] = dist[u] + graph[u, v];
        //        }

                
        //    }

        //    // print the constructed distance array
        //    //printSolution(dist, V);
        //    int x = 0;
        //}

        //public List<Dictionary<VisitedCoordinate, int>> CalculateRouteCost(int x, int y, List<VisitedCoordinate> VisitedInput)
        //{
        //    //Dictionary<VisitedCoordinate, int> newVisited = new Dictionary<VisitedCoordinate, int>(Visited);
        //    List<VisitedCoordinate> Visited = new List<VisitedCoordinate>(VisitedInput);
        //    Visited.Add(new VisitedCoordinate(x, y));
        //    List<Dictionary<VisitedCoordinate, int>> returnValue = new List<Dictionary<VisitedCoordinate, int>>();
        //    VisitedCoordinate vc = new VisitedCoordinate(x, y);
        //    Dictionary<VisitedCoordinate, int> retDictionary = new Dictionary<VisitedCoordinate, int>();

        //    if (x == riskMap.GetLength(0) - 1 && y == riskMap.GetLength(1) - 1)
        //    {
        //        retDictionary.Add(new VisitedCoordinate(x, y), riskMap[x, y]);
        //        returnValue.Add(retDictionary);
        //        return returnValue;
        //    }
        //    List<Dictionary<VisitedCoordinate, int>> returnPaths = new List<Dictionary<VisitedCoordinate, int>>();
        //    if (x > 0 && !Visited.Contains(new VisitedCoordinate(x-1, y)))
        //    {
        //        returnPaths.AddRange(CalculateRouteCost(x - 1, y, Visited));
        //    }
        //    if (y > 0 && !Visited.Contains(new VisitedCoordinate(x, y - 1)))
        //    {
        //        returnPaths.AddRange(CalculateRouteCost(x, y - 1, Visited));
        //    }
        //    if (x + 1 < riskMap.GetLength(0) && !Visited.Contains(new VisitedCoordinate(x + 1, y))){
        //        returnPaths.AddRange(CalculateRouteCost(x + 1, y, Visited));
        //    }
        //    if (y + 1 < riskMap.GetLength(1) && !Visited.Contains(new VisitedCoordinate(x, y + 1))){
        //        returnPaths.AddRange(CalculateRouteCost(x, y + 1, Visited));
        //    }

        //    foreach (Dictionary<VisitedCoordinate, int> dictionary in returnPaths)
        //    {
        //        if (dictionary.ContainsKey(new VisitedCoordinate(riskMap.GetLength(0) - 1, riskMap.GetLength(1) - 1)))
        //        {
        //            // then the path has reached the end
        //            var newDictionary = dictionary;
        //            newDictionary.Add(new VisitedCoordinate(x, y), riskMap[x, y]);
        //            returnValue.Add(newDictionary);
        //        }
        //    }
        //    return returnValue;

        //}



        public void GetShortestRoute(int[,] riskMapInput)
        {
            List<VisitedCoordinate> visited = new List<VisitedCoordinate>();
            // The first spot does not cost anything
            VisitedCoordinate coord = new VisitedCoordinate(0, 0);

            // calculate all neighbours from the current point
            CalculateNeighbours(coord.x, coord.y, trackedCoordinates[coord].cost, visited, riskMapInput);
            visited.Add(coord);
            int quickX = 1;
            int quickY = 1;
            int quickYMax = riskMapInput.GetLength(1)-1;
            int quickXMax = riskMapInput.GetLength(0)-1;
            while (quickX < riskMapInput.GetLength(0) && quickY < riskMapInput.GetLength(1))
            {
                VisitedCoordinate coordNew;
                if ((riskMapInput[quickX, quickY - 1] > riskMapInput[quickX - 1, quickY] && quickY <= quickYMax) || quickX == quickXMax)
                {
                    coordNew = new VisitedCoordinate(quickX - 1, quickY);
                    quickY++;
                }
                else
                {
                    coordNew = new VisitedCoordinate(quickX, quickY - 1);
                    quickX++;
                }
                
                CalculateNeighbours(coordNew.x, coordNew.y, trackedCoordinates[coordNew].cost, visited, riskMapInput);
                //visited.Add(coordNew);

                if (quickX+quickY > quickXMax + quickYMax)
                {
                    coordNew = new VisitedCoordinate(quickXMax, quickYMax);
                    CalculateNeighbours(coordNew.x, coordNew.y, trackedCoordinates[coordNew].cost, visited, riskMapInput);
                    //visited.Add(coordNew);
                }
            }

            
            List< KeyValuePair<VisitedCoordinate, VisitedCoordinateValues>> unvisitedCoordinates = trackedCoordinates.Where(x => !visited.Contains(x.Key)).ToList();

            while (unvisitedCoordinates.Count > 0)
            {
                unvisitedCoordinates = unvisitedCoordinates.Where(x => x.Value.cost == int.MaxValue || x.Value.cost < trackedCoordinates[new VisitedCoordinate(quickXMax, quickYMax)].cost).ToList();
                long smallest = unvisitedCoordinates.Min(x => x.Value.cost);
                KeyValuePair<VisitedCoordinate, VisitedCoordinateValues>  smallestItem = unvisitedCoordinates.Where(x => x.Value.cost == smallest).FirstOrDefault();

                CalculateNeighbours(smallestItem.Key.x, smallestItem.Key.y, smallestItem.Value.cost, visited, riskMapInput);
                visited.Add(smallestItem.Key);
                var itemToRemove = unvisitedCoordinates.Single(r => r.Key == smallestItem.Key);
                unvisitedCoordinates.Remove(itemToRemove);
                //unvisitedCoordinates = trackedCoordinates.Where(x => !visited.Contains(x.Key)).ToList();
            }
        }

        public string PlotRoute()
        {
            string returnValues = string.Empty;
            for (int x = 0; x < riskMap.GetLength(0); x++)
            {
                for (int y = 0; y < riskMap.GetLength(1); y++)
                {
                    if (y > 0)
                    {
                        returnValues += "-";
                    }
                    returnValues += trackedCoordinates[new VisitedCoordinate(x, y)].cost;
                }
                returnValues += Environment.NewLine;
            }
            return returnValues;
        }

        public void CalculateNeighbours(int x, int y, int currentTotal, List<VisitedCoordinate> visited, int[,] riskMapInput)
        {
            if (x > 0)
            {
                // we can move to the left
                int currentCost = trackedCoordinates[new VisitedCoordinate(x - 1, y)].cost;
                if (currentCost > currentTotal + riskMapInput[x - 1, y] && !visited.Contains(new VisitedCoordinate(x - 1, y)))
                {
                    trackedCoordinates[new VisitedCoordinate(x - 1, y)].cost = currentTotal + riskMapInput[x - 1, y];
                    trackedCoordinates[new VisitedCoordinate(x - 1, y)].previousCoordinate = new VisitedCoordinate(x, y);
                }
            }
            if (x < riskMapInput.GetLength(0) - 1 && !visited.Contains(new VisitedCoordinate(x + 1, y)))
            {
                // We can move to the right
                int currentCost = trackedCoordinates[new VisitedCoordinate(x + 1, y)].cost;
                if (currentCost > currentTotal + riskMapInput[x + 1, y])
                {
                    trackedCoordinates[new VisitedCoordinate(x + 1, y)].cost = currentTotal + riskMapInput[x + 1, y];
                    trackedCoordinates[new VisitedCoordinate(x + 1, y)].previousCoordinate = new VisitedCoordinate(x, y);
                }
            }
            if (y > 0 && !visited.Contains(new VisitedCoordinate(x, y - 1)))
            {
                // we can move up
                int currentCost = trackedCoordinates[new VisitedCoordinate(x , y - 1)].cost;
                if (currentCost > currentTotal + riskMapInput[x , y - 1])
                {
                    trackedCoordinates[new VisitedCoordinate(x , y - 1)].cost = currentTotal + riskMapInput[x, y - 1];
                    trackedCoordinates[new VisitedCoordinate(x , y - 1)].previousCoordinate = new VisitedCoordinate(x, y - 1);
                }
            }
            if (y < riskMapInput.GetLength(1) - 1 && !visited.Contains(new VisitedCoordinate(x, y + 1)))
            {
                // we can move down
                int currentCost = trackedCoordinates[new VisitedCoordinate(x, y + 1)].cost;
                if (currentCost > currentTotal + riskMapInput[x, y + 1])
                {
                    trackedCoordinates[new VisitedCoordinate(x, y + 1)].cost = currentTotal + riskMapInput[x, y + 1];
                    trackedCoordinates[new VisitedCoordinate(x, y + 1)].previousCoordinate = new VisitedCoordinate(x, y + 1);
                }
            }
        }

        public string GetResultsPart1()
        {
            GetTrackedCoordinates(riskMap);
            GetShortestRoute(riskMap);
            //dijkstra(riskMap, 0);
            //List<Dictionary<VisitedCoordinate, int>> paths = CalculateRouteCost(0, 0, new List<VisitedCoordinate>());
            //int i = int.MaxValue;
            //foreach(Dictionary<VisitedCoordinate, int> path in paths)
            //{
            //    i = i > path.Values.Sum() ? path.Values.Sum() : i;
            //}
            return trackedCoordinates[end].cost.ToString();  
            //i.ToString();
        }

        public int[,] ExpandRiskMap(int numberOfTimes)
        {
            int[,] returnValue = new int[riskMap.GetLength(0) * 5, riskMap.GetLength(1) * 5];
            int xIncrementer = 0;
            int xSubcounter = 0;
            for (int x = 0; x < riskMap.GetLength(0) * numberOfTimes; x++)
            {
                if (xSubcounter >= riskMap.GetLength(0))
                {
                    xSubcounter = 0;
                    xIncrementer++;
                }

                int yIncrementor = 0;
                int ySubcounter = 0;
                for (int y = 0; y < riskMap.GetLength(1) * numberOfTimes; y++)
                {
                    if (ySubcounter >= riskMap.GetLength(1))
                    {
                        ySubcounter = 0;
                        yIncrementor++;
                    }
                    returnValue[x, y] = incrementValue(riskMap[xSubcounter, ySubcounter], xIncrementer + yIncrementor);
                    ySubcounter++;
                }
                ySubcounter = 0;
                xSubcounter++;
            }
            return returnValue;
        }

        public int incrementValue(int currentValue, int incrementer)
        {
            currentValue = currentValue + incrementer;
            return currentValue <= 9 ? currentValue : currentValue - 9;
        }

        public string OutputGrid(int[,] myGrid)
        {
            string returnValues = string.Empty;
            for (int x = 0; x < myGrid.GetLength(0); x++)
            {
                for (int y = 0; y < myGrid.GetLength(1); y++)
                {
                    returnValues += myGrid[x, y].ToString();
                }
                returnValues += Environment.NewLine;
            }
            return returnValues;
        }

        public string GetResultsPart2()
        {
            int[,] ExpandedMapOutput = ExpandRiskMap(5);
            //string outMap = OutputGrid(ExpandedMapOutput);
            GetTrackedCoordinates(ExpandedMapOutput);
            GetShortestRoute(ExpandedMapOutput);
            return trackedCoordinates[new VisitedCoordinate(ExpandedMapOutput.GetLength(0) - 1, ExpandedMapOutput.GetLength(1) - 1)].cost.ToString();
        }
    }

    public class VisitedCoordinateValues
    {
        public int cost;
        public VisitedCoordinate previousCoordinate;
        public VisitedCoordinateValues(int initialCost)
        {
            cost = initialCost;
            previousCoordinate = null;
        }
    }

    public class VisitedCoordinate
    {
        public int x;
        public int y;

        public VisitedCoordinate(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }

        public override bool Equals(object obj)
        {
            bool returnValue = false;
            VisitedCoordinate newCoord = obj as VisitedCoordinate;
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
