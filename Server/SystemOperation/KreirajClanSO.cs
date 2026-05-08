using Common.Domain;

namespace Server.SystemOperation
{
    public class KreirajClanSO : SystemOperationBase
    {
        private readonly Clan clan;
        public Clan Result { get; set; }

        public KreirajClanSO(Clan clan)
        {
            this.clan = clan;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(clan);
        }
    }
}
