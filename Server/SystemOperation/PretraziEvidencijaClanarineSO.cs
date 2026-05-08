using Common.Domain;

namespace Server.SystemOperation
{
    public class PretraziEvidencijaClanarineSO : SystemOperationBase
    {
        private readonly EvidencijaClanarine evidencija;
        public EvidencijaClanarine Result { get; private set; }

        public PretraziEvidencijaClanarineSO(EvidencijaClanarine kriterijum)
        {
            evidencija = kriterijum;
        }
        protected override void ExecuteConcreteOperation()
        {
            string condition = $"IdEvidencijaClanarine = {evidencija.IdEvidencijaClanarine}";

            var ev = broker.GetByCondition(evidencija, condition);
            if (ev == null)
                throw new Exception("Не постоји Евиденција са овим ИД-јем.");

            Result = ev.Cast<EvidencijaClanarine>().ToList().FirstOrDefault()!;
            StavkaEvidencijeClanarine stavka = new StavkaEvidencijeClanarine();

            string stavkaCondition = $"{evidencija.Alias}.{evidencija.PrimaryKeyName}={evidencija.IdEvidencijaClanarine}";

            var stavkeEvidencije = broker.GetJoin(stavka, evidencija, stavkaCondition);

            var stavke = stavkeEvidencije.Cast<StavkaEvidencijeClanarine>().ToList();

            for (int i = 0; i < stavke.Count(); i++)
            {
                var clanarina = new TipClanarine();
                string clanarinaCondition = $"{clanarina.PrimaryKeyName} = {stavke[i].IdTipClanarine}";
                stavke[i].TipClanarine = broker.GetByCondition(clanarina, clanarinaCondition).Cast<TipClanarine>().FirstOrDefault()!;
            }

            Result.StavkeEvidencijeClanarine = stavke;
        }
    }
}
