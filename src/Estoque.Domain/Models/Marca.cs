using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Marca : BaseModel
    {
        public int IdMarca { get; set; }
        public string Descricao { get; set; }
    }
}