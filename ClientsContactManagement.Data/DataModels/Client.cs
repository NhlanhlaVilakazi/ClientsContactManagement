using ClientsContactManagement.Data.BaseClass;

namespace ClientsContactManagement.Data.DataModels
{
    public class Client : BasePrimaryKey
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int numberOfLinkedContacts { get; set; }
    }
}
