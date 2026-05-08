using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string PrimaryKeyName { get; }
        object PrimaryKeyValue { get; }
        string UpdateValues { get; }
        string Alias { get; }
        string JoinString { get; }
        string Columns { get; }
        List<IEntity> GetReaderList(SqlDataReader reader);
    }
}
