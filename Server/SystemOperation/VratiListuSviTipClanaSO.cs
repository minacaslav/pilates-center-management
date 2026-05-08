using Common.Domain;

namespace Server.SystemOperation
{
    public class VratiListuSviTipClanaSO : SystemOperationBase
    {
        public List<TipClana> Result { get; private set; }

        protected override void ExecuteConcreteOperation()
        {
            TipClana tip = new TipClana();
            List<IEntity> lista = broker.GetAll(tip);
            Result = lista.Cast<TipClana>().ToList();
        }
    }
}
