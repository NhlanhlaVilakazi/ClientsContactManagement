using ClientsContactManagement.Business.Mappings;
using ClientsContactManagement.Repository.Contrasts;
using ClientsContactManagement.ViewModels.Client;

namespace ClientsContactManagement.Business.Clients
{
    public class ClientBusiness
    {
        private readonly IClientRepository _clientRepository;
        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<ClientViewModel> GetAll()
        {
            var clients = _clientRepository.GetClients();
            return ObjectMapper.Mapper.Map<List<ClientViewModel>>(clients);
        }
    }
}
