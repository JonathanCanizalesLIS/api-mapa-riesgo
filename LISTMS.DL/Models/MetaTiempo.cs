using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MetaTiempo
{
    public string IdEmpresa { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public double? MetaIngresoViaje { get; set; }

    public double? MetaPromedioDiasCartera { get; set; }

    public double? MetaRendimientoCombustible { get; set; }

    public double? MetaViajes { get; set; }

    public double? MetaGastosFijosAdmin { get; set; }

    public double? MetaCostoMtto { get; set; }

    public double? MetaCostoMttoXKm { get; set; }
}
