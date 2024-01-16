using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("usuario")]
    public class Usuario : Base
    {
        public string Email { get; set; } = string.Empty; 
        public string Senha { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Nick { get; set; } = string.Empty;
        public string? Elo { get; set; }
        public string? Pix { get; set; }
    }
}
