using ClientsContactManagement.Data.DataModels;

namespace ClientsContactManagement.Repository.Contrasts
{
    public interface IContactRepository : IDisposable
    {
        List<Contact> GetContacts();
    }
}
