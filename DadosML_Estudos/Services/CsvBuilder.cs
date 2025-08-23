using DadosML_Estudos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosML_Estudos.Services
{
    public class CsvBuilder : ICsvBuilder
    {
        private DirectoryInfo _directoryInfo =
            new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "Files/input"));
        private string _fileName { get; set; }
        private ICsvStrategy _csvStrategy { get; set; }
        public CsvBuilder(string fileName)
        {
            _csvStrategy = new CsvStrategy();
            _fileName = fileName;
        }
        public virtual void BuildFileService()
        {
            _csvStrategy.FileStream = new FileStream(
                Path.Combine(_directoryInfo.FullName, _fileName) , 
                FileMode.Open,
                FileAccess.Read 
                );   


        }

        public virtual void BuildReader()
        {
            throw new NotImplementedException();
        }

        public virtual void BuildWriter()
        {
            throw new NotImplementedException();
        }

        public virtual ICsvStrategy GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
