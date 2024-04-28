using NUnit.Framework;
using SIE.Core.DataSource;

namespace SIE.Core.Tests.DataTest
{
    [TestFixture]
    public class SQLTest
    {
        public SQLDataBase? _msSQLDataBase;
        public string _connectionString;

        [SetUp]
        public void SetUp()
        {
            InitializeDataBase();
        }
        [TearDown]
        public void TearDown()
        {
            DisposeConnections();
            _msSQLDataBase = null;
        }
        private void InitializeDataBase()
        {
            _msSQLDataBase = new SQLDataBase
            {
                ConnectionConfig = _connectionString
            };
            _msSQLDataBase.CreateConnection(_connectionString);
            _msSQLDataBase.BeginTransaction();
        }
        private void DisposeConnections()
        {
            _msSQLDataBase!.RollbackTransaction();
        }
    }
}
