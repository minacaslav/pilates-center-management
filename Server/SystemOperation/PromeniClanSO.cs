using Common.Domain;

namespace Server.SystemOperation
{
    public class PromeniClanSO : SystemOperationBase
    {
        private readonly Clan clan;

        public PromeniClanSO(Clan clan)
        {
            this.clan = clan;
        }

        protected override void ExecuteConcreteOperation()
        {
            if (broker.Update(clan) == 0)
                throw new Exception("Члан није пронађен за измену.");
        }
    }
}
