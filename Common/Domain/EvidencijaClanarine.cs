using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class EvidencijaClanarine : IEntity
    {
        public int IdEvidencijaClanarine { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public StatusEvidencije StatusEvidencije { get; set; }
        public float UkupanIznos { get; set; }
        public string? Komentar { get; set; }
        public int IdTrener { get; set; }
        public int IdClan { get; set; }
        public Trener Trener { get; set; }
        public Clan Clan { get; set; }
        public List<StavkaEvidencijeClanarine> StavkeEvidencijeClanarine { get; set; } = [];
        public List<StavkaEvidencijeClanarine> StavkeZaDodavanje { get; set; } = [];
        public List<StavkaEvidencijeClanarine> StavkeZaIzmenu { get; set; } = [];
        public List<StavkaEvidencijeClanarine> StavkeZaBrisanje { get; set; } = [];

        public string TableName => "EvidencijaClanarine";

        public string Values =>
            $"'{DatumPocetka:yyyy-MM-dd}', " +
            $"{(DatumZavrsetka is null ? "NULL" : $"'{DatumZavrsetka:yyyy-MM-dd}'")}, " +
            $"{(int)StatusEvidencije}, {UkupanIznos}, '{Komentar}', {IdTrener}, {IdClan}";
        public string PrimaryKeyName => "IdEvidencijaClanarine";
        public object PrimaryKeyValue => IdEvidencijaClanarine;

        public string UpdateValues =>
            $"DatumPocetka='{DatumPocetka:yyyy-MM-dd}', DatumZavrsetka='{(DatumZavrsetka.HasValue ? DatumZavrsetka.Value.ToString("yyyy-MM-dd") : null)}', " +
            $"StatusEvidencije={(int)StatusEvidencije}, UkupanIznos={UkupanIznos}, Komentar='{Komentar}', IdTrener={IdTrener}, IdClan={IdClan}";

        public string Alias => "ec";
        public string JoinString => $"join {TableName} {Alias} on {Alias}.{PrimaryKeyName}";
        public string Columns => $"DatumPocetka = '{DatumPocetka:yyyy-MM-dd HH:mm:ss}' " +
                                 $"AND DatumZavrsetka = '{DatumZavrsetka:yyyy-MM-dd HH:mm:ss}' " +
                                 $"AND StatusEvidencije = {(int)StatusEvidencije} " +
                                 $"AND UkupanIznos = {UkupanIznos}" +
                                 $"AND Komentar = {Komentar}";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();

            while (reader.Read())
            {
                var e = new EvidencijaClanarine
                {
                    IdEvidencijaClanarine = (int)reader["IdEvidencijaClanarine"],
                    DatumPocetka = (DateTime)reader["DatumPocetka"],
                    DatumZavrsetka = reader["DatumZavrsetka"] == DBNull.Value ? null : (DateTime?)reader["DatumZavrsetka"],
                    StatusEvidencije = (StatusEvidencije)(int)reader["StatusEvidencije"],
                    UkupanIznos = Convert.ToSingle(reader["UkupanIznos"]),
                    Komentar = reader["Komentar"] as string,
                    IdTrener = (int)reader["IdTrener"],
                    IdClan = (int)reader["IdClan"],
                    Trener = new Trener { IdTrener = (int)reader["IdTrener"] },
                    Clan = new Clan { IdClan = (int)reader["IdClan"] }
                };

                list.Add(e);
            }

            return list;
        }

        public override string ToString()
        {
            return $"{Clan?.Ime} {Clan?.Prezime} - {Trener?.Ime} {Trener?.Prezime} - {DatumPocetka:dd.MM.yyyy}";
        }
    }

    public enum StatusEvidencije
    {
        Aktivan = 0,
        Neaktivan = 1,
        Otkazan = 2,
        Istekao = 3,

    }
}
