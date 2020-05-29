using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class FornecedorView : BaseView
    {
        public int IdFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
    }
}