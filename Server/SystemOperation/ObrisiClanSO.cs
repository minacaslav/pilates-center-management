using Common.Domain;

namespace Server.SystemOperation
{
    public class ObrisiClanSO : SystemOperationBase
    {
        private readonly Clan clan;

        public ObrisiClanSO(Clan clan)
        {
            this.clan = clan;
        }

        protected override void ExecuteConcreteOperation()
        {
            var evidencije = broker.GetByCondition(new EvidencijaClanarine(), $"IdClan = {clan.IdClan}");

            if (evidencije.Any())
            {
                throw new Exception("Не можете обрисати члана јер постоје рачуни повезани са њим.");
            }

            if (broker.Delete(clan) == 0) throw new Exception("Члан није пронађен за брисање.");
        }
    }
}
