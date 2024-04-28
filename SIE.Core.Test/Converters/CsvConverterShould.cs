using FluentAssertions;
using SIE.Core.Converters;
using SIE.Core.Test.DTOs;

namespace SIE.Core.Test.Converters
{
    public class CsvConverterShould
    {
        private CsvConverter _csvConverter;

        [SetUp]
        public void SetUp()
        {
            _csvConverter = new CsvConverter();
        }
        [Test]
        public void ConvertListToCsv()
        {
            var dataList = GetObjetList();
            var expectedRow = GetExpectedCsvRow();
            var i = 0;
            var result = _csvConverter.Transform(dataList, '|');

            result.Count.Should().Be(expectedRow.Count);
            result.ForEach(row => {
                row.Should().Be(expectedRow.ElementAt(i));
                i++;
            });
        }

        private static List<string> GetExpectedCsvRow()
        {
            return [
                "Id|Name|Description",
                "1|JhonMe|Test",
                "2|JuanMa|AramarkPeople"
            ];
        }
        private static List<TestDto> GetObjetList()
        {
            return [
                new() { Id = 1, Name = "Jhon&Me\r\n", Description = "Test\t'"},
                new() { Id = 2, Name = "Juan&Ma\r\n", Description = "AramarkPeople\t"}
            ];
        }
    }
}
