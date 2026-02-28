using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitudEstatus
{
    public string Estatus { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BancoSolicitudEstatusIdioma> BancoSolicitudEstatusIdiomas { get; set; } = new List<BancoSolicitudEstatusIdioma>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();
}
