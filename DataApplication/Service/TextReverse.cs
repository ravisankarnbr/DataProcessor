using DataDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplicaton.Factory
{
    public class TextReverse : FileIO
    {
        private readonly string _fileName;
        public TextReverse(string fileName)
        {
            _fileName = fileName;
        }
        public string ProcessFile()
        {
            var text = TextFileReader.ReverseReadDataWithUTF8Encoding(_fileName);
            return text;
        }
    }
}
