
using ClientsContactManagement.Data;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.Repository.Contrasts;
using Microsoft.EntityFrameworkCore;

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
    }
}
