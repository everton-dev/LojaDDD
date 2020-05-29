using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class ProdutoItem : BaseModel
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public int IdProduto { get; set; }
        public int IdProdutoItem { get; set; }
        public string Tamanho { get; set; }
        public Produto Produto { get; set; }
    }
}