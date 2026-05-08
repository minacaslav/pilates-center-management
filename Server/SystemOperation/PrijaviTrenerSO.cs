using Common.Domain;

namespace Server.SystemOperation
{
    public class PrijaviTrenerSO : SystemOperationBase
    {
        private readonly Trener trener;
        public Trener Result { get; set; }

        public PrijaviTrenerSO(Trener tr)
        {
            this.trener = tr;
        }

        protected override void ExecuteConcreteOperation()
        {
            string condition = $"Email = '{trener.Email}' AND Lozinka = '{trener.Lozinka}'";
            List<IEntity> lista = broker.GetByCondition(trener, condition);

            Result = lista.Cast<Trener>().FirstOrDefault()!;

            if (Result == null) throw new Exception("Не постоји тренер са унетим креденцијалима.");
        }
    }
}
