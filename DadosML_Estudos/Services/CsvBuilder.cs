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
        public virtual void BuildFileService()
        {
            


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
