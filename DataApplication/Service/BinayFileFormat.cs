using System;
using DataDomain;

namespace DataApplicaton.Factory
{
    public class BinayFileFormat : FileIO
    {
        private readonly string _fileName;
        public BinayFileFormat(string fileName)
        {
            _fileName = fileName;
        }
        public string ProcessFile()
        {
            var data = BinaryFileReader.ReadBytesFromFile(_fileName);
            return data;
        }
    }
}
