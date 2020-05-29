using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class ProdutoView : BaseView
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public CorView Cor { get; set; }
    }
}