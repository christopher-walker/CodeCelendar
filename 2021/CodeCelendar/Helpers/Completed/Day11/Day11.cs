using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public static class Day11Util
    {
        public static int flashEnergyAfter = 9;
    }
    public class Day11
    {
        Dictionary<FlashCoordinate, EnergyLevel> coordinates = new Dictionary<FlashCoordinate, EnergyLevel>();
        public Day11(string[] input)
        {
            for(int x = 0; x < input.Length; x++)
            {
                char[] yInputs = input[x].ToCharArray();
                for (int y = 0; y < yInputs.Length; y++)
                {
                    coordinates.Add(new FlashCoordinate(x, y), new EnergyLevel(int.Parse(yInputs[y].ToString())));
                }
            }
        }

        private void IncreaseEnergyLevel(int increaseBy = 1)
        {
            foreach(FlashCoordinate coordinate in coordinates.Keys)
            {
                coordinates[coordinate].IncreaseEnergyLevel(increaseBy);
            }
        }

        private void HandleFlashing(int increaseBy = 1)
        {
            bool StillIncrementing = true;
            while (StillIncrementing)
            {
                StillIncrementing = false;
                foreach (FlashCoordinate coordinate in coordinates.Keys)
                {
                    bool newFlash = coordinates[coordinate].NewFlash();
                    if (newFlash)
                    {
                        StillIncrementing = true;
                        for(int xA = -1; xA < 2; xA++)
                        {
                            for (int yA = -1; yA < 2; yA++)
                            {
                                if(coordinates.ContainsKey(new FlashCoordinate(xA + coordinate.x, yA + coordinate.y)))
                                {
                                    coordinates[new FlashCoordinate(xA + coordinate.x, yA + coordinate.y)].IncreaseEnergyLevel(increaseBy);
                                }
                            }
                        }
                    }
                }
            }   
        }
        private double CalculateFlashes()
        {
            double returnValue = 0;
            foreach (FlashCoordinate coordinate in coordinates.Keys)
            {
                returnValue += coordinates[coordinate].ResetFlash();
            }
            return returnValue;
        }

        private double NumberOfIncrements(int increments)
        {
            double numberOfFlashes = 0;
            for(int i = 0; i < increments; i++)
            {
                IncreaseEnergyLevel();
                HandleFlashing();
                numberOfFlashes += CalculateFlashes();
                string currentState = PlotDictionary();
            }
            return numberOfFlashes;
        }

        private double AllFlash()
        {
            double step = 0;
            bool allFlashed = false;
            while (!allFlashed)
            {
                step++;
                IncreaseEnergyLevel();
                HandleFlashing();
                double numberFlashes = CalculateFlashes();
                if (numberFlashes == coordinates.Count())
                {
                    allFlashed = true;
                }

            }
            return step;

        }

        public string PlotDictionary()
        {
            string returnValue = string.Empty;
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    returnValue += coordinates[new FlashCoordinate(x, y)].energyLevel;
                }
                returnValue += System.Environment.NewLine;
            }
            return returnValue;
        }

        public string GetResultsPart1()
        {
            return NumberOfIncrements(100).ToString();
        }

        public string GetResultsPart2()
        {
            return AllFlash().ToString();
        }
    }

    public class EnergyLevel
    {
        public int energyLevel;
        List<FlashCoordinate> increasedBy = new List<FlashCoordinate>();
        bool flashing = false;
        public EnergyLevel(int value)
        {
            energyLevel = value;
        }

        public int ResetFlash()
        {
            if (flashing)
            {
                energyLevel = 0;
                flashing = false;
                return 1;
            }
            return 0;
        }

        public bool NewFlash()
        {
            if (energyLevel > Day11Util.flashEnergyAfter && !flashing)
            {
                flashing = true;
                return true;
            }
            return false;
        }

        public void IncreaseEnergyLevel(int level)
        {
            energyLevel += level;
        }
        public bool Flashing()
        {
            return energyLevel > Day11Util.flashEnergyAfter;
        }
    }

    public class FlashCoordinate
    {
        public int x;
        public int y;
        
        
        public FlashCoordinate(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }
        public override bool Equals(object obj)
        {
            bool returnValue = false;
            FlashCoordinate newCoord = obj as FlashCoordinate;
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
