using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosServicio
{
    public string? Name { get; set; }

    public double? PorcentajePromotor { get; set; }

    public string? Webservice { get; set; }

    public int Id { get; set; }

    public string? Activo { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<PagosPartida> PagosPartida { get; set; } = new List<PagosPartida>();

    public virtual ICollection<PagosServiciosComisione> PagosServiciosComisiones { get; set; } = new List<PagosServiciosComisione>();

    public virtual ICollection<PagosServicioscontratado> PagosServicioscontratados { get; set; } = new List<PagosServicioscontratado>();
}
