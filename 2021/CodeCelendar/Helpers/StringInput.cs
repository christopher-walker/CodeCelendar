using CodeCelendar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public class StringInput:IDataInput
    {
        string stringInput;
        char inputDelimitor;
        public StringInput(string input):this(input,',')
        {
            
        }
        public StringInput(string input, char delimitor)
        {
            stringInput = input;
            inputDelimitor = delimitor;
        }
        public string[] GetData()
        {
            return stringInput.Split(inputDelimitor);
        }
    }
}
