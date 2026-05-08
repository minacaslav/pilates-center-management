using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class Termin : IEntity
    {
        public int IdTrener { get; set; }
        public int IdTrening { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int TrajanjeUMinutima { get; set; }
        public Trener Trener { get; set; }
        public Trening Trening { get; set; }

        public string TableName => "Termin";
        public string Values => $"{IdTrener}, {IdTrening}, '{DatumOdrzavanja:yyyy-MM-dd}', {TrajanjeUMinutima}";
        public string PrimaryKeyName => "IdTrener"; // Composite keys require manual handling
        public object PrimaryKeyValue => IdTrener;  // Only first key used in repo for simplicity
        public string UpdateValues => $"DatumOdrzavanja='{DatumOdrzavanja:yyyy-MM-dd HH:mm}', TrajanjeUMinutima={TrajanjeUMinutima}";
        public string Alias => "";
        public string JoinString => "";
        public string Columns => "";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();

            while (reader.Read())
            {
                var tt = new Termin
                {
                    IdTrener = (int)reader["IdTrener"],
                    IdTrening = (int)reader["IdTrening"],
                    DatumOdrzavanja = (DateTime)reader["DatumOdrzavanja"],
                    TrajanjeUMinutima = (int)reader["TrajanjeUMinutima"],
                    Trener = new Trener { IdTrener = (int)reader["IdTrener"] },
                    Trening = new Trening { IdTrening = (int)reader["IdTrening"] }
                };

                list.Add(tt);
            }

            return list;
        }
    }
}
