using SIE.Core.Adapters;

namespace SIE.Core.Test.Adapters
{
    public class ExcelAdaptersShould
    {
        private ExcelAdapter _excelAdapter;

        [SetUp]
        public void SetUp()
        {
            _excelAdapter = new ExcelAdapter();
        }
    }
}
