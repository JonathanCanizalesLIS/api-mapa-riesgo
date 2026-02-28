using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCredito
{
    public int IdCredito { get; set; }

    public string NumCredito { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdFactura { get; set; }

    public int IdTipo { get; set; }

    public int IdSerie { get; set; }

    public int IdEstatus { get; set; }

    public int IdMoneda { get; set; }

    public decimal Subtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public DateTime Fecha { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public int IdPlazaEmision { get; set; }

    public string ClaveConfirmacion { get; set; } = null!;

    public int IdTipoPeru { get; set; }

    public int IdTipofacturarelacionada { get; set; }

    public int? IdMetodoPago { get; set; }

    public int? IdFormaPago { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public DateTime? FechaSolicitudCancelacion { get; set; }

    public int IdMotivoCancelacion { get; set; }

    public string MotivoCancelacion { get; set; } = null!;

    public string UuidRelacionCancelacion { get; set; } = null!;

    public int IdNotaCreditoRelacionCancelacion { get; set; }

    public string SustituyeDocumento { get; set; } = null!;

    public int EstatusCancelacion { get; set; }

    public int IdFormaPagoPeru { get; set; }

    public DateTime? FechaVencimientoPeru { get; set; }

    public int IdTipodocClickb { get; set; }

    public int IdDocumentoClickb { get; set; }

    public int IdTipoPagoClickb { get; set; }

    public int FolioClickb { get; set; }

    public string NombreTipodocClickb { get; set; } = null!;

    public int IdEstatusClickb { get; set; }

    public virtual ICollection<ElectronicoNotaCredito> ElectronicoNotaCreditos { get; set; } = new List<ElectronicoNotaCredito>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual NotaCreditoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual SerieCredito IdSerieNavigation { get; set; } = null!;

    public virtual NotaCreditoTipoPeru IdTipoPeruNavigation { get; set; } = null!;

    public virtual ICollection<NotaCreditoAdendum> NotaCreditoAdenda { get; set; } = new List<NotaCreditoAdendum>();

    public virtual ICollection<NotaCreditoCuotasPeru> NotaCreditoCuotasPerus { get; set; } = new List<NotaCreditoCuotasPeru>();

    public virtual ICollection<NotaCreditoDetalle> NotaCreditoDetalles { get; set; } = new List<NotaCreditoDetalle>();
}
