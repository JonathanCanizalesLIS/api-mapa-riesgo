using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaDetraccion
{
    public int IdDetraccion { get; set; }

    public string NumDetraccion { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Porcentaje { get; set; }

    public decimal? Minimo { get; set; }

    public string? FleteReferencial { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();
}
