using System.Globalization;
using CsvHelper;
using DadosML_Estudos.Interfaces;

namespace DadosML_Estudos.Services
{
    internal class CsvReader : ICsvReader
    {
        private Stream CsvFile { get; set; }

        public CsvReader(string fileName)
        {
        }
        public void ReadCsv()
        {
            throw new NotImplementedException();
        }

        public void WriteResult()
        {
            throw new NotImplementedException();
        }
    }
}


Console.WriteLine("Hello, World!");

// Exemplo de leitura de CSV
using var reader = new StreamReader("dados.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var registros = csv.GetRecords<dynamic>();
foreach (var registro in registros)
{
    Console.WriteLine(registro);
}