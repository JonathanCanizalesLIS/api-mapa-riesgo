using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CombustibleVale
{
    public int IdVale { get; set; }

    public string NumVale { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdProveedor { get; set; }

    public int IdCombustible { get; set; }

    public int IdUnidad { get; set; }

    public int IdUnidadMedida { get; set; }

    public int IdUnidadMedidaBase { get; set; }

    public int IdIva { get; set; }

    public decimal CantidadCombustible { get; set; }

    public decimal CantidadCombustibleBase { get; set; }

    public decimal PrecioCombustible { get; set; }

    public decimal MontoSubtotal { get; set; }

    public decimal MontoCombustible { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoIeps { get; set; }

    public int IdEstatus { get; set; }

    public int IdSucursal { get; set; }

    public int IdViaje { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaCombustible { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdMoneda { get; set; }

    public string ValeEnviadoRoutech { get; set; } = null!;

    public int IdTipoGastoClickb { get; set; }

    public int IdAsociadoDeudorClickb { get; set; }

    public int IdFormaPagoClickb { get; set; }

    public int IdDocumentoGastoClickb { get; set; }

    public string FolioDocumentoGastoClickb { get; set; } = null!;

    public int IdCentroCostoClickb { get; set; }

    public virtual Combustible IdCombustibleNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual CombustibleEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaBaseNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
