using Estoque.Entities.Views.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Entities.Views
{
    public class ClienteView : BaseView
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
    }
}
