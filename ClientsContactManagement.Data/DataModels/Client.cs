using ClientsContactManagement.Data.BaseClass;

namespace ClientsContactManagement.Data.DataModels
{
    public class Client : BasePrimaryKey
    {
        public string name { get; set; }
    }
}
