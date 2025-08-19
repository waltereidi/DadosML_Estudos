using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosML_Estudos.Interfaces
{
    public interface ICsvStrategy
    {
        Stream Start(string fileName);

    }
}
