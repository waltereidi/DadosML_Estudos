using CsvHelper;
using DadosML_Estudos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosML_Estudos.Services
{
    public class CsvStrategy : ICsvStrategy
    {
        public FileStream FileStream { get; set; }
        public ICsvReader CsvReader { get; set; }
        public ICsvTemplate CsvTemplate { get; set; }
        public ICsvCoR ChainOfResponsability { get;set; }

        public void SetChainOfResponsibility(ICsvCoR csvCor)
        {
            throw new NotImplementedException();
        }

        public void SetCsvReader(ICsvReader reader)
        {
            throw new NotImplementedException();
        }

        public void SetCsvTemplate(ICsvTemplate template)
        {
            throw new NotImplementedException();
        }

        public void SetFileStream(FileStream fs)
        {
            throw new NotImplementedException();
        }

        public Stream Start(string fileName)
        {

            //CsvReader.ReadCsv();



        }
    }
}
