using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MetodoPago
{
    public int IdMetodoPago { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
