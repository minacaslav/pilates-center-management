using Common.Domain;
using DbBroker;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace DBBroker
{
    public class Broker
    {
        private static Broker instance;
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }
        public static Broker Instance => instance ??= new Broker();

        public void OpenConnection() => connection.OpenConnection();
        public void CloseConnection() => connection.CloseConnection();
        public void BeginTransaction() => connection.BeginTransaction();
        public void Commit() => connection.Commit();
        public void Rollback() => connection.Rollback();

        public int Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {obj.TableName} values({obj.Values}); SELECT CAST(SCOPE_IDENTITY() as int)";
            int id = (int)cmd.ExecuteScalar();
            return id;
        }
        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName}";
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }
        public List<IEntity> GetByCondition(IEntity entity, string condition, string query = null!)
        {
            SqlCommand command = connection.CreateCommand();

            if (!query.IsNullOrEmpty())
            {
                command.CommandText = query;
            }
            else
            {
                command.CommandText = $"SELECT * FROM {entity.TableName} WHERE {condition}";
            }

            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }
        public int Insert(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO {entity.TableName} VALUES({entity.Values}); SELECT SCOPE_IDENTITY();";
            object result = command.ExecuteScalar();
            command.Dispose();
            return Convert.ToInt32(result);
        }
        public int Update(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"UPDATE {entity.TableName} SET {entity.UpdateValues} WHERE {entity.PrimaryKeyName} = {entity.PrimaryKeyValue}";
            int rows = command.ExecuteNonQuery();
            command.Dispose();
            return rows;
        }
        public int Delete(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.PrimaryKeyName} = {entity.PrimaryKeyValue}";
            int rows = command.ExecuteNonQuery();
            command.Dispose();
            return rows;
        }
        public List<IEntity> GetJoin(IEntity entity1, IEntity entity2, string condition)
        {
            SqlCommand command = connection.CreateCommand();

            string whereCondition = string.IsNullOrWhiteSpace(condition) ? "" : $" where {condition}";

            command.CommandText = $"select {entity1.Alias}.* " +
                $" from {entity1.TableName} {entity1.Alias}" +
                $" {entity2.JoinString}={entity1.Alias}.{entity2.PrimaryKeyName}" +
                $" {whereCondition}";

            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> lista = entity1.GetReaderList(reader);
            command.Dispose();
            return lista;
        }
        public List<IEntity> GetJoin(IEntity entity1, IEntity entity2, IEntity entity3, string condition = null!)
        {
            SqlCommand command = connection.CreateCommand();

            string where = string.IsNullOrWhiteSpace(condition) ? "" : $" where {condition}";

            command.CommandText = $"select {entity1.Alias}.*" +
                $" from {entity1.TableName} {entity1.Alias}" +
                $" {entity2.JoinString}={entity1.Alias}.{entity1.PrimaryKeyName} {entity3.JoinString}={entity2.Alias}.{entity3.PrimaryKeyName}" +
                $" {where}";
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> lista = entity1.GetReaderList(reader);
            command.Dispose();
            return lista;
        }
    }
}
