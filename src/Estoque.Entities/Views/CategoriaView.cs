using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class CategoriaView : BaseView
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
        public MarcaView Marca { get; set; }
    }
}