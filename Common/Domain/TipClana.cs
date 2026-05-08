using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class TipClana : IEntity
    {
        public int IdTipClana { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public string TableName => "TipClana";
        public string Values => $"'{Naziv}', '{Opis}'";
        public string PrimaryKeyName => "IdTipClana";
        public object PrimaryKeyValue => IdTipClana;
        public string UpdateValues => $"Naziv='{Naziv}', Opis='{Opis}'";

        public string Alias => "tc";
        public string JoinString => $"join {TableName} {Alias} on {Alias}.{PrimaryKeyName}";
        public string Columns => $"Naziv = '{Naziv}' AND Opis = {Opis}";


        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();

            while (reader.Read())
            {
                var t = new TipClana
                {
                    IdTipClana = (int)reader["IdTipClana"],
                    Naziv = (string)reader["Naziv"],
                    Opis = (string)reader["Opis"]
                };

                list.Add(t);
            }

            return list;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
