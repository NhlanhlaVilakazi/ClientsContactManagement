using ClientsContactManagement.Business.Mappings;
using ClientsContactManagement.Data.DataModels;
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
            clients.ForEach(client => 
            {
                client.linkClient = $"<a title=\"Link client\" type=\"button\" href=https://localhost:7249/Client/LinkClient?clientCode={client.code}> <i class=\"fas fa-link\"></i></a>";
                client.unlinkClient = $"<a title=\"Unlink client\" type=\"button\" href=https://localhost:7249/Client/UnLinkClient?clientCode={client.code}> <i class=\"fas fa-heart-broken\"></i></a>";
            });
            return ObjectMapper.Mapper.Map<List<ClientViewModel>>(clients);
        }

        public void AddClient(ClientViewModel client) 
        {
            client.code = GetClientAphaCode(client.firstName, client.lastName);
            var clientModel = ObjectMapper.Mapper.Map<Client>(client);
            _clientRepository.CreateNewClient(clientModel);
        }

        public string GetClientAphaCode(string firstname, string lastname)
        {
            string firstCharachers = firstname[..1] + "" + firstname.Substring(firstname.IndexOf(" ") + 1, 1);
            string clientCode = $"{firstCharachers}{lastname[..1]}";
            return clientCode.ToUpper();
        }
        public Client? GetByCode(string code) 
        {
            return _clientRepository.GetClientByCode(code);
        }
    }
}
