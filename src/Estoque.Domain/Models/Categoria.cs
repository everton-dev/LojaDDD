using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Categoria : BaseModel
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
        public Marca Marca { get; set; }
    }
}