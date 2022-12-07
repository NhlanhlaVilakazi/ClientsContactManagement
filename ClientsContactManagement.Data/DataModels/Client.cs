using System.ComponentModel.DataAnnotations.Schema;

namespace ClientsContactManagement.Data.DataModels
{
    public class Client
    {
        public string code { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int numberOfLinkedContacts { get; set; }
    }
}
