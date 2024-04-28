using NUnit.Framework;
using SIE.Core.DataSource;

namespace SIE.Core.Tests.DataTest
{
    [TestFixture]
    public class FireBirdTest
    {
        public FireBirdDataBase? _fbDataBase;
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
            _fbDataBase = null;
        }
        private void InitializeDataBase()
        {
            _fbDataBase = new FireBirdDataBase
            {
                ConnectionConfig = _connectionString
            };
            _fbDataBase.CreateConnection(_connectionString);
            _fbDataBase.BeginTransaction();
        }
        private void DisposeConnections()
        {
            _fbDataBase!.RollbackTransaction();
        }
    }
}
