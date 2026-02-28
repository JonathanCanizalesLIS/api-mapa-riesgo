using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteMetodoPago
{
    public int IdMetodoPago { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();
}
