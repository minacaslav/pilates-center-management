using Microsoft.Data.SqlClient;
using System.Globalization;

namespace Common.Domain
{
    public class TipClanarine : IEntity
    {
        public int IdTipClanarine { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }

        public string TableName => "TipClanarine";

        public string Values => $"'{Naziv}', {Cena}, '{Opis}'";
        public string PrimaryKeyName => "IdTipClanarine";
        public object PrimaryKeyValue => IdTipClanarine;
        public string UpdateValues => $"Naziv='{Naziv}', Cena={Cena}, Opis='{Opis}'";
        public string Alias => "tclr";
        public string JoinString => $"join {TableName} {Alias} on {Alias}.{PrimaryKeyName}";
        public string Columns => $"Naziv = '{Naziv}' AND {Alias}.Cena = {Cena} AND Opis = '{Opis}'";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();

            while (reader.Read())
            {
                var t = new TipClanarine
                {
                    IdTipClanarine = (int)reader["IdTipClanarine"],
                    Naziv = (string)reader["Naziv"],
                    Cena = Convert.ToDouble(reader["Cena"]),
                    Opis = (string)reader["Opis"]
                };

                list.Add(t);
            }

            return list;
        }

        public override string ToString()
        {
            if (Cena == 0)
                return $"{Naziv}";
            else
                return $"{Naziv} - {Cena.ToString("C", new CultureInfo("sr-RS"))}";
        }

    }
}
