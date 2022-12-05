using ClientsContactManagement.Data.DataModels;

namespace ClientsContactManagement.Repository.Contrasts
{
    public interface IClientRepository : IDisposable
    {
        Task<List<Client>> GetClients();
    }
}
