using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("usuarioTime")]
    public class UsuarioTime : Base
    {
        public int UsuarioId { get; set; }
        public int TimeId { get; set; }

        public Usuario? Usuario { get; set; }
        public Time? Time { get; set; }
    }
}
