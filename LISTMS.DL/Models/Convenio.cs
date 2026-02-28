using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Convenio
{
    public int IdConvenio { get; set; }

    public int IdEmpresa { get; set; }

    public int IdCliente { get; set; }

    public int IdDestinatario { get; set; }

    public int IdRemitente { get; set; }

    public int IdPlazaOrigen { get; set; }

    public int IdPlazaDestino { get; set; }

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public string Estatus { get; set; } = null!;

    public string? NombreBusqueda { get; set; }

    public string ValorDeclarado { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string RecogerEn { get; set; } = null!;

    public string EntregarEn { get; set; } = null!;

    public int IdTipoCobro { get; set; }

    public int IdMoneda { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public decimal Flete { get; set; }

    public decimal Seguro { get; set; }

    public decimal Maniobras { get; set; }

    public decimal Autopistas { get; set; }

    public decimal Otros { get; set; }

    public decimal Subtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal TipoCambio { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal FactorCobro { get; set; }

    public DateTime FechaModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int? IdEntregaEn { get; set; }

    public int? IdRecogerEn { get; set; }

    public int? IdObjetoImpuesto { get; set; }

    public int IdClaveprodservCp { get; set; }

    public int IdClaveUnidad { get; set; }

    public string MaterialPeligroso { get; set; } = null!;

    public string TransporteInternacional { get; set; } = null!;

    public string EntSalida { get; set; } = null!;

    public virtual ICollection<ConvenioEvidencium> ConvenioEvidencia { get; set; } = new List<ConvenioEvidencium>();

    public virtual ICollection<ConvenioProducto> ConvenioProductos { get; set; } = new List<ConvenioProducto>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Cliente IdDestinatarioNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ClienteRecEnt? IdEntregaEnNavigation { get; set; }

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaDestinoNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaOrigenNavigation { get; set; } = null!;

    public virtual ClienteRecEnt? IdRecogerEnNavigation { get; set; }

    public virtual Cliente IdRemitenteNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual GuiaTipoCobro IdTipoCobroNavigation { get; set; } = null!;
}
