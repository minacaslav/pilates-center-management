using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class StavkaEvidencijeClanarine : IEntity
    {
        public int IdEvidencijaClanarine { get; set; }
        public int IdStavkaEvidencijeClanarine { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public StatusUplate StatusUplate { get; set; }
        public float Cena { get; set; }
        public int TrajanjeUNedeljama { get; set; }
        public float IznosStavke { get; set; } //TrajanjeUNedeljama * Cena
        public NacinPlacanja NacinPlacanja { get; set; }
        public int IdTipClanarine { get; set; }

        public EvidencijaClanarine EvidencijaClanarine { get; set; }
        public TipClanarine TipClanarine { get; set; }

        public string TableName => "StavkaEvidencijeClanarine";

        public string Values =>
            $"{IdEvidencijaClanarine}, '{DatumKreiranja:yyyy-MM-dd}', " +
            $"{(int)StatusUplate}, {Cena}, {TrajanjeUNedeljama}, {IznosStavke}, {(int)NacinPlacanja}, {IdTipClanarine}";
        public string PrimaryKeyName => "IdStavkaEvidencijeClanarine";
        public object PrimaryKeyValue => IdStavkaEvidencijeClanarine;

        public string UpdateValues =>
            $"IdEvidencijaClanarine={IdEvidencijaClanarine}, DatumKreiranja='{DatumKreiranja:yyyy-MM-dd}', " +
            $"StatusUplate={(int)StatusUplate}, Cena={Cena}, TrajanjeUNedeljama={TrajanjeUNedeljama}, " +
            $"IznosStavke={IznosStavke}, NacinPlacanja={(int)NacinPlacanja}, IdTipClanarine={IdTipClanarine}";

        public string Alias => "sev";
        public string JoinString => $"join {TableName} {Alias} on {Alias}.IdEvidencijaClanarine";

        public string Columns => "";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();

            while (reader.Read())
            {
                var s = new StavkaEvidencijeClanarine
                {
                    IdEvidencijaClanarine = (int)reader["IdEvidencijaClanarine"],
                    IdStavkaEvidencijeClanarine = (int)reader["IdStavkaEvidencijeClanarine"],
                    DatumKreiranja = (DateTime)reader["DatumKreiranja"],
                    StatusUplate = (StatusUplate)(int)reader["StatusUplate"],
                    Cena = Convert.ToSingle(reader["Cena"]),
                    TrajanjeUNedeljama = (int)reader["TrajanjeUNedeljama"],
                    IznosStavke = Convert.ToSingle(reader["IznosStavke"]),
                    NacinPlacanja = (NacinPlacanja)(int)reader["NacinPlacanja"],
                    IdTipClanarine = (int)reader["IdTipClanarine"],
                    EvidencijaClanarine = new EvidencijaClanarine { IdEvidencijaClanarine = (int)reader["IdEvidencijaClanarine"] },
                    TipClanarine = new TipClanarine { IdTipClanarine = (int)reader["IdTipClanarine"] }
                };

                list.Add(s);
            }

            return list;
        }
    }
    public enum StatusUplate
    {
        NaCekanju = 0,
        Uplaceno = 1,
        Kasni = 2,
    }
    public enum NacinPlacanja
    {
        Gotovina = 0,
        KreditnaKartica = 1,
        BankovniTransfer = 2,
    }
}
