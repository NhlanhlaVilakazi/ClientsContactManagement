using AutoMapper;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.ViewModels.Client;
using ClientsContactManagement.ViewModels.Contact;

namespace ClientsContactManagement.Business.Mappings
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClientViewModel, Client>().ReverseMap();
                cfg.CreateMap<ContactViewModel, Contact>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
