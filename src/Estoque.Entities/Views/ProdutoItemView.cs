using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class ProdutoItemView : BaseView
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public int IdProduto { get; set; }
        public int IdProdutoItem { get; set; }
        public string Tamanho { get; set; }
        public ProdutoView Produto { get; set; }
    }
}