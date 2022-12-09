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
            contacts.ForEach(contact => { contact.actionLink = $"<a title=\"Unlink contact\" href=https://localhost:7249/Contact/UnlinkContact?code={contact.code}><i class=\"fas fa-heart-broken\"></i></a>"; });
            return ObjectMapper.Mapper.Map<List<ContactViewModel>>(contacts);
        }

        public void UnlinkContact(Guid contactCode)
        {
            _contactRepository.UnlinkContact(contactCode);
        }
    }
}
