using ClientsContactManagement.Data;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.Repository.Contrasts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

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
            const string query = "EXEC [GetAllClients]";
            return _dbContext.Set<Client>().FromSqlRaw(query).ToList();
        }

        public void CreateNewClient(Client client)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@code",  client.code),
                new SqlParameter("@firstName", client.firstName),
                new SqlParameter("@lastName", client.lastName)
            };
            const string query = "[NewClient] @code, @firstName, @lastName";
            _dbContext.Database.ExecuteSqlRaw(query, parameters);
        }
    }
}
