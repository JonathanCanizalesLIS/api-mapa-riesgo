using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosServiciosComisione
{
    public int Id { get; set; }

    public int ServicioId { get; set; }

    public int RangoInicialMeses { get; set; }

    public int RangoFinalMeses { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Porcentaje { get; set; }

    public int? PorcentajeLis { get; set; }

    public virtual PagosServicio Servicio { get; set; } = null!;
}
