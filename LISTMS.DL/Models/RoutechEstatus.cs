using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class RoutechEstatus
{
    public int IdRoutechEstatus { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<ViajeRutaRoutech> ViajeRutaRouteches { get; set; } = new List<ViajeRutaRoutech>();
}
