

namespace ClientsContactManagement.ViewModels.Contact
{
    public class ContactViewModel
    {
        public string code { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string actionLink { get; set; }
        public int numberOfLinkedClients { get; set; }
    }
}
