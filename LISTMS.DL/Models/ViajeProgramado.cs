using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeProgramado
{
    public int IdViaje { get; set; }

    public int IdOrigen { get; set; }

    public int IdDestino { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaCarga { get; set; }

    public DateTime FechaDescarga { get; set; }

    public string? HoraCarga { get; set; }

    public string? HoraDescarga { get; set; }

    public string Referencia { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdViaje1 { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Plaza IdDestinoNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Plaza IdOrigenNavigation { get; set; } = null!;

    public virtual Viaje IdViaje1Navigation { get; set; } = null!;
}
