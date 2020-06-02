using AutoMapper;
using Estoque.Application.Configuration.Estoque;

namespace Estoque.Application.Configuration
{
    public static class AutoMapperConfig
    {
        public static IMapper RegisterMappings()
        {
            return new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile<EstoqueApplicationProfile>();
            })
            .CreateMapper();
        }
    }
}