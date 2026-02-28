using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosPartida
{
    public int? ServicioId { get; set; }

    public string? Name { get; set; }

    public double? Precio { get; set; }

    public int Id { get; set; }

    public int? Meses { get; set; }

    public string? Base { get; set; }

    public string? Edodecuenta { get; set; }

    public string? Activo { get; set; }

    public string? Descripcion { get; set; }

    public int? Rangoinicial { get; set; }

    public int? Rangofinal { get; set; }

    public string? Pais { get; set; }

    public virtual ICollection<PagosCorte> PagosCortes { get; set; } = new List<PagosCorte>();

    public virtual PagosServicio? Servicio { get; set; }
}
