using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAM.DL.Models
{
    public partial class UnidadesZam
    {
        public string IdUnidad { get; set; } = null!;

        public string? Unidad1 { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        public int? IdOperador { get; set; }

        public int? IdEmpresa { get; set; }
    }
}
