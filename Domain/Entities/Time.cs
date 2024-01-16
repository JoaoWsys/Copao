using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("time")]
    public class Time
    {
        public string Nome { get; set; } = string.Empty;
        public int CapitaoId { get; set; }
        public string Logo { get; set; } = string.Empty;


        public Usuario? Capitao { get; set; }
    }
}
