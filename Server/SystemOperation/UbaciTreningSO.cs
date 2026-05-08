using Common.Domain;

namespace Server.SystemOperation
{
    public class UbaciTreningSO : SystemOperationBase
    {
        private readonly Trening trening;
        public Trening Result { get; private set; }

        public UbaciTreningSO(Trening trening)
        {
            this.trening = trening;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(trening);
            Result = trening;
        }
    }
}
