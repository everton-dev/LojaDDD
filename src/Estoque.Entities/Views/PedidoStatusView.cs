using Estoque.Entities.Views.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Entities.Views
{
    public class PedidoStatusView : BaseView
    {
        public int IdPedidoStatus { get; set; }
        public string Descricao { get; set; }
    }
}