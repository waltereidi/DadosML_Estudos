using DadosML_Estudos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosML_Estudos.Services
{
    public class CsvCor : ICsvCoR
    {
        private DirectoryInfo _directoryInfo =
            new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "Files/output"));
        private Stream _stream { get; set; }
        private string _fileName { get; set; }
        public void SetFile(Stream file, string fileName)
        { 
            _stream = file; 
            _fileName = fileName;
        }

        public async Task WriteFile()
        {
            var fileName = String.Concat(
                _directoryInfo.FullName.Substring(0, 20) , new Guid().ToString());

            using (var s = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                _stream.CopyTo(s);
            }
        }
    }
}
