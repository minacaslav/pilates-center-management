using Common.Domain;

namespace Server.SystemOperation
{
    public class VratiListuEvidencijaClanarineSO : SystemOperationBase
    {
        private readonly IEntity kriterijum;
        public List<EvidencijaClanarine> Result { get; private set; }

        public VratiListuEvidencijaClanarineSO(IEntity kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void ExecuteConcreteOperation()
        {
            EvidencijaClanarine evidencija = new EvidencijaClanarine();
            List<IEntity> lista = [];
            string condition = "";

            switch (kriterijum)
            {
                case Trener trener:
                    lista = broker.GetJoin(evidencija, kriterijum, kriterijum.Columns);
                    break;
                case Clan clan:
                    lista = broker.GetJoin(evidencija, kriterijum, kriterijum.Columns);
                    break;
                case TipClanarine tipClanarine:
                    StavkaEvidencijeClanarine stavka = new StavkaEvidencijeClanarine();
                    lista = broker.GetJoin(evidencija, stavka, kriterijum, kriterijum.Columns);
                    break;
                case EvidencijaClanarine evidencijaClanarine:
                    List<string> parts = new();

                    if (evidencijaClanarine.DatumPocetka != default)
                        parts.Add($"DatumPocetka >= '{evidencijaClanarine.DatumPocetka:yyyy-MM-dd}'");

                    if (evidencijaClanarine.DatumZavrsetka != null)
                        parts.Add($"DatumZavrsetka <= '{evidencijaClanarine.DatumZavrsetka:yyyy-MM-dd}'");

                    if (Enum.IsDefined(typeof(StatusEvidencije), evidencijaClanarine.StatusEvidencije))
                        parts.Add($"StatusEvidencije = {(int)evidencijaClanarine.StatusEvidencije}");

                    condition = parts.Count > 0 ? string.Join(" AND ", parts) : "1=1";

                    lista = broker.GetByCondition(evidencija, condition);
                    break;

                default:
                    condition = "1=1";
                    break;
            }

            Result = lista.Cast<EvidencijaClanarine>().ToList();
        }

        //- Stara metoda
        private void PopuniStavkeEvidencije(EvidencijaClanarine evidencija)
        {
            StavkaEvidencijeClanarine stavka = new StavkaEvidencijeClanarine();
            string condition = $"IdEvidencijaClanarine = {evidencija.IdEvidencijaClanarine}";

            var stavke = broker.GetByCondition(stavka, condition).Cast<StavkaEvidencijeClanarine>().ToList();
            evidencija.StavkeEvidencijeClanarine = stavke;
        }
    }
}
