using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosML_Estudos.Interfaces
{
    public interface ICsvStrategy
    {
        void SetFileStream(FileStream fs);
        void SetCsvReader(ICsvReader reader);
        void SetCsvTemplate(ICsvTemplate template);
        void SetChainOfResponsibility(ICsvCoR csvCor);
        Stream Start(string fileName);

    }
}
