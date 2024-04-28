using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIE.Core.Adapters
{
    public class ExcelAdapter : Adapter
    {
        public virtual IEnumerable<T> Execute<T>(string pathFile, bool headerRow = false, string? sheetName = null)
        {
            throw new NotImplementedException();
        }
        public virtual IEnumerable<T> Execute<T>(Stream stream, bool headerRow = false, string? sheetName = null)
        {
            throw new NotImplementedException ();
        }
    }
}
