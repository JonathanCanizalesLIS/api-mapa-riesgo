using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMotriz
{
    public int IdUnidad { get; set; }

    public int TipoCombustible1 { get; set; }

    public int TipoCombustible2 { get; set; }

    public int CapacidadTanque1 { get; set; }

    public int CapacidadTanque2 { get; set; }

    public int UnidadMedidaTanque1 { get; set; }

    public int UnidadMedidaTanque2 { get; set; }

    public string Tanque2 { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual Combustible TipoCombustible1Navigation { get; set; } = null!;

    public virtual Combustible TipoCombustible2Navigation { get; set; } = null!;

    public virtual UnidadMedidum UnidadMedidaTanque1Navigation { get; set; } = null!;

    public virtual UnidadMedidum UnidadMedidaTanque2Navigation { get; set; } = null!;
}
