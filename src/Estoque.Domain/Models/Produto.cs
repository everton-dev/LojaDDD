using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Produto : BaseModel
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public Cor Cor { get; set; }
    }
}