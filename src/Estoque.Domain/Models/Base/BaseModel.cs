using System;

namespace Estoque.Domain.Models.Base
{
    public class BaseModel
    {
        public bool Ativo { get; set; }
        public string UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}