using DBBroker;

namespace Server.SystemOperation
{
    public abstract class SystemOperationBase
    {
        protected Broker broker;
        protected SystemOperationBase()
        {
            broker = Broker.Instance;
        }
        public void ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                ExecuteConcreteOperation();

                broker.Commit();
            }
            catch (Exception ex)
            {
                broker.Rollback();
                throw new Exception($"Грешка: {ex.Message}.");
            }
            finally
            {
                broker.CloseConnection();
            }
        }
        protected abstract void ExecuteConcreteOperation();
    }
}
