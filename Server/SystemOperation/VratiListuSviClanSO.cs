using Common.Domain;
using System.Text;

namespace Server.SystemOperation
{
    public class VratiListuSviClanSO : SystemOperationBase
    {
        private readonly Clan kriterijum;
        public List<Clan> Result { get; private set; }
        public VratiListuSviClanSO(Clan kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        //* Razmotriti da bude stroga provera sa AND
        protected override void ExecuteConcreteOperation()
        {
            StringBuilder condition = new StringBuilder();

            if (kriterijum != null)
            {
                if (kriterijum.IdClan > 0)
                    condition.Append($"IdClan = {kriterijum.IdClan} OR ");

                if (!string.IsNullOrEmpty(kriterijum.Ime))
                    condition.Append($"Ime LIKE '%{kriterijum.Ime}%' OR ");

                if (!string.IsNullOrEmpty(kriterijum.Prezime))
                    condition.Append($"Prezime LIKE '%{kriterijum.Prezime}%' OR ");

                if (!string.IsNullOrEmpty(kriterijum.Email))
                    condition.Append($"Email = '%{kriterijum.Email}%' OR ");

                if (kriterijum.IdTipClana > 0)
                {
                    if (condition.Length > 0)
                    {
                        condition.Length -= 4;
                        condition.Append($" AND ");
                    }
                    condition.Append($"IdTipClana = {kriterijum.IdTipClana} OR ");
                }


                if (kriterijum.Status != default)
                {
                    if (condition.Length > 0)
                    {
                        condition.Length -= 4;
                        condition.Append($" AND ");
                    }
                    condition.Append($"Status = {(int)kriterijum.Status} OR ");
                }

                if (condition.Length > 0)
                    condition.Length -= 4;
                else
                    condition.Append("1=1");
            }
            else
                condition.Append("1=1");


            List<IEntity> lista = broker.GetByCondition(new Clan(), condition.ToString());
            Result = lista.Cast<Clan>().ToList();

            if (Result.Count == 0) throw new Exception("Систем не може да нађе чланове по задатим критеријумима");
        }
    }
}
