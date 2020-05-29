using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Segmento : BaseModel
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
    }
}