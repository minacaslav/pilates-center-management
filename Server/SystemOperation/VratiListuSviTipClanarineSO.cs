using Common.Domain;

namespace Server.SystemOperation
{
    public class VratiListuSviTipClanarineSO : SystemOperationBase
    {
        public List<TipClanarine> Result { get; private set; }

        protected override void ExecuteConcreteOperation()
        {
            TipClanarine tip = new TipClanarine();
            List<IEntity> lista = broker.GetAll(tip);
            Result = lista.Cast<TipClanarine>().ToList();
        }
    }
}
