using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionDirectum
{
    public int IdLiquidacionDirecta { get; set; }

    public int IdPersonal { get; set; }

    public int IdBancosat { get; set; }

    public DateTime FechaPago { get; set; }

    public DateTime? FechaInicial { get; set; }

    public DateTime? FechaFinal { get; set; }

    public int? IdEstatus { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdEmpresa { get; set; }

    public int IdMoneda { get; set; }

    public int IdSucursal { get; set; }

    public decimal MontoGravable { get; set; }

    public decimal MontoExcento { get; set; }

    public decimal MontoTotal { get; set; }

    public int NumLiquidacionDirecta { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdTiponomina { get; set; }

    public int IdLiquidacionTipo { get; set; }

    public decimal Totalpagado { get; set; }

    public int Numanioserv { get; set; }

    public decimal Ultsueldomens { get; set; }

    public decimal Ingresoacum { get; set; }

    public decimal Ingresonoacum { get; set; }

    public int Numdiaspagados { get; set; }

    public string ClaveConfirmacion { get; set; } = null!;

    public decimal SubsidioEmpleo { get; set; }

    public virtual ICollection<ElectronicoLiquidacionDirectum> ElectronicoLiquidacionDirecta { get; set; } = new List<ElectronicoLiquidacionDirectum>();

    public virtual BancoBancosat IdBancosatNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual LiquidacionEstatus? IdEstatusNavigation { get; set; }

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual LiquidacionTipo IdLiquidacionTipoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Personal IdPersonalNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual NominaTipo IdTiponominaNavigation { get; set; } = null!;
}
