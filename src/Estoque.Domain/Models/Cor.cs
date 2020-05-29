using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Cor : BaseModel
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public string Descricao { get; set; }
        public Segmento Segmento { get; set; }
    }
}