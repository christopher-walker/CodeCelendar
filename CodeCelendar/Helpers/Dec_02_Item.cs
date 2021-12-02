using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public class Dec_02_Item
    {
        public string direction;
        public int number;
        public Dec_02_Item(string input)
        {
            string[] parsed = input.Split(' ');
            if (parsed.Length == 2)
            {
                direction = parsed[0];
                number = int.Parse(parsed[1]);
            }
        }
    }
}
