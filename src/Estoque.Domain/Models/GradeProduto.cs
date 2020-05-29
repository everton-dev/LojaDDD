using Estoque.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Domain.Models
{
    public class GradeProduto : BaseModel
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public int IdProduto { get; set; }
        public int IdProdutoItem { get; set; }
        public int IdGradeProduto { get; set; }
        public int IdPedido { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Custo { get; set; }
        public decimal Preco { get; set; }
        public ProdutoItem ProdutoItem { get; set; }
        public Pedido Pedido { get; set; }
    }
}