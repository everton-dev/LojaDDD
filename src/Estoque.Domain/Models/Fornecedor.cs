using Estoque.Domain.Models.Base;

namespace Estoque.Domain.Models
{
    public class Fornecedor : BaseModel
    {
        public int IdFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
    }
}