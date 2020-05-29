using Estoque.Entities.Views.Base;
using System.Collections.Generic;

namespace Estoque.Entities.Views
{
    public class PedidoView : BaseView
    {
        public int IdPedido { get; set; }
        public int IdFornecedor { get; set; }
        public int IdPedidoStatus { get; set; }
        public int Quantidade { get; set; }
        public decimal Custo { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public FornecedorView Fornecedor { get; set; }
        public PedidoStatusView PedidoStatus { get; set; }
        public IEnumerable<GradeProdutoView> GradeProdutos { get; set; }
    }
}