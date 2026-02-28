using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoPeruTicket
{
    public int IdTicket { get; set; }

    public int IdEmpresa { get; set; }

    public int IdGuia { get; set; }

    public string NoTicket { get; set; } = null!;

    public string? FechaTimbrado { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Igv { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime? FechaModifico { get; set; }

    public int IdNotaCredito { get; set; }

    public int IdNotaCargo { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
