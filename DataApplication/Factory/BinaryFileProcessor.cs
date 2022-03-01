using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplicaton.Factory
{
    public class BinaryFileProcessor : DataApplication
    {
        public BinaryFileProcessor(string filePath) : base(filePath)
        {

        }
        protected override FileIO GetFile(string fileName)
        {
            FileIO file = new BinayFileFormat(fileName);
            return file;
        }
    }
}
