using Common.Domain;
using DBBroker;
using Common.Domain;
using Server.SystemOperation;

namespace Server
{
    public class Controller
    {
        private readonly Broker broker;
        private static Controller instance;
        public static Controller Instance => instance ??= new Controller();
        private Controller() { broker = Broker.Instance; }

        public Trener Login(Trener trener)
        {
            PrijaviTrenerSO so = new PrijaviTrenerSO(trener);
            so.ExecuteTemplate();
            return so.Result;
        }

        public EvidencijaClanarine KreirajEvidencijaClanarine(EvidencijaClanarine evidencija)
        {
            KreirajEvidencijaClanarineSO so = new KreirajEvidencijaClanarineSO(evidencija);
            so.ExecuteTemplate();
            return evidencija;
        }

        public EvidencijaClanarine PretraziEvidencijaClanarine(EvidencijaClanarine kriterijum)
        {
            PretraziEvidencijaClanarineSO so = new PretraziEvidencijaClanarineSO(kriterijum);
            so.ExecuteTemplate();
            return so.Result;
        }

        public void PromeniEvidencijaClanarine(EvidencijaClanarine evidencija)
        {
            PromeniEvidencijaClanarineSO so = new PromeniEvidencijaClanarineSO(evidencija);
            so.ExecuteTemplate();
        }
        public void VratiListuEvidencijaClanarine(EvidencijaClanarine evidencija, ref List<EvidencijaClanarine> evidencije)
        {
            VratiListuEvidencijaClanarineSO so = new VratiListuEvidencijaClanarineSO(evidencija);
            so.ExecuteTemplate();
            evidencije = so.Result;
        }
        public void VratiListuEvidencijaClanarine(Trener trener, ref List<EvidencijaClanarine> evidencije)
        {
            VratiListuEvidencijaClanarineSO so = new VratiListuEvidencijaClanarineSO(trener);
            so.ExecuteTemplate();
            evidencije = so.Result;
        }
        public void VratiListuEvidencijaClanarine(Clan clan, ref List<EvidencijaClanarine> evidencije)
        {
            VratiListuEvidencijaClanarineSO so = new VratiListuEvidencijaClanarineSO(clan);
            so.ExecuteTemplate();
            evidencije = so.Result;
        }
        public void VratiListuEvidencijaClanarine(TipClanarine tipClanarine, ref List<EvidencijaClanarine> evidencije)
        {
            VratiListuEvidencijaClanarineSO so = new VratiListuEvidencijaClanarineSO(tipClanarine);
            so.ExecuteTemplate();
            evidencije = so.Result;
        }

        public List<Clan> VratiListuSviClan(Clan clan)
        {
            VratiListuSviClanSO so = new VratiListuSviClanSO(clan);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<TipClana> VratiListuSviTipClana()
        {
            VratiListuSviTipClanaSO so = new VratiListuSviTipClanaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Trener> VratiListuSviTrener()
        {
            VratiListuSviTrenerSO so = new VratiListuSviTrenerSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<TipClanarine> VratiListuSviTipClanarine()
        {
            VratiListuSviTipClanarineSO so = new VratiListuSviTipClanarineSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public Clan KreirajClan(Clan clan)
        {
            KreirajClanSO so = new KreirajClanSO(clan);
            so.ExecuteTemplate();
            return so.Result;
        }

        public void PromeniClan(Clan clan)
        {
            PromeniClanSO so = new PromeniClanSO(clan);
            so.ExecuteTemplate();
        }

        public void ObrisiClan(Clan clan)
        {
            ObrisiClanSO so = new ObrisiClanSO(clan);
            so.ExecuteTemplate();
        }

        internal void UbaciTrening(Trening trening)
        {
            UbaciTreningSO so = new UbaciTreningSO(trening);
            so.ExecuteTemplate();
        }
    }
}