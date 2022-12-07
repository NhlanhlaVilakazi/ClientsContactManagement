
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientsContactManagement.Data.DataModels
{
    public class Contact
    {
        public Guid code { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        [NotMapped]
        public string actionLink { get; set; }
        public int numberOfLinkedClients { get; set; }
    }
}
