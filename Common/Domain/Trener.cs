using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public class Trener : IEntity
    {
        public int IdTrener { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public Specijalnost Specijalnost { get; set; }

        public string TableName => "Trener";
        public string Values => $"'{Ime}', '{Prezime}', '{KontaktTelefon}', '{Email}', '{Lozinka}', {(int)Specijalnost}";
        public string PrimaryKeyName => "IdTrener";
        public object PrimaryKeyValue => IdTrener;
        public string UpdateValues => $"Ime='{Ime}', Prezime='{Prezime}', KontaktTelefon='{KontaktTelefon}', Email='{Email}', Lozinka='{Lozinka}', Specijalnost={(int)Specijalnost}";

        public List<Termin> ListaTermin { get; set; } = [];
        public string Alias => "t";
        public string JoinString => $"join {TableName} {Alias} on {Alias}.{PrimaryKeyName}";
        public string Columns => $"Ime = '{Ime}' AND Prezime = '{Prezime}' AND KontaktTelefon = '{KontaktTelefon}' AND Email = '{Email}'";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var treneri = new List<IEntity>();

            while (reader.Read())
            {
                var t = new Trener
                {
                    IdTrener = (int)reader["IdTrener"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    KontaktTelefon = (string)reader["KontaktTelefon"],
                    Email = (string)reader["Email"],
                    Lozinka = (string)reader["Lozinka"],
                    Specijalnost = (Specijalnost)(int)reader["Specijalnost"]
                };

                treneri.Add(t);
            }

            return treneri;
        }

        public override string ToString()
        {
            if (Specijalnost == Specijalnost.BezSpecijalnosti)
                return $"{Ime} {Prezime}";
            else
                return $"{Ime} {Prezime} - {Specijalnost}";
        }
    }

    public enum Specijalnost
    {
        BezSpecijalnosti = -1,
        MatPilates = 0,
        ReformerPilates = 1,
        TrudnickiPilates = 2,
        PosturalnaKorekcija = 3,
        RehabilitacioniPilates = 4,
        PilatesZaSeniore = 5
    }
}

