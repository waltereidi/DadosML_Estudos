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
        public Stream FileStream { get; set; }
        private CsvReader CsvReader { get; set; }
        private ICsvTemplate CsvTemplate { get; set; }
        private ICsvCoR ChainOfResponsability { get;set; }
        public Stream Start(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
