using NUnit.Framework;
using SIE.Core.DataSource;

namespace SIE.Core.Tests.DataTest
{
    [TestFixture]
    public class SQLiteTest
    {
        public SQLiteDataBase? _sqLiteDataBase;
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
            _sqLiteDataBase = null;
        }
        private void InitializeDataBase()
        {
            _sqLiteDataBase = new SQLiteDataBase
            {
                ConnectionConfig = _connectionString
            };
            _sqLiteDataBase.CreateConnection(_connectionString);
            _sqLiteDataBase.BeginTransaction();
        }
        private void DisposeConnections()
        {
            _sqLiteDataBase!.RollbackTransaction();
        }
    }
}
