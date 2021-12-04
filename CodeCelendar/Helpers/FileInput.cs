using CodeCelendar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCelendar.Helpers
{
    public class FileInput: IDataInput
    {
        string filePath;
        public FileInput(string path)
        {
            filePath = path;
        }
        public string[] GetData()
        {
            return System.IO.File.ReadAllLines(filePath);
        }
    }
}
