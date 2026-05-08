using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class Trening : IEntity
    {
        public int IdTrening { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public TipTreninga TipTreninga { get; set; }

        public string TableName => "Trening";
        public string Values => $"'{Naziv}', {(int)TipTreninga},'{Opis}' ";
        public string PrimaryKeyName => "IdTrening";
        public object PrimaryKeyValue => IdTrening;
        public string UpdateValues => $"Naziv='{Naziv}', TipTreninga={(int)TipTreninga}, Opis='{Opis}'";
        public string Alias => "";
        public string JoinString => "";
        public string Columns => "";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();

            while (reader.Read())
            {
                var t = new Trening
                {
                    IdTrening = (int)reader["IdTrening"],
                    Naziv = (string)reader["Naziv"],
                    TipTreninga = (TipTreninga)(int)reader["TipTreninga"],
                    Opis = (string)reader["Opis"]
                };

                list.Add(t);
            }

            return list;
        }
        public override string ToString()
        {
            return $"{Naziv} ({TipTreninga})";
        }
    }

    public enum TipTreninga
    {
        Personalni = 0,
        Grupni = 1,
        Reformer = 2,
        Pocetnicki = 3,
        Napredni = 4,
        Trudnicki = 5,
        Rehabilitacioni = 6,
    }
}
