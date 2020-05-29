using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Cliente : BaseModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
    }
}