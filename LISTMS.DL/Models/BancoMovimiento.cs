using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoMovimiento
{
    public int IdMovimiento { get; set; }

    public string NumMovimiento { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdRol { get; set; }

    public decimal Monto { get; set; }

    public int IdMoneda { get; set; }

    public int IdIngreso { get; set; }

    public decimal TipoCambio { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdBanco { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdTipoDoc { get; set; }

    public string Referencia { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public int IdProveedor { get; set; }

    public string Estatus { get; set; } = null!;

    public string Conciliado { get; set; } = null!;

    public DateTime FechaDoc { get; set; }

    public int IdMovimientoPadre { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdDocumento { get; set; }

    public int IdCuentaCliente { get; set; }

    public int IdClienteFacturaje { get; set; }

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal Total { get; set; }

    public string? FolioFiscal { get; set; }

    public int IdDocumentoClickb { get; set; }

    public int FolioClickb { get; set; }

    public int IdGuia { get; set; }

    public decimal? MontoIeps { get; set; }

    public decimal? RetencionIsr { get; set; }

    public int? IdSolicitud { get; set; }

    public virtual ICollection<BancoMovimientoDetalle> BancoMovimientoDetalles { get; set; } = new List<BancoMovimientoDetalle>();

    public virtual ICollection<BancoSolicitudRelacion> BancoSolicitudRelacions { get; set; } = new List<BancoSolicitudRelacion>();

    public virtual BancoMovimientoEstatus EstatusNavigation { get; set; } = null!;

    public virtual ICollection<FacturaPago> FacturaPagos { get; set; } = new List<FacturaPago>();

    public virtual Banco IdBancoNavigation { get; set; } = null!;

    public virtual Cliente IdClienteFacturajeNavigation { get; set; } = null!;

    public virtual CuentaCliente IdCuentaClienteNavigation { get; set; } = null!;

    public virtual TiposDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual BancoPeriodo IdPeriodoNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual BancoMovimientoRol IdRolNavigation { get; set; } = null!;

    public virtual BancoSolicitud? IdSolicitudNavigation { get; set; }

    public virtual BancoMovimientoTipoReferencium IdTipoDocNavigation { get; set; } = null!;
}
