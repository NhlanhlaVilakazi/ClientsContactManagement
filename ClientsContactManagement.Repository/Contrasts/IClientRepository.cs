using ClientsContactManagement.Data.DataModels;

namespace ClientsContactManagement.Repository.Contrasts
{
    public interface IClientRepository : IDisposable
    {
        List<Client> GetClients();
    }
}
