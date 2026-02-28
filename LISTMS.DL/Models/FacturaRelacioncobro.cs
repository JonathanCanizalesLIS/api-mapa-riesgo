using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FacturaRelacioncobro
{
    public int IdRelacioncobro { get; set; }

    public string NumRelacion { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdMoneda { get; set; }

    public int IdEstatus { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaRelacion { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual FacturaRelacioncobroEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
}
