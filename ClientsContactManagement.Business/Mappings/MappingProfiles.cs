using AutoMapper;
using ClientsContactManagement.Data.DataModels;
using ClientsContactManagement.ViewModels.Client;

namespace ClientsContactManagement.Business.Mappings
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClientViewModel, Client>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
