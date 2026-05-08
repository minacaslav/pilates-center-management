using Common.Domain;

namespace Server.SystemOperation
{
    public class KreirajEvidencijaClanarineSO : SystemOperationBase
    {
        private readonly EvidencijaClanarine evidencija;

        public KreirajEvidencijaClanarineSO(EvidencijaClanarine evidencija)
        {
            this.evidencija = evidencija;
        }

        protected override void ExecuteConcreteOperation()
        {
            evidencija.IdEvidencijaClanarine = broker.Add(evidencija);
            foreach (StavkaEvidencijeClanarine s in evidencija.StavkeEvidencijeClanarine)
            {
                s.IdEvidencijaClanarine = evidencija.IdEvidencijaClanarine;
                broker.Add(s);
            }
        }
    }
}
