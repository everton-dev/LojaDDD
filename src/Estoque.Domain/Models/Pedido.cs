using Estoque.Domain.Models.Base;
using System.Collections.Generic;

namespace Estoque.Domain.Models
{
    public class Pedido : BaseModel
    {
        public int IdPedido { get; set; }
        public int IdFornecedor { get; set; }
        public int IdPedidoStatus { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Custo { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public PedidoStatus PedidoStatus { get; set; }
        public IEnumerable<GradeProduto> GradeProdutos { get; set; }
    }
}