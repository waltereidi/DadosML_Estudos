using DadosML_Estudos.Enum;
using DadosML_Estudos.Interfaces;

namespace DadosML_Estudos.Services
{
    public class CsvTemplate : ICsvTemplate
    {
        private readonly List<List<string>> _dto;
        private readonly List<string> _columnTypes;
        private List<ColumnType> _types { get; set; }
        public List<List<string>> _result { get; private set; }
        public CsvTemplate(List<List<string>> dto, List<string> columnTypes) 
        { 
            this._dto = dto ?? throw new ArgumentNullException(nameof(dto), "DTO cannot be null");
            _columnTypes = columnTypes ?? throw new ArgumentNullException(nameof(columnTypes), "Type cannot be null");
            _types = new List<ColumnType>();
        }
        public void ConvertColumns()
        {
            _types.ForEach(f => {
                switch (f)
                {
                    case ColumnType.SimpleAggregateReduction: ;break;
                    case ColumnType.ToInteger:break;
                    default: throw new ArgumentException($"Invalid column type: {f}", nameof(_types));
                }
            });
        }
        private void ToSimpleAggregateReduction()
        {
               
        }
        private void ToInt()
        {

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
