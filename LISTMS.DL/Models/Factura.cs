using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public string NumFactura { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdCliente { get; set; }

    public int IdEstatus { get; set; }

    public int IdSerie { get; set; }

    public decimal TipoCambio { get; set; }

    public int IdRelacioncobro { get; set; }

    public int IdMoneda { get; set; }

    public decimal MontoNcargo { get; set; }

    public decimal MontoNcredito { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal MontoPago { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int IdSolicitud { get; set; }

    public int IdMetodoPago { get; set; }

    public string NoCuenta { get; set; } = null!;

    public int? IdDetraccion { get; set; }

    public decimal? MontoDetraccion { get; set; }

    public decimal? MontoFleteReferencial { get; set; }

    public decimal? PagoDetraccion { get; set; }

    public string ClaveConfirmacion { get; set; } = null!;

    public int IdFormaPagoFact { get; set; }

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual GuiaDetraccion? IdDetraccionNavigation { get; set; }

    public virtual AnticipoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual MetodoPago IdFormaPagoFactNavigation { get; set; } = null!;

    public virtual ClienteMetodoPago IdMetodoPagoNavigation { get; set; } = null!;

    public virtual BancoSolicitud IdSolicitudNavigation { get; set; } = null!;

    public virtual ICollection<NotaCargo> NotaCargos { get; set; } = new List<NotaCargo>();

    public virtual ICollection<NotaCredito> NotaCreditos { get; set; } = new List<NotaCredito>();
}
