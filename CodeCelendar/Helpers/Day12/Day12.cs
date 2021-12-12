using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public static class Day12Util
    {
        
    }
    public class Day12
    {
        HashSet<string> route = new HashSet<string>();
        Dictionary<string, Cave> caves = new Dictionary<string, Cave>();
        public Day12(string[] input)
        {
            for(int x = 0; x < input.Length; x++)
            {
                string[] path = input[x].Split('-');
                for (int i = 0; i < path.Length; i++)
                {
                    if (!caves.ContainsKey(path[i]))
                    {
                        caves.Add(path[i], new Cave(path[i]));
                    }
                    caves[path[i]].addConnectingCaves(i > 0 ? path[i - 1] : string.Empty, i < path.Length - 1 ? path[i + 1] : string.Empty);
                }
            }
        }

        public int GetNumberOfRoutes(string startCave, string endCave, int allowSmallCaveVisit = 0)
        {
            List<string> visitedCaves = new List<string>();
            List<string> returnedRoutes = UpdateRouteList(startCave, GetRoutes(caves[startCave], visitedCaves, endCave, allowSmallCaveVisit));
            List<string> distinctRoutes = returnedRoutes.Distinct().ToList();
            return distinctRoutes.Count();
        }

        public List<string> UpdateRouteList(string parentRoute, List<string> childRoutes)
        {
            List<string> returnValue = new List<string>();
            foreach(string child in childRoutes)
            {
                returnValue.Add($"{parentRoute}-{child}");
            }
            return returnValue;
        }

        public List<string> GetRoutes(Cave currentCave, List<string> visitedCaves, string endCave, int allowSmallCaveVisit = 0, string startCave = "start")
        {
            List<string> returnValue = new List<string>();
            visitedCaves.Add(currentCave.name);
            for(int i = 0; i<currentCave.connectingCaves.Count; i++)
            {
                if (currentCave.connectingCaves[i] != endCave && (!visitedCaves.Contains(currentCave.connectingCaves[i]) || caves[currentCave.connectingCaves[i]].big || (allowSmallCaveVisit > 0 && currentCave.connectingCaves[i] != startCave)))
                {
                    int currentVisits = allowSmallCaveVisit;
                    if (!caves[currentCave.connectingCaves[i]].big && visitedCaves.Contains(currentCave.connectingCaves[i]))
                    {
                        currentVisits--;

                    }
                    returnValue.AddRange(GetRoutes(caves[currentCave.connectingCaves[i]], new List<string>(visitedCaves), endCave, currentVisits));
                }
                else if (currentCave.connectingCaves[i] == endCave)
                {
                    returnValue.Add(currentCave.connectingCaves[i]);
                }
            }
            return UpdateRouteList(currentCave.name, returnValue);
        }

        public string GetResultsPart1()
        {
            return GetNumberOfRoutes("start", "end").ToString();
        }

        public string GetResultsPart2()
        {
            return GetNumberOfRoutes("start", "end", 1).ToString();
        }
    }

    public class Cave
    {
        public bool big = false;
        public string name = string.Empty;
        public List<string> connectingCaves = new List<string>();
        public Cave(string caveName)
        {
            name = caveName;
            big = caveName == caveName.ToUpper();
        }

        public void addConnectingCaves(string caveBefore, string caveAfter)
        {
            addConnectingCave(caveBefore);
            addConnectingCave(caveAfter);
        }

        private void addConnectingCave(string caveName)
        {
            if (!string.IsNullOrEmpty(caveName) && !connectingCaves.Contains(caveName))
            {
                connectingCaves.Add(caveName);
            }
        }

        public override bool Equals(object obj)
        {
            bool returnValue = false;
            Cave newCave = obj as Cave;
            if (newCave != null)
            {
                return newCave.name == name;
            }
            return returnValue;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
