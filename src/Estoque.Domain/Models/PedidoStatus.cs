using Estoque.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Domain.Models
{
    public class PedidoStatus : BaseModel
    {
        public int IdPedidoStatus { get; set; }
        public string Descricao { get; set; }
    }
}