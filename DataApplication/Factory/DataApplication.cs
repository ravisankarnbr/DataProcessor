using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplicaton.Factory
{
    public abstract class DataApplication
    {        
        private readonly string _filePath;
        public DataApplication(string filePath)
        {           
            _filePath = filePath;
        }
        protected abstract FileIO GetFile(string _filePath);
        public FileIO ReadFile()
        {
            return this.GetFile(_filePath);
        }
    }
}
