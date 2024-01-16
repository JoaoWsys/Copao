using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("timetorneio")]
    public class TimeTorneio : Base
    {
        public int IdTime { get; set; }
        public int IdTorneio { get; set; }

        public Time? Time { get; set; }
        public Torneio? Torneio { get; set; }
    }
}
