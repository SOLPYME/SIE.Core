using Dapper;
using System.Data;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace SIE.Core.DataSource
{
    public class SQLDataBase : IDataSource
    {
        private const int _maxTimeOut = 300;

        private SqlCommand _command;
        private SqlConnection _sqlConnection;
        private SqlTransaction _transaction;
        private bool _useTransaction;

        public string ConnectionConfig { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void BulkInsert<T>(string targetTable, IEnumerable<T> data)
        {
            throw new NotImplementedException();
        }

        public Task BulkInsertAsync<T>(string targetTable, IEnumerable<T> data)
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void CreateConnection(string connectionConfig)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string query, object? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteAsync(string query, object? parameters = null)
        {
            throw new NotImplementedException();
        }

        public void ExecuteConnection(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteConnectionAsync(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public IList<T> ExecuteDapper<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> ExecuteDapperAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public GridReader ExecuteDapperMultipleQuery(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<GridReader> ExecuteDapperMultipleQueryAsync(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public T ExecuteDapperScalar<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteDapperScalarAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<T?> ExecuteDapperScalarNullableAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public void ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public IList<T> Select<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> SelectAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public GridReader SelectMultipleQuery(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<GridReader> SelectMultipleQueryAsync(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public T? SelectScalar<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<T?> SelectScalarAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public void TransactionalExecute(string query, object? parameters = null)
        {
            throw new NotImplementedException();
        }

        public Task TransactionalExecuteAsync(string query, object? parameters = null)
        {
            throw new NotImplementedException();
        }

        public GridReader TransactionalMultipleQuery(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<GridReader> TransactionalMultipleQueryAsync(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public T TransactionalQuery<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> TransactionalQueryAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public T? TransactionalQueryScalar<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public Task<T?> TransactionalQueryScalarAsync<T>(string query, object? parameters = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }
    }
}
