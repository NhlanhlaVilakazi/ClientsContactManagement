using ClientsContactManagement.Business.Mappings;
using ClientsContactManagement.Repository.Contrasts;
using ClientsContactManagement.ViewModels.Contact;


namespace ClientsContactManagement.Business.Contacts
{
    public class ContactBusiness
    {
        private readonly IContactRepository _contactRepository;
        public ContactBusiness(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public List<ContactViewModel> GetContacts()
        {
            var contacts = _contactRepository.GetContacts();
            return ObjectMapper.Mapper.Map<List<ContactViewModel>>(contacts);
        }
    }
}
