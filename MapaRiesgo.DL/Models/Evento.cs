using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class Evento
{
    public int IdEvento { get; set; }

    public int IdTipoEvento { get; set; }

    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public string? Evidencia { get; set; }

    public DateTime Fecha { get; set; }

    public int IdSistemaOrigen { get; set; }

    public int IdEmpresa { get; set; }

    public virtual SistemaOrigen IdSistemaOrigenNavigation { get; set; } = null!;

    public virtual TipoEvento IdTipoEventoNavigation { get; set; } = null!;
}
