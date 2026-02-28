using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitudFrecuencium
{
    public int IdFrecuencia { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BancoSolicitudFrecuenciaIdioma> BancoSolicitudFrecuenciaIdiomas { get; set; } = new List<BancoSolicitudFrecuenciaIdioma>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();
}
