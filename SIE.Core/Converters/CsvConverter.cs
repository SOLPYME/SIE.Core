using SIE.Core.Extensions;
using System.ComponentModel;

namespace SIE.Core.Converters
{
    public class CsvConverter
    {
        public virtual List<string> Transform<T>(List<T> dataList, char separator)
        {
            var rows = new List<string>();

            IEnumerable<PropertyDescriptor> propertiesName = TypeDescriptor.GetProperties(typeof(T)).OfType<PropertyDescriptor>();
            var headers = string.Join(separator, propertiesName.ToList().Select(x => x.Name));
            rows.Add(headers);
            var valueLines = dataList.Select(row => string.Join(separator, headers.Split(separator)
                                     .Select(a => row?.GetType()?.GetProperty(a)?
                                        .GetValue(row, null)?.ToString()?
                                        .RemoveSpecialCharacters() ?? string.Empty)));
            rows.AddRange(valueLines);
            return rows;
        }
    }
}
