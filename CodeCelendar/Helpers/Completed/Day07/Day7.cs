using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day7
{
    public class Day7
    {
        List<Position> positions = new List<Position>();
        int largestPosition = int.MinValue;
        int smallestPosition = int.MaxValue;

        public Dictionary<int, int> TotalCosts;
        public Day7(string[] input)
        {
            foreach(string inp in input)
            {
                int currentPosition = int.Parse(inp);
                if (currentPosition > largestPosition)
                {
                    largestPosition = currentPosition;
                }

                if (currentPosition < smallestPosition)
                {
                    smallestPosition = currentPosition;
                }
                positions.Add(new Position(currentPosition));
            }
        }

        public void CalculateAllPositions()
        {
            TotalCosts = new Dictionary<int, int>();
            for(int i = 0; i < positions.Count; i++)
            {
                Dictionary<int, int>  PositionCost = positions[i].GetPositionCosts(smallestPosition, largestPosition);
                foreach(int key in PositionCost.Keys)
                {
                    if (!TotalCosts.ContainsKey(key))
                    {
                        TotalCosts.Add(key, PositionCost[key]);
                    }
                    else
                    {
                        TotalCosts[key] += PositionCost[key];
                    }
                }
            }
        }

        public void CalculateAllPositions2()
        {
            TotalCosts = new Dictionary<int, int>();
            for (int i = 0; i < positions.Count; i++)
            {
                Dictionary<int, int> PositionCost = positions[i].GetPositionCosts2(smallestPosition, largestPosition);
                foreach (int key in PositionCost.Keys)
                {
                    if (!TotalCosts.ContainsKey(key))
                    {
                        TotalCosts.Add(key, PositionCost[key]);
                    }
                    else
                    {
                        TotalCosts[key] += PositionCost[key];
                    }
                }
            }
        }

        public int GetSmallestPositionChange()
        {
            CalculateAllPositions();
            List<int> keys = TotalCosts.Keys.ToList();
            var query = keys.Select(key => TotalCosts[key]).ToList();
            return query.Min();
        }

        public int GetSmallestPositionChange2()
        {
            CalculateAllPositions2();
            List<int> keys = TotalCosts.Keys.ToList();
            var query = keys.Select(key => TotalCosts[key]).ToList();
            return query.Min();
        }
    }

    public class Position
    {
        public int StartPosition { get; set; }
        public Dictionary<int, int> EndPositions;

        public Position(int position)
        {
            StartPosition = position;
        }

        public Dictionary<int, int> GetPositionCosts(int minPosition, int maxPosition)
        {
            EndPositions = new Dictionary<int, int>();
            for (int i = minPosition; i <= maxPosition; i++)
            {
                EndPositions.Add(i, CalculatePositionCost(i, StartPosition));
            }
            return EndPositions;
        }
        public int CalculatePositionCost(int targetPosition, int startPosition)
        {
            int returnValue = startPosition - targetPosition;
            if (returnValue < 0)
            {
                returnValue = returnValue * -1;
            }
            return returnValue;
        }


        public Dictionary<int, int> GetPositionCosts2(int minPosition, int maxPosition)
        {
            EndPositions = new Dictionary<int, int>();
            for (int i = minPosition; i <= maxPosition; i++)
            {
                EndPositions.Add(i, CalculatePositionCost2(i, StartPosition));
            }
            return EndPositions;
        }
        public int CalculatePositionCost2(int targetPosition, int startPosition)
        {
            int returnValue = 0;
            int totalMoves = CalculatePositionCost(targetPosition, startPosition);
            for(int i = 0; i < totalMoves; i++)
            {
                returnValue += i + 1;
            }
            return returnValue;
        }
    }
}
