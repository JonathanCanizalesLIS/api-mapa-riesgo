using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionPermisionario
{
    public int IdLiquidacionPermisionario { get; set; }

    public string NumLiquidacionPermisionario { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public DateTime Fecha { get; set; }

    public int IdPermisionario { get; set; }

    public int IdEstatus { get; set; }

    public DateTime FechaInicial { get; set; }

    public DateTime FechaFinal { get; set; }

    public decimal TotalAnticipos { get; set; }

    public decimal TotalPagoFlete { get; set; }

    public decimal TotalOtrosPagos { get; set; }

    public decimal TotalDescuentos { get; set; }

    public decimal MontoTotalPagar { get; set; }

    public int IdMoneda { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdIva { get; set; }

    public int IdUsuarioCancelo { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public int TipoPersona { get; set; }

    public int IdSolicitud { get; set; }

    public string ReferenciaPago { get; set; } = null!;

    public DateTime? FechaPago { get; set; }

    public int IdUsuarioPago { get; set; }

    public decimal MontoSubtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public int IdRetencion { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual LiquidacionPermisionarioEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual UnidadLinea IdPermisionarioNavigation { get; set; } = null!;

    public virtual BancoSolicitud IdSolicitudNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioCanceloNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioPagoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionPermisionarioDetalle> LiquidacionPermisionarioDetalles { get; set; } = new List<LiquidacionPermisionarioDetalle>();

    public virtual ICollection<LiquidacionPermisionarioGuium> LiquidacionPermisionarioGuia { get; set; } = new List<LiquidacionPermisionarioGuium>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
