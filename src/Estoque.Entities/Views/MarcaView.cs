using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class MarcaView : BaseView
    {
        public int IdMarca { get; set; }
        public string Descricao { get; set; }
    }
}