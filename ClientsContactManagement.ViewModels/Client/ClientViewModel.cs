
using System.ComponentModel;

namespace ClientsContactManagement.ViewModels.Client
{
    public class ClientViewModel
    {
        public string code { get; set; }
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [DisplayName("First Name")]
        public string lastName { get; set; }
        public int numberOfLinkedContacts  { get; set; }
    }
}
