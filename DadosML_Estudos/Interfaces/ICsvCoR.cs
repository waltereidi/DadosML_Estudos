using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosML_Estudos.Interfaces
{
    public interface ICsvCoR
    {
        void SetFile(Stream file , string fileName);
        Task WriteFile();
    }
}
