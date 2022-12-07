
using ClientsContactManagement.Data;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.Repository.Contrasts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClientsContactManagement.Repository.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _dbContext;

        public ContactRepository()
        {
            _dbContext = new DataContext();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public List<Contact> GetContacts()
        {
            const string query = "EXEC [GetAllContacts]";
            return _dbContext.Set<Contact>().FromSqlRaw(query).ToList();
        }

        public void UnlinkContact(Guid code)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter("@code", code)
            };
            const string query = "[UnlinkLinkedContact] @code";
            _dbContext.Database.ExecuteSqlRaw(query, parameter);
        }
    }
}
