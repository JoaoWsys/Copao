using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("torneio")]
    public class Torneio : Base
    {
        public string Nome { get; set; } = string.Empty;
        public int NrParticipantes { get; set; }
        public DateTime DataInicio { get; set; }
        public int CampeaoId { get; set; }

        public Time? Campeao { get;}

    }
}
