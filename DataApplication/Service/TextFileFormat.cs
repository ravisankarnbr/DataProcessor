using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDomain;

namespace DataApplicaton.Factory
{
    public class TextFileFormat : FileIO
    {
        private readonly string _fileName;
        public TextFileFormat(string fileName)
        {
            _fileName = fileName;
        }
        public string ProcessFile()
        {
            var text = TextFileReader.ReadDataTxtFileWithUTF8Encoding(_fileName);
            return text;
        }
    }
}
