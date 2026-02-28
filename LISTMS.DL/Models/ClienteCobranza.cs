using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteCobranza
{
    public int IdCliente { get; set; }

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public int IdSucursalcobro { get; set; }

    public int DiasCredito { get; set; }

    public int CalculaVencimiento { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalcobroNavigation { get; set; } = null!;
}
