using Estoque.Entities.Views.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Entities.Views
{
    public class GradeProdutoView : BaseView
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public int IdProduto { get; set; }
        public int IdProdutoItem { get; set; }
        public int IdGradeProduto { get; set; }
        public int IdPedido { get; set; }
        public int Quantidade { get; set; }
        public int Custo { get; set; }
        public int Preco { get; set; }
        public ProdutoItemView ProdutoItem { get; set; }
        public PedidoView Pedido { get; set; }
    }
}