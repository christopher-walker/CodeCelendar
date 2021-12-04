using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers.Day4
{
    public class Bingo_Number
    {
        public Bingo_Number(int initNumber)
        {
            Number = initNumber;
            Drawn = false;
        }
        public int Number { get; set; }
        public bool Drawn { get; set; }

        public void DrawNumber(int number)
        {
            if (Number == number)
            {
                Drawn = true;
            }
        }
    }

    public class Bingo_Row
    {
        List<Bingo_Number> cardRow = new List<Bingo_Number>();
        public Bingo_Row(string row)
        {
            string[] rowItems = row.Split(' ');
            for(int i = 0; i < rowItems.Length; i++)
            {
                if (!string.IsNullOrEmpty(rowItems[i]))
                {
                    cardRow.Add(new Bingo_Number(int.Parse(rowItems[i])));
                }
            }
        }

        public void DrawNumber(int number)
        {
            for (int i = 0; i < cardRow.Count; i++){
                cardRow[i].DrawNumber(number);
            }
        }

        public bool HasRowBeenDrawn()
        {
            return cardRow.Where(x => x.Drawn == true).ToList().Count == cardRow.Count;
        }

        public bool RowCornersSelected()
        {
            return cardRow[0].Drawn && cardRow[cardRow.Count - 1].Drawn;
        }

        public bool HasPositionBeenDrawn(int position)
        {
            if (position >= cardRow.Count || position < 0) { return false; }
            return cardRow[position].Drawn;
        }

        public int GetNumberOfColumns()
        {
            return cardRow.Count;
        }

        public int GetRowScore(bool DrawNumber)
        {
            int returnValue = 0;
            for (int i = 0; i< cardRow.Count; i++)
            {
                if (cardRow[i].Drawn == DrawNumber)
                {
                    returnValue += cardRow[i].Number;
                }
            }
            return returnValue;
        }
    }
    public class Bingo_Card
    {
        public List<Bingo_Row> cardRows = new List<Bingo_Row>();
        public Bingo_Card(string[] cardNos)
        {
            foreach(string cardRow in cardNos)
            {
                cardRows.Add(new Bingo_Row(cardRow));
            }
        }

        public bool DrawNumber(int number)
        {
            for(int i = 0; i < cardRows.Count; i++)
            {
                cardRows[i].DrawNumber(number);
            }
            return CardWon();
        }

        public bool CardWon()
        {
            for (int i = 0; i < cardRows.Count; i++)
            {
                if (cardRows[i].HasRowBeenDrawn())
                {
                    return true;
                }
            }
            
            int numberOfPositions = cardRows[0].GetNumberOfColumns();
            for (int i = 0; i < numberOfPositions; i++)
            {
                bool columnWon = true;
                for (int j = 0; j < cardRows.Count; j++)
                {
                    if (!cardRows[j].HasPositionBeenDrawn(i))
                    {
                        columnWon = false;
                        j = cardRows.Count;
                    }
                }
                if (columnWon) { return true; }
            }

            return false;
        }

        public int CalculateBordScore(bool DrawNumber)
        {
            int returnValue = 0;
            for(int i = 0; i < cardRows.Count; i++)
            {
                returnValue += cardRows[i].GetRowScore(DrawNumber);
            }
            return returnValue;
        }
    }
    public class Day4_Bingo
    {
        string[] drawOrder;
        List<int> calledNumbers = new List<int>();

        List<Bingo_Card> cards = new List<Bingo_Card>();
        public Day4_Bingo(string[] bingoInput)
        {
            drawOrder = bingoInput[0].Split(',');
            List<string> cardRows = new List<string>();
            for (int i = 1; i < bingoInput.Length; i++)
            {
                if (bingoInput[i].Length == 0)
                {
                    // new card
                    if (cardRows.Count > 0)
                    {
                        cards.Add(new Bingo_Card(cardRows.ToArray()));
                    }
                    cardRows = new List<string>();
                }
                else
                {
                    cardRows.Add(bingoInput[i]);
                }
                if (i == bingoInput.Length-1 && cardRows.Count > 0)
                {
                    cards.Add(new Bingo_Card(cardRows.ToArray()));
                }
            }
        }

        public Bingo_Card GetWinningCard()
        {
            for(int i = 0; i < drawOrder.Length; i++)
            {
                int calledNumber = int.Parse(drawOrder[i]);
                calledNumbers.Add(calledNumber);
                for (int j=0; j<cards.Count;j++)
                {
                    cards[j].DrawNumber(calledNumber);
                    if (cards[j].CardWon())
                    {
                        return cards[j];
                    }
                }
            }
            return null;
        }

        public Bingo_Card GetLoosingCard()
        {
            int numberOfWinners = 0;
            for (int i = 0; i < drawOrder.Length; i++)
            {
                int calledNumber = int.Parse(drawOrder[i]);
                calledNumbers.Add(calledNumber);
                for (int j = 0; j < cards.Count; j++)
                {
                    if (!cards[j].CardWon())
                    {
                        cards[j].DrawNumber(calledNumber);
                        if (cards[j].CardWon())
                        {
                            numberOfWinners++;
                            if (numberOfWinners == cards.Count)
                            {
                                return cards[j];
                            }
                        }
                    }
                }
            }
            return null;
        }

        public int GetLastCalledNumber()
        {
            return calledNumbers.Last<int>();
        }

    }
}
