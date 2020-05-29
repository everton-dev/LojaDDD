using Estoque.Entities.Views.Base;

namespace Estoque.Entities.Views
{
    public class CorView : BaseView
    {
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdSegmento { get; set; }
        public int IdCor { get; set; }
        public string Descricao { get; set; }
        public SegmentoView Segmento { get; set; }
    }
}