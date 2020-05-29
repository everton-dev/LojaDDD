using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class SegmentoView : BaseView
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public string Descricao { get; set; }
        public CategoriaView Categoria { get; set; }
    }
}