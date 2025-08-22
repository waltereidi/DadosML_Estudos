using DadosML_Estudos.Enum;
using DadosML_Estudos.Interfaces;

namespace DadosML_Estudos.Services
{
    public class CsvTemplate : ICsvTemplate
    {
        private readonly List<List<string>> _dto;
        private readonly List<string> _columnTypes;
        private List<ColumnType> _types { get; set; }
        public List<List<double>> _result { get; private set; }
        public CsvTemplate(List<List<string>> dto, List<string> columnTypes) 
        { 
            this._dto = dto ?? throw new ArgumentNullException(nameof(dto), "DTO cannot be null");
            _columnTypes = columnTypes ?? throw new ArgumentNullException(nameof(columnTypes), "Type cannot be null");
            _types = new List<ColumnType>();
            _result = new List<List<double>>();
        }
        public void ConvertColumns()
        {
            _types.Select((s, i) => new { v = s , i = i})
                .ToList()
                .ForEach(f => {
                switch (f.v)
                {
                    case ColumnType.SimpleAggregateReduction: ToSimpleAggregateReduction(_dto.ElementAt(f.i));break;
                    case ColumnType.ToInteger:break;
                    default: throw new ArgumentException($"Invalid column type: {f}", nameof(_types));
                }
            });
        }
        private void ToSimpleAggregateReduction(List<string> column)
        {
            List<double> res = column.GroupBy(g => g)
                .Select((s, i) => (double)i)
                .ToList();

            _result.Add(res);
        }
        private void ToInt(List<string> column )
        {
            List<double> res = column.Select(s => double.Parse(s))
                .ToList();

            _result.Add(res);
        }
        public void IdentifyColumns()
        {
            _columnTypes.ForEach(f => {
                switch (f)
                {
                    case "1" : _types.Add(ColumnType.SimpleAggregateReduction); break;
                    case "2" : _types.Add(ColumnType.ToInteger); break;
                    default : throw new ArgumentException($"Invalid column type: {f}", nameof(_columnTypes));
                }
            });
        }
    }
}
