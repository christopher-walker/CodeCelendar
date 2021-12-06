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
        string fileParse = "";
        public FileInput(string path): this(path, "")
        {
            
        }
        public FileInput(string path, string parse)
        {
            filePath = path;
            if (parse.Length > 1)
            {
                throw new Exception("Parse length must only be one char");
            }
            fileParse = parse;
        }
        public string[] GetData()
        {
            if (string.IsNullOrEmpty(fileParse))
            {
                return System.IO.File.ReadAllLines(filePath);
            }
            else
            {
                string output = System.IO.File.ReadAllText(filePath);
                char[] parseChar = fileParse.ToCharArray();
                return output.Split(parseChar[0]);
            }
        }
    }
}
