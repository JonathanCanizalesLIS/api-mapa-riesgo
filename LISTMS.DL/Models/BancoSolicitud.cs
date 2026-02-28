using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitud
{
    public int IdSolicitud { get; set; }

    public int NumSolicitud { get; set; }

    public int IdEmpresa { get; set; }

    public decimal Monto { get; set; }

    public int IdMoneda { get; set; }

    public int IdBanco { get; set; }

    public int IdTipoDoc { get; set; }

    public int IdRol { get; set; }

    public string Referencia { get; set; } = null!;

    public int IdProveedor { get; set; }

    public string PornumVeces { get; set; } = null!;

    public int IdFrecuencia { get; set; }

    public int RepetirCada { get; set; }

    public int CantidadRepeticiones { get; set; }

    public string Finaliza { get; set; } = null!;

    public DateTime FechaLimiteEjecucion { get; set; }

    public DateTime FechaSiguienteRepeticion { get; set; }

    public int IdConcepto { get; set; }

    public int IdDocumento { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public DateTime UltimoRealizado { get; set; }

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal Total { get; set; }

    public int? IdSucursal { get; set; }

    public string? Estado { get; set; }

    public decimal? MontoIeps { get; set; }

    public string? FolioFiscal { get; set; }

    public decimal? RetencionIsr { get; set; }

    public decimal FactorIeps { get; set; }

    public decimal FactorIsr { get; set; }

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitudRelacion> BancoSolicitudRelacions { get; set; } = new List<BancoSolicitudRelacion>();

    public virtual BancoSolicitudEstatus EstatusNavigation { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Banco IdBancoNavigation { get; set; } = null!;

    public virtual BancoConcepto IdConceptoNavigation { get; set; } = null!;

    public virtual TiposDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual BancoSolicitudFrecuencium IdFrecuenciaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual BancoMovimientoRol IdRolNavigation { get; set; } = null!;

    public virtual BancoMovimientoTipoReferencium IdTipoDocNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();
}
