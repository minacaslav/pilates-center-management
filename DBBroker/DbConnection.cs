using Microsoft.Data.SqlClient;

namespace DbBroker
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DbConnection()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pilates;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public void OpenConnection() => connection?.Open();
        public void CloseConnection() => connection?.Close();
        public void BeginTransaction() => transaction = connection.BeginTransaction();
        public void Commit() => transaction?.Commit();
        public void Rollback() => transaction?.Rollback();
        public SqlCommand CreateCommand() => new SqlCommand("", connection, transaction);
    }
}
