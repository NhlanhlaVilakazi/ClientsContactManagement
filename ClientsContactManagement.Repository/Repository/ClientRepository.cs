using ClientsContactManagement.Data;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.Repository.Contrasts;

namespace ClientsContactManagement.Repository.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _dbContext;

        public ClientRepository()
        {
            _dbContext = new DataContext();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public List<Client> GetClients()
        {
            return _dbContext.Client.ToList();
        }
    }
}
