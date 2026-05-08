using Common.Domain;

namespace Server.SystemOperation
{
    public class VratiListuSviTrenerSO : SystemOperationBase
    {
        public List<Trener> Result { get; private set; }

        protected override void ExecuteConcreteOperation()
        {
            Trener trener = new Trener();
            List<IEntity> lista = broker.GetAll(trener);
            Result = lista.Cast<Trener>().ToList();
        }
    }
}
