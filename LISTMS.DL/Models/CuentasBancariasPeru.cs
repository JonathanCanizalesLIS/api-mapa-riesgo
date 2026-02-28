using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CuentasBancariasPeru
{
    public int IdCliente { get; set; }

    public int Consecutivo { get; set; }

    public string? InstitucionBancaria { get; set; }

    public string? NoCuenta { get; set; }

    public string? NoCuentaInterbancaria { get; set; }

    public int? IdMoneda { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Monedum? IdMonedaNavigation { get; set; }
}
