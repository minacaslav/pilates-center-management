using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class Clan : IEntity
    {
        public int IdClan { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public DateOnly DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public TipClana TipClana { get; set; }
        public int IdTipClana { get; set; }
        public List<EvidencijaClanarine> ListaEvidencijaClanarine { get; set; } = [];

        public string TableName => "Clan";

        public string Values =>
            $"'{Ime}', '{Prezime}', '{JMBG}', '{DatumRodjenja:yyyy-MM-dd}', '{Adresa}', '{KontaktTelefon}', '{Email}', {(int)Status}, {IdTipClana}"; //*

        public string PrimaryKeyName => "IdClan";
        public object PrimaryKeyValue => IdClan;

        public string UpdateValues =>
            $"Ime='{Ime}', Prezime='{Prezime}', DatumRodjenja='{DatumRodjenja:yyyy-MM-dd}', Adresa='{Adresa}', KontaktTelefon='{KontaktTelefon}', Email='{Email}', Status={(int)Status}, IdTipClana={IdTipClana}"; //*

        public string Alias => "c";
        public string JoinString => $"join {TableName} {Alias} on {Alias}.{PrimaryKeyName}";
        public string Columns => $"Ime = '{Ime}' " +
                                 $"AND Prezime = '{Prezime}' " +
                                 $"AND JMBG = '{JMBG}' " +
                                 $"AND DatumRodjenja = '{DatumRodjenja:yyyy-MM-dd}' " +
                                 $"AND Adresa = '{Adresa}' " +
                                 $"AND KontaktTelefon = '{KontaktTelefon}' " +
                                 $"AND Email = '{Email}' " +
                                 $"AND Status = {(int)Status} ";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var clanovi = new List<IEntity>();

            while (reader.Read())
            {
                var c = new Clan
                {
                    IdClan = (int)reader["IdClan"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    JMBG = (string)reader["JMBG"],
                    DatumRodjenja = DateOnly.FromDateTime((DateTime)reader["DatumRodjenja"]),
                    Adresa = (string)reader["Adresa"],
                    KontaktTelefon = (string)reader["KontaktTelefon"],
                    Email = (string)reader["Email"],
                    Status = (Status)(int)reader["Status"],
                    TipClana = new TipClana { IdTipClana = (int)reader["IdTipClana"] }
                };

                clanovi.Add(c);
            }

            return clanovi;
        }



        public override string ToString()
        {
            if (String.IsNullOrEmpty(Email))
                return $"{Ime} {Prezime}";
            else
                return $"{Ime} {Prezime} ({Email})";
        }
    }

    public enum Status
    {
        Aktivan = 0,
        Neaktivan = 1,
        Suspendovan = 2,
    }
}
