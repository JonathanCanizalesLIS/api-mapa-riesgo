using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Guium
{
    public int IdGuia { get; set; }

    public string NumGuia { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public DateTime Fecha { get; set; }

    public int IdCliente { get; set; }

    public int IdConvenio { get; set; }

    public int IdRemitente { get; set; }

    public int IdPlazaOrigen { get; set; }

    public string RecogerEn { get; set; } = null!;

    public int IdDestinatario { get; set; }

    public int IdPlazaDestino { get; set; }

    public string EntregarEn { get; set; } = null!;

    public int IdFactura { get; set; }

    public int IdFacturarelacionada { get; set; }

    public int IdTipoCobro { get; set; }

    public decimal FactorCobro { get; set; }

    public decimal Flete { get; set; }

    public decimal Seguro { get; set; }

    public decimal Maniobras { get; set; }

    public decimal Autopistas { get; set; }

    public decimal Otros { get; set; }

    public decimal Subtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public string ValorDeclarado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? Referencia { get; set; }

    public int IdMoneda { get; set; }

    public decimal TipoCambio { get; set; }

    public int IdViaje { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdEstatus { get; set; }

    public int IdSerie { get; set; }

    public int IdPlazaEmision { get; set; }

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public int IdTipoDocumento { get; set; }

    public string MotivoCancelacion { get; set; } = null!;

    public DateTime? FechaCancelacion { get; set; }

    public string SustituyeDocumento { get; set; } = null!;

    public int Remolque { get; set; }

    public int EstatusSac { get; set; }

    public int IdSolicitud { get; set; }

    public int IdMetodoPago { get; set; }

    public string NoCuenta { get; set; } = null!;

    public int? IdDetraccion { get; set; }

    public decimal? MontoDetraccion { get; set; }

    public decimal? MontoFleteReferencial { get; set; }

    public int? OrdenImpresion { get; set; }

    public int MaterialPeligroso { get; set; }

    public decimal MontoIndemnizacion { get; set; }

    public bool Facturado { get; set; }

    public DateTime FechaCita { get; set; }

    public int? IdEntregaEn { get; set; }

    public int? IdRecogerEn { get; set; }

    public string ClaveConfirmacion { get; set; } = null!;

    public int IdClaveprodservFlete { get; set; }

    public int IdClaveUnidadFlete { get; set; }

    public int IdClaveprodservAutopista { get; set; }

    public int IdClaveUnidadAutopista { get; set; }

    public int IdClaveprodservManiobras { get; set; }

    public int IdClaveUnidadManiobras { get; set; }

    public int IdClaveprodservSeguro { get; set; }

    public int IdClaveUnidadSeguro { get; set; }

    public string HoraCita { get; set; } = null!;

    public int EstatusCancelacion { get; set; }

    public DateTime? FechaSolicitudCancelacion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string CodigoVenta { get; set; } = null!;

    public decimal FleteLiquidacion { get; set; }

    public string FacturaAnticipo { get; set; } = null!;

    public string CpEnviadaRoutech { get; set; } = null!;

    public string IdTipodocClickb { get; set; } = null!;

    public string NombreTipodocClickb { get; set; } = null!;

    public string IdAgenteClickb { get; set; } = null!;

    public string IdDireccionEntClickb { get; set; } = null!;

    public int IdDocumentoClickb { get; set; }

    public int IdTipoPagoClickb { get; set; }

    public string FolioClickb { get; set; } = null!;

    public string SerieClickb { get; set; } = null!;

    public int IdMetodopagoSat { get; set; }

    public int IdUsoCfdi { get; set; }

    public string DescripcionFlete { get; set; } = null!;

    public string CFletePorGuia { get; set; } = null!;

    public string TransInternacional { get; set; } = null!;

    public string EntSalida { get; set; } = null!;

    public string IsComplementoCp { get; set; } = null!;

    public string AseguraMedAmbiente { get; set; } = null!;

    public string PolizaSegMedAmbiente { get; set; } = null!;

    public string AseguraCarga { get; set; } = null!;

    public string PolizaSegCarga { get; set; } = null!;

    public decimal PrimaSeguroCarga { get; set; }

    public int IdMotivoCancelacion { get; set; }

    public string UuidRelacionCancelacion { get; set; } = null!;

    public int IdguiaRelacionCancelacion { get; set; }

    public int IdEmbarcadorPe { get; set; }

    public string TipoExportacion { get; set; } = null!;

    public int? IdObjetoImpuesto { get; set; }

    public int IdResico { get; set; }

    public decimal MontoResico { get; set; }

    public int? IdPeriodicidad { get; set; }

    public int? IdMeses { get; set; }

    public int IdFormaPago { get; set; }

    public int IdTipoOperacion { get; set; }

    public int IdMedioPago { get; set; }

    public string CuentaBancoNacion { get; set; } = null!;

    public string Contenedores { get; set; } = null!;

    public string ReferenciasAdicionales { get; set; } = null!;

    public string RegistroIstmo { get; set; } = null!;

    public int IdRegimenAduanero { get; set; }

    public int IdUbicacionPoloOrigen { get; set; }

    public int IdUbicacionPoloDestino { get; set; }

    public bool LogisticaInversa { get; set; }

    public bool Timbrando { get; set; }

    public decimal? PesoBrutoVehicular { get; set; }

    public int IdEstatusClickb { get; set; }

    public DateTime? FechaAceptacion { get; set; }

    public int CantidadProductos { get; set; }

    public decimal PesoTotalProductos { get; set; }

    public int IdLocalRetencion { get; set; }

    public decimal MontoLocalRetencion { get; set; }

    public int IdFormaPagoGcp { get; set; }

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<ElectronicoGuium> ElectronicoGuia { get; set; } = new List<ElectronicoGuium>();

    public virtual ICollection<ElectronicoPeruTicket> ElectronicoPeruTickets { get; set; } = new List<ElectronicoPeruTicket>();

    public virtual ICollection<GuiaAdendum> GuiaAdenda { get; set; } = new List<GuiaAdendum>();

    public virtual ICollection<GuiaAdicional> GuiaAdicionals { get; set; } = new List<GuiaAdicional>();

    public virtual ICollection<GuiaCuotasPeru> GuiaCuotasPerus { get; set; } = new List<GuiaCuotasPeru>();

    public virtual ICollection<GuiaEvidencium> GuiaEvidencia { get; set; } = new List<GuiaEvidencium>();

    public virtual ICollection<GuiaOtro> GuiaOtros { get; set; } = new List<GuiaOtro>();

    public virtual ICollection<GuiaProductoIdentificacion> GuiaProductoIdentificacions { get; set; } = new List<GuiaProductoIdentificacion>();

    public virtual ICollection<GuiaProducto> GuiaProductos { get; set; } = new List<GuiaProducto>();

    public virtual UnidadClave IdClaveUnidadAutopistaNavigation { get; set; } = null!;

    public virtual UnidadClave IdClaveUnidadFleteNavigation { get; set; } = null!;

    public virtual UnidadClave IdClaveUnidadManiobrasNavigation { get; set; } = null!;

    public virtual UnidadClave IdClaveUnidadSeguroNavigation { get; set; } = null!;

    public virtual ClaveProductoServicio IdClaveprodservManiobrasNavigation { get; set; } = null!;

    public virtual ClaveProductoServicio IdClaveprodservSeguroNavigation { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Convenio IdConvenioNavigation { get; set; } = null!;

    public virtual Cliente IdDestinatarioNavigation { get; set; } = null!;

    public virtual GuiaDetraccion? IdDetraccionNavigation { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ClienteRecEnt? IdEntregaEnNavigation { get; set; }

    public virtual GuiaEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual ClienteMetodoPago IdMetodoPagoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaDestinoNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaEmisionNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaOrigenNavigation { get; set; } = null!;

    public virtual ClienteRecEnt? IdRecogerEnNavigation { get; set; }

    public virtual Cliente IdRemitenteNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual SerieGuium IdSerieNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual GuiaTipoCobro IdTipoCobroNavigation { get; set; } = null!;

    public virtual GuiaTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionGuium> LiquidacionGuia { get; set; } = new List<LiquidacionGuium>();

    public virtual ICollection<LiquidacionPermisionarioGuium> LiquidacionPermisionarioGuia { get; set; } = new List<LiquidacionPermisionarioGuium>();

    public virtual ICollection<RegimenAduaneroGuium> RegimenAduaneroGuia { get; set; } = new List<RegimenAduaneroGuium>();
}
