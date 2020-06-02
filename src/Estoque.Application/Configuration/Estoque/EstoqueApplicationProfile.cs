using Estoque.Entities.Views;

namespace Estoque.Application.Configuration.Estoque
{
    public class EstoqueApplicationProfile : AutoMapper.Profile
    {
        public EstoqueApplicationProfile()
        {
            CreateMap<Domain.Models.Categoria, CategoriaView>()
                .ReverseMap();

            CreateMap<Domain.Models.Cliente, ClienteView>()
                .ReverseMap();

            CreateMap<Domain.Models.Cor, CorView>()
                .ReverseMap();

            CreateMap<Domain.Models.Fornecedor, FornecedorView>()
                .ReverseMap();

            CreateMap<Domain.Models.GradeProduto, GradeProdutoView>()
                .ReverseMap();

            CreateMap<Domain.Models.Marca, MarcaView>()
                .ReverseMap();

            CreateMap<Domain.Models.PedidoStatus, PedidoStatusView>()
                .ReverseMap();

            CreateMap<Domain.Models.Pedido, PedidoView>()
                .ReverseMap();

            CreateMap<Domain.Models.ProdutoItem, ProdutoItemView>()
                .ReverseMap();

            CreateMap<Domain.Models.Produto, ProdutoView>()
                .ReverseMap();

            CreateMap<Domain.Models.Segmento, SegmentoView>()
                .ReverseMap();
        }
    }
}