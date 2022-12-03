using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public class Dec_02_2022
    {
        Dictionary<string, string> elfPlay = new Dictionary<string, string>();
        //private string[] input;
        List<RockPaperScissorsGame> rounds = new List<RockPaperScissorsGame>();
        public Dec_02_2022(string[] input)
        {
            elfPlay.Add("A", "X");
            elfPlay.Add("B", "Y");
            elfPlay.Add("C", "Z");

            for (int i = 0; i < input.Length; i++)
            {
                string[] round = input[i].Split(new char[] { ' ' });
                rounds.Add(new RockPaperScissorsGame(elfPlay[round[0]], round[1]));
                //movements[i] = new Dec_02_Item(input[i]);
            }
        }

        public double GuidePoints
        {
            get
            {
                return rounds.Sum(x => x.FullPoints);
            }
        }

        public double RealGuidePoints
        {
            get
            {
                return rounds.Sum(x => x.RealFullPoints);
            }
        }
    }


    public class RockPaperScissorsGame
    {
        private string _ourPlay;
        private double _ourPlayValue
        {
            get
            {
                if (_ourPlay == "X") { return 1; }
                if (_ourPlay == "Y") { return 2; }
                return 3;
            }
        }
        private string _elfPlay;
        public double RoundPoints
        {
            get
            {
                if(_elfPlay == _ourPlay) { return 3; }
                if (_elfPlay == "X")
                {
                    return _ourPlay == "Y" ? 6 : 0;
                }
                if (_elfPlay == "Y")
                {
                    return _ourPlay == "Z" ? 6 : 0;
                }
                if (_elfPlay == "Z")
                {
                    return _ourPlay == "X" ? 6 : 0;
                }
                return 0;
            }
        }

        // X Lose
        // Y Dray
        // Z Win
        public double FullPoints
        {
            get
            {
                return RoundPoints + _ourPlayValue;
            }
        }


        public int RealFullPoints
        {
            get
            {
                if (_elfPlay == "X")
                {
                    if (_ourPlay == "X") // Plays Rock
                    {
                        return 3; // lose with scissors
                    }
                    else if (_ourPlay == "Y")
                    {
                        return 4; // draw with rock
                    }
                    else
                    {
                        return 8; // win with paper
                    }

                }
                else if (_elfPlay == "Y") // Plays Paper
                {
                    if (_ourPlay == "X") // Lose
                    {
                        return 1; // Rock
                    }
                    else if (_ourPlay == "Y")
                    {
                        return 5; // draw with Paper
                    }
                    else
                    {
                        return 9; // win with scissors
                    }
                }
                else // Plays Scissors
                {
                    if (_ourPlay == "X") // Lose
                    {
                        return 2; // Paper
                    }
                    else if (_ourPlay == "Y")
                    {
                        return 6; // draw with Scissors
                    }
                    else
                    {
                        return 7; // win with Rock
                    }
                }
            }
        }



        public RockPaperScissorsGame(string elfPlay, string ourPlay)
        {
            _ourPlay = ourPlay;
            _elfPlay = elfPlay;
        }
    }
}
