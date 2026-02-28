using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class Unidad
{
    public int IdGeoposicion { get; set; }

    public int IdUnidad { get; set; }

    public string? Unidad1 { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public int? IdOperador { get; set; }

    public int IdSistemaOrigen { get; set; }

    public int? IdEmpresa { get; set; }
}
