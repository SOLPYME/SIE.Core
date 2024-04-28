using NUnit.Framework;
using SIE.Core.DataSource;

namespace SIE.Core.Tests.DataTest
{
    public class DatabaseSQLiteTest
    {
        protected SQLiteDataBase _datasource;
        protected string _connectionString;
        protected List<string> _tables;

        [SetUp]
        public void SetUp()
        {
            _datasource = new SQLiteDataBase
            {
                ConnectionConfig = _connectionString
            };
            _tables = [];
        }
        [TearDown]
        public void TearDown()
        {
            DisposeTables();
        }
        protected void DisposeTable(string x)
        {
            _datasource.SelectScalar<int>($"Delete from {x}");
        }
        protected void DisposeTables()
        {
            _tables?.ForEach(x => DisposeTable(x));
        }
    }
}
