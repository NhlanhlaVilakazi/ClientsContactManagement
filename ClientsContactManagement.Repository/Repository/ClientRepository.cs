using ClientsContactManagement.Data;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.Repository.Contrasts;
using Microsoft.EntityFrameworkCore;

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

        public Task<List<Client>> GetClients()
        {
            const string query = "EXEC [GetAllClients]";
            return _dbContext.Set<Client>().FromSqlRaw(query).ToListAsync();
        }
    }
}
