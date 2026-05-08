using Common.Domain;

namespace Server.SystemOperation
{
    public class PromeniEvidencijaClanarineSO : SystemOperationBase
    {
        private readonly EvidencijaClanarine evidencija;
        public EvidencijaClanarine Result { get; set; }

        public PromeniEvidencijaClanarineSO(EvidencijaClanarine evidencija)
        {
            this.evidencija = evidencija;
        }

        protected override void ExecuteConcreteOperation()
        {
            int rows = broker.Update(evidencija);
            if (rows == 0)
                throw new Exception("Евиденција није измењена.");

            if (evidencija.StavkeZaIzmenu != null)
            {
                foreach (var s in evidencija.StavkeZaIzmenu)
                    if (broker.Update(s) == 0) throw new Exception("Ставка није измењена.");

                if (evidencija.StavkeZaBrisanje != null)
                    foreach (var s in evidencija.StavkeZaBrisanje)
                        broker.Delete(s);

                if (evidencija.StavkeZaDodavanje != null)
                    foreach (var s in evidencija.StavkeZaDodavanje)
                        broker.Add(s);
            }
        }
    }
}
