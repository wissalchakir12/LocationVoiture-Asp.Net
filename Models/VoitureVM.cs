using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VoitureVM
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool Est_Dispo { get; set; }
        public string Image { get; set; }

    }
}
