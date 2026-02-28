using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LISTMS.DL.Models;

public partial class ListmsContext : DbContext
{
    public ListmsContext()
    {
    }

    public ListmsContext(DbContextOptions<ListmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aduana> Aduanas { get; set; }

    public virtual DbSet<Alarma> Alarmas { get; set; }

    public virtual DbSet<AlarmaFrecuenciaIdioma> AlarmaFrecuenciaIdiomas { get; set; }

    public virtual DbSet<AlarmaFrecuencium> AlarmaFrecuencia { get; set; }

    public virtual DbSet<AlarmaLog> AlarmaLogs { get; set; }

    public virtual DbSet<AlarmaTipo> AlarmaTipos { get; set; }

    public virtual DbSet<AlarmaTipoIdioma> AlarmaTipoIdiomas { get; set; }

    public virtual DbSet<Anticipo> Anticipos { get; set; }

    public virtual DbSet<AnticipoConcepto> AnticipoConceptos { get; set; }

    public virtual DbSet<AnticipoDesglose> AnticipoDesgloses { get; set; }

    public virtual DbSet<AnticipoEstatus> AnticipoEstatuses { get; set; }

    public virtual DbSet<AnticipoEstatusIdioma> AnticipoEstatusIdiomas { get; set; }

    public virtual DbSet<ApiKeyIum> ApiKeyIa { get; set; }

    public virtual DbSet<Archivo> Archivos { get; set; }

    public virtual DbSet<Arrendatario> Arrendatarios { get; set; }

    public virtual DbSet<Aviso> Avisos { get; set; }

    public virtual DbSet<AvisoDestinatario> AvisoDestinatarios { get; set; }

    public virtual DbSet<AyudaMenu> AyudaMenus { get; set; }

    public virtual DbSet<Ayudum> Ayuda { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BancoBancosat> BancoBancosats { get; set; }

    public virtual DbSet<BancoConcepto> BancoConceptos { get; set; }

    public virtual DbSet<BancoConceptoClasificacion> BancoConceptoClasificacions { get; set; }

    public virtual DbSet<BancoConceptoClasificacionIdioma> BancoConceptoClasificacionIdiomas { get; set; }

    public virtual DbSet<BancoConceptoGrupo> BancoConceptoGrupos { get; set; }

    public virtual DbSet<BancoConceptoNaturaleza> BancoConceptoNaturalezas { get; set; }

    public virtual DbSet<BancoConceptoNaturalezaIdioma> BancoConceptoNaturalezaIdiomas { get; set; }

    public virtual DbSet<BancoConceptoTipoReferenciaIdioma> BancoConceptoTipoReferenciaIdiomas { get; set; }

    public virtual DbSet<BancoConceptoTipoReferencium> BancoConceptoTipoReferencia { get; set; }

    public virtual DbSet<BancoMovimiento> BancoMovimientos { get; set; }

    public virtual DbSet<BancoMovimientoDetalle> BancoMovimientoDetalles { get; set; }

    public virtual DbSet<BancoMovimientoDetalleDocumento> BancoMovimientoDetalleDocumentos { get; set; }

    public virtual DbSet<BancoMovimientoEstatus> BancoMovimientoEstatuses { get; set; }

    public virtual DbSet<BancoMovimientoEstatusIdioma> BancoMovimientoEstatusIdiomas { get; set; }

    public virtual DbSet<BancoMovimientoRol> BancoMovimientoRols { get; set; }

    public virtual DbSet<BancoMovimientoRolIdioma> BancoMovimientoRolIdiomas { get; set; }

    public virtual DbSet<BancoMovimientoTipoReferenciaIdioma> BancoMovimientoTipoReferenciaIdiomas { get; set; }

    public virtual DbSet<BancoMovimientoTipoReferencium> BancoMovimientoTipoReferencia { get; set; }

    public virtual DbSet<BancoPeriodo> BancoPeriodos { get; set; }

    public virtual DbSet<BancoRol> BancoRols { get; set; }

    public virtual DbSet<BancoRolIdioma> BancoRolIdiomas { get; set; }

    public virtual DbSet<BancoSolicitud> BancoSolicituds { get; set; }

    public virtual DbSet<BancoSolicitudEstatus> BancoSolicitudEstatuses { get; set; }

    public virtual DbSet<BancoSolicitudEstatusIdioma> BancoSolicitudEstatusIdiomas { get; set; }

    public virtual DbSet<BancoSolicitudFrecuenciaIdioma> BancoSolicitudFrecuenciaIdiomas { get; set; }

    public virtual DbSet<BancoSolicitudFrecuencium> BancoSolicitudFrecuencia { get; set; }

    public virtual DbSet<BancoSolicitudProyeccion> BancoSolicitudProyeccions { get; set; }

    public virtual DbSet<BancoSolicitudRelacion> BancoSolicitudRelacions { get; set; }

    public virtual DbSet<BancoSolicitudViaje> BancoSolicitudViajes { get; set; }

    public virtual DbSet<Botone> Botones { get; set; }

    public virtual DbSet<BotonesSeguridad> BotonesSeguridads { get; set; }

    public virtual DbSet<CClaveProdServCp> CClaveProdServCps { get; set; }

    public virtual DbSet<CConfigAutotransporte> CConfigAutotransportes { get; set; }

    public virtual DbSet<CFraccionArancelarium> CFraccionArancelaria { get; set; }

    public virtual DbSet<CMaterialPeligroso> CMaterialPeligrosos { get; set; }

    public virtual DbSet<CMotivoCancelacionSat> CMotivoCancelacionSats { get; set; }

    public virtual DbSet<CParteTransporte> CParteTransportes { get; set; }

    public virtual DbSet<CSubTipoRemolque> CSubTipoRemolques { get; set; }

    public virtual DbSet<CTipoEmbalaje> CTipoEmbalajes { get; set; }

    public virtual DbSet<CTipoPermisoSct> CTipoPermisoScts { get; set; }

    public virtual DbSet<CUnidadEmbalaje> CUnidadEmbalajes { get; set; }

    public virtual DbSet<CadenaPago> CadenaPagos { get; set; }

    public virtual DbSet<ClaveProductoServicio> ClaveProductoServicios { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteCobranza> ClienteCobranzas { get; set; }

    public virtual DbSet<ClienteContacto> ClienteContactos { get; set; }

    public virtual DbSet<ClienteMetodoPago> ClienteMetodoPagos { get; set; }

    public virtual DbSet<ClienteMetodoPagoIdioma> ClienteMetodoPagoIdiomas { get; set; }

    public virtual DbSet<ClienteRecEnt> ClienteRecEnts { get; set; }

    public virtual DbSet<ClienteTipoRol> ClienteTipoRols { get; set; }

    public virtual DbSet<ClienteTipoRolIdioma> ClienteTipoRolIdiomas { get; set; }

    public virtual DbSet<Combustible> Combustibles { get; set; }

    public virtual DbSet<CombustibleEstatus> CombustibleEstatuses { get; set; }

    public virtual DbSet<CombustibleEstatusIdioma> CombustibleEstatusIdiomas { get; set; }

    public virtual DbSet<CombustibleTarifa> CombustibleTarifas { get; set; }

    public virtual DbSet<CombustibleTarifaDetalle> CombustibleTarifaDetalles { get; set; }

    public virtual DbSet<CombustibleVale> CombustibleVales { get; set; }

    public virtual DbSet<ComprobanteTipo> ComprobanteTipos { get; set; }

    public virtual DbSet<ConceptoPermisionario> ConceptoPermisionarios { get; set; }

    public virtual DbSet<ConceptosContable> ConceptosContables { get; set; }

    public virtual DbSet<ConfiguracionRangoVencimiento> ConfiguracionRangoVencimientos { get; set; }

    public virtual DbSet<ConsultaAlineacion> ConsultaAlineacions { get; set; }

    public virtual DbSet<ConsultaAlineacionIdioma> ConsultaAlineacionIdiomas { get; set; }

    public virtual DbSet<ConsultaDetalle> ConsultaDetalles { get; set; }

    public virtual DbSet<ConsultaDetalleIdioma> ConsultaDetalleIdiomas { get; set; }

    public virtual DbSet<ConsultaVistaDetalle> ConsultaVistaDetalles { get; set; }

    public virtual DbSet<ConsultaVistum> ConsultaVista { get; set; }

    public virtual DbSet<Consultum> Consulta { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<ContactoPuesto> ContactoPuestos { get; set; }

    public virtual DbSet<Convenio> Convenios { get; set; }

    public virtual DbSet<ConvenioAnticipo> ConvenioAnticipos { get; set; }

    public virtual DbSet<ConvenioAnticipoDesglose> ConvenioAnticipoDesgloses { get; set; }

    public virtual DbSet<ConvenioEvidencium> ConvenioEvidencia { get; set; }

    public virtual DbSet<ConvenioLiquidacion> ConvenioLiquidacions { get; set; }

    public virtual DbSet<ConvenioLiquidacionGasto> ConvenioLiquidacionGastos { get; set; }

    public virtual DbSet<ConvenioOtro> ConvenioOtros { get; set; }

    public virtual DbSet<ConvenioProducto> ConvenioProductos { get; set; }

    public virtual DbSet<CotizacionViajeFactore> CotizacionViajeFactores { get; set; }

    public virtual DbSet<CuentaCliente> CuentaClientes { get; set; }

    public virtual DbSet<CuentasBancariasPeru> CuentasBancariasPerus { get; set; }

    public virtual DbSet<DescripcionFlete> DescripcionFletes { get; set; }

    public virtual DbSet<EdiLine> EdiLines { get; set; }

    public virtual DbSet<EdiLoadTender> EdiLoadTenders { get; set; }

    public virtual DbSet<EdiParty> EdiParties { get; set; }

    public virtual DbSet<EdiSesionUsuario> EdiSesionUsuarios { get; set; }

    public virtual DbSet<EdiShipmentStatus> EdiShipmentStatuses { get; set; }

    public virtual DbSet<EdiStatusCode> EdiStatusCodes { get; set; }

    public virtual DbSet<EdiUsuario> EdiUsuarios { get; set; }

    public virtual DbSet<Electronico> Electronicos { get; set; }

    public virtual DbSet<ElectronicoAdendaCampo> ElectronicoAdendaCampos { get; set; }

    public virtual DbSet<ElectronicoAdendaCamposDefault> ElectronicoAdendaCamposDefaults { get; set; }

    public virtual DbSet<ElectronicoAdendaCamposRequerido> ElectronicoAdendaCamposRequeridos { get; set; }

    public virtual DbSet<ElectronicoAdendaCamposRequeridoIdioma> ElectronicoAdendaCamposRequeridoIdiomas { get; set; }

    public virtual DbSet<ElectronicoAdendaCliente> ElectronicoAdendaClientes { get; set; }

    public virtual DbSet<ElectronicoAdendaIdioma> ElectronicoAdendaIdiomas { get; set; }

    public virtual DbSet<ElectronicoAdendum> ElectronicoAdenda { get; set; }

    public virtual DbSet<ElectronicoCertificado> ElectronicoCertificados { get; set; }

    public virtual DbSet<ElectronicoControlPago> ElectronicoControlPagos { get; set; }

    public virtual DbSet<ElectronicoControlPagosDetalle> ElectronicoControlPagosDetalles { get; set; }

    public virtual DbSet<ElectronicoEstatus> ElectronicoEstatuses { get; set; }

    public virtual DbSet<ElectronicoGuium> ElectronicoGuia { get; set; }

    public virtual DbSet<ElectronicoLiquidacion> ElectronicoLiquidacions { get; set; }

    public virtual DbSet<ElectronicoLiquidacionDirectum> ElectronicoLiquidacionDirecta { get; set; }

    public virtual DbSet<ElectronicoNotaCargo> ElectronicoNotaCargos { get; set; }

    public virtual DbSet<ElectronicoNotaCredito> ElectronicoNotaCreditos { get; set; }

    public virtual DbSet<ElectronicoPeruTicket> ElectronicoPeruTickets { get; set; }

    public virtual DbSet<Embalaje> Embalajes { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EmpresaClickbalance> EmpresaClickbalances { get; set; }

    public virtual DbSet<EmpresaConfiguracion> EmpresaConfiguracions { get; set; }

    public virtual DbSet<EmpresaInscripcion> EmpresaInscripcions { get; set; }

    public virtual DbSet<EmpresaProveedoresGp> EmpresaProveedoresGps { get; set; }

    public virtual DbSet<EmpresaProveedoresGpsSuscr> EmpresaProveedoresGpsSuscrs { get; set; }

    public virtual DbSet<EmpresaRegimenFiscal> EmpresaRegimenFiscals { get; set; }

    public virtual DbSet<Esquema> Esquemas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadoCuentum> EstadoCuenta { get; set; }

    public virtual DbSet<EstatusCancelacion> EstatusCancelacions { get; set; }

    public virtual DbSet<EstatusCatalogo> EstatusCatalogos { get; set; }

    public virtual DbSet<EstatusCatalogoIdioma> EstatusCatalogoIdiomas { get; set; }

    public virtual DbSet<EstatusPedido> EstatusPedidos { get; set; }

    public virtual DbSet<EstatusViajeCustom> EstatusViajeCustoms { get; set; }

    public virtual DbSet<EtiquetaConfigurable> EtiquetaConfigurables { get; set; }

    public virtual DbSet<EtiquetaIdioma> EtiquetaIdiomas { get; set; }

    public virtual DbSet<Etiquetum> Etiqueta { get; set; }

    public virtual DbSet<Evidencium> Evidencia { get; set; }

    public virtual DbSet<FactorTipo> FactorTipos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaEstatus> FacturaEstatuses { get; set; }

    public virtual DbSet<FacturaEstatusIdioma> FacturaEstatusIdiomas { get; set; }

    public virtual DbSet<FacturaPago> FacturaPagos { get; set; }

    public virtual DbSet<FacturaPagoDetalle> FacturaPagoDetalles { get; set; }

    public virtual DbSet<FacturaRelacioncobro> FacturaRelacioncobros { get; set; }

    public virtual DbSet<FacturaRelacioncobroEstatus> FacturaRelacioncobroEstatuses { get; set; }

    public virtual DbSet<FacturaRelacioncobroEstatusIdioma> FacturaRelacioncobroEstatusIdiomas { get; set; }

    public virtual DbSet<FacturaXml> FacturaXmls { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<FreeTier> FreeTiers { get; set; }

    public virtual DbSet<FuncionIum> FuncionIa { get; set; }

    public virtual DbSet<GeneralParametro> GeneralParametros { get; set; }

    public virtual DbSet<GeneralSitiosFtp> GeneralSitiosFtps { get; set; }

    public virtual DbSet<GuiaAdendum> GuiaAdenda { get; set; }

    public virtual DbSet<GuiaAdicional> GuiaAdicionals { get; set; }

    public virtual DbSet<GuiaCfdiRelacion> GuiaCfdiRelacions { get; set; }

    public virtual DbSet<GuiaConcepto> GuiaConceptos { get; set; }

    public virtual DbSet<GuiaCuotasPeru> GuiaCuotasPerus { get; set; }

    public virtual DbSet<GuiaDetraccion> GuiaDetraccions { get; set; }

    public virtual DbSet<GuiaEstatus> GuiaEstatuses { get; set; }

    public virtual DbSet<GuiaEstatusIdioma> GuiaEstatusIdiomas { get; set; }

    public virtual DbSet<GuiaEvidenciaFoto> GuiaEvidenciaFotos { get; set; }

    public virtual DbSet<GuiaEvidencium> GuiaEvidencia { get; set; }

    public virtual DbSet<GuiaOtro> GuiaOtros { get; set; }

    public virtual DbSet<GuiaProducto> GuiaProductos { get; set; }

    public virtual DbSet<GuiaProductoIdentificacion> GuiaProductoIdentificacions { get; set; }

    public virtual DbSet<GuiaRegimenAduanero> GuiaRegimenAduaneros { get; set; }

    public virtual DbSet<GuiaTipoCobro> GuiaTipoCobros { get; set; }

    public virtual DbSet<GuiaTipoCobroIdioma> GuiaTipoCobroIdiomas { get; set; }

    public virtual DbSet<GuiaTipoDocumento> GuiaTipoDocumentos { get; set; }

    public virtual DbSet<GuiaTipoDocumentoIdioma> GuiaTipoDocumentoIdiomas { get; set; }

    public virtual DbSet<GuiaTituloAdicional> GuiaTituloAdicionals { get; set; }

    public virtual DbSet<GuiaUbicPoloIstmo> GuiaUbicPoloIstmos { get; set; }

    public virtual DbSet<GuiaViaje> GuiaViajes { get; set; }

    public virtual DbSet<Guium> Guia { get; set; }

    public virtual DbSet<HDisponibilidad> HDisponibilidads { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<Iep> Ieps { get; set; }

    public virtual DbSet<Imagene> Imagenes { get; set; }

    public virtual DbSet<Impresion> Impresions { get; set; }

    public virtual DbSet<ImpresionDetalle> ImpresionDetalles { get; set; }

    public virtual DbSet<ImpresionDetalleIdioma> ImpresionDetalleIdiomas { get; set; }

    public virtual DbSet<ImpresionIdioma> ImpresionIdiomas { get; set; }

    public virtual DbSet<ImpresionSeccione> ImpresionSecciones { get; set; }

    public virtual DbSet<ImpresionSeccionesIdioma> ImpresionSeccionesIdiomas { get; set; }

    public virtual DbSet<ImpresionVistaDetalle> ImpresionVistaDetalles { get; set; }

    public virtual DbSet<ImpresionVistum> ImpresionVista { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<ImpuestoClasificacion> ImpuestoClasificacions { get; set; }

    public virtual DbSet<ImpuestoClasificacionIdioma> ImpuestoClasificacionIdiomas { get; set; }

    public virtual DbSet<ImpuestoImpuesto> ImpuestoImpuestos { get; set; }

    public virtual DbSet<InterfaceConfiguracion> InterfaceConfiguracions { get; set; }

    public virtual DbSet<InterfazProveedoresGp> InterfazProveedoresGps { get; set; }

    public virtual DbSet<Liquidacion> Liquidacions { get; set; }

    public virtual DbSet<LiquidacionConcepto> LiquidacionConceptos { get; set; }

    public virtual DbSet<LiquidacionConceptoComplemento> LiquidacionConceptoComplementos { get; set; }

    public virtual DbSet<LiquidacionConceptoDeduccion> LiquidacionConceptoDeduccions { get; set; }

    public virtual DbSet<LiquidacionConceptoIncapacidad> LiquidacionConceptoIncapacidads { get; set; }

    public virtual DbSet<LiquidacionConceptoPercepcion> LiquidacionConceptoPercepcions { get; set; }

    public virtual DbSet<LiquidacionDirectaDetalle> LiquidacionDirectaDetalles { get; set; }

    public virtual DbSet<LiquidacionDirectum> LiquidacionDirecta { get; set; }

    public virtual DbSet<LiquidacionEstatus> LiquidacionEstatuses { get; set; }

    public virtual DbSet<LiquidacionEstatusIdioma> LiquidacionEstatusIdiomas { get; set; }

    public virtual DbSet<LiquidacionGasto> LiquidacionGastos { get; set; }

    public virtual DbSet<LiquidacionGuium> LiquidacionGuia { get; set; }

    public virtual DbSet<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; }

    public virtual DbSet<LiquidacionPermisionarioDetalle> LiquidacionPermisionarioDetalles { get; set; }

    public virtual DbSet<LiquidacionPermisionarioEstatus> LiquidacionPermisionarioEstatuses { get; set; }

    public virtual DbSet<LiquidacionPermisionarioEstatusIdioma> LiquidacionPermisionarioEstatusIdiomas { get; set; }

    public virtual DbSet<LiquidacionPermisionarioGuium> LiquidacionPermisionarioGuia { get; set; }

    public virtual DbSet<LiquidacionSueldo> LiquidacionSueldos { get; set; }

    public virtual DbSet<LiquidacionSueldoRelacion> LiquidacionSueldoRelacions { get; set; }

    public virtual DbSet<LiquidacionSueldoRutum> LiquidacionSueldoRuta { get; set; }

    public virtual DbSet<LiquidacionSueldoTipo> LiquidacionSueldoTipos { get; set; }

    public virtual DbSet<LiquidacionSueldoTipoIdioma> LiquidacionSueldoTipoIdiomas { get; set; }

    public virtual DbSet<LiquidacionTipo> LiquidacionTipos { get; set; }

    public virtual DbSet<LiquidacionTipoAdeudo> LiquidacionTipoAdeudos { get; set; }

    public virtual DbSet<LiquidacionTipoAdeudoIdioma> LiquidacionTipoAdeudoIdiomas { get; set; }

    public virtual DbSet<LisSecuencium> LisSecuencia { get; set; }

    public virtual DbSet<MapaError> MapaErrors { get; set; }

    public virtual DbSet<MatrizConfigMetaAnual> MatrizConfigMetaAnuals { get; set; }

    public virtual DbSet<MedioPagoPeru> MedioPagoPerus { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<MensajeClasificacion> MensajeClasificacions { get; set; }

    public virtual DbSet<MensajeClasificacionIdioma> MensajeClasificacionIdiomas { get; set; }

    public virtual DbSet<MensajeError> MensajeErrors { get; set; }

    public virtual DbSet<MensajeIdioma> MensajeIdiomas { get; set; }

    public virtual DbSet<Mese> Meses { get; set; }

    public virtual DbSet<MetaIndicador> MetaIndicadors { get; set; }

    public virtual DbSet<MetaTiempo> MetaTiempos { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<ModeloIum> ModeloIa { get; set; }

    public virtual DbSet<MonedaMonedum> MonedaMoneda { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<MttoUnidad> MttoUnidads { get; set; }

    public virtual DbSet<MttoUnidadDetalle> MttoUnidadDetalles { get; set; }

    public virtual DbSet<MttoUnidadEstatus> MttoUnidadEstatuses { get; set; }

    public virtual DbSet<MttoUnidadEstatusIdioma> MttoUnidadEstatusIdiomas { get; set; }

    public virtual DbSet<MttoUnidadTipoActividad> MttoUnidadTipoActividads { get; set; }

    public virtual DbSet<MttoUnidadTipoActividadIdioma> MttoUnidadTipoActividadIdiomas { get; set; }

    public virtual DbSet<MttoUnidadTipoMtto> MttoUnidadTipoMttos { get; set; }

    public virtual DbSet<MttoUnidadTipoMttoIdioma> MttoUnidadTipoMttoIdiomas { get; set; }

    public virtual DbSet<NominaTipo> NominaTipos { get; set; }

    public virtual DbSet<NotaCargo> NotaCargos { get; set; }

    public virtual DbSet<NotaCargoAdendum> NotaCargoAdenda { get; set; }

    public virtual DbSet<NotaCargoCfdiRelacion> NotaCargoCfdiRelacions { get; set; }

    public virtual DbSet<NotaCargoDetalle> NotaCargoDetalles { get; set; }

    public virtual DbSet<NotaCargoEstatus> NotaCargoEstatuses { get; set; }

    public virtual DbSet<NotaCargoEstatusIdioma> NotaCargoEstatusIdiomas { get; set; }

    public virtual DbSet<NotaCargoTipoPeru> NotaCargoTipoPerus { get; set; }

    public virtual DbSet<NotaCredito> NotaCreditos { get; set; }

    public virtual DbSet<NotaCreditoAdendum> NotaCreditoAdenda { get; set; }

    public virtual DbSet<NotaCreditoCfdiRelacion> NotaCreditoCfdiRelacions { get; set; }

    public virtual DbSet<NotaCreditoCuotasPeru> NotaCreditoCuotasPerus { get; set; }

    public virtual DbSet<NotaCreditoDetalle> NotaCreditoDetalles { get; set; }

    public virtual DbSet<NotaCreditoEstatus> NotaCreditoEstatuses { get; set; }

    public virtual DbSet<NotaCreditoEstatusIdioma> NotaCreditoEstatusIdiomas { get; set; }

    public virtual DbSet<NotaCreditoTipo> NotaCreditoTipos { get; set; }

    public virtual DbSet<NotaCreditoTipoPeru> NotaCreditoTipoPerus { get; set; }

    public virtual DbSet<NumUnidade> NumUnidades { get; set; }

    public virtual DbSet<Objetivo> Objetivos { get; set; }

    public virtual DbSet<ObjetoImpuesto> ObjetoImpuestos { get; set; }

    public virtual DbSet<ObjetoImpuestoIdioma> ObjetoImpuestoIdiomas { get; set; }

    public virtual DbSet<OrdenCompraViaje> OrdenCompraViajes { get; set; }

    public virtual DbSet<PagoEstado> PagoEstados { get; set; }

    public virtual DbSet<PagoPaise> PagoPaises { get; set; }

    public virtual DbSet<PagosCliente> PagosClientes { get; set; }

    public virtual DbSet<PagosCorte> PagosCortes { get; set; }

    public virtual DbSet<PagosEmpresa> PagosEmpresas { get; set; }

    public virtual DbSet<PagosEstado> PagosEstados { get; set; }

    public virtual DbSet<PagosFpago> PagosFpagos { get; set; }

    public virtual DbSet<PagosFpagosRegla> PagosFpagosReglas { get; set; }

    public virtual DbSet<PagosGrupo> PagosGrupos { get; set; }

    public virtual DbSet<PagosListimbrado> PagosListimbrados { get; set; }

    public virtual DbSet<PagosPago> PagosPagos { get; set; }

    public virtual DbSet<PagosPaise> PagosPaises { get; set; }

    public virtual DbSet<PagosPartida> PagosPartidas { get; set; }

    public virtual DbSet<PagosPromotore> PagosPromotores { get; set; }

    public virtual DbSet<PagosReferenciacontacto> PagosReferenciacontactos { get; set; }

    public virtual DbSet<PagosRegla> PagosReglas { get; set; }

    public virtual DbSet<PagosServicio> PagosServicios { get; set; }

    public virtual DbSet<PagosServiciosComisione> PagosServiciosComisiones { get; set; }

    public virtual DbSet<PagosServicioscontratado> PagosServicioscontratados { get; set; }

    public virtual DbSet<PagosTimbrado> PagosTimbrados { get; set; }

    public virtual DbSet<PagosTimbreslistmsli> PagosTimbreslistmslis { get; set; }

    public virtual DbSet<PagosTimbreszamli> PagosTimbreszamlis { get; set; }

    public virtual DbSet<PagosUsuario> PagosUsuarios { get; set; }

    public virtual DbSet<PagosUsuariosGrupo> PagosUsuariosGrupos { get; set; }

    public virtual DbSet<PagosZamlicencia> PagosZamlicencias { get; set; }

    public virtual DbSet<PagosZamtimbrado> PagosZamtimbrados { get; set; }

    public virtual DbSet<PagosZona> PagosZonas { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Periodicidad> Periodicidads { get; set; }

    public virtual DbSet<PermisionarioTarifa> PermisionarioTarifas { get; set; }

    public virtual DbSet<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracions { get; set; }

    public virtual DbSet<PermisionarioTarifaRutum> PermisionarioTarifaRuta { get; set; }

    public virtual DbSet<PermisionarioTarifaTipo> PermisionarioTarifaTipos { get; set; }

    public virtual DbSet<PermisionarioTarifaTipoIdioma> PermisionarioTarifaTipoIdiomas { get; set; }

    public virtual DbSet<PermisionarioTipoConcepto> PermisionarioTipoConceptos { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<PersonalCatRiesgo> PersonalCatRiesgos { get; set; }

    public virtual DbSet<PersonalCategorium> PersonalCategoria { get; set; }

    public virtual DbSet<PersonalEstatus> PersonalEstatuses { get; set; }

    public virtual DbSet<PersonalEstatusIdioma> PersonalEstatusIdiomas { get; set; }

    public virtual DbSet<PersonalJornadum> PersonalJornada { get; set; }

    public virtual DbSet<PersonalOperador> PersonalOperadors { get; set; }

    public virtual DbSet<PersonalPeriodicidad> PersonalPeriodicidads { get; set; }

    public virtual DbSet<PersonalRegiman> PersonalRegimen { get; set; }

    public virtual DbSet<PersonalTipoContrato> PersonalTipoContratos { get; set; }

    public virtual DbSet<PersonalTipoEmpleado> PersonalTipoEmpleados { get; set; }

    public virtual DbSet<PersonalTipoPersona> PersonalTipoPersonas { get; set; }

    public virtual DbSet<PeticionIum> PeticionIa { get; set; }

    public virtual DbSet<Plaza> Plazas { get; set; }

    public virtual DbSet<PreguntaFrecuente> PreguntaFrecuentes { get; set; }

    public virtual DbSet<PreguntaVentana> PreguntaVentanas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoDocumentoAduanero> ProductoDocumentoAduaneros { get; set; }

    public virtual DbSet<ProductoTipoMaterium> ProductoTipoMateria { get; set; }

    public virtual DbSet<Profiling> Profilings { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ProveedorCombustible> ProveedorCombustibles { get; set; }

    public virtual DbSet<ProveedorRol> ProveedorRols { get; set; }

    public virtual DbSet<ProveedorRolIdioma> ProveedorRolIdiomas { get; set; }

    public virtual DbSet<RegimenAduaneroGuium> RegimenAduaneroGuia { get; set; }

    public virtual DbSet<ReglasEliminacionImpresion> ReglasEliminacionImpresions { get; set; }

    public virtual DbSet<RelacionTipo> RelacionTipos { get; set; }

    public virtual DbSet<Relacionllaveprimarium> Relacionllaveprimaria { get; set; }

    public virtual DbSet<RoutechEstatus> RoutechEstatuses { get; set; }

    public virtual DbSet<SeguridadAyudaIdioma> SeguridadAyudaIdiomas { get; set; }

    public virtual DbSet<SeguridadAyudum> SeguridadAyuda { get; set; }

    public virtual DbSet<SeguridadGrupo> SeguridadGrupos { get; set; }

    public virtual DbSet<SeguridadGrupoIdioma> SeguridadGrupoIdiomas { get; set; }

    public virtual DbSet<SeguridadMenu> SeguridadMenus { get; set; }

    public virtual DbSet<SeguridadMenuAyudum> SeguridadMenuAyuda { get; set; }

    public virtual DbSet<SeguridadMenuIdioma> SeguridadMenuIdiomas { get; set; }

    public virtual DbSet<SerieCargo> SerieCargos { get; set; }

    public virtual DbSet<SerieControlaFolio> SerieControlaFolios { get; set; }

    public virtual DbSet<SerieControlaFolioIdioma> SerieControlaFolioIdiomas { get; set; }

    public virtual DbSet<SerieCredito> SerieCreditos { get; set; }

    public virtual DbSet<SerieGuium> SerieGuia { get; set; }

    public virtual DbSet<SerieTipo> SerieTipos { get; set; }

    public virtual DbSet<SerieTipoIdioma> SerieTipoIdiomas { get; set; }

    public virtual DbSet<Sesion> Sesions { get; set; }

    public virtual DbSet<SesionUsuario> SesionUsuarios { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<Sugerencia> Sugerencias { get; set; }

    public virtual DbSet<SugerenciaEstatus> SugerenciaEstatuses { get; set; }

    public virtual DbSet<SugerenciaEstatusIdioma> SugerenciaEstatusIdiomas { get; set; }

    public virtual DbSet<TasaCuotum> TasaCuota { get; set; }

    public virtual DbSet<TipoCarga> TipoCargas { get; set; }

    public virtual DbSet<TipoConceptoContable> TipoConceptoContables { get; set; }

    public virtual DbSet<TipoContribuyente> TipoContribuyentes { get; set; }

    public virtual DbSet<TipoExportacion> TipoExportacions { get; set; }

    public virtual DbSet<TipoExportacionIdioma> TipoExportacionIdiomas { get; set; }

    public virtual DbSet<TipoMonedum> TipoMoneda { get; set; }

    public virtual DbSet<TipoOperacionPeru> TipoOperacionPerus { get; set; }

    public virtual DbSet<TipoRelacion> TipoRelacions { get; set; }

    public virtual DbSet<TipoRelacionIdioma> TipoRelacionIdiomas { get; set; }

    public virtual DbSet<TiposDocumento> TiposDocumentos { get; set; }

    public virtual DbSet<TiposDocumentoIdioma> TiposDocumentoIdiomas { get; set; }

    public virtual DbSet<Tooltip> Tooltips { get; set; }

    public virtual DbSet<TooltipIdioma> TooltipIdiomas { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<UnidadAsignacion> UnidadAsignacions { get; set; }

    public virtual DbSet<UnidadClave> UnidadClaves { get; set; }

    public virtual DbSet<UnidadFianza> UnidadFianzas { get; set; }

    public virtual DbSet<UnidadLinea> UnidadLineas { get; set; }

    public virtual DbSet<UnidadMarca> UnidadMarcas { get; set; }

    public virtual DbSet<UnidadMedidaClase> UnidadMedidaClases { get; set; }

    public virtual DbSet<UnidadMedidaClasificacion> UnidadMedidaClasificacions { get; set; }

    public virtual DbSet<UnidadMedidaIdioma> UnidadMedidaIdiomas { get; set; }

    public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; }

    public virtual DbSet<UnidadMotriz> UnidadMotrizs { get; set; }

    public virtual DbSet<UnidadMtto> UnidadMttos { get; set; }

    public virtual DbSet<UnidadPosicione> UnidadPosiciones { get; set; }

    public virtual DbSet<UnidadPosicionesHistorial> UnidadPosicionesHistorials { get; set; }

    public virtual DbSet<UnidadSeguimiento> UnidadSeguimientos { get; set; }

    public virtual DbSet<UnidadSeguimientoEstatus> UnidadSeguimientoEstatuses { get; set; }

    public virtual DbSet<UnidadTipo> UnidadTipos { get; set; }

    public virtual DbSet<UnidadTipoRol> UnidadTipoRols { get; set; }

    public virtual DbSet<UnidadTipoRolIdioma> UnidadTipoRolIdiomas { get; set; }

    public virtual DbSet<UsoCfdi> UsoCfdis { get; set; }

    public virtual DbSet<UsoCfdiRegimenFiscal> UsoCfdiRegimenFiscals { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioConfiguracion> UsuarioConfiguracions { get; set; }

    public virtual DbSet<VCostoIum> VCostoIa { get; set; }

    public virtual DbSet<VEmpresa> VEmpresas { get; set; }

    public virtual DbSet<VEmpresasPerdido> VEmpresasPerdidos { get; set; }

    public virtual DbSet<VEstadocuentum> VEstadocuenta { get; set; }

    public virtual DbSet<VEstadocuentum1> VEstadocuenta1 { get; set; }

    public virtual DbSet<VGasto> VGastos { get; set; }

    public virtual DbSet<VGastoLiq> VGastoLiqs { get; set; }

    public virtual DbSet<VGastosAnalitica> VGastosAnaliticas { get; set; }

    public virtual DbSet<VSesionUsuario> VSesionUsuarios { get; set; }

    public virtual DbSet<Ventana> Ventanas { get; set; }

    public virtual DbSet<Viaje> Viajes { get; set; }

    public virtual DbSet<ViajeEstatus> ViajeEstatuses { get; set; }

    public virtual DbSet<ViajeEstatusIdioma> ViajeEstatusIdiomas { get; set; }

    public virtual DbSet<ViajeProgramado> ViajeProgramados { get; set; }

    public virtual DbSet<ViajeRutaRoutech> ViajeRutaRouteches { get; set; }

    public virtual DbSet<ViajeRutaTipo> ViajeRutaTipos { get; set; }

    public virtual DbSet<ViajeRutum> ViajeRuta { get; set; }

    public virtual DbSet<ViajeSeguimientoControl> ViajeSeguimientoControls { get; set; }

    public virtual DbSet<ViajeSeguimientoEstatus> ViajeSeguimientoEstatuses { get; set; }

    public virtual DbSet<ViajeTipo> ViajeTipos { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    public virtual DbSet<VideoClasificacion> VideoClasificacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:ListmsSQLServerDatabase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aduana>(entity =>
        {
            entity.HasKey(e => e.IdAduana).HasName("PK_aduana_id_aduana");

            entity.ToTable("aduana");

            entity.HasIndex(e => e.Clave, "UQ_aduana_clave").IsUnique();

            entity.Property(e => e.IdAduana)
                .ValueGeneratedNever()
                .HasColumnName("id_aduana");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Alarma>(entity =>
        {
            entity.HasKey(e => e.IdAlarma);

            entity.ToTable("alarma");

            entity.Property(e => e.IdAlarma)
                .ValueGeneratedNever()
                .HasColumnName("id_alarma");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaSiguiente)
                .HasColumnType("datetime")
                .HasColumnName("fecha_siguiente");
            entity.Property(e => e.Filtro1).HasColumnName("filtro1");
            entity.Property(e => e.Filtro2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("filtro2");
            entity.Property(e => e.Filtro3)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("filtro3");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFrecuencia).HasColumnName("id_frecuencia");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdPuesto).HasColumnName("id_puesto");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.RepetirCada).HasColumnName("repetir_cada");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_08");

            entity.HasOne(d => d.Filtro1Navigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.Filtro1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_09");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_05");

            entity.HasOne(d => d.IdFrecuenciaNavigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.IdFrecuencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_02");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.AlarmaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_06");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.AlarmaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_07");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_03");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.IdPuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_04");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Alarmas)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_01");
        });

        modelBuilder.Entity<AlarmaFrecuenciaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdFrecuencia, e.IdIdioma });

            entity.ToTable("alarma_frecuencia_idioma");

            entity.Property(e => e.IdFrecuencia).HasColumnName("id_frecuencia");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdFrecuenciaNavigation).WithMany(p => p.AlarmaFrecuenciaIdiomas)
                .HasForeignKey(d => d.IdFrecuencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_frecuencia_idioma_01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.AlarmaFrecuenciaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_frecuencia_idioma_02");
        });

        modelBuilder.Entity<AlarmaFrecuencium>(entity =>
        {
            entity.HasKey(e => e.IdFrecuencia);

            entity.ToTable("alarma_frecuencia");

            entity.Property(e => e.IdFrecuencia)
                .ValueGeneratedNever()
                .HasColumnName("id_frecuencia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<AlarmaLog>(entity =>
        {
            entity.HasKey(e => e.IdAlarma);

            entity.ToTable("alarma_log");

            entity.Property(e => e.IdAlarma)
                .ValueGeneratedNever()
                .HasColumnName("id_alarma");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mensaje");

            entity.HasOne(d => d.IdAlarmaNavigation).WithOne(p => p.AlarmaLog)
                .HasForeignKey<AlarmaLog>(d => d.IdAlarma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_log01");
        });

        modelBuilder.Entity<AlarmaTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("alarma_tipo");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.AlarmaTipos)
                .HasForeignKey(d => d.Estatus)
                .HasConstraintName("FK_alarma_tipo_01");
        });

        modelBuilder.Entity<AlarmaTipoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipo, e.IdIdioma });

            entity.ToTable("alarma_tipo_idioma");

            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.AlarmaTipoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_tipo_idioma_02");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.AlarmaTipoIdiomas)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarma_tipo_idioma_01");
        });

        modelBuilder.Entity<Anticipo>(entity =>
        {
            entity.HasKey(e => e.IdAnticipo);

            entity.ToTable("anticipo");

            entity.HasIndex(e => e.IdViaje, "IX_anticipo_id_viaje");

            entity.Property(e => e.IdAnticipo)
                .ValueGeneratedNever()
                .HasColumnName("id_anticipo");
            entity.Property(e => e.AnticipoEnviadoRoutech)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("anticipo_enviado_routech");
            entity.Property(e => e.FechaAnticipo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_anticipo");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FolioDocumentoGastoClickb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_documento_gasto_clickb");
            entity.Property(e => e.IdAsociadoDeudorClickb).HasColumnName("id_asociado_deudor_clickb");
            entity.Property(e => e.IdCentroCostoClickb).HasColumnName("id_centro_costo_clickb");
            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.IdDocumentoGastoClickb).HasColumnName("id_documento_gasto_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdFormaPagoClickb).HasColumnName("id_forma_pago_clickb");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdPersonal).HasColumnName("id_personal");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipoGastoClickb).HasColumnName("id_tipo_gasto_clickb");
            entity.Property(e => e.IdUsuarioPago).HasColumnName("id_usuario_pago");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.MontoAnticipo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_anticipo");
            entity.Property(e => e.NumAnticipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("num_anticipo");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdConvenio)
                .HasConstraintName("FK_anticipo10");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo02");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.AnticipoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo06");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.AnticipoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo07");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo03");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo04");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo09");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo05");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo08");
        });

        modelBuilder.Entity<AnticipoConcepto>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.ToTable("anticipo_concepto");

            entity.Property(e => e.IdConcepto)
                .ValueGeneratedNever()
                .HasColumnName("id_concepto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.AnticipoConceptos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_concepto02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.AnticipoConceptos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_concepto01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.AnticipoConceptoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_concepto03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.AnticipoConceptoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_concepto04");
        });

        modelBuilder.Entity<AnticipoDesglose>(entity =>
        {
            entity.HasKey(e => new { e.IdAnticipo, e.IdConcepto });

            entity.ToTable("anticipo_desglose");

            entity.Property(e => e.IdAnticipo).HasColumnName("id_anticipo");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdAnticipoNavigation).WithMany(p => p.AnticipoDesgloses)
                .HasForeignKey(d => d.IdAnticipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_desglose01");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.AnticipoDesgloses)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_desglose02");
        });

        modelBuilder.Entity<AnticipoEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("anticipo_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<AnticipoEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("anticipo_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.AnticipoEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.AnticipoEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_anticipo_estatus_idioma02");
        });

        modelBuilder.Entity<ApiKeyIum>(entity =>
        {
            entity.HasKey(e => e.IdApiKey).HasName("pk_api_key_ia");

            entity.ToTable("api_key_ia");

            entity.HasIndex(e => e.Key, "unq_api_key_ia").IsUnique();

            entity.Property(e => e.IdApiKey)
                .ValueGeneratedNever()
                .HasColumnName("id_api_key");
            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("key");
            entity.Property(e => e.Servicio)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("servicio");
        });

        modelBuilder.Entity<Archivo>(entity =>
        {
            entity.HasKey(e => e.IdArchivo).HasName("pk_archivo");

            entity.ToTable("archivo");

            entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");
            entity.Property(e => e.Bytes).HasColumnName("bytes");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Ruta)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("ruta");
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Archivos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_archivo_empresa");
        });

        modelBuilder.Entity<Arrendatario>(entity =>
        {
            entity.HasKey(e => e.IdArrendatario).HasName("PK_arrendatarios_id_arrendatario");

            entity.ToTable("arrendatarios");

            entity.Property(e => e.IdArrendatario)
                .ValueGeneratedNever()
                .HasColumnName("id_arrendatario");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Correo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_contacto");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.Numregidtrib)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numregidtrib");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Aviso>(entity =>
        {
            entity.HasKey(e => e.IdAviso);

            entity.ToTable("aviso");

            entity.Property(e => e.IdAviso)
                .ValueGeneratedNever()
                .HasColumnName("id_aviso");
            entity.Property(e => e.Asunto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaVigencia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vigencia");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");
            entity.Property(e => e.Link)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("link");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("mensaje");

            entity.HasOne(d => d.IdRemitenteNavigation).WithMany(p => p.Avisos)
                .HasForeignKey(d => d.IdRemitente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_aviso01");
        });

        modelBuilder.Entity<AvisoDestinatario>(entity =>
        {
            entity.HasKey(e => new { e.IdAviso, e.IdUsuario });

            entity.ToTable("aviso_destinatario");

            entity.Property(e => e.IdAviso).HasColumnName("id_aviso");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<AyudaMenu>(entity =>
        {
            entity.HasKey(e => new { e.IdAyuda, e.IdMenu });

            entity.ToTable("ayuda_menu");

            entity.Property(e => e.IdAyuda).HasColumnName("id_ayuda");
            entity.Property(e => e.IdMenu).HasColumnName("id_menu");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.AyudaMenus)
                .HasForeignKey(d => d.IdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ayuda_menu01");
        });

        modelBuilder.Entity<Ayudum>(entity =>
        {
            entity.HasKey(e => new { e.IdAyuda, e.IdIdioma });

            entity.ToTable("ayuda");

            entity.Property(e => e.IdAyuda).HasColumnName("id_ayuda");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.RutaArchivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ruta_archivo");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.Ayuda)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ayuda__id_idioma__729BEF18");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.IdBanco);

            entity.ToTable("banco");

            entity.Property(e => e.IdBanco)
                .ValueGeneratedNever()
                .HasColumnName("id_banco");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdBancosat).HasColumnName("id_bancosat");
            entity.Property(e => e.IdCuentaClickb).HasColumnName("id_cuenta_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFormaPagoClickb).HasColumnName("id_forma_pago_clickb");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdTipoCobroClickb).HasColumnName("id_tipo_cobro_clickb");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.InstitucionBancaria)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("institucion_bancaria");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("no_cuenta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.SaldoInicial)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("saldo_inicial");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Bancos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Bancos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.BancoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.BancoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco02");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.Bancos)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco05");
        });

        modelBuilder.Entity<BancoBancosat>(entity =>
        {
            entity.HasKey(e => e.IdBancosat);

            entity.ToTable("banco_bancosat");

            entity.Property(e => e.IdBancosat).HasColumnName("id_bancosat");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdBancoPais).HasColumnName("id_banco_pais");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("razon_social");
            entity.Property(e => e.RfcBanco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("rfc_banco");
        });

        modelBuilder.Entity<BancoConcepto>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.ToTable("banco_concepto");

            entity.Property(e => e.IdConcepto)
                .ValueGeneratedNever()
                .HasColumnName("id_concepto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DesglosaIva)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("desglosa_iva");
            entity.Property(e => e.DesglosaRetencion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("desglosa_retencion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdConceptoPadre).HasColumnName("id_concepto_padre");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdTipoReferencia).HasColumnName("id_tipo_referencia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.ReporteImpuestos).HasColumnName("reporte_impuestos");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoConceptos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BancoConceptos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto01");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.BancoConceptos)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto05");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.BancoConceptoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.BancoConceptoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto04");

            entity.HasOne(d => d.IdTipoReferenciaNavigation).WithMany(p => p.BancoConceptos)
                .HasForeignKey(d => d.IdTipoReferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto06");
        });

        modelBuilder.Entity<BancoConceptoClasificacion>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion);

            entity.ToTable("banco_concepto_clasificacion");

            entity.Property(e => e.IdClasificacion)
                .ValueGeneratedNever()
                .HasColumnName("id_clasificacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoConceptoClasificacionIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdClasificacion, e.IdIdioma });

            entity.ToTable("banco_concepto_clasificacion_idioma");

            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.BancoConceptoClasificacionIdiomas)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cbanco_concepto_clasificacion_idioma_01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoConceptoClasificacionIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_clasificacion_idioma_02");
        });

        modelBuilder.Entity<BancoConceptoGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.ToTable("banco_concepto_grupo");

            entity.Property(e => e.IdGrupo)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdNaturaleza).HasColumnName("id_naturaleza");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoConceptoGrupos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_grupo05");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BancoConceptoGrupos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_grupo02");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.BancoConceptoGrupoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_grupo04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.BancoConceptoGrupoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_grupo03");

            entity.HasOne(d => d.IdNaturalezaNavigation).WithMany(p => p.BancoConceptoGrupos)
                .HasForeignKey(d => d.IdNaturaleza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_grupo01");
        });

        modelBuilder.Entity<BancoConceptoNaturaleza>(entity =>
        {
            entity.HasKey(e => e.IdNaturaleza);

            entity.ToTable("banco_concepto_naturaleza");

            entity.Property(e => e.IdNaturaleza)
                .ValueGeneratedNever()
                .HasColumnName("id_naturaleza");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoConceptoNaturalezaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdNaturaleza, e.IdIdioma });

            entity.ToTable("banco_concepto_naturaleza_idioma");

            entity.Property(e => e.IdNaturaleza).HasColumnName("id_naturaleza");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoConceptoNaturalezaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_naturaleza_idioma01");

            entity.HasOne(d => d.IdNaturalezaNavigation).WithMany(p => p.BancoConceptoNaturalezaIdiomas)
                .HasForeignKey(d => d.IdNaturaleza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_naturaleza_idioma02");
        });

        modelBuilder.Entity<BancoConceptoTipoReferenciaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoReferencia, e.IdIdioma });

            entity.ToTable("banco_concepto_tipo_referencia_idioma");

            entity.Property(e => e.IdTipoReferencia).HasColumnName("id_tipo_referencia");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoConceptoTipoReferenciaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_tipo_referencia_idioma02");

            entity.HasOne(d => d.IdTipoReferenciaNavigation).WithMany(p => p.BancoConceptoTipoReferenciaIdiomas)
                .HasForeignKey(d => d.IdTipoReferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_concepto_tipo_referencia_idioma01");
        });

        modelBuilder.Entity<BancoConceptoTipoReferencium>(entity =>
        {
            entity.HasKey(e => e.IdTipoReferencia);

            entity.ToTable("banco_concepto_tipo_referencia");

            entity.Property(e => e.IdTipoReferencia)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_referencia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoMovimiento>(entity =>
        {
            entity.HasKey(e => e.IdMovimiento);

            entity.ToTable("banco_movimiento");

            entity.Property(e => e.IdMovimiento)
                .ValueGeneratedNever()
                .HasColumnName("id_movimiento");
            entity.Property(e => e.Conciliado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("conciliado");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaDoc)
                .HasColumnType("datetime")
                .HasColumnName("fecha_doc");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FolioClickb).HasColumnName("folio_clickb");
            entity.Property(e => e.FolioFiscal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("folio_fiscal");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdClienteFacturaje).HasColumnName("id_cliente_facturaje");
            entity.Property(e => e.IdCuentaCliente).HasColumnName("id_cuenta_cliente");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdDocumentoClickb).HasColumnName("id_documento_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdMovimientoPadre).HasColumnName("id_movimiento_padre");
            entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIeps)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_ieps");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.NumMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_movimiento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.RetencionIsr)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("retencion_isr");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento10");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento06");

            entity.HasOne(d => d.IdClienteFacturajeNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdClienteFacturaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_id_cliente_facturaje");

            entity.HasOne(d => d.IdCuentaClienteNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdCuentaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_id_cuenta_cliente");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento11");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento01");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_id_guia");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.BancoMovimientoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.BancoMovimientoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento03");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento05");

            entity.HasOne(d => d.IdPeriodoNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento08");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento09");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento04");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdSolicitud)
                .HasConstraintName("fk_banco_movimiento_solicitud");

            entity.HasOne(d => d.IdTipoDocNavigation).WithMany(p => p.BancoMovimientos)
                .HasForeignKey(d => d.IdTipoDoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento07");
        });

        modelBuilder.Entity<BancoMovimientoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdMovimiento, e.Consecutivo });

            entity.ToTable("banco_movimiento_detalle");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.DesglosaIva)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("desglosa_iva");
            entity.Property(e => e.DesglosaRetencion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("desglosa_retencion");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdRetencion)
                .HasDefaultValueSql("((0))")
                .HasColumnName("id_retencion");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIva)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoTotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto_total");
            entity.Property(e => e.ReferenciaDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia_documento");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.BancoMovimientoDetalles)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_detalle02");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.BancoMovimientoDetalles)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_detalle01");

            entity.HasOne(d => d.IdMovimientoNavigation).WithMany(p => p.BancoMovimientoDetalles)
                .HasForeignKey(d => d.IdMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_detalle03");
        });

        modelBuilder.Entity<BancoMovimientoDetalleDocumento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.ToTable("banco_movimiento_detalle_documento");

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoMovimientoEstatus>(entity =>
        {
            entity.HasKey(e => e.Estatus);

            entity.ToTable("banco_movimiento_estatus");

            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<BancoMovimientoEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.Estatus, e.IdIdioma });

            entity.ToTable("banco_movimiento_estatus_idioma");

            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoMovimientoEstatusIdiomas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_estatus_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoMovimientoEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_estatus_idioma01");
        });

        modelBuilder.Entity<BancoMovimientoRol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("banco_movimiento_rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("id_rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoMovimientoRols)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_rol01");
        });

        modelBuilder.Entity<BancoMovimientoRolIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdRol, e.IdIdioma });

            entity.ToTable("banco_movimiento_rol_idioma");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoMovimientoRolIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_rol_idioma01");
        });

        modelBuilder.Entity<BancoMovimientoTipoReferenciaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoDoc, e.IdIdioma });

            entity.ToTable("banco_movimiento_tipo_referencia_idioma");

            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TituloReferencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("titulo_referencia");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoMovimientoTipoReferenciaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_tipo_referencia_idioma01");

            entity.HasOne(d => d.IdTipoDocNavigation).WithMany(p => p.BancoMovimientoTipoReferenciaIdiomas)
                .HasForeignKey(d => d.IdTipoDoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_movimiento_tipo_referencia_idioma02");
        });

        modelBuilder.Entity<BancoMovimientoTipoReferencium>(entity =>
        {
            entity.HasKey(e => e.IdTipoDoc);

            entity.ToTable("banco_movimiento_tipo_referencia");

            entity.Property(e => e.IdTipoDoc)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_doc");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdPeriodo);

            entity.ToTable("banco_periodo");

            entity.Property(e => e.IdPeriodo)
                .ValueGeneratedNever()
                .HasColumnName("id_periodo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.MontoPeriodo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_periodo");
            entity.Property(e => e.Periodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("periodo");
            entity.Property(e => e.SaldoFinal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("saldo_final");
            entity.Property(e => e.SaldoInicial)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("saldo_inicial");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoPeriodos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_periodo01");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.BancoPeriodos)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_periodo02");
        });

        modelBuilder.Entity<BancoRol>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("banco_rol");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoRolIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipo, e.IdIdioma });

            entity.ToTable("banco_rol_idioma");

            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BancoSolicitud>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud);

            entity.ToTable("banco_solicitud");

            entity.Property(e => e.IdSolicitud)
                .ValueGeneratedNever()
                .HasColumnName("id_solicitud");
            entity.Property(e => e.CantidadRepeticiones).HasColumnName("cantidad_repeticiones");
            entity.Property(e => e.Estado)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("estado");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FactorIeps)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("factor_ieps");
            entity.Property(e => e.FactorIsr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("factor_isr");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaLimiteEjecucion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_limite_ejecucion");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaSiguienteRepeticion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_siguiente_repeticion");
            entity.Property(e => e.Finaliza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("finaliza");
            entity.Property(e => e.FolioFiscal)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("folio_fiscal");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFrecuencia).HasColumnName("id_frecuencia");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdSucursal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipoDoc).HasColumnName("id_tipo_doc");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIeps)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_ieps");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.NumSolicitud).HasColumnName("num_solicitud");
            entity.Property(e => e.PornumVeces)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pornum_veces");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.RepetirCada).HasColumnName("repetir_cada");
            entity.Property(e => e.RetencionIsr)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("retencion_isr");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");
            entity.Property(e => e.UltimoRealizado)
                .HasColumnType("datetime")
                .HasColumnName("ultimo_realizado");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud09");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud04");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud10");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud11");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud01");

            entity.HasOne(d => d.IdFrecuenciaNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdFrecuencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud07");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.BancoSolicitudIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.BancoSolicitudIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud05");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud02");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud08");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud12");

            entity.HasOne(d => d.IdTipoDocNavigation).WithMany(p => p.BancoSolicituds)
                .HasForeignKey(d => d.IdTipoDoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud06");
        });

        modelBuilder.Entity<BancoSolicitudEstatus>(entity =>
        {
            entity.HasKey(e => e.Estatus);

            entity.ToTable("banco_solicitud_estatus");

            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<BancoSolicitudEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.Estatus, e.IdIdioma });

            entity.ToTable("banco_solicitud_estatus_idioma");

            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.BancoSolicitudEstatusIdiomas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud_estatus_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoSolicitudEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud_estatus_idioma01");
        });

        modelBuilder.Entity<BancoSolicitudFrecuenciaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdFrecuencia, e.IdIdioma });

            entity.ToTable("banco_solicitud_frecuencia_idioma");

            entity.Property(e => e.IdFrecuencia).HasColumnName("id_frecuencia");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdFrecuenciaNavigation).WithMany(p => p.BancoSolicitudFrecuenciaIdiomas)
                .HasForeignKey(d => d.IdFrecuencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud_frecuencia_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.BancoSolicitudFrecuenciaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud_frecuencia_idioma01");
        });

        modelBuilder.Entity<BancoSolicitudFrecuencium>(entity =>
        {
            entity.HasKey(e => e.IdFrecuencia);

            entity.ToTable("banco_solicitud_frecuencia");

            entity.Property(e => e.IdFrecuencia)
                .ValueGeneratedNever()
                .HasColumnName("id_frecuencia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<BancoSolicitudProyeccion>(entity =>
        {
            entity.HasKey(e => new { e.IdSolicitud, e.IdConsecutivo });

            entity.ToTable("banco_solicitud_proyeccion");

            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdConsecutivo).HasColumnName("id_consecutivo");
            entity.Property(e => e.FechaDoc)
                .HasColumnType("datetime")
                .HasColumnName("fecha_doc");
        });

        modelBuilder.Entity<BancoSolicitudRelacion>(entity =>
        {
            entity.HasKey(e => new { e.IdSolicitud, e.IdMovimiento });

            entity.ToTable("banco_solicitud_relacion");

            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");

            entity.HasOne(d => d.IdMovimientoNavigation).WithMany(p => p.BancoSolicitudRelacions)
                .HasForeignKey(d => d.IdMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud_relacion01");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.BancoSolicitudRelacions)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_solicitud_relacion02");
        });

        modelBuilder.Entity<BancoSolicitudViaje>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("banco_solicitud_viaje");

            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany()
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Banco_Solicitud");

            entity.HasOne(d => d.IdViajeNavigation).WithMany()
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Viaje");
        });

        modelBuilder.Entity<Botone>(entity =>
        {
            entity.HasKey(e => e.IdBoton);

            entity.ToTable("botones");

            entity.Property(e => e.IdBoton)
                .ValueGeneratedNever()
                .HasColumnName("id_boton");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<BotonesSeguridad>(entity =>
        {
            entity.HasKey(e => new { e.IdMenu, e.IdGrupo, e.IdBoton }).HasName("PK_seguridad_botones");

            entity.ToTable("botones_seguridad");

            entity.Property(e => e.IdMenu).HasColumnName("id_menu");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.IdBoton).HasColumnName("id_boton");

            entity.HasOne(d => d.IdBotonNavigation).WithMany(p => p.BotonesSeguridads)
                .HasForeignKey(d => d.IdBoton)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_botones03");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.BotonesSeguridads)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_botones02");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.BotonesSeguridads)
                .HasForeignKey(d => d.IdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_botones01");
        });

        modelBuilder.Entity<CClaveProdServCp>(entity =>
        {
            entity.HasKey(e => e.IdClaveprodserv).HasName("PK_c_clave_prod_serv_cp_id_claveprodserv");

            entity.ToTable("c_clave_prod_serv_cp");

            entity.HasIndex(e => new { e.Clave, e.IdPais }, "UQ_c_clave_prod_serv_cp_clave_idPais").IsUnique();

            entity.Property(e => e.IdClaveprodserv)
                .ValueGeneratedNever()
                .HasColumnName("id_claveprodserv");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdPais)
                .HasDefaultValueSql("((1))")
                .HasColumnName("idPais");
            entity.Property(e => e.MaterialPeligrosoCps)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("material_peligroso_cps");
        });

        modelBuilder.Entity<CConfigAutotransporte>(entity =>
        {
            entity.HasKey(e => e.IdConfigAutotransporte).HasName("PK_c_config_autotransporte_id_config_autotransporte");

            entity.ToTable("c_config_autotransporte");

            entity.HasIndex(e => e.Clave, "UQ_c_config_autotransporte_clave").IsUnique();

            entity.Property(e => e.IdConfigAutotransporte)
                .ValueGeneratedNever()
                .HasColumnName("id_config_autotransporte");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CFraccionArancelarium>(entity =>
        {
            entity.HasKey(e => e.IdFraccionArancelaria).HasName("PK_c_fraccion_arancelaria_id_fraccion_arancelaria");

            entity.ToTable("c_fraccion_arancelaria");

            entity.HasIndex(e => e.Clave, "UQ_c_fraccion_arancelaria_clave").IsUnique();

            entity.Property(e => e.IdFraccionArancelaria)
                .ValueGeneratedNever()
                .HasColumnName("id_fraccion_arancelaria");
            entity.Property(e => e.Clave)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
        });

        modelBuilder.Entity<CMaterialPeligroso>(entity =>
        {
            entity.HasKey(e => e.IdMaterialPeligroso).HasName("PK_c_material_peligroso_id_material_peligroso");

            entity.ToTable("c_material_peligroso");

            entity.HasIndex(e => e.Clave, "UQ_c_material_peligroso_clave").IsUnique();

            entity.Property(e => e.IdMaterialPeligroso)
                .ValueGeneratedNever()
                .HasColumnName("id_material_peligroso");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CMotivoCancelacionSat>(entity =>
        {
            entity.HasKey(e => e.IdMotivoCancelacion).HasName("PK_c_motivo_cancelacion_sat_id_motivo_cancelacion");

            entity.ToTable("c_motivo_cancelacion_sat");

            entity.HasIndex(e => e.Clave, "UQ_c_motivo_cancelacion_sat_clave").IsUnique();

            entity.Property(e => e.IdMotivoCancelacion)
                .ValueGeneratedNever()
                .HasColumnName("id_motivo_cancelacion");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CParteTransporte>(entity =>
        {
            entity.HasKey(e => e.IdParteTransporte).HasName("PK_c_parte_transporte_id_parte_transporte");

            entity.ToTable("c_parte_transporte");

            entity.HasIndex(e => e.Clave, "UQ_c_parte_transporte_clave").IsUnique();

            entity.Property(e => e.IdParteTransporte)
                .ValueGeneratedNever()
                .HasColumnName("id_parte_transporte");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CSubTipoRemolque>(entity =>
        {
            entity.HasKey(e => e.IdSubtiporem).HasName("PK_c_sub_tipo_remolque_id_subtiporem");

            entity.ToTable("c_sub_tipo_remolque");

            entity.HasIndex(e => e.Clave, "UQ_c_sub_tipo_remolque_clave").IsUnique();

            entity.Property(e => e.IdSubtiporem)
                .ValueGeneratedNever()
                .HasColumnName("id_subtiporem");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CTipoEmbalaje>(entity =>
        {
            entity.HasKey(e => e.IdTipoembalaje).HasName("PK_c_tipo_embalaje_id_tipoembalaje");

            entity.ToTable("c_tipo_embalaje");

            entity.HasIndex(e => e.Clave, "UQ_c_tipo_embalaje_clave").IsUnique();

            entity.Property(e => e.IdTipoembalaje)
                .ValueGeneratedNever()
                .HasColumnName("id_tipoembalaje");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CTipoPermisoSct>(entity =>
        {
            entity.HasKey(e => e.IdTipopermiso).HasName("PK_c_tipo_permiso_sct_id_tipopermiso");

            entity.ToTable("c_tipo_permiso_sct");

            entity.HasIndex(e => e.Clave, "UQ_c_tipo_permiso_sct_clave").IsUnique();

            entity.Property(e => e.IdTipopermiso)
                .ValueGeneratedNever()
                .HasColumnName("id_tipopermiso");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CUnidadEmbalaje>(entity =>
        {
            entity.HasKey(e => e.IdUnidadembalaje).HasName("PK_c_unidad_embalaje_id_unidadembalaje");

            entity.ToTable("c_unidad_embalaje");

            entity.HasIndex(e => e.Clave, "UQ_c_unidad_embalaje_clave").IsUnique();

            entity.Property(e => e.IdUnidadembalaje)
                .ValueGeneratedNever()
                .HasColumnName("id_unidadembalaje");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<CadenaPago>(entity =>
        {
            entity.HasKey(e => e.IdCadenaPago).HasName("PK_cadena_pago_id_cadena_pago");

            entity.ToTable("cadena_pago");

            entity.HasIndex(e => e.Clave, "UQ_cadena_pago_clave").IsUnique();

            entity.Property(e => e.IdCadenaPago)
                .ValueGeneratedNever()
                .HasColumnName("id_cadena_pago");
            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<ClaveProductoServicio>(entity =>
        {
            entity.HasKey(e => e.IdClaveprodserv).HasName("PK_clave_producto_servicio_id_claveprodserv");

            entity.ToTable("clave_producto_servicio");

            entity.HasIndex(e => e.Clave, "UQ_clave_producto_servicio_clave").IsUnique();

            entity.Property(e => e.IdClaveprodserv)
                .ValueGeneratedNever()
                .HasColumnName("id_claveprodserv");
            entity.Property(e => e.Clave)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("cliente");

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnName("id_cliente");
            entity.Property(e => e.Calle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Correo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("delegacion");
            entity.Property(e => e.DestinoIdSat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("destino_id_sat");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdClienteClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_cliente_clickb");
            entity.Property(e => e.IdDireccionClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_direccion_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdFormaPago)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_forma_pago");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdPlaza).HasColumnName("id_plaza");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdUsoCfdi)
                .HasDefaultValueSql("((22))")
                .HasColumnName("id_usoCFDI");
            entity.Property(e => e.IsAseguradora)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("is_aseguradora");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("no_cuenta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NumCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_cliente");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.Numregidtrib)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("numregidtrib");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(280)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OrigenIdSat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("origen_id_sat");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("regimen_fiscal");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("telefono");
            entity.Property(e => e.TipoContribuyente).HasColumnName("tipo_contribuyente");
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tipo_persona");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente01");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente02");

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente09");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ClienteIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente03");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente08");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ClienteIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente04");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente05");

            entity.HasOne(d => d.IdPlazaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdPlaza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente06");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente07");

            entity.HasOne(d => d.IdUsoCfdiNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdUsoCfdi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente10");
        });

        modelBuilder.Entity<ClienteCobranza>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("cliente_cobranza");

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnName("id_cliente");
            entity.Property(e => e.CalculaVencimiento).HasColumnName("calcula_vencimiento");
            entity.Property(e => e.DiasCredito).HasColumnName("dias_credito");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdSucursalcobro).HasColumnName("id_sucursalcobro");

            entity.HasOne(d => d.IdClienteNavigation).WithOne(p => p.ClienteCobranza)
                .HasForeignKey<ClienteCobranza>(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_cobranza01");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.ClienteCobranzaIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_cobranza03");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.ClienteCobranzaIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_cobranza04");

            entity.HasOne(d => d.IdSucursalcobroNavigation).WithMany(p => p.ClienteCobranzas)
                .HasForeignKey(d => d.IdSucursalcobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_cobranza02");
        });

        modelBuilder.Entity<ClienteContacto>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdContacto });

            entity.ToTable("cliente_contacto");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdContacto).HasColumnName("id_contacto");
            entity.Property(e => e.Apellido1Contacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("apellido1_contacto");
            entity.Property(e => e.Apellido2Contacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("apellido2_contacto");
            entity.Property(e => e.Email1Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email1_contacto");
            entity.Property(e => e.Email2Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email2_contacto");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.MovilContacto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("movil_contacto");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre_contacto");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.PuestoContacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("puesto_contacto");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteContactos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_contacto01");
        });

        modelBuilder.Entity<ClienteMetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago);

            entity.ToTable("cliente_metodo_pago");

            entity.Property(e => e.IdMetodoPago)
                .ValueGeneratedNever()
                .HasColumnName("id_metodo_pago");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.ClienteMetodoPagos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_metodo_pago01");
        });

        modelBuilder.Entity<ClienteMetodoPagoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdMetodoPago, e.IdIdioma });

            entity.ToTable("cliente_metodo_pago_idioma");

            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Clave)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.ClienteMetodoPagoIdiomas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_metodo_pago_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ClienteMetodoPagoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_metodo_pago_idioma01");
        });

        modelBuilder.Entity<ClienteRecEnt>(entity =>
        {
            entity.HasKey(e => e.IdRecEnt).HasName("PK_cliente_rec_ent01");

            entity.ToTable("cliente_rec_ent");

            entity.Property(e => e.IdRecEnt)
                .ValueGeneratedNever()
                .HasColumnName("id_rec_ent");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.ClaveCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("clave_ciudad");
            entity.Property(e => e.ClaveColonia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("clave_colonia");
            entity.Property(e => e.ClaveMunicipio)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("clave_municipio");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DestinoIdSat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("destino_id_sat");
            entity.Property(e => e.DetalleDireccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("detalle_direccion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("longitud");
            entity.Property(e => e.Municipio)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.Numregidtrib)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numregidtrib");
            entity.Property(e => e.OrigenIdSat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("origen_id_sat");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteRecEnts)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vcliente_rec_ent01");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ClienteRecEnts)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vcliente_rec_ent02");
        });

        modelBuilder.Entity<ClienteTipoRol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("cliente_tipo_rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("id_rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ClienteTipoRolIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdRol, e.IdIdioma });

            entity.ToTable("cliente_tipo_rol_idioma");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ClienteTipoRolIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_tipo_rol_idioma02");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.ClienteTipoRolIdiomas)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_tipo_rol_idioma01");
        });

        modelBuilder.Entity<Combustible>(entity =>
        {
            entity.HasKey(e => e.IdCombustible);

            entity.ToTable("combustible");

            entity.Property(e => e.IdCombustible)
                .ValueGeneratedNever()
                .HasColumnName("id_combustible");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Combustibles)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Combustibles)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.CombustibleIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.CombustibleIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible04");
        });

        modelBuilder.Entity<CombustibleEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("combustible_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CombustibleEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("combustible_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.CombustibleEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.CombustibleEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_estatus_idioma02");
        });

        modelBuilder.Entity<CombustibleTarifa>(entity =>
        {
            entity.HasKey(e => e.IdTarifa);

            entity.ToTable("combustible_tarifa");

            entity.Property(e => e.IdTarifa)
                .ValueGeneratedNever()
                .HasColumnName("id_tarifa");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.CombustibleTarifas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_tarifa02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CombustibleTarifas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_tarifa01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.CombustibleTarifaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_tarifa03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.CombustibleTarifaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_tarifa04");
        });

        modelBuilder.Entity<CombustibleTarifaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdTarifa, e.IdCombustible });

            entity.ToTable("combustible_tarifa_detalle");

            entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");
            entity.Property(e => e.IdCombustible).HasColumnName("id_combustible");
            entity.Property(e => e.FactorIeps)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_ieps");
            entity.Property(e => e.MontoTarifa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_tarifa");

            entity.HasOne(d => d.IdCombustibleNavigation).WithMany(p => p.CombustibleTarifaDetalles)
                .HasForeignKey(d => d.IdCombustible)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_tarifa_detalle02");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.CombustibleTarifaDetalles)
                .HasForeignKey(d => d.IdTarifa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_tarifa_detalle01");
        });

        modelBuilder.Entity<CombustibleVale>(entity =>
        {
            entity.HasKey(e => e.IdVale);

            entity.ToTable("combustible_vale");

            entity.HasIndex(e => e.IdViaje, "IX_combustible_vale_id_viaje");

            entity.Property(e => e.IdVale)
                .ValueGeneratedNever()
                .HasColumnName("id_vale");
            entity.Property(e => e.CantidadCombustible)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad_combustible");
            entity.Property(e => e.CantidadCombustibleBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad_combustible_base");
            entity.Property(e => e.FechaCombustible)
                .HasColumnType("datetime")
                .HasColumnName("fecha_combustible");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FolioDocumentoGastoClickb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_documento_gasto_clickb");
            entity.Property(e => e.IdAsociadoDeudorClickb).HasColumnName("id_asociado_deudor_clickb");
            entity.Property(e => e.IdCentroCostoClickb).HasColumnName("id_centro_costo_clickb");
            entity.Property(e => e.IdCombustible).HasColumnName("id_combustible");
            entity.Property(e => e.IdDocumentoGastoClickb).HasColumnName("id_documento_gasto_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdFormaPagoClickb).HasColumnName("id_forma_pago_clickb");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipoGastoClickb).HasColumnName("id_tipo_gasto_clickb");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IdUnidadMedidaBase).HasColumnName("id_unidad_medida_base");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.MontoCombustible)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_combustible");
            entity.Property(e => e.MontoIeps)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_ieps");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoSubtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_subtotal");
            entity.Property(e => e.NumVale)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("num_vale");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.PrecioCombustible)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("precio_combustible");
            entity.Property(e => e.ValeEnviadoRoutech)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("vale_enviado_routech");

            entity.HasOne(d => d.IdCombustibleNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdCombustible)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale01");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale03");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale04");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.CombustibleValeIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale05");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale06");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.CombustibleValeIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale07");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale11");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale02");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale10");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.CombustibleValeIdUnidadMedidaNavigations)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale09");

            entity.HasOne(d => d.IdUnidadMedidaBaseNavigation).WithMany(p => p.CombustibleValeIdUnidadMedidaBaseNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaBase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_combustible_vale08");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.CombustibleVales)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_combustible_vale_viaje");
        });

        modelBuilder.Entity<ComprobanteTipo>(entity =>
        {
            entity.HasKey(e => e.IdComprobanteTipo).HasName("PK_comprobante_tipo_id_comprobante_tipo");

            entity.ToTable("comprobante_tipo");

            entity.HasIndex(e => e.Clave, "UQ_comprobante_tipo_clave").IsUnique();

            entity.Property(e => e.IdComprobanteTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_comprobante_tipo");
            entity.Property(e => e.Clave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.ValorMaximo1)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("valor_maximo1");
            entity.Property(e => e.ValorMaximo2)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("valor_maximo2");
        });

        modelBuilder.Entity<ConceptoPermisionario>(entity =>
        {
            entity.HasKey(e => e.IdConcepto).HasName("PK_concepto_permisionario01");

            entity.ToTable("concepto_permisionario");

            entity.Property(e => e.IdConcepto)
                .ValueGeneratedNever()
                .HasColumnName("id_concepto");
            entity.Property(e => e.CalculaIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("calcula_iva");
            entity.Property(e => e.CalculaRetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("calcula_retencion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdTipoConcepto).HasColumnName("id_tipo_concepto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ConceptoPermisionarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_concepto_permisionario_id_empresa");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ConceptoPermisionarioIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_concepto_permisionario_id_ingreso");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ConceptoPermisionarioIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_concepto_permisionario_id_modifico");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.ConceptoPermisionarios)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_concepto_permisionario_id_retencion");

            entity.HasOne(d => d.IdTipoConceptoNavigation).WithMany(p => p.ConceptoPermisionarios)
                .HasForeignKey(d => d.IdTipoConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_concepto_permisionario_id_tipo_concepto");
        });

        modelBuilder.Entity<ConceptosContable>(entity =>
        {
            entity.HasKey(e => e.IdConceptoContable).HasName("PK_conceptos_contables01");

            entity.ToTable("conceptos_contables");

            entity.Property(e => e.IdConceptoContable)
                .ValueGeneratedNever()
                .HasColumnName("id_concepto_contable");
            entity.Property(e => e.ContableClasificacion)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("contable_clasificacion");
            entity.Property(e => e.ContableConcepto)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("contable_concepto");
            entity.Property(e => e.ContableInstitucionBancaria)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("contable_institucion_bancaria");
            entity.Property(e => e.ContableTipoConcepto)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("contable_tipo_concepto");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("cuenta_contable");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdInstitucionBancaria).HasColumnName("id_institucion_bancaria");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.IdPersonal).HasColumnName("id_personal");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdTipoConcepto).HasColumnName("id_tipo_concepto");
            entity.Property(e => e.IdUsuarioIngreso).HasColumnName("id_usuario_ingreso");
            entity.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ConceptosContables)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conceptos_contables_id_cliente");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ConceptosContables)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conceptos_contables_id_empresa");

            entity.HasOne(d => d.IdOperadorNavigation).WithMany(p => p.ConceptosContableIdOperadorNavigations)
                .HasForeignKey(d => d.IdOperador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conceptos_contables_id_operador");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.ConceptosContableIdPersonalNavigations)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conceptos_contables_id_personal");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ConceptosContables)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conceptos_contables_id_proveedor");

            entity.HasOne(d => d.IdTipoConceptoNavigation).WithMany(p => p.ConceptosContables)
                .HasForeignKey(d => d.IdTipoConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conceptos_contables_id_tipo_concepto");
        });

        modelBuilder.Entity<ConfiguracionRangoVencimiento>(entity =>
        {
            entity.HasKey(e => e.IdRangoVencimiento).HasName("PK_config_rango_vencimiento");

            entity.ToTable("configuracion_rango_vencimiento");

            entity.Property(e => e.IdRangoVencimiento)
                .ValueGeneratedNever()
                .HasColumnName("id_rango_vencimiento");
            entity.Property(e => e.DescRangoVencimiento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("desc_rango_vencimiento");
            entity.Property(e => e.Fin).HasColumnName("fin");
            entity.Property(e => e.Inicio).HasColumnName("inicio");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<ConsultaAlineacion>(entity =>
        {
            entity.HasKey(e => e.IdAlineacion);

            entity.ToTable("consulta_alineacion");

            entity.Property(e => e.IdAlineacion)
                .ValueGeneratedNever()
                .HasColumnName("id_alineacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ConsultaAlineacionIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdAlineacion, e.IdIdioma });

            entity.ToTable("consulta_alineacion_idioma");

            entity.Property(e => e.IdAlineacion).HasColumnName("id_alineacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdAlineacionNavigation).WithMany(p => p.ConsultaAlineacionIdiomas)
                .HasForeignKey(d => d.IdAlineacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_alineacion_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ConsultaAlineacionIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_alineacion_idioma01");
        });

        modelBuilder.Entity<ConsultaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdConsulta, e.Consecutivo });

            entity.ToTable("consulta_detalle");

            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Agrupar).HasColumnName("agrupar");
            entity.Property(e => e.AliasInterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias_interno");
            entity.Property(e => e.AlineacionDefault)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("alineacion_default");
            entity.Property(e => e.AnchoDefault).HasColumnName("ancho_default");
            entity.Property(e => e.FormatoDefault)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formato_default");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.NombreInterno)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("nombre_interno");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Requerido).HasColumnName("requerido");
            entity.Property(e => e.Sumar).HasColumnName("sumar");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_dato");
            entity.Property(e => e.VisibleDefault).HasColumnName("visible_default");

            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.ConsultaDetalles)
                .HasForeignKey(d => d.IdConsulta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_detalle01");
        });

        modelBuilder.Entity<ConsultaDetalleIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdIdioma, e.IdConsulta, e.Consecutivo });

            entity.ToTable("consulta_detalle_idioma");

            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.DescripcionExterna)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion_externa");
            entity.Property(e => e.NombreExterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_externo");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ConsultaDetalleIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_detalle_idioma01");

            entity.HasOne(d => d.ConsultaDetalle).WithMany(p => p.ConsultaDetalleIdiomas)
                .HasForeignKey(d => new { d.IdConsulta, d.Consecutivo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_detalle_idioma02");
        });

        modelBuilder.Entity<ConsultaVistaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdVista, e.Consecutivo });

            entity.ToTable("consulta_vista_detalle");

            entity.Property(e => e.IdVista).HasColumnName("id_vista");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Agrupar).HasColumnName("agrupar");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.Alinear)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("alinear");
            entity.Property(e => e.AnchoColumna).HasColumnName("ancho_columna");
            entity.Property(e => e.Formato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.NombreExterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_externo");
            entity.Property(e => e.NombreInterno)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("nombre_interno");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Ordenar).HasColumnName("ordenar");
            entity.Property(e => e.Requerido).HasColumnName("requerido");
            entity.Property(e => e.Sumar).HasColumnName("sumar");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_Dato");
            entity.Property(e => e.Visible).HasColumnName("visible");

            entity.HasOne(d => d.IdVistaNavigation).WithMany(p => p.ConsultaVistaDetalles)
                .HasForeignKey(d => d.IdVista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_vista_detalle01");
        });

        modelBuilder.Entity<ConsultaVistum>(entity =>
        {
            entity.HasKey(e => e.IdVista);

            entity.ToTable("consulta_vista");

            entity.Property(e => e.IdVista)
                .ValueGeneratedNever()
                .HasColumnName("id_vista");
            entity.Property(e => e.Cte)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("cte");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Dfrom)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("dfrom");
            entity.Property(e => e.Dorderby)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("dorderby");
            entity.Property(e => e.Dselect)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("dselect");
            entity.Property(e => e.Dwhere)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("dwhere");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Publica).HasColumnName("publica");
            entity.Property(e => e.VistaDefault).HasColumnName("vista_default");

            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.ConsultaVista)
                .HasForeignKey(d => d.IdConsulta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_vista01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ConsultaVistumIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_vista02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ConsultaVistumIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta_vista03");
        });

        modelBuilder.Entity<Consultum>(entity =>
        {
            entity.HasKey(e => e.IdConsulta);

            entity.ToTable("consulta");

            entity.Property(e => e.IdConsulta)
                .ValueGeneratedNever()
                .HasColumnName("id_consulta");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Dfrom)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("dfrom");
            entity.Property(e => e.Dorderby)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("dorderby");
            entity.Property(e => e.Dwhere)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("dwhere");
            entity.Property(e => e.IdVentana).HasColumnName("id_ventana");

            entity.HasOne(d => d.IdVentanaNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdVentana)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_consulta01");
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.HasKey(e => e.IdContacto);

            entity.ToTable("contacto");

            entity.Property(e => e.IdContacto)
                .ValueGeneratedNever()
                .HasColumnName("id_contacto");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido2");
            entity.Property(e => e.Celular)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdPuesto).HasColumnName("id_puesto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono1");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono2");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_agenda_06");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_agenda_02");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ContactoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_agenda_04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ContactoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_agenda_05");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_agenda_03");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.IdPuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_agenda_01");
        });

        modelBuilder.Entity<ContactoPuesto>(entity =>
        {
            entity.HasKey(e => e.IdPuesto);

            entity.ToTable("contacto_puesto");

            entity.Property(e => e.IdPuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_puesto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.ContactoPuestos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ContactoPuestos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_contacto_01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ContactoPuestoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ContactoPuestoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_contacto_03");
        });

        modelBuilder.Entity<Convenio>(entity =>
        {
            entity.HasKey(e => e.IdConvenio);

            entity.ToTable("convenio");

            entity.Property(e => e.IdConvenio)
                .ValueGeneratedNever()
                .HasColumnName("id_convenio");
            entity.Property(e => e.Autopistas)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("autopistas");
            entity.Property(e => e.EntSalida)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasColumnName("ent_salida");
            entity.Property(e => e.EntregarEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("entregar_en");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FactorCobro)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("factor_cobro");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.Flete)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("flete");
            entity.Property(e => e.IdClaveUnidad).HasColumnName("id_clave_unidad");
            entity.Property(e => e.IdClaveprodservCp).HasColumnName("id_claveprodserv_cp");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEntregaEn).HasColumnName("id_entrega_en");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdObjetoImpuesto).HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.IdPlazaDestino).HasColumnName("id_plaza_destino");
            entity.Property(e => e.IdPlazaOrigen).HasColumnName("id_plaza_origen");
            entity.Property(e => e.IdRecogerEn).HasColumnName("id_recoger_en");
            entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdTipoCobro).HasColumnName("id_tipo_cobro");
            entity.Property(e => e.Maniobras)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("maniobras");
            entity.Property(e => e.MaterialPeligroso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("material_peligroso");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Otros)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("otros");
            entity.Property(e => e.RecogerEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("recoger_en");
            entity.Property(e => e.Referencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Seguro)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("seguro");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.TransporteInternacional)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("transporte_internacional");
            entity.Property(e => e.ValorDeclarado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("valor_declarado");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Convenios)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio13");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ConvenioIdClienteNavigations)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio01");

            entity.HasOne(d => d.IdDestinatarioNavigation).WithMany(p => p.ConvenioIdDestinatarioNavigations)
                .HasForeignKey(d => d.IdDestinatario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Convenios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio12");

            entity.HasOne(d => d.IdEntregaEnNavigation).WithMany(p => p.ConvenioIdEntregaEnNavigations)
                .HasForeignKey(d => d.IdEntregaEn)
                .HasConstraintName("FK_convenio14");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ConvenioIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio11");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.ConvenioIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ConvenioIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio10");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.Convenios)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio06");

            entity.HasOne(d => d.IdPlazaDestinoNavigation).WithMany(p => p.ConvenioIdPlazaDestinoNavigations)
                .HasForeignKey(d => d.IdPlazaDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio07");

            entity.HasOne(d => d.IdPlazaOrigenNavigation).WithMany(p => p.ConvenioIdPlazaOrigenNavigations)
                .HasForeignKey(d => d.IdPlazaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio08");

            entity.HasOne(d => d.IdRecogerEnNavigation).WithMany(p => p.ConvenioIdRecogerEnNavigations)
                .HasForeignKey(d => d.IdRecogerEn)
                .HasConstraintName("FK_convenio15");

            entity.HasOne(d => d.IdRemitenteNavigation).WithMany(p => p.ConvenioIdRemitenteNavigations)
                .HasForeignKey(d => d.IdRemitente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio03");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.ConvenioIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio05");

            entity.HasOne(d => d.IdTipoCobroNavigation).WithMany(p => p.Convenios)
                .HasForeignKey(d => d.IdTipoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio09");
        });

        modelBuilder.Entity<ConvenioAnticipo>(entity =>
        {
            entity.HasKey(e => e.IdConvenio).HasName("PK_convenio_anticipo01");

            entity.ToTable("convenio_anticipo");

            entity.Property(e => e.IdConvenio)
                .ValueGeneratedNever()
                .HasColumnName("id_convenio");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.MontoAnticipo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_anticipo");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.ConvenioAnticipos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_anticipo02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ConvenioAnticipos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_anticipo01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ConvenioAnticipoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_anticipo03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ConvenioAnticipoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_anticipo04");
        });

        modelBuilder.Entity<ConvenioAnticipoDesglose>(entity =>
        {
            entity.HasKey(e => new { e.IdConvenio, e.IdConcepto }).HasName("PK_convenio_anticipo_desglose01");

            entity.ToTable("convenio_anticipo_desglose");

            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.ConvenioAnticipoDesgloses)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_anticipo_desglose02");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.ConvenioAnticipoDesgloses)
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_anticipo_desglose01");
        });

        modelBuilder.Entity<ConvenioEvidencium>(entity =>
        {
            entity.HasKey(e => new { e.IdConvenio, e.Consecutivo }).HasName("PK_convenio_evidencia01");

            entity.ToTable("convenio_evidencia");

            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEvidencia).HasColumnName("id_evidencia");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ConvenioEvidencia)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_evidencia01");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.ConvenioEvidencia)
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_evidencia04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ConvenioEvidencia)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_evidencia03");

            entity.HasOne(d => d.IdEvidenciaNavigation).WithMany(p => p.ConvenioEvidencia)
                .HasForeignKey(d => d.IdEvidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_evidencia02");
        });

        modelBuilder.Entity<ConvenioLiquidacion>(entity =>
        {
            entity.HasKey(e => e.IdConvenio).HasName("PK_convenio_liquidacion01");

            entity.ToTable("convenio_liquidacion");

            entity.Property(e => e.IdConvenio)
                .ValueGeneratedNever()
                .HasColumnName("id_convenio");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.ConvenioLiquidacions)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_liquidacion02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ConvenioLiquidacions)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_liquidacion01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ConvenioLiquidacionIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_liquidacion03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ConvenioLiquidacionIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_liquidacion04");
        });

        modelBuilder.Entity<ConvenioLiquidacionGasto>(entity =>
        {
            entity.HasKey(e => new { e.IdConvenio, e.IdConcepto }).HasName("PK_convenio_liquidacion_gasto01");

            entity.ToTable("convenio_liquidacion_gasto");

            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.ConceptoGasto).HasColumnName("concepto_gasto");
            entity.Property(e => e.IdUnidadMedidaVolumen).HasColumnName("id_unidad_medida_volumen");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoSubtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_subtotal");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.VolumenBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen_base");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.ConvenioLiquidacionGastos)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_liquidacion_gasto02");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.ConvenioLiquidacionGastos)
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_liquidacion_gasto01");
        });

        modelBuilder.Entity<ConvenioOtro>(entity =>
        {
            entity.HasKey(e => new { e.IdConvenio, e.Consecutivo });

            entity.ToTable("convenio_otros");

            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cantidad");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdObjetoImpuesto).HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.ConvenioOtros)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_otros01");
        });

        modelBuilder.Entity<ConvenioProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdConvenio, e.Consecutivo });

            entity.ToTable("convenio_producto");

            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FolioDocumentoAduanero)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_documento_aduanero");
            entity.Property(e => e.IdDestinatarioProd).HasColumnName("id_destinatario_prod");
            entity.Property(e => e.IdDestino).HasColumnName("id_destino");
            entity.Property(e => e.IdDocumentoAduanero).HasColumnName("id_documento_aduanero");
            entity.Property(e => e.IdEmbalaje).HasColumnName("id_embalaje");
            entity.Property(e => e.IdFraccionArancelaria).HasColumnName("id_fraccion_arancelaria");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdRemitenteProd).HasColumnName("id_remitente_prod");
            entity.Property(e => e.IdUnidadMedidaPeso).HasColumnName("id_unidad_medida_peso");
            entity.Property(e => e.IdUnidadMedidaPesoBase).HasColumnName("id_unidad_medida_peso_base");
            entity.Property(e => e.IdUnidadMedidaVolumen).HasColumnName("id_unidad_medida_volumen");
            entity.Property(e => e.IdUnidadMedidaVolumenBase).HasColumnName("id_unidad_medida_volumen_base");
            entity.Property(e => e.KmRecorridos)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("km_recorridos");
            entity.Property(e => e.Pedimento)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("pedimento");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso");
            entity.Property(e => e.PesoBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_base");
            entity.Property(e => e.PesoKg)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("peso_kg");
            entity.Property(e => e.RfcImportador)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("rfc_importador");
            entity.Property(e => e.UuidCemercioExt)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("uuid_cemercio_ext");
            entity.Property(e => e.ValorMercancia)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("valor_mercancia");
            entity.Property(e => e.Volumen)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen");
            entity.Property(e => e.VolumenBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen_base");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.ConvenioProductos)
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto01");

            entity.HasOne(d => d.IdEmbalajeNavigation).WithMany(p => p.ConvenioProductos)
                .HasForeignKey(d => d.IdEmbalaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto02");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ConvenioProductos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto03");

            entity.HasOne(d => d.IdUnidadMedidaPesoNavigation).WithMany(p => p.ConvenioProductoIdUnidadMedidaPesoNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaPeso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto05");

            entity.HasOne(d => d.IdUnidadMedidaPesoBaseNavigation).WithMany(p => p.ConvenioProductoIdUnidadMedidaPesoBaseNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaPesoBase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto06");

            entity.HasOne(d => d.IdUnidadMedidaVolumenNavigation).WithMany(p => p.ConvenioProductoIdUnidadMedidaVolumenNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaVolumen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto04");

            entity.HasOne(d => d.IdUnidadMedidaVolumenBaseNavigation).WithMany(p => p.ConvenioProductoIdUnidadMedidaVolumenBaseNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaVolumenBase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_convenio_producto07");
        });

        modelBuilder.Entity<CotizacionViajeFactore>(entity =>
        {
            entity.HasKey(e => e.IdCotizacion);

            entity.ToTable("cotizacion_viaje_factores");

            entity.Property(e => e.IdCotizacion)
                .ValueGeneratedNever()
                .HasColumnName("id_cotizacion");
            entity.Property(e => e.Arrendamiento)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("arrendamiento");
            entity.Property(e => e.ArrendamientoChk).HasColumnName("arrendamiento_chk");
            entity.Property(e => e.CostoCombustible)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("costo_combustible");
            entity.Property(e => e.CostoCombustibleChk).HasColumnName("costo_combustible_chk");
            entity.Property(e => e.Depreciacion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("depreciacion");
            entity.Property(e => e.DepreciacionChk).HasColumnName("depreciacion_chk");
            entity.Property(e => e.Factor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor");
            entity.Property(e => e.FactorChk).HasColumnName("factor_chk");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipoViaje).HasColumnName("id_tipo_viaje");
            entity.Property(e => e.Llantas)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("llantas");
            entity.Property(e => e.LlantasChk).HasColumnName("llantas_chk");
            entity.Property(e => e.Mantenimiento)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("mantenimiento");
            entity.Property(e => e.MantenimientoChk).HasColumnName("mantenimiento_chk");
            entity.Property(e => e.OperadorCargado)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("operador_cargado");
            entity.Property(e => e.OperadorCargadoChk).HasColumnName("operador_cargado_chk");
            entity.Property(e => e.OperadorVacio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("operador_vacio");
            entity.Property(e => e.OperadorVacioChk).HasColumnName("operador_vacio_chk");
            entity.Property(e => e.OtrosDia)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("otros_dia");
            entity.Property(e => e.OtrosDiaChk).HasColumnName("otros_dia_chk");
            entity.Property(e => e.OtrosKm)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("otros_km");
            entity.Property(e => e.OtrosKmChk).HasColumnName("otros_km_chk");
            entity.Property(e => e.RendimientoCargado)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rendimiento_cargado");
            entity.Property(e => e.RendimientoCargadoChk).HasColumnName("rendimiento_cargado_chk");
            entity.Property(e => e.RendimientoVacio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rendimiento_vacio");
            entity.Property(e => e.RendimientoVacioChk).HasColumnName("rendimiento_vacio_chk");
            entity.Property(e => e.Viaticos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("viaticos");
            entity.Property(e => e.ViaticosChk).HasColumnName("viaticos_chk");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CotizacionViajeFactores)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cotizacion_viaje_factores_01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.CotizacionViajeFactoreIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cotizacion_viaje_factores_03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.CotizacionViajeFactoreIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cotizacion_viaje_factores_04");

            entity.HasOne(d => d.IdTipoViajeNavigation).WithMany(p => p.CotizacionViajeFactores)
                .HasForeignKey(d => d.IdTipoViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cotizacion_viaje_factores_02");
        });

        modelBuilder.Entity<CuentaCliente>(entity =>
        {
            entity.HasKey(e => e.IdCuenta).HasName("PK_cuenta_cliente01");

            entity.ToTable("cuenta_cliente");

            entity.Property(e => e.IdCuenta)
                .ValueGeneratedNever()
                .HasColumnName("id_cuenta");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdBancosat).HasColumnName("id_bancosat");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("no_cuenta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");

            entity.HasOne(d => d.IdBancosatNavigation).WithMany(p => p.CuentaClientes)
                .HasForeignKey(d => d.IdBancosat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cuenta_cliente_id_bancosat");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CuentaClientes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cuenta_cliente_id_empresa");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.CuentaClienteIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cuenta_cliente_id_ingreso");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.CuentaClienteIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cuenta_cliente_id_modifico");
        });

        modelBuilder.Entity<CuentasBancariasPeru>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.Consecutivo }).HasName("PK__cuentas___0811A0B77DCF49BD");

            entity.ToTable("cuentas_bancarias_peru");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.InstitucionBancaria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("institucion_bancaria");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("no_cuenta");
            entity.Property(e => e.NoCuentaInterbancaria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("no_cuenta_interbancaria");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.CuentasBancariasPerus)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cuentas_b__id_cl__5689C04F");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.CuentasBancariasPerus)
                .HasForeignKey(d => d.IdMoneda)
                .HasConstraintName("FK__cuentas_b__id_mo__577DE488");
        });

        modelBuilder.Entity<DescripcionFlete>(entity =>
        {
            entity.HasKey(e => e.IdDescripcionFlete).HasName("PK_descripcion_flete01");

            entity.ToTable("descripcion_flete");

            entity.Property(e => e.IdDescripcionFlete)
                .ValueGeneratedNever()
                .HasColumnName("id_descripcion_flete");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<EdiLine>(entity =>
        {
            entity.HasKey(e => e.IdEdiLine).HasName("pk_edi_line");

            entity.ToTable("edi_line");

            entity.Property(e => e.IdEdiLine)
                .ValueGeneratedNever()
                .HasColumnName("id_edi_line");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEdiShipmentStatus).HasColumnName("id_edi_shipment_status");
            entity.Property(e => e.ShipmentAppointmentStatusCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shipment_appointment_status_code");
            entity.Property(e => e.ShipmentStatusAppointmentReasonCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shipment_status_appointment_reason_code");
            entity.Property(e => e.ShipmentStatusAppointmentReasonCode1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shipment_status_appointment_reason_code_1");
            entity.Property(e => e.ShipmentStatusIndicatorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shipment_status_indicator_code");
            entity.Property(e => e.TimeCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("time_code");

            entity.HasOne(d => d.IdEdiShipmentStatusNavigation).WithMany(p => p.EdiLines)
                .HasForeignKey(d => d.IdEdiShipmentStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_line");
        });

        modelBuilder.Entity<EdiLoadTender>(entity =>
        {
            entity.HasKey(e => e.IdEdiLoadTender).HasName("pk_edi_load_tender");

            entity.ToTable("edi_load_tender");

            entity.HasIndex(e => e.ShipmentIdentificationNumber, "unq_edi_load_tender").IsUnique();

            entity.Property(e => e.IdEdiLoadTender).HasColumnName("id_edi_load_tender");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaReservacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_reservacion");
            entity.Property(e => e.IdEdiUsuario).HasColumnName("id_edi_usuario");
            entity.Property(e => e.IdViajeAsignado).HasColumnName("id_viaje_asignado");
            entity.Property(e => e.LoadTender204)
                .IsUnicode(false)
                .HasColumnName("load_tender_204");
            entity.Property(e => e.ReservationActionCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reservation_action_code");
            entity.Property(e => e.ShipmentIdentificationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("shipment_identification_number");
            entity.Property(e => e.Type)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('application/json')")
                .HasColumnName("type");

            entity.HasOne(d => d.IdEdiUsuarioNavigation).WithMany(p => p.EdiLoadTenders)
                .HasForeignKey(d => d.IdEdiUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_load_tender_edi_usuario");

            entity.HasOne(d => d.IdViajeAsignadoNavigation).WithMany(p => p.EdiLoadTenders)
                .HasForeignKey(d => d.IdViajeAsignado)
                .HasConstraintName("fk_edi_load_tender_viaje");
        });

        modelBuilder.Entity<EdiParty>(entity =>
        {
            entity.HasKey(e => e.IdEdiParty).HasName("pk_edi_party");

            entity.ToTable("edi_party");

            entity.Property(e => e.IdEdiParty).HasColumnName("id_edi_party");
            entity.Property(e => e.Address)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Address1)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("address_1");
            entity.Property(e => e.CityName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.CodigoFecha)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("codigo_fecha");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("country_code");
            entity.Property(e => e.EntityIdentifierCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("entity_identifier_code");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEdiShipmentStatus).HasColumnName("id_edi_shipment_status");
            entity.Property(e => e.IdentificationCode)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("identification_code");
            entity.Property(e => e.IdentificationCodeQualifier)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("identification_code_qualifier");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.StateProvinceCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("state_province_code");
            entity.Property(e => e.TimeQualifier)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("time_qualifier");

            entity.HasOne(d => d.IdEdiShipmentStatusNavigation).WithMany(p => p.EdiParties)
                .HasForeignKey(d => d.IdEdiShipmentStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_party_edi_load_tender");
        });

        modelBuilder.Entity<EdiSesionUsuario>(entity =>
        {
            entity.HasKey(e => e.IdEdiSesionUsuario).HasName("pk_edi_sesion_usuario");

            entity.ToTable("edi_sesion_usuario");

            entity.Property(e => e.IdEdiSesionUsuario).HasColumnName("id_edi_sesion_usuario");
            entity.Property(e => e.FechaInicio)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdEdiUsuario).HasColumnName("id_edi_usuario");
            entity.Property(e => e.Navegador)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("navegador");
            entity.Property(e => e.Token)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.UltimaActividad)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("ultima_actividad");

            entity.HasOne(d => d.IdEdiUsuarioNavigation).WithMany(p => p.EdiSesionUsuarios)
                .HasForeignKey(d => d.IdEdiUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_sesion_usuario");
        });

        modelBuilder.Entity<EdiShipmentStatus>(entity =>
        {
            entity.HasKey(e => e.IdEdiShipmentStatus).HasName("pk_edi_shipment_status");

            entity.ToTable("edi_shipment_status");

            entity.Property(e => e.IdEdiShipmentStatus).HasColumnName("id_edi_shipment_status");
            entity.Property(e => e.FechaTransmision)
                .HasColumnType("datetime")
                .HasColumnName("fecha_transmision");
            entity.Property(e => e.IdEdiLoadTender).HasColumnName("id_edi_load_tender");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.IdentificacionReferencia).HasColumnName("identificacion_referencia");

            entity.HasOne(d => d.IdEdiLoadTenderNavigation).WithMany(p => p.EdiShipmentStatuses)
                .HasForeignKey(d => d.IdEdiLoadTender)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_shipment_status");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.EdiShipmentStatuses)
                .HasForeignKey(d => d.IdViaje)
                .HasConstraintName("fk_edi_shipment_status_viaje");
        });

        modelBuilder.Entity<EdiStatusCode>(entity =>
        {
            entity.HasKey(e => e.IdEdiStatusCode).HasName("pk_edi_status_code");

            entity.ToTable("edi_status_code");

            entity.Property(e => e.IdEdiStatusCode)
                .ValueGeneratedNever()
                .HasColumnName("id_edi_status_code");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Key)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("key");
            entity.Property(e => e.Usage)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("usage");
        });

        modelBuilder.Entity<EdiUsuario>(entity =>
        {
            entity.HasKey(e => e.IdEdiUsuario).HasName("pk_edi_usuario");

            entity.ToTable("edi_usuario");

            entity.Property(e => e.IdEdiUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_edi_usuario");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.GsId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("gs_id");
            entity.Property(e => e.HabilitaEncripcion).HasColumnName("habilita_encripcion");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IsaId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("isa_id");
            entity.Property(e => e.IsaQualifier)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("isa_qualifier");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.EdiUsuarios)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_usuario_cliente");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.EdiUsuarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edi_usuario_empresa");
        });

        modelBuilder.Entity<Electronico>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.ToTable("electronico");

            entity.HasIndex(e => new { e.IdEmpresa, e.FechaIngreso, e.TipoDoc }, "IX_electronico_empresa_fecha_tipo").HasFillFactor(90);

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.CadenaOriginal1)
                .IsUnicode(false)
                .HasColumnName("cadena_original_1");
            entity.Property(e => e.CadenaOriginal2)
                .IsUnicode(false)
                .HasColumnName("cadena_original_2");
            entity.Property(e => e.CadenaOriginal3)
                .HasMaxLength(260)
                .IsUnicode(false)
                .HasColumnName("cadena_original_3");
            entity.Property(e => e.CadenaSat1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cadena_sat_1");
            entity.Property(e => e.CadenaSat2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cadena_sat_2");
            entity.Property(e => e.CcpQr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ccp_qr");
            entity.Property(e => e.EstadoComprobante).HasColumnName("estado_comprobante");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaTimbrado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fecha_timbrado");
            entity.Property(e => e.Folio).HasColumnName("folio");
            entity.Property(e => e.IdCcp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_ccp");
            entity.Property(e => e.IdCertificado).HasColumnName("id_certificado");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTimbre).HasColumnName("id_timbre");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoLocalRetencion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("monto_local_retencion");
            entity.Property(e => e.MontoResico)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_resico");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.NoCertificadoSat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("no_certificado_sat");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("prefijo");
            entity.Property(e => e.ProveedorTimbrado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('B')")
                .HasColumnName("proveedor_timbrado");
            entity.Property(e => e.RfcEmisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc_emisor");
            entity.Property(e => e.RfcReceptor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc_receptor");
            entity.Property(e => e.SelloContribuyente)
                .IsUnicode(false)
                .HasColumnName("sello_contribuyente");
            entity.Property(e => e.SelloProveedor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("sello_proveedor");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.TipoComprobante)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_comprobante");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uuid");
            entity.Property(e => e.ValorQr)
                .HasMaxLength(198)
                .IsUnicode(false)
                .HasColumnName("valor_qr");

            entity.HasOne(d => d.IdCertificadoNavigation).WithMany(p => p.Electronicos)
                .HasForeignKey(d => d.IdCertificado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_03");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Electronicos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Electronicos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ElectronicoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ElectronicoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_05");
        });

        modelBuilder.Entity<ElectronicoAdendaCampo>(entity =>
        {
            entity.HasKey(e => new { e.IdAdenda, e.Consecutivo });

            entity.ToTable("electronico_adenda_campos");

            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Campo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Obligatorio).HasColumnName("obligatorio");
            entity.Property(e => e.Requerido).HasColumnName("requerido");

            entity.HasOne(d => d.IdAdendaNavigation).WithMany(p => p.ElectronicoAdendaCampos)
                .HasForeignKey(d => d.IdAdenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_campos_02");

            entity.HasOne(d => d.RequeridoNavigation).WithMany(p => p.ElectronicoAdendaCampos)
                .HasForeignKey(d => d.Requerido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_campos_01");
        });

        modelBuilder.Entity<ElectronicoAdendaCamposDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAdenda, e.Consecutivo }).HasName("PK__electron__BA02678B7B4F45D2");

            entity.ToTable("electronico_adenda_campos_default");

            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Valor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.ElectronicoAdendaCampo).WithMany(p => p.ElectronicoAdendaCamposDefaults)
                .HasForeignKey(d => new { d.IdAdenda, d.Consecutivo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__electronico_aden__5F1F0650");
        });

        modelBuilder.Entity<ElectronicoAdendaCamposRequerido>(entity =>
        {
            entity.HasKey(e => e.IdRequerido);

            entity.ToTable("electronico_adenda_campos_requerido");

            entity.Property(e => e.IdRequerido)
                .ValueGeneratedNever()
                .HasColumnName("id_requerido");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ElectronicoAdendaCamposRequeridoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdRequerido, e.IdIdioma });

            entity.ToTable("electronico_adenda_campos_requerido_idioma");

            entity.Property(e => e.IdRequerido).HasColumnName("id_requerido");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.NombreEstandar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre_estandar");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ElectronicoAdendaCamposRequeridoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_campos_requerido_idioma_01");

            entity.HasOne(d => d.IdRequeridoNavigation).WithMany(p => p.ElectronicoAdendaCamposRequeridoIdiomas)
                .HasForeignKey(d => d.IdRequerido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_campos_requerido_idioma_02");
        });

        modelBuilder.Entity<ElectronicoAdendaCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdAdenda, e.IdCliente, e.Consecutivo });

            entity.ToTable("electronico_adenda_cliente");

            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Campo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Obligatorio).HasColumnName("obligatorio");
            entity.Property(e => e.Requerido).HasColumnName("requerido");
            entity.Property(e => e.Valor)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAdendaNavigation).WithMany(p => p.ElectronicoAdendaClientes)
                .HasForeignKey(d => d.IdAdenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_cliente_02");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ElectronicoAdendaClientes)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_cliente_01");
        });

        modelBuilder.Entity<ElectronicoAdendaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdAdenda, e.IdIdioma });

            entity.ToTable("electronico_adenda_idioma");

            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.IdAdendaNavigation).WithMany(p => p.ElectronicoAdendaIdiomas)
                .HasForeignKey(d => d.IdAdenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_idioma_01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ElectronicoAdendaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_adenda_idioma_02");
        });

        modelBuilder.Entity<ElectronicoAdendum>(entity =>
        {
            entity.HasKey(e => e.IdAdenda);

            entity.ToTable("electronico_adenda");

            entity.Property(e => e.IdAdenda)
                .ValueGeneratedNever()
                .HasColumnName("id_adenda");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasMany(d => d.IdEmpresas).WithMany(p => p.IdAdenda)
                .UsingEntity<Dictionary<string, object>>(
                    "ElectronicoAdendaEmpresa",
                    r => r.HasOne<Empresa>().WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_electronico_adenda_empresa_02"),
                    l => l.HasOne<ElectronicoAdendum>().WithMany()
                        .HasForeignKey("IdAdenda")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_electronico_adenda_empresa_01"),
                    j =>
                    {
                        j.HasKey("IdAdenda", "IdEmpresa");
                        j.ToTable("electronico_adenda_empresa");
                        j.IndexerProperty<int>("IdAdenda").HasColumnName("id_adenda");
                        j.IndexerProperty<int>("IdEmpresa").HasColumnName("id_empresa");
                    });
        });

        modelBuilder.Entity<ElectronicoCertificado>(entity =>
        {
            entity.HasKey(e => e.IdCertificado);

            entity.ToTable("electronico_certificado");

            entity.Property(e => e.IdCertificado)
                .ValueGeneratedNever()
                .HasColumnName("id_certificado");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInicial)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicial");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FiletypeBuzone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("filetype_buzone");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.NoCertificado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("no_certificado");
            entity.Property(e => e.NumActivacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("num_activacion");
            entity.Property(e => e.PasswordBuzone)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("password_buzone");
            entity.Property(e => e.PasswordBuzoneant)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("password_buzoneant");
            entity.Property(e => e.PasswordCancel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("password_cancel");
            entity.Property(e => e.PasswordDetecno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("password_detecno");
            entity.Property(e => e.RutaCer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruta_cer");
            entity.Property(e => e.RutaKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruta_key");
            entity.Property(e => e.SerieCertificado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie_certificado");
            entity.Property(e => e.UserBuzone)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("user_buzone");
            entity.Property(e => e.UserBuzoneant)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("user_buzoneant");
            entity.Property(e => e.UserCancel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("user_cancel");
            entity.Property(e => e.UserDetecno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("user_detecno");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.ElectronicoCertificados)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_certificado_04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ElectronicoCertificados)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_certificado_01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ElectronicoCertificadoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_certificado_02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ElectronicoCertificadoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_certificado_03");
        });

        modelBuilder.Entity<ElectronicoControlPago>(entity =>
        {
            entity.HasKey(e => e.IdPagoElectronico).HasName("PK_electronico_control_pagos01");

            entity.ToTable("electronico_control_pagos");

            entity.Property(e => e.IdPagoElectronico)
                .ValueGeneratedNever()
                .HasColumnName("id_pago_electronico");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.IdDocRelacionado).HasColumnName("id_doc_relacionado");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.MontoPagoTimbrado)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_pago_timbrado");
            entity.Property(e => e.UuidRelacionado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uuid_relacionado");
        });

        modelBuilder.Entity<ElectronicoControlPagosDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdPagoElectronico, e.IdFactura }).HasName("PK_electronico_control_pagos_detalle01");

            entity.ToTable("electronico_control_pagos_detalle");

            entity.Property(e => e.IdPagoElectronico).HasColumnName("id_pago_electronico");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.EstatusPagoFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estatus_pago_factura");
            entity.Property(e => e.IdMetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_metodo_pago");
            entity.Property(e => e.NumParcialidad).HasColumnName("num_parcialidad");
        });

        modelBuilder.Entity<ElectronicoEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus).HasName("PK_electronico_estatus_id_estatus");

            entity.ToTable("electronico_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ElectronicoGuium>(entity =>
        {
            entity.HasKey(e => e.IdGuiaElectronica);

            entity.ToTable("electronico_guia");

            entity.Property(e => e.IdGuiaElectronica)
                .ValueGeneratedNever()
                .HasColumnName("id_guia_electronica");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.ElectronicoGuia)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_guia_01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ElectronicoGuia)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_guia_03");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.ElectronicoGuia)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_guia_02");
        });

        modelBuilder.Entity<ElectronicoLiquidacion>(entity =>
        {
            entity.HasKey(e => e.IdLiqElectronica);

            entity.ToTable("electronico_liquidacion");

            entity.Property(e => e.IdLiqElectronica)
                .ValueGeneratedNever()
                .HasColumnName("id_liq_electronica");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.ElectronicoLiquidacions)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_liquidacion_01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ElectronicoLiquidacions)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_liquidacion_03");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany(p => p.ElectronicoLiquidacions)
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_liquidacion_02");
        });

        modelBuilder.Entity<ElectronicoLiquidacionDirectum>(entity =>
        {
            entity.HasKey(e => e.IdLiqdirElectronica);

            entity.ToTable("electronico_liquidacion_directa");

            entity.Property(e => e.IdLiqdirElectronica)
                .ValueGeneratedNever()
                .HasColumnName("id_liqdir_electronica");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdLiquidacionDirecta).HasColumnName("id_liquidacion_directa");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.ElectronicoLiquidacionDirecta)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_liquidacion_directa_01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ElectronicoLiquidacionDirecta)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_liquidacion_directa_03");

            entity.HasOne(d => d.IdLiquidacionDirectaNavigation).WithMany(p => p.ElectronicoLiquidacionDirecta)
                .HasForeignKey(d => d.IdLiquidacionDirecta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_liquidacion_directa_02");
        });

        modelBuilder.Entity<ElectronicoNotaCargo>(entity =>
        {
            entity.HasKey(e => e.IdCargoElectronica);

            entity.ToTable("electronico_nota_cargo");

            entity.Property(e => e.IdCargoElectronica)
                .ValueGeneratedNever()
                .HasColumnName("id_cargo_electronica");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_estatus");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.ElectronicoNotaCargos)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_delectronico_nota_cargo_02");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.ElectronicoNotaCargos)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_nota_cargo_01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ElectronicoNotaCargos)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_nota_cargo_03");
        });

        modelBuilder.Entity<ElectronicoNotaCredito>(entity =>
        {
            entity.HasKey(e => e.IdCreditoElectronica);

            entity.ToTable("electronico_nota_credito");

            entity.Property(e => e.IdCreditoElectronica)
                .ValueGeneratedNever()
                .HasColumnName("id_credito_electronica");
            entity.Property(e => e.IdCredito).HasColumnName("id_credito");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_estatus");

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.ElectronicoNotaCreditos)
                .HasForeignKey(d => d.IdCredito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_nota_credito_02");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.ElectronicoNotaCreditos)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_nota_credito_01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ElectronicoNotaCreditos)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_nota_credito_03");
        });

        modelBuilder.Entity<ElectronicoPeruTicket>(entity =>
        {
            entity.HasKey(e => e.IdTicket).HasName("PK_electronico_peru_ticket01");

            entity.ToTable("electronico_peru_ticket");

            entity.Property(e => e.IdTicket)
                .ValueGeneratedNever()
                .HasColumnName("id_ticket");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaTimbrado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fecha_timbrado");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdNotaCargo).HasColumnName("id_nota_cargo");
            entity.Property(e => e.IdNotaCredito).HasColumnName("id_nota_credito");
            entity.Property(e => e.Igv)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("igv");
            entity.Property(e => e.NoTicket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("no_ticket");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ElectronicoPeruTickets)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_peru_ticket_id_empresa");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.ElectronicoPeruTickets)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_peru_ticket_id_guia");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ElectronicoPeruTicketIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_peru_ticket_id_ingreso");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ElectronicoPeruTicketIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_electronico_peru_ticket_id_modifico");
        });

        modelBuilder.Entity<Embalaje>(entity =>
        {
            entity.HasKey(e => e.IdEmbalaje);

            entity.ToTable("embalaje");

            entity.Property(e => e.IdEmbalaje)
                .ValueGeneratedNever()
                .HasColumnName("id_embalaje");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdUnidadembalaje).HasColumnName("id_unidadembalaje");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Embalajes)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_embalaje02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Embalajes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_embalaje01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.EmbalajeIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_embalaje03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.EmbalajeIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_embalaje04");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("empresa");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("id_empresa");
            entity.Property(e => e.ActualizaOdometroUnidad).HasColumnName("actualiza_odometro_unidad");
            entity.Property(e => e.AlertaVigencia)
                .HasDefaultValueSql("(getdate()-(1))")
                .HasColumnType("datetime")
                .HasColumnName("alerta_vigencia");
            entity.Property(e => e.ArchivoConstanciaFiscal)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("archivo_constancia_fiscal");
            entity.Property(e => e.Calle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.CambiosMovac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasColumnName("cambios_movac");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.CodigoUbigeo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("codigo_ubigeo");
            entity.Property(e => e.Colonia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Contrato).HasColumnName("contrato");
            entity.Property(e => e.Curp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("curp");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delegacion");
            entity.Property(e => e.DiaHoraLocalizar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('S/D')")
                .HasColumnName("dia_hora_localizar");
            entity.Property(e => e.FechaAceptocontrato)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_aceptocontrato");
            entity.Property(e => e.IdDescripcionFlete).HasColumnName("id_descripcion_flete");
            entity.Property(e => e.IdEsquema).HasColumnName("id_esquema");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdNumUnidades)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_num_unidades");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdRazonSocial).HasColumnName("id_razon_social");
            entity.Property(e => e.IdRegimenfiscal)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_regimenfiscal");
            entity.Property(e => e.IdTipoCarga)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_tipo_carga");
            entity.Property(e => e.IdTipoPersona)
                .HasDefaultValueSql("((2))")
                .HasColumnName("id_tipo_persona");
            entity.Property(e => e.IdUsuarioAceptocontrato).HasColumnName("id_usuario_aceptocontrato");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.Numerointerior)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numerointerior");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("regimen_fiscal");
            entity.Property(e => e.RegistroPatronal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("registro_patronal");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.SaldoEmbarcador).HasColumnName("saldo_embarcador");
            entity.Property(e => e.SaldoPermisionario).HasColumnName("saldo_permisionario");
            entity.Property(e => e.SaldoPlanner).HasColumnName("saldo_planner");
            entity.Property(e => e.SaldoRoutech).HasColumnName("saldo_routech");
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("telefono_2");
            entity.Property(e => e.Telefono3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("telefono_3");
            entity.Property(e => e.UsoProrroga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("uso_prorroga");
            entity.Property(e => e.UsoProrrogaSoporte)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("uso_prorroga_soporte");
            entity.Property(e => e.VigenciaPlanner)
                .HasColumnType("date")
                .HasColumnName("vigencia_planner");

            entity.HasOne(d => d.IdEsquemaNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdEsquema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_03");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa02");

            entity.HasOne(d => d.IdNumUnidadesNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdNumUnidades)
                .HasConstraintName("FK__empresa__id_num___267098D9");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa01");

            entity.HasOne(d => d.IdRegimenfiscalNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdRegimenfiscal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_05");

            entity.HasOne(d => d.IdTipoCargaNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdTipoCarga)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__empresa__id_tipo__294D0584");

            entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdTipoPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_04");
        });

        modelBuilder.Entity<EmpresaClickbalance>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK_empresa_clickbalance01");

            entity.ToTable("empresa_clickbalance");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("id_empresa");
            entity.Property(e => e.CodigoProductoAutopista)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("codigo_producto_autopista");
            entity.Property(e => e.CodigoProductoFlete)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("codigo_producto_flete");
            entity.Property(e => e.CodigoProductoManiobras)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("codigo_producto_maniobras");
            entity.Property(e => e.CodigoProductoSeguro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("codigo_producto_seguro");
            entity.Property(e => e.EmpresaCb).HasColumnName("empresa_cb");
            entity.Property(e => e.IdProductoAutopista)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_producto_autopista");
            entity.Property(e => e.IdProductoFlete)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_producto_flete");
            entity.Property(e => e.IdProductoManiobras)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_producto_maniobras");
            entity.Property(e => e.IdProductoSeguro)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_producto_seguro");
            entity.Property(e => e.IdTipoGastoAnticipo).HasColumnName("id_tipo_gasto_anticipo");
            entity.Property(e => e.IdTipoGastoVales).HasColumnName("id_tipo_gasto_vales");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Password)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.EmpresaClickbalance)
                .HasForeignKey<EmpresaClickbalance>(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_clickbalance_id_empresa");
        });

        modelBuilder.Entity<EmpresaConfiguracion>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("empresa_configuracion");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("id_empresa");
            entity.Property(e => e.AdendaPostTimbrado).HasColumnName("adenda_post_timbrado");
            entity.Property(e => e.CalculaIsr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("calcula_isr");
            entity.Property(e => e.CantidadTimbresAlerta).HasColumnName("cantidad_timbres_alerta");
            entity.Property(e => e.ClienteClickBalance)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("cliente_click_balance");
            entity.Property(e => e.ClientePemex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("cliente_pemex");
            entity.Property(e => e.ColConceptoDescTesoreria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("col_concepto_desc_tesoreria");
            entity.Property(e => e.Contenedor).HasColumnName("contenedor");
            entity.Property(e => e.ControlaFolioAnticipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("controla_folio_anticipo");
            entity.Property(e => e.DescontarHorasFe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Descontar_HorasFE");
            entity.Property(e => e.DiasAlertaMttoUnidad).HasColumnName("dias_alerta_mtto_unidad");
            entity.Property(e => e.DiasAvisoPolizaAmarillo).HasColumnName("dias_aviso_poliza_amarillo");
            entity.Property(e => e.DiasAvisoPolizaRojo).HasColumnName("dias_aviso_poliza_rojo");
            entity.Property(e => e.DiasAvisoSigmttoAmarillo).HasColumnName("dias_aviso_sigmtto_amarillo");
            entity.Property(e => e.DiasAvisoSigmttoRojo).HasColumnName("dias_aviso_sigmtto_rojo");
            entity.Property(e => e.EmpresaPermisionario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("empresa_permisionario");
            entity.Property(e => e.EstatusViajeCustom).HasColumnName("estatus_viaje_custom");
            entity.Property(e => e.FleteLiquidacion).HasColumnName("flete_liquidacion");
            entity.Property(e => e.FormatoFecha)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("formato_fecha");
            entity.Property(e => e.GuiaViaje).HasColumnName("guia_viaje");
            entity.Property(e => e.HabilitarIa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("habilitar_ia");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdConcepto1).HasColumnName("id_concepto1");
            entity.Property(e => e.IdConcepto2).HasColumnName("id_concepto2");
            entity.Property(e => e.IdConceptoDeduccion)
                .HasDefaultValueSql("((0))")
                .HasColumnName("id_concepto_deduccion");
            entity.Property(e => e.IdConceptoIngresos).HasColumnName("id_concepto_ingresos");
            entity.Property(e => e.IdConceptoLiquidacionContra).HasColumnName("id_concepto_liquidacion_contra");
            entity.Property(e => e.IdConceptoPercepcion)
                .HasDefaultValueSql("((0))")
                .HasColumnName("id_concepto_percepcion");
            entity.Property(e => e.IdEstatusUnidad).HasColumnName("id_estatus_unidad");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdUndMedDist).HasColumnName("id_und_med_dist");
            entity.Property(e => e.IdUndMedPeso).HasColumnName("id_und_med_peso");
            entity.Property(e => e.IdUndMedVol).HasColumnName("id_und_med_Vol");
            entity.Property(e => e.ImportMasCal).HasColumnName("import_mas_cal");
            entity.Property(e => e.ImpuestoLocal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("impuesto_local");
            entity.Property(e => e.IntegracionBfiskur)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("integracion_bfiskur");
            entity.Property(e => e.IntegracionPlanner)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("integracion_planner");
            entity.Property(e => e.IntegracionPortalEmbarcador)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("integracion_portal_embarcador");
            entity.Property(e => e.IntegracionRoutech)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("integracion_routech");
            entity.Property(e => e.IsEditIvaRet)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("is_edit_iva_ret");
            entity.Property(e => e.IsFacturaVolumen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("is_factura_volumen");
            entity.Property(e => e.LimiteConsumoIa)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("limite_consumo_ia");
            entity.Property(e => e.LitrosAutorizados).HasColumnName("litros_autorizados");
            entity.Property(e => e.Moneda).HasColumnName("moneda");
            entity.Property(e => e.OrdenCompraVje)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("orden_compra_vje");
            entity.Property(e => e.ProdUnidadIngValFiscal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("prod_unidad_ing_val_fiscal");
            entity.Property(e => e.Region)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.RendXViaje)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("rend_x_viaje");
            entity.Property(e => e.RestringirConceptosAnticipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("restringir_conceptos_anticipo");
            entity.Property(e => e.SeparadorDecimales)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("separador_decimales");
            entity.Property(e => e.SeparadorMiles)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("separador_miles");
            entity.Property(e => e.SincronizacionPortalEmbarcador)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("sincronizacion_portal_embarcador");
            entity.Property(e => e.SincronizacionTaller)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("sincronizacion_taller");
            entity.Property(e => e.SueldoViaje).HasColumnName("sueldo_viaje");
            entity.Property(e => e.UtilidadViaje).HasColumnName("utilidad_viaje");
            entity.Property(e => e.ValidacionesViaje).HasColumnName("validaciones_viaje");
            entity.Property(e => e.VersionCfdi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('3.3')")
                .HasColumnName("version_cfdi");
            entity.Property(e => e.VersionComplementoCp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('2.0')")
                .HasColumnName("version_complemento_cp");
            entity.Property(e => e.VersionIntegracionRoutech)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("version_integracion_routech");
            entity.Property(e => e.ViajeProgramado).HasColumnName("viaje_programado");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.EmpresaConfiguracions)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion08");

            entity.HasOne(d => d.IdConcepto1Navigation).WithMany(p => p.EmpresaConfiguracionIdConcepto1Navigations)
                .HasForeignKey(d => d.IdConcepto1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion06");

            entity.HasOne(d => d.IdConcepto2Navigation).WithMany(p => p.EmpresaConfiguracionIdConcepto2Navigations)
                .HasForeignKey(d => d.IdConcepto2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion07");

            entity.HasOne(d => d.IdConceptoIngresosNavigation).WithMany(p => p.EmpresaConfiguracionIdConceptoIngresosNavigations)
                .HasForeignKey(d => d.IdConceptoIngresos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion12");

            entity.HasOne(d => d.IdConceptoLiquidacionContraNavigation).WithMany(p => p.EmpresaConfiguracions)
                .HasForeignKey(d => d.IdConceptoLiquidacionContra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion11");

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.EmpresaConfiguracion)
                .HasForeignKey<EmpresaConfiguracion>(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion09");

            entity.HasOne(d => d.IdEstatusUnidadNavigation).WithMany(p => p.EmpresaConfiguracions)
                .HasForeignKey(d => d.IdEstatusUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion13");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.EmpresaConfiguracions)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion02");

            entity.HasOne(d => d.IdUndMedDistNavigation).WithMany(p => p.EmpresaConfiguracionIdUndMedDistNavigations)
                .HasForeignKey(d => d.IdUndMedDist)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion05");

            entity.HasOne(d => d.IdUndMedPesoNavigation).WithMany(p => p.EmpresaConfiguracionIdUndMedPesoNavigations)
                .HasForeignKey(d => d.IdUndMedPeso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion03");

            entity.HasOne(d => d.IdUndMedVolNavigation).WithMany(p => p.EmpresaConfiguracionIdUndMedVolNavigations)
                .HasForeignKey(d => d.IdUndMedVol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion04");

            entity.HasOne(d => d.MonedaNavigation).WithMany(p => p.EmpresaConfiguracions)
                .HasForeignKey(d => d.Moneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_configuracion10");
        });

        modelBuilder.Entity<EmpresaInscripcion>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("empresa_inscripcion");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("id_empresa");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<EmpresaProveedoresGp>(entity =>
        {
            entity.HasKey(e => new { e.IdProveedor, e.IdEmpresa }).HasName("PK_empresa_proveedores_gps01");

            entity.ToTable("empresa_proveedores_gps");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.Empresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.EmpresaProveedoresGps)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_proveedores_gps01");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.EmpresaProveedoresGps)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_proveedores_gps02");
        });

        modelBuilder.Entity<EmpresaProveedoresGpsSuscr>(entity =>
        {
            entity.HasKey(e => e.Consecutivo).HasName("PK_empresa_proveedores_gps_suscr01");

            entity.ToTable("empresa_proveedores_gps_suscr");

            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Suscriptor).HasColumnName("suscriptor");
            entity.Property(e => e.Transaccion).HasColumnName("transaccion");

            entity.HasOne(d => d.Id).WithMany(p => p.EmpresaProveedoresGpsSuscrs)
                .HasForeignKey(d => new { d.IdProveedor, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_proveedores_gps_suscr01");
        });

        modelBuilder.Entity<EmpresaRegimenFiscal>(entity =>
        {
            entity.HasKey(e => e.IdRegimenfiscal).HasName("PK_empresa_regimen_fiscal_id_regimenfiscal");

            entity.ToTable("empresa_regimen_fiscal");

            entity.Property(e => e.IdRegimenfiscal).HasColumnName("id_regimenfiscal");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("claveSAT");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.PFisica)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("pFisica");
            entity.Property(e => e.PMoral)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("pMoral");
        });

        modelBuilder.Entity<Esquema>(entity =>
        {
            entity.HasKey(e => e.IdEsquema);

            entity.ToTable("esquema");

            entity.Property(e => e.IdEsquema)
                .ValueGeneratedNever()
                .HasColumnName("id_esquema");
            entity.Property(e => e.IdAnticipo).HasColumnName("id_anticipo");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdControlpago).HasColumnName("id_controlpago");
            entity.Property(e => e.IdCredito).HasColumnName("id_credito");
            entity.Property(e => e.IdFacturacion).HasColumnName("id_facturacion");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.IdRegistroie).HasColumnName("id_registroie");
            entity.Property(e => e.IdRelacion).HasColumnName("id_relacion");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdVale).HasColumnName("id_vale");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Nombre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tope).HasColumnName("tope");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("estado");

            entity.Property(e => e.IdEstado)
                .ValueGeneratedNever()
                .HasColumnName("id_estado");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("claveSAT");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdZona).HasColumnName("id_zona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_estado02");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_estado01");
        });

        modelBuilder.Entity<EstadoCuentum>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCuenta);

            entity.ToTable("estado_cuenta");

            entity.Property(e => e.IdEstadoCuenta).HasColumnName("id_estado_cuenta");
            entity.Property(e => e.DiaCorte).HasColumnName("dia_corte");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Periodo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("periodo");
            entity.Property(e => e.UnidadesContratadas).HasColumnName("unidades_contratadas");
            entity.Property(e => e.UnidadesPropias).HasColumnName("unidades_propias");
            entity.Property(e => e.Vigencia)
                .HasColumnType("datetime")
                .HasColumnName("vigencia");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.EstadoCuenta)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_estado_cuenta01");
        });

        modelBuilder.Entity<EstatusCancelacion>(entity =>
        {
            entity.HasKey(e => e.IdEstatus).HasName("PK_estatus_cancelacion01");

            entity.ToTable("estatus_cancelacion");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EstatusCatalogo>(entity =>
        {
            entity.HasKey(e => e.Estatus);

            entity.ToTable("estatus_catalogo");

            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<EstatusCatalogoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.Estatus, e.IdIdioma });

            entity.ToTable("estatus_catalogo_idioma");

            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.EstatusCatalogoIdiomas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_estatus_catalogo_idioma03");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.EstatusCatalogoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_estatus_catalogo_idioma02");
        });

        modelBuilder.Entity<EstatusPedido>(entity =>
        {
            entity.HasKey(e => e.IdEstatusPedido).HasName("PK__estatus___F04277080C64A42A");

            entity.ToTable("estatus_pedido");

            entity.Property(e => e.IdEstatusPedido).HasColumnName("id_estatus_pedido");
            entity.Property(e => e.Clave)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EstatusViajeCustom>(entity =>
        {
            entity.HasKey(e => e.IdEstatusViaje);

            entity.ToTable("estatus_viaje_custom");

            entity.Property(e => e.IdEstatusViaje)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus_viaje");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("date")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("date")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
        });

        modelBuilder.Entity<EtiquetaConfigurable>(entity =>
        {
            entity.HasKey(e => new { e.IdEtiqueta, e.IdEmpresa });

            entity.ToTable("etiqueta_configurable");

            entity.Property(e => e.IdEtiqueta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_etiqueta");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.NombreConfigurable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre_configurable");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.EtiquetaConfigurables)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etiqueta_configurable_02");

            entity.HasOne(d => d.IdEtiquetaNavigation).WithMany(p => p.EtiquetaConfigurables)
                .HasForeignKey(d => d.IdEtiqueta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etiqueta_configurable_01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.EtiquetaConfigurableIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etiqueta_configurable_03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.EtiquetaConfigurableIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etiqueta_configurable_04");
        });

        modelBuilder.Entity<EtiquetaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEtiqueta, e.IdIdioma });

            entity.ToTable("etiqueta_idioma");

            entity.Property(e => e.IdEtiqueta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_etiqueta");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.NombreEstandar)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("nombre_estandar");

            entity.HasOne(d => d.IdEtiquetaNavigation).WithMany(p => p.EtiquetaIdiomas)
                .HasForeignKey(d => d.IdEtiqueta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etiqueta_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.EtiquetaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_etiqueta_idioma01");
        });

        modelBuilder.Entity<Etiquetum>(entity =>
        {
            entity.HasKey(e => e.IdEtiqueta);

            entity.ToTable("etiqueta");

            entity.Property(e => e.IdEtiqueta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_etiqueta");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Evidencium>(entity =>
        {
            entity.HasKey(e => e.IdEvidencia).HasName("PK_evidencia01");

            entity.ToTable("evidencia");

            entity.Property(e => e.IdEvidencia)
                .ValueGeneratedNever()
                .HasColumnName("id_evidencia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Evidencia)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_evidencia01");
        });

        modelBuilder.Entity<FactorTipo>(entity =>
        {
            entity.HasKey(e => e.IdFactorTipo).HasName("PK_factor_tipo_id_factor_tipo");

            entity.ToTable("factor_tipo");

            entity.HasIndex(e => e.Clave, "UQ_factor_tipo_clave").IsUnique();

            entity.Property(e => e.IdFactorTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_factor_tipo");
            entity.Property(e => e.Clave)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("clave");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura);

            entity.ToTable("factura");

            entity.Property(e => e.IdFactura)
                .ValueGeneratedNever()
                .HasColumnName("id_factura");
            entity.Property(e => e.ClaveConfirmacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveConfirmacion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdDetraccion).HasColumnName("id_detraccion");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdFormaPagoFact).HasColumnName("id_forma_pago_fact");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdRelacioncobro).HasColumnName("id_relacioncobro");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.MontoDetraccion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("monto_detraccion");
            entity.Property(e => e.MontoFleteReferencial)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("monto_flete_referencial");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoNcargo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_ncargo");
            entity.Property(e => e.MontoNcredito)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_ncredito");
            entity.Property(e => e.MontoPago)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_pago");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("no_cuenta");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("num_factura");
            entity.Property(e => e.PagoDetraccion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pago_detraccion");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdDetraccionNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdDetraccion)
                .HasConstraintName("FK_factura_guia_detraccion");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura01");

            entity.HasOne(d => d.IdFormaPagoFactNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdFormaPagoFact)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_metodo_pago");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura03");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura02");
        });

        modelBuilder.Entity<FacturaEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("factura_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<FacturaEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("factura_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.FacturaEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.FacturaEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_estatus_idioma02");
        });

        modelBuilder.Entity<FacturaPago>(entity =>
        {
            entity.HasKey(e => e.IdPago);

            entity.ToTable("factura_pago");

            entity.Property(e => e.IdPago)
                .ValueGeneratedNever()
                .HasColumnName("id_pago");
            entity.Property(e => e.DepositoMontoAjuste)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("deposito_monto_ajuste");
            entity.Property(e => e.DepositoMontoSaldo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("deposito_monto_saldo");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.Retimbrado).HasColumnName("retimbrado");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.FacturaPagos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_pago01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.FacturaPagoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_pago02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.FacturaPagoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_pago03");

            entity.HasOne(d => d.IdMovimientoNavigation).WithMany(p => p.FacturaPagos)
                .HasForeignKey(d => d.IdMovimiento)
                .HasConstraintName("FK_factura_pago04");
        });

        modelBuilder.Entity<FacturaPagoDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("factura_pago_detalle");

            entity.Property(e => e.DepositoMonto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("deposito_monto");
            entity.Property(e => e.DepositoMontomonedabase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("deposito_montomonedabase");
            entity.Property(e => e.DepositoTipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("deposito_tipo_cambio");
            entity.Property(e => e.GuiaMonto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("guia_monto");
            entity.Property(e => e.GuiaMontoAjuste)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("guia_monto_ajuste");
            entity.Property(e => e.GuiaMontoSaldo)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("guia_monto_saldo");
            entity.Property(e => e.GuiaMontomonedabase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("guia_montomonedabase");
            entity.Property(e => e.GuiaTipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("guia_tipo_cambio");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.IdPagoDetraccion).HasColumnName("id_pago_detraccion");
            entity.Property(e => e.IdPagoElectronico).HasColumnName("id_pago_electronico");
            entity.Property(e => e.TipoDocumento)
                .HasDefaultValueSql("((1))")
                .HasColumnName("tipo_documento");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany()
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_pago_detalle01");

            entity.HasOne(d => d.IdPagoNavigation).WithMany()
                .HasForeignKey(d => d.IdPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_pago_detalle02");
        });

        modelBuilder.Entity<FacturaRelacioncobro>(entity =>
        {
            entity.HasKey(e => e.IdRelacioncobro);

            entity.ToTable("factura_relacioncobro");

            entity.Property(e => e.IdRelacioncobro)
                .ValueGeneratedNever()
                .HasColumnName("id_relacioncobro");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaRelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_relacion");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.NumRelacion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("num_relacion");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.FacturaRelacioncobros)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro01");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.FacturaRelacioncobros)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro02");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.FacturaRelacioncobros)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro03");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.FacturaRelacioncobroIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.FacturaRelacioncobroIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro05");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.FacturaRelacioncobros)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro06");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.FacturaRelacioncobros)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro07");
        });

        modelBuilder.Entity<FacturaRelacioncobroEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("factura_relacioncobro_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<FacturaRelacioncobroEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("factura_relacioncobro_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.FacturaRelacioncobroEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.FacturaRelacioncobroEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_factura_relacioncobro_estatus_idioma02");
        });

        modelBuilder.Entity<FacturaXml>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_factura_xml_id");

            entity.ToTable("factura_xml");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoError).HasColumnName("codigo_error");
            entity.Property(e => e.Enviado).HasColumnName("enviado");
            entity.Property(e => e.FechaConsumo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_consumo");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.KeyProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("key_proveedor");
            entity.Property(e => e.MensajeError)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mensaje_error");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("num_factura");
            entity.Property(e => e.Procesado).HasColumnName("procesado");
            entity.Property(e => e.Xmltimsa)
                .IsUnicode(false)
                .HasColumnName("xmltimsa");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.IdFormaPago).HasName("PK__forma_pa__DA9B39EE443EC0A6");

            entity.ToTable("forma_pago");

            entity.Property(e => e.IdFormaPago)
                .ValueGeneratedNever()
                .HasColumnName("id_forma_pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<FreeTier>(entity =>
        {
            entity.HasKey(e => e.IdApiKey).HasName("pk_free_tier");

            entity.ToTable("free_tier");

            entity.Property(e => e.IdApiKey)
                .ValueGeneratedNever()
                .HasColumnName("id_api_key");
            entity.Property(e => e.Gem20Flash).HasColumnName("gem_2_0_flash");
            entity.Property(e => e.Gem20FlashLite).HasColumnName("gem_2_0_flash_lite");
            entity.Property(e => e.Gem25Flash).HasColumnName("gem_2_5_flash");
            entity.Property(e => e.Gem25FlashLite).HasColumnName("gem_2_5_flash_lite");
            entity.Property(e => e.Gem25Pro).HasColumnName("gem_2_5_pro");

            entity.HasOne(d => d.IdApiKeyNavigation).WithOne(p => p.FreeTier)
                .HasForeignKey<FreeTier>(d => d.IdApiKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_free_tier_api_key_ia");
        });

        modelBuilder.Entity<FuncionIum>(entity =>
        {
            entity.HasKey(e => e.IdFuncionIa).HasName("pk_funcion_ia");

            entity.ToTable("funcion_ia");

            entity.Property(e => e.IdFuncionIa)
                .ValueGeneratedNever()
                .HasColumnName("id_funcion_ia");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdModeloIa).HasColumnName("id_modelo_ia");
            entity.Property(e => e.LimiteInput).HasColumnName("limite_input");
            entity.Property(e => e.LimiteOutput).HasColumnName("limite_output");
            entity.Property(e => e.LimiteRequest).HasColumnName("limite_request");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdModeloIaNavigation).WithMany(p => p.FuncionIa)
                .HasForeignKey(d => d.IdModeloIa)
                .HasConstraintName("fk_funcion_ia_modelo_ia");
        });

        modelBuilder.Entity<GeneralParametro>(entity =>
        {
            entity.HasKey(e => e.IdParametro).HasName("pk_gral_parametros");

            entity.ToTable("general_parametros");

            entity.Property(e => e.IdParametro)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_parametro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Modulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("modulo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<GeneralSitiosFtp>(entity =>
        {
            entity.HasKey(e => e.IdFtp);

            entity.ToTable("general_sitios_ftp");

            entity.Property(e => e.IdFtp).HasColumnName("id_ftp");
            entity.Property(e => e.FtpNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ftp_nombre");
            entity.Property(e => e.FtpPass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ftp_pass");
            entity.Property(e => e.FtpPuerto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ftp_puerto");
            entity.Property(e => e.FtpRuta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ftp_ruta");
            entity.Property(e => e.FtpServer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ftp_server");
            entity.Property(e => e.FtpUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ftp_user");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
        });

        modelBuilder.Entity<GuiaAdendum>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.IdAdenda, e.Consecutivo });

            entity.ToTable("guia_adenda");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Campo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.Valor)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAdendaNavigation).WithMany(p => p.GuiaAdenda)
                .HasForeignKey(d => d.IdAdenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_adenda_02");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaAdenda)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_adenda_01");
        });

        modelBuilder.Entity<GuiaAdicional>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.IdAdicional });

            entity.ToTable("guia_adicional");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdAdicional).HasColumnName("id_adicional");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAdicionalNavigation).WithMany(p => p.GuiaAdicionals)
                .HasForeignKey(d => d.IdAdicional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_adicional02");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaAdicionals)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_adicional01");
        });

        modelBuilder.Entity<GuiaCfdiRelacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guia_cfdi_relacion");

            entity.Property(e => e.FolioFactura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_factura");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdGuiaRelacionada).HasColumnName("id_guia_relacionada");
            entity.Property(e => e.TipoRelacion).HasColumnName("tipo_relacion");
            entity.Property(e => e.Uuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<GuiaConcepto>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.ToTable("guia_concepto");

            entity.Property(e => e.IdConcepto)
                .ValueGeneratedNever()
                .HasColumnName("id_concepto");
            entity.Property(e => e.CodigoProdClickb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("codigo_prod_clickb");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DesglosaIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("desglosa_iva");
            entity.Property(e => e.DesglosaRetencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("desglosa_retencion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdAlmacenClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_almacen_clickb");
            entity.Property(e => e.IdClaveUnidad)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_clave_unidad");
            entity.Property(e => e.IdClaveprodserv)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_claveprodserv");
            entity.Property(e => e.IdEmbalaje).HasColumnName("id_embalaje");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdObjetoImpuesto)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.IdProductoClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_producto_clickb");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");

            entity.HasOne(d => d.IdClaveUnidadNavigation).WithMany(p => p.GuiaConceptos)
                .HasForeignKey(d => d.IdClaveUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_concepto05");

            entity.HasOne(d => d.IdClaveprodservNavigation).WithMany(p => p.GuiaConceptos)
                .HasForeignKey(d => d.IdClaveprodserv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_concepto04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.GuiaConceptos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_concepto01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.GuiaConceptoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_concepto02");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.GuiaConceptoIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idIVA");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.GuiaConceptoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_concepto03");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.GuiaConceptoIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_concepto_id_retencion");
        });

        modelBuilder.Entity<GuiaCuotasPeru>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.Consecutivo }).HasName("PK__guia_cuo__58A7E9B35412F484");

            entity.ToTable("guia_cuotas_peru");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaCuotasPerus)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__guia_cuot__id_gu__5EE9FC26");
        });

        modelBuilder.Entity<GuiaDetraccion>(entity =>
        {
            entity.HasKey(e => e.IdDetraccion);

            entity.ToTable("guia_detraccion");

            entity.Property(e => e.IdDetraccion)
                .ValueGeneratedNever()
                .HasColumnName("id_detraccion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FleteReferencial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flete_referencial");
            entity.Property(e => e.Minimo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("minimo");
            entity.Property(e => e.NumDetraccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("num_detraccion");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("porcentaje");
        });

        modelBuilder.Entity<GuiaEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("guia_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<GuiaEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("guia_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.GuiaEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.GuiaEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_estatus_idioma02");
        });

        modelBuilder.Entity<GuiaEvidenciaFoto>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.IdEvidencia, e.Consecutivo }).HasName("PK_guia_evidencia_foto01");

            entity.ToTable("guia_evidencia_foto");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdEvidencia).HasColumnName("id_evidencia");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Foto)
                .IsUnicode(false)
                .HasColumnName("foto");
            entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");
            entity.Property(e => e.IdFoto).HasColumnName("id_foto");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.IdArchivoNavigation).WithMany(p => p.GuiaEvidenciaFotos)
                .HasForeignKey(d => d.IdArchivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_guia_evidencia_foto_archivo");

            entity.HasOne(d => d.Id).WithMany(p => p.GuiaEvidenciaFotos)
                .HasForeignKey(d => new { d.IdGuia, d.IdEvidencia })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_evidencia_foto01");
        });

        modelBuilder.Entity<GuiaEvidencium>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.IdEvidencia }).HasName("PK_guia_evidencia01");

            entity.ToTable("guia_evidencia");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdEvidencia).HasColumnName("id_evidencia");
            entity.Property(e => e.Entregado).HasColumnName("entregado");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.GuiaEvidencia)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_evidencia02");

            entity.HasOne(d => d.IdEvidenciaNavigation).WithMany(p => p.GuiaEvidencia)
                .HasForeignKey(d => d.IdEvidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_evidencia01");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaEvidencia)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_evidencia03");
        });

        modelBuilder.Entity<GuiaOtro>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.Consecutivo });

            entity.ToTable("guia_otros");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CartaPorte)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("carta_porte");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FactorResico)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_resico");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdObjetoImpuesto).HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoResico)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_resico");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.PkGuiaOtros).HasColumnName("PK_guia_otros");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.GuiaOtros)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_otros01");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaOtros)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_otros02");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.GuiaOtros)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_otros_id_retencion");
        });

        modelBuilder.Entity<GuiaProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.Consecutivo });

            entity.ToTable("guia_producto");

            entity.HasIndex(e => e.IdGuia, "IX_guia_producto_id_guia");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FolioDocumentoAduanero)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_documento_aduanero");
            entity.Property(e => e.IdDestinatarioProd).HasColumnName("id_destinatario_prod");
            entity.Property(e => e.IdDestino).HasColumnName("id_destino");
            entity.Property(e => e.IdDocumentoAduanero).HasColumnName("id_documento_aduanero");
            entity.Property(e => e.IdEmbalaje).HasColumnName("id_embalaje");
            entity.Property(e => e.IdFraccionArancelaria).HasColumnName("id_fraccion_arancelaria");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdRemitenteProd).HasColumnName("id_remitente_prod");
            entity.Property(e => e.IdUnidadClave).HasColumnName("id_unidad_clave");
            entity.Property(e => e.IdUnidadMedidaPeso).HasColumnName("id_unidad_medida_peso");
            entity.Property(e => e.IdUnidadMedidaPesoBase).HasColumnName("id_unidad_medida_peso_base");
            entity.Property(e => e.IdUnidadMedidaVolumen).HasColumnName("id_unidad_medida_volumen");
            entity.Property(e => e.IdUnidadMedidaVolumenBase).HasColumnName("id_unidad_medida_volumen_base");
            entity.Property(e => e.KmRecorridos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("km_recorridos");
            entity.Property(e => e.Pedimento)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("pedimento");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso");
            entity.Property(e => e.PesoBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_base");
            entity.Property(e => e.PesoKg)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_kg");
            entity.Property(e => e.RfcImportador)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("rfc_importador");
            entity.Property(e => e.UuidCemercioExt)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("uuid_cemercio_ext");
            entity.Property(e => e.ValorMercancia)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("valor_mercancia");
            entity.Property(e => e.Volumen)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen");
            entity.Property(e => e.VolumenBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen_base");

            entity.HasOne(d => d.IdEmbalajeNavigation).WithMany(p => p.GuiaProductos)
                .HasForeignKey(d => d.IdEmbalaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto01");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaProductos)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto02");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.GuiaProductos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto03");

            entity.HasOne(d => d.IdUnidadMedidaPesoNavigation).WithMany(p => p.GuiaProductoIdUnidadMedidaPesoNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaPeso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto05");

            entity.HasOne(d => d.IdUnidadMedidaPesoBaseNavigation).WithMany(p => p.GuiaProductoIdUnidadMedidaPesoBaseNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaPesoBase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto06");

            entity.HasOne(d => d.IdUnidadMedidaVolumenNavigation).WithMany(p => p.GuiaProductoIdUnidadMedidaVolumenNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaVolumen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto04");

            entity.HasOne(d => d.IdUnidadMedidaVolumenBaseNavigation).WithMany(p => p.GuiaProductoIdUnidadMedidaVolumenBaseNavigations)
                .HasForeignKey(d => d.IdUnidadMedidaVolumenBase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto07");
        });

        modelBuilder.Entity<GuiaProductoIdentificacion>(entity =>
        {
            entity.HasKey(e => new { e.IdGuia, e.Consecutivo }).HasName("PK_guia_producto_identificacion01");

            entity.ToTable("guia_producto_identificacion");

            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.DescripcionGuiaIdentificacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion_guia_identificacion");
            entity.Property(e => e.IdDestino).HasColumnName("id_destino");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.NumGuiaIdentificacion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("num_guia_identificacion");
            entity.Property(e => e.PesoGuiaIdentificacion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_guia_identificacion");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.GuiaProductoIdentificacions)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_producto_identificacion_id_guia");
        });

        modelBuilder.Entity<GuiaRegimenAduanero>(entity =>
        {
            entity.HasKey(e => e.IdRegimenAduanero).HasName("PK__guia_reg__9182FFA16F418FC3");

            entity.ToTable("guia_regimen_aduanero");

            entity.Property(e => e.IdRegimenAduanero).HasColumnName("id_regimen_aduanero");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Entrada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("entrada");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.ImpoExpo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("impo_expo");
            entity.Property(e => e.Salida)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("salida");
        });

        modelBuilder.Entity<GuiaTipoCobro>(entity =>
        {
            entity.HasKey(e => e.IdTipoCobro);

            entity.ToTable("guia_tipo_cobro");

            entity.Property(e => e.IdTipoCobro)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_cobro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<GuiaTipoCobroIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoCobro, e.IdIdioma });

            entity.ToTable("guia_tipo_cobro_idioma");

            entity.Property(e => e.IdTipoCobro).HasColumnName("id_tipo_cobro");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.GuiaTipoCobroIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_tipo_cobro_idioma01");

            entity.HasOne(d => d.IdTipoCobroNavigation).WithMany(p => p.GuiaTipoCobroIdiomas)
                .HasForeignKey(d => d.IdTipoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_tipo_cobro_idioma02");
        });

        modelBuilder.Entity<GuiaTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento);

            entity.ToTable("guia_tipo_documento");

            entity.Property(e => e.IdTipoDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_documento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<GuiaTipoDocumentoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoDocumento, e.IdIdioma });

            entity.ToTable("guia_tipo_documento_idioma");

            entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipo_documento");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.GuiaTipoDocumentoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_tipo_documento_idioma01");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.GuiaTipoDocumentoIdiomas)
                .HasForeignKey(d => d.IdTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_tipo_documento_idioma02");
        });

        modelBuilder.Entity<GuiaTituloAdicional>(entity =>
        {
            entity.HasKey(e => e.IdAdicional);

            entity.ToTable("guia_titulo_adicional");

            entity.Property(e => e.IdAdicional)
                .ValueGeneratedNever()
                .HasColumnName("id_adicional");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.GuiaTituloAdicionals)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_titulo_adicional02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.GuiaTituloAdicionals)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_titulo_adicional01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.GuiaTituloAdicionalIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_titulo_adicional03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.GuiaTituloAdicionalIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia_titulo_adicional04");
        });

        modelBuilder.Entity<GuiaUbicPoloIstmo>(entity =>
        {
            entity.HasKey(e => e.IdUbicPoloIstmo).HasName("PK__guia_ubi__6CC347074DD5204F");

            entity.ToTable("guia_ubic_polo_ISTMO");

            entity.Property(e => e.IdUbicPoloIstmo).HasColumnName("id_ubic_polo_ISTMO");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<GuiaViaje>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guia_viaje");

            entity.Property(e => e.IdConfiguracionVehicular).HasColumnName("id_configuracion_vehicular");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.IdRemolque).HasColumnName("id_remolque");
            entity.Property(e => e.IdSegundoOperador).HasColumnName("id_segundo_operador");
            entity.Property(e => e.IdSegundoRemolque).HasColumnName("id_segundo_remolque");
            entity.Property(e => e.IdTipoPermisoSct).HasColumnName("id_tipo_permiso_sct");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.NumeroPermisoSct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_permiso_sct");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_bruto_vehicular");

            entity.HasOne(d => d.IdConfiguracionVehicularNavigation).WithMany()
                .HasForeignKey(d => d.IdConfiguracionVehicular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKConfiguracion_vehicular");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany()
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKGuia");

            entity.HasOne(d => d.IdOperadorNavigation).WithMany()
                .HasForeignKey(d => d.IdOperador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKOperador");

            entity.HasOne(d => d.IdRemolqueNavigation).WithMany()
                .HasForeignKey(d => d.IdRemolque)
                .HasConstraintName("FKRemolque");

            entity.HasOne(d => d.IdSegundoOperadorNavigation).WithMany()
                .HasForeignKey(d => d.IdSegundoOperador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKSegundo_operador");

            entity.HasOne(d => d.IdSegundoRemolqueNavigation).WithMany()
                .HasForeignKey(d => d.IdSegundoRemolque)
                .HasConstraintName("FKSegundo_remolque");

            entity.HasOne(d => d.IdTipoPermisoSctNavigation).WithMany()
                .HasForeignKey(d => d.IdTipoPermisoSct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKTipo_permiso_sct");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany()
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKUnidad");
        });

        modelBuilder.Entity<Guium>(entity =>
        {
            entity.HasKey(e => e.IdGuia);

            entity.ToTable("guia");

            entity.HasIndex(e => e.IdViaje, "IX_guia_id_viaje");

            entity.HasIndex(e => new { e.NumGuia, e.IdEmpresa }, "XAK_guia01").IsUnique();

            entity.HasIndex(e => e.IdViaje, "i_guia_id_viaje");

            entity.Property(e => e.IdGuia)
                .ValueGeneratedNever()
                .HasColumnName("id_guia");
            entity.Property(e => e.AseguraCarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asegura_carga");
            entity.Property(e => e.AseguraMedAmbiente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asegura_med_ambiente");
            entity.Property(e => e.Autopistas)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("autopistas");
            entity.Property(e => e.CFletePorGuia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("c_flete_por_guia");
            entity.Property(e => e.CantidadProductos).HasColumnName("cantidad_productos");
            entity.Property(e => e.ClaveConfirmacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveConfirmacion");
            entity.Property(e => e.CodigoVenta)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codigo_venta");
            entity.Property(e => e.Contenedores)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("contenedores");
            entity.Property(e => e.CpEnviadaRoutech)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("cp_enviada_routech");
            entity.Property(e => e.CuentaBancoNacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("cuenta_banco_nacion");
            entity.Property(e => e.DescripcionFlete)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("descripcion_flete");
            entity.Property(e => e.EntSalida)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ent_salida");
            entity.Property(e => e.EntregarEn)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("entregar_en");
            entity.Property(e => e.EstatusCancelacion).HasColumnName("estatus_cancelacion");
            entity.Property(e => e.EstatusSac).HasColumnName("estatus_sac");
            entity.Property(e => e.FactorCobro)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("factor_cobro");
            entity.Property(e => e.FacturaAnticipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("factura_anticipo");
            entity.Property(e => e.Facturado).HasColumnName("facturado");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaAceptacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_aceptacion");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaCita)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_cita");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaSolicitudCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_solicitud_cancelacion");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.Flete)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("flete");
            entity.Property(e => e.FleteLiquidacion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("flete_liquidacion");
            entity.Property(e => e.FolioClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_clickb");
            entity.Property(e => e.HoraCita)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hora_cita");
            entity.Property(e => e.IdAgenteClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("id_agente_clickb");
            entity.Property(e => e.IdClaveUnidadAutopista)
                .HasDefaultValueSql("((2))")
                .HasColumnName("id_clave_unidad_autopista");
            entity.Property(e => e.IdClaveUnidadFlete)
                .HasDefaultValueSql("((2))")
                .HasColumnName("id_clave_unidad_flete");
            entity.Property(e => e.IdClaveUnidadManiobras)
                .HasDefaultValueSql("((2))")
                .HasColumnName("id_clave_unidad_maniobras");
            entity.Property(e => e.IdClaveUnidadSeguro)
                .HasDefaultValueSql("((2))")
                .HasColumnName("id_clave_unidad_seguro");
            entity.Property(e => e.IdClaveprodservAutopista)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_claveprodserv_autopista");
            entity.Property(e => e.IdClaveprodservFlete)
                .HasDefaultValueSql("((28))")
                .HasColumnName("id_claveprodserv_flete");
            entity.Property(e => e.IdClaveprodservManiobras)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_claveprodserv_maniobras");
            entity.Property(e => e.IdClaveprodservSeguro)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_claveprodserv_seguro");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");
            entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");
            entity.Property(e => e.IdDetraccion).HasColumnName("id_detraccion");
            entity.Property(e => e.IdDireccionEntClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("id_direccion_ent_clickb");
            entity.Property(e => e.IdDocumentoClickb).HasColumnName("id_documento_clickb");
            entity.Property(e => e.IdEmbarcadorPe).HasColumnName("id_embarcador_pe");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEntregaEn).HasColumnName("id_entrega_en");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdEstatusClickb).HasColumnName("id_estatus_clickb");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdFacturarelacionada).HasColumnName("id_facturarelacionada");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdFormaPagoGcp).HasColumnName("id_forma_pago_gcp");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdLocalRetencion).HasColumnName("id_local_retencion");
            entity.Property(e => e.IdMedioPago).HasColumnName("id_medio_pago");
            entity.Property(e => e.IdMeses).HasColumnName("id_meses");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdMetodopagoSat).HasColumnName("id_metodopago_sat");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdMotivoCancelacion).HasColumnName("id_motivo_cancelacion");
            entity.Property(e => e.IdObjetoImpuesto).HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("id_periodicidad");
            entity.Property(e => e.IdPlazaDestino).HasColumnName("id_plaza_destino");
            entity.Property(e => e.IdPlazaEmision).HasColumnName("id_plaza_emision");
            entity.Property(e => e.IdPlazaOrigen).HasColumnName("id_plaza_origen");
            entity.Property(e => e.IdRecogerEn).HasColumnName("id_recoger_en");
            entity.Property(e => e.IdRegimenAduanero).HasColumnName("id_regimen_aduanero");
            entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");
            entity.Property(e => e.IdResico).HasColumnName("id_resico");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipoCobro).HasColumnName("id_tipo_cobro");
            entity.Property(e => e.IdTipoDocumento).HasColumnName("id_tipo_documento");
            entity.Property(e => e.IdTipoOperacion).HasColumnName("id_tipo_operacion");
            entity.Property(e => e.IdTipoPagoClickb).HasColumnName("id_tipo_pago_clickb");
            entity.Property(e => e.IdTipodocClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("id_tipodoc_clickb");
            entity.Property(e => e.IdUbicacionPoloDestino).HasColumnName("id_ubicacion_polo_destino");
            entity.Property(e => e.IdUbicacionPoloOrigen).HasColumnName("id_ubicacion_polo_origen");
            entity.Property(e => e.IdUsoCfdi).HasColumnName("id_usoCFDI");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.IdguiaRelacionCancelacion).HasColumnName("idguia_relacion_cancelacion");
            entity.Property(e => e.IsComplementoCp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("is_complementoCP");
            entity.Property(e => e.LogisticaInversa).HasColumnName("logistica_inversa");
            entity.Property(e => e.Maniobras)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("maniobras");
            entity.Property(e => e.MaterialPeligroso).HasColumnName("material_peligroso");
            entity.Property(e => e.MontoDetraccion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("monto_detraccion");
            entity.Property(e => e.MontoFleteReferencial)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("monto_flete_referencial");
            entity.Property(e => e.MontoIndemnizacion)
                .HasColumnType("decimal(16, 8)")
                .HasColumnName("monto_indemnizacion");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoLocalRetencion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("monto_local_retencion");
            entity.Property(e => e.MontoResico)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_resico");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("motivo_cancelacion");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("no_cuenta");
            entity.Property(e => e.NombreTipodocClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_tipodoc_clickb");
            entity.Property(e => e.NumGuia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_guia");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OrdenImpresion).HasColumnName("orden_impresion");
            entity.Property(e => e.Otros)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("otros");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_bruto_vehicular");
            entity.Property(e => e.PesoTotalProductos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_total_productos");
            entity.Property(e => e.PolizaSegCarga)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("poliza_seg_carga");
            entity.Property(e => e.PolizaSegMedAmbiente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("poliza_seg_med_ambiente");
            entity.Property(e => e.PrimaSeguroCarga)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("prima_seguro_carga");
            entity.Property(e => e.RecogerEn)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("recoger_en");
            entity.Property(e => e.Referencia)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.ReferenciasAdicionales)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("referencias_adicionales");
            entity.Property(e => e.RegistroIstmo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("registro_ISTMO");
            entity.Property(e => e.Remolque).HasColumnName("remolque");
            entity.Property(e => e.Seguro)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("seguro");
            entity.Property(e => e.SerieClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("serie_clickb");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SustituyeDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sustituye_documento");
            entity.Property(e => e.Timbrando).HasColumnName("timbrando");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.TipoExportacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("tipo_exportacion");
            entity.Property(e => e.TransInternacional)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("trans_internacional");
            entity.Property(e => e.UuidRelacionCancelacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uuid_relacion_cancelacion");
            entity.Property(e => e.ValorDeclarado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("valor_declarado");

            entity.HasOne(d => d.IdClaveUnidadAutopistaNavigation).WithMany(p => p.GuiumIdClaveUnidadAutopistaNavigations)
                .HasForeignKey(d => d.IdClaveUnidadAutopista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia28");

            entity.HasOne(d => d.IdClaveUnidadFleteNavigation).WithMany(p => p.GuiumIdClaveUnidadFleteNavigations)
                .HasForeignKey(d => d.IdClaveUnidadFlete)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia27");

            entity.HasOne(d => d.IdClaveUnidadManiobrasNavigation).WithMany(p => p.GuiumIdClaveUnidadManiobrasNavigations)
                .HasForeignKey(d => d.IdClaveUnidadManiobras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia29");

            entity.HasOne(d => d.IdClaveUnidadSeguroNavigation).WithMany(p => p.GuiumIdClaveUnidadSeguroNavigations)
                .HasForeignKey(d => d.IdClaveUnidadSeguro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia30");

            entity.HasOne(d => d.IdClaveprodservManiobrasNavigation).WithMany(p => p.GuiumIdClaveprodservManiobrasNavigations)
                .HasForeignKey(d => d.IdClaveprodservManiobras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia25");

            entity.HasOne(d => d.IdClaveprodservSeguroNavigation).WithMany(p => p.GuiumIdClaveprodservSeguroNavigations)
                .HasForeignKey(d => d.IdClaveprodservSeguro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia26");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.GuiumIdClienteNavigations)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia01");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia21");

            entity.HasOne(d => d.IdDestinatarioNavigation).WithMany(p => p.GuiumIdDestinatarioNavigations)
                .HasForeignKey(d => d.IdDestinatario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia02");

            entity.HasOne(d => d.IdDetraccionNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdDetraccion)
                .HasConstraintName("FK_guia_guia_detraccion");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia03");

            entity.HasOne(d => d.IdEntregaEnNavigation).WithMany(p => p.GuiumIdEntregaEnNavigations)
                .HasForeignKey(d => d.IdEntregaEn)
                .HasConstraintName("FK_guia23");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia04");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia05");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.GuiumIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia07");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.GuiumIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia08");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia22");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.GuiumIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia09");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia10");

            entity.HasOne(d => d.IdPlazaDestinoNavigation).WithMany(p => p.GuiumIdPlazaDestinoNavigations)
                .HasForeignKey(d => d.IdPlazaDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia11");

            entity.HasOne(d => d.IdPlazaEmisionNavigation).WithMany(p => p.GuiumIdPlazaEmisionNavigations)
                .HasForeignKey(d => d.IdPlazaEmision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia12");

            entity.HasOne(d => d.IdPlazaOrigenNavigation).WithMany(p => p.GuiumIdPlazaOrigenNavigations)
                .HasForeignKey(d => d.IdPlazaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia13");

            entity.HasOne(d => d.IdRecogerEnNavigation).WithMany(p => p.GuiumIdRecogerEnNavigations)
                .HasForeignKey(d => d.IdRecogerEn)
                .HasConstraintName("FK_guia24");

            entity.HasOne(d => d.IdRemitenteNavigation).WithMany(p => p.GuiumIdRemitenteNavigations)
                .HasForeignKey(d => d.IdRemitente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia14");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.GuiumIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia15");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia20");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia16");

            entity.HasOne(d => d.IdTipoCobroNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdTipoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia17");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia18");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_guia19");
        });

        modelBuilder.Entity<HDisponibilidad>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUnidad, e.FechaIni });

            entity.ToTable("h_disponibilidad", "PowerLISTMS");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_empresa");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_unidad");
            entity.Property(e => e.FechaIni)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ini");
            entity.Property(e => e.DiasMes).HasColumnName("dias_mes");
            entity.Property(e => e.DiasTaller).HasColumnName("dias_taller");
            entity.Property(e => e.DiasTrabajados).HasColumnName("dias_trabajados");
            entity.Property(e => e.EntradasATaller).HasColumnName("entradas_a_taller");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.PkDisponibilidad)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pk_disponibilidad");
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasKey(e => e.IdIdioma);

            entity.ToTable("idioma");

            entity.Property(e => e.IdIdioma)
                .ValueGeneratedNever()
                .HasColumnName("id_idioma");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Idiomas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_idioma01");
        });

        modelBuilder.Entity<Iep>(entity =>
        {
            entity.HasKey(e => e.IdIeps);

            entity.ToTable("ieps");

            entity.Property(e => e.IdIeps)
                .ValueGeneratedNever()
                .HasColumnName("id_ieps");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.FactorIeps)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_ieps");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdCombustible).HasColumnName("id_combustible");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Periodo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("periodo");

            entity.HasOne(d => d.IdCombustibleNavigation).WithMany(p => p.Ieps)
                .HasForeignKey(d => d.IdCombustible)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ieps01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.IepIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ieps02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.IepIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ieps03");
        });

        modelBuilder.Entity<Imagene>(entity =>
        {
            entity.HasKey(e => e.IdImagen);

            entity.ToTable("imagenes");

            entity.Property(e => e.IdImagen)
                .ValueGeneratedNever()
                .HasColumnName("id_imagen");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.ImagenBase64)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("imagen_base64");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Imagenes)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagenes04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Imagenes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagenes01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ImageneIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagenes02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ImageneIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_imagenes03");
        });

        modelBuilder.Entity<Impresion>(entity =>
        {
            entity.HasKey(e => e.IdImpresion);

            entity.ToTable("impresion");

            entity.Property(e => e.IdImpresion)
                .ValueGeneratedNever()
                .HasColumnName("id_impresion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<ImpresionDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdImpresion, e.Consecutivo });

            entity.ToTable("impresion_detalle");

            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Alinear).HasColumnName("alinear");
            entity.Property(e => e.Alto).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Border).HasColumnName("border");
            entity.Property(e => e.Cantidadconletra).HasColumnName("cantidadconletra");
            entity.Property(e => e.Detalle).HasColumnName("detalle");
            entity.Property(e => e.Espacioizq)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("espacioizq");
            entity.Property(e => e.Espaciotop)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("espaciotop");
            entity.Property(e => e.Formato)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.IdImagen).HasColumnName("id_imagen");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.Imprimircero).HasColumnName("imprimircero");
            entity.Property(e => e.Negrita).HasColumnName("negrita");
            entity.Property(e => e.NoPagina).HasColumnName("no_pagina");
            entity.Property(e => e.NombreExterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_externo");
            entity.Property(e => e.NombreInterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_interno");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PosicionX)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("posicionX");
            entity.Property(e => e.PosicionY)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("posicionY");
            entity.Property(e => e.Renglones).HasColumnName("renglones");
            entity.Property(e => e.Requerido).HasColumnName("requerido");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Texto).HasColumnName("texto");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo_dato");

            entity.HasOne(d => d.IdImagenNavigation).WithMany(p => p.ImpresionDetalles)
                .HasForeignKey(d => d.IdImagen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_detalle_01");

            entity.HasOne(d => d.IdImpresionNavigation).WithMany(p => p.ImpresionDetalles)
                .HasForeignKey(d => d.IdImpresion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_detalle01");

            entity.HasOne(d => d.Id).WithMany(p => p.ImpresionDetalles)
                .HasForeignKey(d => new { d.IdImpresion, d.IdSeccion })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_detalle02");
        });

        modelBuilder.Entity<ImpresionDetalleIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdIdioma, e.IdImpresion, e.Consecutivo });

            entity.ToTable("impresion_detalle_idioma");

            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ImpresionDetalleIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_detalle_idioma_01");

            entity.HasOne(d => d.IdI).WithMany(p => p.ImpresionDetalleIdiomas)
                .HasForeignKey(d => new { d.IdIdioma, d.IdImpresion })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_detalle_idioma_03");

            entity.HasOne(d => d.ImpresionDetalle).WithMany(p => p.ImpresionDetalleIdiomas)
                .HasForeignKey(d => new { d.IdImpresion, d.Consecutivo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_detalle_idioma_02");
        });

        modelBuilder.Entity<ImpresionIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdIdioma, e.IdImpresion });

            entity.ToTable("impresion_idioma");

            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ImpresionIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_idioma_01");

            entity.HasOne(d => d.IdImpresionNavigation).WithMany(p => p.ImpresionIdiomas)
                .HasForeignKey(d => d.IdImpresion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_idioma_02");
        });

        modelBuilder.Entity<ImpresionSeccione>(entity =>
        {
            entity.HasKey(e => new { e.IdImpresion, e.IdSeccion });

            entity.ToTable("impresion_secciones");

            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Orden).HasColumnName("orden");

            entity.HasOne(d => d.IdImpresionNavigation).WithMany(p => p.ImpresionSecciones)
                .HasForeignKey(d => d.IdImpresion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_secciones01");
        });

        modelBuilder.Entity<ImpresionSeccionesIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdIdioma, e.IdImpresion, e.IdSeccion });

            entity.ToTable("impresion_secciones_idioma");

            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ImpresionSeccionesIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_secciones_idioma_01");

            entity.HasOne(d => d.IdImpresionNavigation).WithMany(p => p.ImpresionSeccionesIdiomas)
                .HasForeignKey(d => d.IdImpresion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_secciones_idioma_02");
        });

        modelBuilder.Entity<ImpresionVistaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdVista, e.Consecutivo });

            entity.ToTable("impresion_vista_detalle");

            entity.Property(e => e.IdVista).HasColumnName("id_vista");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Alinear).HasColumnName("alinear");
            entity.Property(e => e.Alto).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Ancho).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Border).HasColumnName("border");
            entity.Property(e => e.Cantidadconletra).HasColumnName("cantidadconletra");
            entity.Property(e => e.Detalle).HasColumnName("detalle");
            entity.Property(e => e.Espacioizq)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("espacioizq");
            entity.Property(e => e.Espaciotop)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("espaciotop");
            entity.Property(e => e.Formato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.IdImagen).HasColumnName("id_imagen");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.Imprimircero).HasColumnName("imprimircero");
            entity.Property(e => e.Negrita).HasColumnName("negrita");
            entity.Property(e => e.NoPagina).HasColumnName("no_pagina");
            entity.Property(e => e.NombreExterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_externo");
            entity.Property(e => e.NombreInterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_interno");
            entity.Property(e => e.PosicionX).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PosicionY).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Renglones).HasColumnName("renglones");
            entity.Property(e => e.Requerido).HasColumnName("requerido");
            entity.Property(e => e.Texto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("texto");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_dato");

            entity.HasOne(d => d.IdImagenNavigation).WithMany(p => p.ImpresionVistaDetalles)
                .HasForeignKey(d => d.IdImagen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impresion_vista_detalle_01");
        });

        modelBuilder.Entity<ImpresionVistum>(entity =>
        {
            entity.HasKey(e => e.IdVista);

            entity.ToTable("impresion_vista");

            entity.Property(e => e.IdVista)
                .ValueGeneratedNever()
                .HasColumnName("id_vista");
            entity.Property(e => e.Alto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("alto");
            entity.Property(e => e.Ancho)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ancho");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.Medida).HasColumnName("medida");
            entity.Property(e => e.NoPaginas).HasColumnName("no_paginas");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoLetra)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tipo_letra");
            entity.Property(e => e.TipoPapel).HasColumnName("tipo_papel");
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.HasKey(e => e.IdImpuesto);

            entity.ToTable("impuesto");

            entity.Property(e => e.IdImpuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_impuesto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Factor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IsObjetoDeIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("is_objeto_de_iva");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.Impuestos)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impuesto01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ImpuestoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impuesto02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ImpuestoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impuesto03");
        });

        modelBuilder.Entity<ImpuestoClasificacion>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion);

            entity.ToTable("impuesto_clasificacion");

            entity.Property(e => e.IdClasificacion)
                .ValueGeneratedNever()
                .HasColumnName("id_clasificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ImpuestoClasificacionIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdClasificacion, e.IdIdioma });

            entity.ToTable("impuesto_clasificacion_idioma");

            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.ImpuestoClasificacionIdiomas)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impuesto_clasificacion_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ImpuestoClasificacionIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_impuesto_clasificacion_idioma02");
        });

        modelBuilder.Entity<ImpuestoImpuesto>(entity =>
        {
            entity.HasKey(e => e.IdImpuesto).HasName("PK_impuesto_impuesto_id_impuesto");

            entity.ToTable("impuesto_impuesto");

            entity.HasIndex(e => e.Clave, "UQ_impuesto_impuesto_clave").IsUnique();

            entity.Property(e => e.IdImpuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_impuesto");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<InterfaceConfiguracion>(entity =>
        {
            entity.HasKey(e => e.IdInterface);

            entity.ToTable("interface_configuracion");

            entity.Property(e => e.IdInterface)
                .ValueGeneratedNever()
                .HasColumnName("id_interface");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaSiguiente)
                .HasColumnType("datetime")
                .HasColumnName("fecha_siguiente");
            entity.Property(e => e.Frecuencia).HasColumnName("frecuencia");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoFrecuencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_frecuencia");
            entity.Property(e => e.UrlApi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("url_api");
        });

        modelBuilder.Entity<InterfazProveedoresGp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_interfaz_proveedores_gps01");

            entity.ToTable("interfaz_proveedores_gps");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ConfigurarContrasenia).HasColumnName("configurar_contrasenia");
            entity.Property(e => e.ConfigurarEmpresa).HasColumnName("configurar_empresa");
            entity.Property(e => e.ConfigurarFecha).HasColumnName("configurar_fecha");
            entity.Property(e => e.ConfigurarToken).HasColumnName("configurar_token");
            entity.Property(e => e.ConfigurarUsuario).HasColumnName("configurar_usuario");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.RutaImagen)
                .IsUnicode(false)
                .HasColumnName("ruta_imagen");
            entity.Property(e => e.Webservice)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("webservice");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.InterfazProveedoresGps)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_interfaz_proveedores_gps01");
        });

        modelBuilder.Entity<Liquidacion>(entity =>
        {
            entity.HasKey(e => e.IdLiquidacion);

            entity.ToTable("liquidacion");

            entity.Property(e => e.IdLiquidacion)
                .ValueGeneratedNever()
                .HasColumnName("id_liquidacion");
            entity.Property(e => e.ActualizaUnidad).HasColumnName("actualiza_unidad");
            entity.Property(e => e.ClaveConfirmacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveConfirmacion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaFinal)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInicial)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicial");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FolioComprobacionGastoCb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_comprobacion_gasto_cb");
            entity.Property(e => e.IdAsociadoDeudorClickb).HasColumnName("id_asociado_deudor_clickb");
            entity.Property(e => e.IdComprobacionGastoCb).HasColumnName("id_comprobacion_gasto_cb");
            entity.Property(e => e.IdConvenioLiquidacion).HasColumnName("id_convenio_liquidacion");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdPersonal).HasColumnName("id_personal");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipoAdeudo).HasColumnName("id_tipo_adeudo");
            entity.Property(e => e.IdTipoComprobacionGastoClickb).HasColumnName("id_tipo_comprobacion_gasto_clickb");
            entity.Property(e => e.IdTipoSueldo).HasColumnName("id_tipo_sueldo");
            entity.Property(e => e.IdTipoViaje).HasColumnName("id_tipo_viaje");
            entity.Property(e => e.IdTiponomina)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_tiponomina");
            entity.Property(e => e.IdUnidadMotriz).HasColumnName("id_unidad_motriz");
            entity.Property(e => e.IdUsuarioCancelo).HasColumnName("id_usuario_cancelo");
            entity.Property(e => e.IdUsuarioPago).HasColumnName("id_usuario_pago");
            entity.Property(e => e.Imss)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("IMSS");
            entity.Property(e => e.Infonavit)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("infonavit");
            entity.Property(e => e.Isr)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("isr");
            entity.Property(e => e.MontoAnticipo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_anticipo");
            entity.Property(e => e.MontoGasto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_gasto");
            entity.Property(e => e.MontoPercepcion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_percepcion");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.MotorElectrico).HasColumnName("motor_electrico");
            entity.Property(e => e.NumLiquidacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_liquidacion");
            entity.Property(e => e.Numdiaspagados)
                .HasDefaultValueSql("((1))")
                .HasColumnName("numdiaspagados");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OdometroFinal).HasColumnName("odometro_final");
            entity.Property(e => e.OdometroInicial).HasColumnName("odometro_inicial");
            entity.Property(e => e.OtrasDeducciones)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("otras_deducciones");
            entity.Property(e => e.OtrasPercepciones)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("otras_percepciones");
            entity.Property(e => e.ReferenciaAdeudo).HasColumnName("referencia_adeudo");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");
            entity.Property(e => e.RendReseteo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rend_reseteo");
            entity.Property(e => e.Rendimiento)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rendimiento");
            entity.Property(e => e.SubsidioEmpleo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subsidio_empleo");
            entity.Property(e => e.TotalKilometros)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_kilometros");
            entity.Property(e => e.TotalViajes).HasColumnName("total_viajes");

            entity.HasOne(d => d.IdConvenioLiquidacionNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdConvenioLiquidacion)
                .HasConstraintName("FK_liquidacion13");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion02");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.LiquidacionIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion05");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.LiquidacionIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion06");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion10");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion03");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion07");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion12");

            entity.HasOne(d => d.IdTipoAdeudoNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdTipoAdeudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion11");

            entity.HasOne(d => d.IdTiponominaNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdTiponomina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion14");

            entity.HasOne(d => d.IdUnidadMotrizNavigation).WithMany(p => p.Liquidacions)
                .HasForeignKey(d => d.IdUnidadMotriz)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion04");

            entity.HasOne(d => d.IdUsuarioCanceloNavigation).WithMany(p => p.LiquidacionIdUsuarioCanceloNavigations)
                .HasForeignKey(d => d.IdUsuarioCancelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion09");

            entity.HasOne(d => d.IdUsuarioPagoNavigation).WithMany(p => p.LiquidacionIdUsuarioPagoNavigations)
                .HasForeignKey(d => d.IdUsuarioPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion08");
        });

        modelBuilder.Entity<LiquidacionConcepto>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.ToTable("liquidacion_concepto");

            entity.Property(e => e.IdConcepto)
                .ValueGeneratedNever()
                .HasColumnName("id_concepto");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdCombustible).HasColumnName("id_combustible");
            entity.Property(e => e.IdComplemento).HasColumnName("id_complemento");
            entity.Property(e => e.IdComplementoAtributo).HasColumnName("id_complemento_atributo");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdTipoGasto).HasColumnName("id_tipo_gasto");
            entity.Property(e => e.IdTipoGastoClickb).HasColumnName("id_tipo_gasto_clickb");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.LiquidacionConceptos)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto07");

            entity.HasOne(d => d.IdCombustibleNavigation).WithMany(p => p.LiquidacionConceptos)
                .HasForeignKey(d => d.IdCombustible)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.LiquidacionConceptos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.LiquidacionConceptoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto02");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.LiquidacionConceptoIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto05");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.LiquidacionConceptoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto03");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.LiquidacionConceptoIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_concepto06");
        });

        modelBuilder.Entity<LiquidacionConceptoComplemento>(entity =>
        {
            entity.HasKey(e => e.IdComplemento);

            entity.ToTable("liquidacion_concepto_complemento");

            entity.Property(e => e.IdComplemento)
                .ValueGeneratedNever()
                .HasColumnName("id_complemento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<LiquidacionConceptoDeduccion>(entity =>
        {
            entity.HasKey(e => e.IdDeduccion);

            entity.ToTable("liquidacion_concepto_deduccion");

            entity.Property(e => e.IdDeduccion).HasColumnName("id_deduccion");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_sat");
            entity.Property(e => e.Comentario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<LiquidacionConceptoIncapacidad>(entity =>
        {
            entity.HasKey(e => e.IdIncapacidad);

            entity.ToTable("liquidacion_concepto_incapacidad");

            entity.Property(e => e.IdIncapacidad)
                .ValueGeneratedNever()
                .HasColumnName("id_incapacidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<LiquidacionConceptoPercepcion>(entity =>
        {
            entity.HasKey(e => e.IdPercepcion);

            entity.ToTable("liquidacion_concepto_percepcion");

            entity.Property(e => e.IdPercepcion).HasColumnName("id_percepcion");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<LiquidacionDirectaDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("liquidacion_directa_detalle");

            entity.Property(e => e.IdDeduccion).HasColumnName("id_deduccion");
            entity.Property(e => e.IdLiquidacionDirecta).HasColumnName("id_liquidacion_directa");
            entity.Property(e => e.IdPercepcion).HasColumnName("id_percepcion");
            entity.Property(e => e.MontoExcento)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_excento");
            entity.Property(e => e.MontoGravable)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_gravable");

            entity.HasOne(d => d.IdDeduccionNavigation).WithMany()
                .HasForeignKey(d => d.IdDeduccion)
                .HasConstraintName("FK_id_deduccion");

            entity.HasOne(d => d.IdLiquidacionDirectaNavigation).WithMany()
                .HasForeignKey(d => d.IdLiquidacionDirecta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_liqdir");

            entity.HasOne(d => d.IdPercepcionNavigation).WithMany()
                .HasForeignKey(d => d.IdPercepcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_percepcion");
        });

        modelBuilder.Entity<LiquidacionDirectum>(entity =>
        {
            entity.HasKey(e => e.IdLiquidacionDirecta).HasName("PK_id_liqdir");

            entity.ToTable("liquidacion_directa");

            entity.Property(e => e.IdLiquidacionDirecta)
                .ValueGeneratedNever()
                .HasColumnName("id_liquidacion_directa");
            entity.Property(e => e.ClaveConfirmacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveConfirmacion");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInicial)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicial");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdBancosat).HasColumnName("id_bancosat");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdLiquidacionTipo).HasColumnName("id_liquidacion_tipo");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdPersonal).HasColumnName("id_personal");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTiponomina)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_tiponomina");
            entity.Property(e => e.Ingresoacum)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ingresoacum");
            entity.Property(e => e.Ingresonoacum)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ingresonoacum");
            entity.Property(e => e.MontoExcento)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto_excento");
            entity.Property(e => e.MontoGravable)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto_gravable");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto_total");
            entity.Property(e => e.NumLiquidacionDirecta).HasColumnName("num_liquidacion_directa");
            entity.Property(e => e.Numanioserv).HasColumnName("numanioserv");
            entity.Property(e => e.Numdiaspagados)
                .HasDefaultValueSql("((1))")
                .HasColumnName("numdiaspagados");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("observaciones");
            entity.Property(e => e.SubsidioEmpleo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subsidio_empleo");
            entity.Property(e => e.Totalpagado)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("totalpagado");
            entity.Property(e => e.Ultsueldomens)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ultsueldomens");

            entity.HasOne(d => d.IdBancosatNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdBancosat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_bancosat");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_empresa");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdEstatus)
                .HasConstraintName("FK_id_estatus");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_ingreso");

            entity.HasOne(d => d.IdLiquidacionTipoNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdLiquidacionTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion15");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_moneda");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_personal");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_id_sucursal");

            entity.HasOne(d => d.IdTiponominaNavigation).WithMany(p => p.LiquidacionDirecta)
                .HasForeignKey(d => d.IdTiponomina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_directa01");
        });

        modelBuilder.Entity<LiquidacionEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("liquidacion_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LiquidacionEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("liquidacion_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.LiquidacionEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.LiquidacionEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_estatus_idioma02");
        });

        modelBuilder.Entity<LiquidacionGasto>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacion, e.Consecutivo });

            entity.ToTable("liquidacion_gasto");

            entity.HasIndex(e => e.IdLiquidacion, "IX_liquidacion_gasto_id_liquidacion");

            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.ConceptoGasto).HasColumnName("concepto_gasto");
            entity.Property(e => e.FolioDocumentoGastoClickb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_documento_gasto_clickb");
            entity.Property(e => e.FolioFiscal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("folio_fiscal");
            entity.Property(e => e.IdAsociadoDeudorClickb).HasColumnName("id_asociado_deudor_clickb");
            entity.Property(e => e.IdCentroCostoClickb).HasColumnName("id_centro_costo_clickb");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdConceptoAnticipoLiq).HasColumnName("id_concepto_anticipo_liq");
            entity.Property(e => e.IdConvenioLiquidacion).HasColumnName("id_convenio_liquidacion");
            entity.Property(e => e.IdDocumentoGastoClickb).HasColumnName("id_documento_gasto_clickb");
            entity.Property(e => e.IdFormaPagoClickb).HasColumnName("id_forma_pago_clickb");
            entity.Property(e => e.IdTipoGastoClickb).HasColumnName("id_tipo_gasto_clickb");
            entity.Property(e => e.IdUnidadMedidaVolumen).HasColumnName("id_unidad_medida_volumen");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoSubtota)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_subtota");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.VolumenBase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen_base");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.LiquidacionGastos)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_gasto01");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany(p => p.LiquidacionGastos)
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_gasto02");
        });

        modelBuilder.Entity<LiquidacionGuium>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacion, e.Consecutivo });

            entity.ToTable("liquidacion_guia");

            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Flete)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("flete");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.LiquidacionGuia)
                .HasForeignKey(d => d.IdGuia)
                .HasConstraintName("FK_liquidacion_guia_01");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany(p => p.LiquidacionGuia)
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_guia_03");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.LiquidacionGuia)
                .HasForeignKey(d => d.IdViaje)
                .HasConstraintName("FK_liquidacion_guia_02");
        });

        modelBuilder.Entity<LiquidacionPermisionario>(entity =>
        {
            entity.HasKey(e => e.IdLiquidacionPermisionario).HasName("PK_liquidacion_permisionario01");

            entity.ToTable("liquidacion_permisionario");

            entity.Property(e => e.IdLiquidacionPermisionario)
                .ValueGeneratedNever()
                .HasColumnName("id_liquidacion_permisionario");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInicial)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicial");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdPermisionario).HasColumnName("id_permisionario");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdUsuarioCancelo).HasColumnName("id_usuario_cancelo");
            entity.Property(e => e.IdUsuarioPago).HasColumnName("id_usuario_pago");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoSubtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_subtotal");
            entity.Property(e => e.MontoTotalPagar)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total_pagar");
            entity.Property(e => e.NumLiquidacionPermisionario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_liquidacion_permisionario");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");
            entity.Property(e => e.TipoPersona).HasColumnName("tipo_persona");
            entity.Property(e => e.TotalAnticipos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_anticipos");
            entity.Property(e => e.TotalDescuentos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_descuentos");
            entity.Property(e => e.TotalOtrosPagos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_otros_pagos");
            entity.Property(e => e.TotalPagoFlete)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_pago_flete");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_empresa");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_estatus");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.LiquidacionPermisionarioIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_ingreso");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_iva");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.LiquidacionPermisionarioIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_modifico");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_moneda");

            entity.HasOne(d => d.IdPermisionarioNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_permisionario");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_solicitud");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.LiquidacionPermisionarios)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_sucursal");

            entity.HasOne(d => d.IdUsuarioCanceloNavigation).WithMany(p => p.LiquidacionPermisionarioIdUsuarioCanceloNavigations)
                .HasForeignKey(d => d.IdUsuarioCancelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_usuario_cancelo");

            entity.HasOne(d => d.IdUsuarioPagoNavigation).WithMany(p => p.LiquidacionPermisionarioIdUsuarioPagoNavigations)
                .HasForeignKey(d => d.IdUsuarioPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_id_usuario_pago");
        });

        modelBuilder.Entity<LiquidacionPermisionarioDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacionPermisionario, e.Consecutivo }).HasName("PK_liquidacion_permisionario_detalle01");

            entity.ToTable("liquidacion_permisionario_detalle");

            entity.Property(e => e.IdLiquidacionPermisionario).HasColumnName("id_liquidacion_permisionario");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.TipoConcepto).HasColumnName("tipo_concepto");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.LiquidacionPermisionarioDetalles)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_detalle_id_concepto");

            entity.HasOne(d => d.IdLiquidacionPermisionarioNavigation).WithMany(p => p.LiquidacionPermisionarioDetalles)
                .HasForeignKey(d => d.IdLiquidacionPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_detalle_id_liquidacion_permisionario");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.LiquidacionPermisionarioDetalles)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_detalle_id_retencion");
        });

        modelBuilder.Entity<LiquidacionPermisionarioEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus).HasName("PK_liquidacion_permisionario_estatus01");

            entity.ToTable("liquidacion_permisionario_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<LiquidacionPermisionarioEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma }).HasName("PK_liquidacion_permisionario_estatus_idioma01");

            entity.ToTable("liquidacion_permisionario_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.LiquidacionPermisionarioEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_estatus_idioma_id_estatus");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.LiquidacionPermisionarioEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_estatus_idioma_id_idioma");
        });

        modelBuilder.Entity<LiquidacionPermisionarioGuium>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacionPermisionario, e.Consecutivo }).HasName("PK_liquidacion_permisionario_guia01");

            entity.ToTable("liquidacion_permisionario_guia");

            entity.Property(e => e.IdLiquidacionPermisionario).HasColumnName("id_liquidacion_permisionario");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Flete)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("flete");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Referencia)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("referencia");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.LiquidacionPermisionarioGuia)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_guia_id_guia");

            entity.HasOne(d => d.IdLiquidacionPermisionarioNavigation).WithMany(p => p.LiquidacionPermisionarioGuia)
                .HasForeignKey(d => d.IdLiquidacionPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_guia_id_liquidacion_permisionario");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.LiquidacionPermisionarioGuia)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_permisionario_guia_id_viaje");
        });

        modelBuilder.Entity<LiquidacionSueldo>(entity =>
        {
            entity.HasKey(e => e.IdTipoSueldo);

            entity.ToTable("liquidacion_sueldo");

            entity.Property(e => e.IdTipoSueldo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_sueldo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Factor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.TipoSueldo).HasColumnName("tipo_sueldo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.LiquidacionSueldos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.LiquidacionSueldoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.LiquidacionSueldoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo04");

            entity.HasOne(d => d.TipoSueldoNavigation).WithMany(p => p.LiquidacionSueldos)
                .HasForeignKey(d => d.TipoSueldo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo02");
        });

        modelBuilder.Entity<LiquidacionSueldoRelacion>(entity =>
        {
            entity.HasKey(e => e.IdSueldoRelacion);

            entity.ToTable("liquidacion_sueldo_relacion");

            entity.Property(e => e.IdSueldoRelacion)
                .ValueGeneratedNever()
                .HasColumnName("id_sueldo_relacion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipoSueldo).HasColumnName("id_tipo_sueldo");
            entity.Property(e => e.ViajeTipo).HasColumnName("viaje_tipo");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.LiquidacionSueldoRelacions)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_relacion04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.LiquidacionSueldoRelacions)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_relacion01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.LiquidacionSueldoRelacionIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_relacion02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.LiquidacionSueldoRelacionIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_relacion03");

            entity.HasOne(d => d.IdTipoSueldoNavigation).WithMany(p => p.LiquidacionSueldoRelacions)
                .HasForeignKey(d => d.IdTipoSueldo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_relacion05");

            entity.HasOne(d => d.ViajeTipoNavigation).WithMany(p => p.LiquidacionSueldoRelacions)
                .HasForeignKey(d => d.ViajeTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_relacion06");
        });

        modelBuilder.Entity<LiquidacionSueldoRutum>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoSueldo, e.IdRuta });

            entity.ToTable("liquidacion_sueldo_ruta");

            entity.Property(e => e.IdTipoSueldo).HasColumnName("id_tipo_sueldo");
            entity.Property(e => e.IdRuta).HasColumnName("id_ruta");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.LiquidacionSueldoRuta)
                .HasForeignKey(d => d.IdRuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_ruta01");

            entity.HasOne(d => d.IdTipoSueldoNavigation).WithMany(p => p.LiquidacionSueldoRuta)
                .HasForeignKey(d => d.IdTipoSueldo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_ruta02");
        });

        modelBuilder.Entity<LiquidacionSueldoTipo>(entity =>
        {
            entity.HasKey(e => e.TipoSueldo);

            entity.ToTable("liquidacion_sueldo_tipo");

            entity.Property(e => e.TipoSueldo)
                .ValueGeneratedNever()
                .HasColumnName("tipo_sueldo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LiquidacionSueldoTipoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.TipoSueldo, e.IdIdioma });

            entity.ToTable("liquidacion_sueldo_tipo_idioma");

            entity.Property(e => e.TipoSueldo).HasColumnName("tipo_sueldo");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.LiquidacionSueldoTipoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_tipo_idioma02");

            entity.HasOne(d => d.TipoSueldoNavigation).WithMany(p => p.LiquidacionSueldoTipoIdiomas)
                .HasForeignKey(d => d.TipoSueldo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_sueldo_tipo_idioma01");
        });

        modelBuilder.Entity<LiquidacionTipo>(entity =>
        {
            entity.HasKey(e => e.IdLiquidacionTipo).HasName("PK_liquidacion_tipo_id");

            entity.ToTable("liquidacion_tipo");

            entity.Property(e => e.IdLiquidacionTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_liquidacion_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<LiquidacionTipoAdeudo>(entity =>
        {
            entity.HasKey(e => e.IdTipoAdeudo);

            entity.ToTable("liquidacion_tipo_adeudo");

            entity.Property(e => e.IdTipoAdeudo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_adeudo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LiquidacionTipoAdeudoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoAdeudo, e.IdIdioma });

            entity.ToTable("liquidacion_tipo_adeudo_idioma");

            entity.Property(e => e.IdTipoAdeudo).HasColumnName("id_tipo_adeudo");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.LiquidacionTipoAdeudoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_tipo_adeudo_idioma_01");

            entity.HasOne(d => d.IdTipoAdeudoNavigation).WithMany(p => p.LiquidacionTipoAdeudoIdiomas)
                .HasForeignKey(d => d.IdTipoAdeudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_liquidacion_tipo_adeudo_idioma_02");
        });

        modelBuilder.Entity<LisSecuencium>(entity =>
        {
            entity.HasKey(e => e.Number);

            entity.ToTable("lis_secuencia", "PowerLISTMS");

            entity.Property(e => e.Number)
                .ValueGeneratedNever()
                .HasColumnName("number");
            entity.Property(e => e.High).HasColumnName("high");
            entity.Property(e => e.Low).HasColumnName("low");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<MapaError>(entity =>
        {
            entity.HasKey(e => e.IdMapaError).HasName("PK__mapa_err__39783E39960ABDA5");

            entity.ToTable("mapa_error");

            entity.HasIndex(e => e.IdMapaError, "UQ_id_mapa_error").IsUnique();

            entity.Property(e => e.IdMapaError)
                .ValueGeneratedNever()
                .HasColumnName("id_mapa_error");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.ErrorServicio)
                .IsUnicode(false)
                .HasColumnName("error_servicio");
        });

        modelBuilder.Entity<MatrizConfigMetaAnual>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Anio });

            entity.ToTable("matriz_config_meta_anual", "PowerLISTMS");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_empresa");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Mes10CostoMtto).HasColumnName("mes10_costo_mtto");
            entity.Property(e => e.Mes10CostoMttoXKm).HasColumnName("mes10_costo_mtto_x_km");
            entity.Property(e => e.Mes10GastosFijosAdmin).HasColumnName("mes10_gastos_fijos_admin");
            entity.Property(e => e.Mes10IngresoViaje).HasColumnName("mes10_ingreso_viaje");
            entity.Property(e => e.Mes10PromedioDiasCartera).HasColumnName("mes10_promedio_dias_cartera");
            entity.Property(e => e.Mes10RendimientoCombustible).HasColumnName("mes10_rendimiento_combustible");
            entity.Property(e => e.Mes10Viajes).HasColumnName("mes10_viajes");
            entity.Property(e => e.Mes11CostoMtto).HasColumnName("mes11_costo_mtto");
            entity.Property(e => e.Mes11CostoMttoXKm).HasColumnName("mes11_costo_mtto_x_km");
            entity.Property(e => e.Mes11GastosFijosAdmin).HasColumnName("mes11_gastos_fijos_admin");
            entity.Property(e => e.Mes11IngresoViaje).HasColumnName("mes11_ingreso_viaje");
            entity.Property(e => e.Mes11PromedioDiasCartera).HasColumnName("mes11_promedio_dias_cartera");
            entity.Property(e => e.Mes11RendimientoCombustible).HasColumnName("mes11_rendimiento_combustible");
            entity.Property(e => e.Mes11Viajes).HasColumnName("mes11_viajes");
            entity.Property(e => e.Mes12CostoMtto).HasColumnName("mes12_costo_mtto");
            entity.Property(e => e.Mes12CostoMttoXKm).HasColumnName("mes12_costo_mtto_x_km");
            entity.Property(e => e.Mes12GastosFijosAdmin).HasColumnName("mes12_gastos_fijos_admin");
            entity.Property(e => e.Mes12IngresoViaje).HasColumnName("mes12_ingreso_viaje");
            entity.Property(e => e.Mes12PromedioDiasCartera).HasColumnName("mes12_promedio_dias_cartera");
            entity.Property(e => e.Mes12RendimientoCombustible).HasColumnName("mes12_rendimiento_combustible");
            entity.Property(e => e.Mes12Viajes).HasColumnName("mes12_viajes");
            entity.Property(e => e.Mes1CostoMtto).HasColumnName("mes1_costo_mtto");
            entity.Property(e => e.Mes1CostoMttoXKm).HasColumnName("mes1_costo_mtto_x_km");
            entity.Property(e => e.Mes1GastosFijosAdmin).HasColumnName("mes1_gastos_fijos_admin");
            entity.Property(e => e.Mes1IngresoViaje).HasColumnName("mes1_ingreso_viaje");
            entity.Property(e => e.Mes1PromedioDiasCartera).HasColumnName("mes1_promedio_dias_cartera");
            entity.Property(e => e.Mes1RendimientoCombustible).HasColumnName("mes1_rendimiento_combustible");
            entity.Property(e => e.Mes1Viajes).HasColumnName("mes1_viajes");
            entity.Property(e => e.Mes2CostoMtto).HasColumnName("mes2_costo_mtto");
            entity.Property(e => e.Mes2CostoMttoXKm).HasColumnName("mes2_costo_mtto_x_km");
            entity.Property(e => e.Mes2GastosFijosAdmin).HasColumnName("mes2_gastos_fijos_admin");
            entity.Property(e => e.Mes2IngresoViaje).HasColumnName("mes2_ingreso_viaje");
            entity.Property(e => e.Mes2PromedioDiasCartera).HasColumnName("mes2_promedio_dias_cartera");
            entity.Property(e => e.Mes2RendimientoCombustible).HasColumnName("mes2_rendimiento_combustible");
            entity.Property(e => e.Mes2Viajes).HasColumnName("mes2_viajes");
            entity.Property(e => e.Mes3CostoMtto).HasColumnName("mes3_costo_mtto");
            entity.Property(e => e.Mes3CostoMttoXKm).HasColumnName("mes3_costo_mtto_x_km");
            entity.Property(e => e.Mes3GastosFijosAdmin).HasColumnName("mes3_gastos_fijos_admin");
            entity.Property(e => e.Mes3IngresoViaje).HasColumnName("mes3_ingreso_viaje");
            entity.Property(e => e.Mes3PromedioDiasCartera).HasColumnName("mes3_promedio_dias_cartera");
            entity.Property(e => e.Mes3RendimientoCombustible).HasColumnName("mes3_rendimiento_combustible");
            entity.Property(e => e.Mes3Viajes).HasColumnName("mes3_viajes");
            entity.Property(e => e.Mes4CostoMtto).HasColumnName("mes4_costo_mtto");
            entity.Property(e => e.Mes4CostoMttoXKm).HasColumnName("mes4_costo_mtto_x_km");
            entity.Property(e => e.Mes4GastosFijosAdmin).HasColumnName("mes4_gastos_fijos_admin");
            entity.Property(e => e.Mes4IngresoViaje).HasColumnName("mes4_ingreso_viaje");
            entity.Property(e => e.Mes4PromedioDiasCartera).HasColumnName("mes4_promedio_dias_cartera");
            entity.Property(e => e.Mes4RendimientoCombustible).HasColumnName("mes4_rendimiento_combustible");
            entity.Property(e => e.Mes4Viajes).HasColumnName("mes4_viajes");
            entity.Property(e => e.Mes5CostoMtto).HasColumnName("mes5_costo_mtto");
            entity.Property(e => e.Mes5CostoMttoXKm).HasColumnName("mes5_costo_mtto_x_km");
            entity.Property(e => e.Mes5GastosFijosAdmin).HasColumnName("mes5_gastos_fijos_admin");
            entity.Property(e => e.Mes5IngresoViaje).HasColumnName("mes5_ingreso_viaje");
            entity.Property(e => e.Mes5PromedioDiasCartera).HasColumnName("mes5_promedio_dias_cartera");
            entity.Property(e => e.Mes5RendimientoCombustible).HasColumnName("mes5_rendimiento_combustible");
            entity.Property(e => e.Mes5Viajes).HasColumnName("mes5_viajes");
            entity.Property(e => e.Mes6CostoMtto).HasColumnName("mes6_costo_mtto");
            entity.Property(e => e.Mes6CostoMttoXKm).HasColumnName("mes6_costo_mtto_x_km");
            entity.Property(e => e.Mes6GastosFijosAdmin).HasColumnName("mes6_gastos_fijos_admin");
            entity.Property(e => e.Mes6IngresoViaje).HasColumnName("mes6_ingreso_viaje");
            entity.Property(e => e.Mes6PromedioDiasCartera).HasColumnName("mes6_promedio_dias_cartera");
            entity.Property(e => e.Mes6RendimientoCombustible).HasColumnName("mes6_rendimiento_combustible");
            entity.Property(e => e.Mes6Viajes).HasColumnName("mes6_viajes");
            entity.Property(e => e.Mes7CostoMtto).HasColumnName("mes7_costo_mtto");
            entity.Property(e => e.Mes7CostoMttoXKm).HasColumnName("mes7_costo_mtto_x_km");
            entity.Property(e => e.Mes7GastosFijosAdmin).HasColumnName("mes7_gastos_fijos_admin");
            entity.Property(e => e.Mes7IngresoViaje).HasColumnName("mes7_ingreso_viaje");
            entity.Property(e => e.Mes7PromedioDiasCartera).HasColumnName("mes7_promedio_dias_cartera");
            entity.Property(e => e.Mes7RendimientoCombustible).HasColumnName("mes7_rendimiento_combustible");
            entity.Property(e => e.Mes7Viajes).HasColumnName("mes7_viajes");
            entity.Property(e => e.Mes8CostoMtto).HasColumnName("mes8_costo_mtto");
            entity.Property(e => e.Mes8CostoMttoXKm).HasColumnName("mes8_costo_mtto_x_km");
            entity.Property(e => e.Mes8GastosFijosAdmin).HasColumnName("mes8_gastos_fijos_admin");
            entity.Property(e => e.Mes8IngresoViaje).HasColumnName("mes8_ingreso_viaje");
            entity.Property(e => e.Mes8PromedioDiasCartera).HasColumnName("mes8_promedio_dias_cartera");
            entity.Property(e => e.Mes8RendimientoCombustible).HasColumnName("mes8_rendimiento_combustible");
            entity.Property(e => e.Mes8Viajes).HasColumnName("mes8_viajes");
            entity.Property(e => e.Mes9CostoMtto).HasColumnName("mes9_costo_mtto");
            entity.Property(e => e.Mes9CostoMttoXKm).HasColumnName("mes9_costo_mtto_x_km");
            entity.Property(e => e.Mes9GastosFijosAdmin).HasColumnName("mes9_gastos_fijos_admin");
            entity.Property(e => e.Mes9IngresoViaje).HasColumnName("mes9_ingreso_viaje");
            entity.Property(e => e.Mes9PromedioDiasCartera).HasColumnName("mes9_promedio_dias_cartera");
            entity.Property(e => e.Mes9RendimientoCombustible).HasColumnName("mes9_rendimiento_combustible");
            entity.Property(e => e.Mes9Viajes).HasColumnName("mes9_viajes");
            entity.Property(e => e.TotalCostoMtto).HasColumnName("total_costo_mtto");
            entity.Property(e => e.TotalCostoMttoXKm).HasColumnName("total_costo_mtto_x_km");
            entity.Property(e => e.TotalGastosFijosAdmin).HasColumnName("total_gastos_fijos_admin");
            entity.Property(e => e.TotalIngresosAnual).HasColumnName("total_ingresos_anual");
            entity.Property(e => e.TotalPromedioDiasCartera).HasColumnName("total_promedio_dias_cartera");
            entity.Property(e => e.TotalRendimientoCombustible).HasColumnName("total_rendimiento_combustible");
            entity.Property(e => e.TotalViajes).HasColumnName("total_viajes");
        });

        modelBuilder.Entity<MedioPagoPeru>(entity =>
        {
            entity.HasKey(e => e.IdMedioPago).HasName("PK_medio_pago_peru_id_medio_pago");

            entity.ToTable("medio_pago_peru");

            entity.HasIndex(e => e.Clave, "UQ_clave_medio_pago_peru").IsUnique();

            entity.Property(e => e.IdMedioPago)
                .ValueGeneratedNever()
                .HasColumnName("id_medio_pago");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.IdMensaje);

            entity.ToTable("mensaje");

            entity.Property(e => e.IdMensaje)
                .ValueGeneratedNever()
                .HasColumnName("id_mensaje");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.Parametros).HasColumnName("parametros");
        });

        modelBuilder.Entity<MensajeClasificacion>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion);

            entity.ToTable("mensaje_clasificacion");

            entity.Property(e => e.IdClasificacion)
                .ValueGeneratedNever()
                .HasColumnName("id_clasificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<MensajeClasificacionIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdClasificacion, e.IdIdioma });

            entity.ToTable("mensaje_clasificacion_idioma");

            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.TextoAceptar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("texto_aceptar");
            entity.Property(e => e.TextoCancelar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("texto_cancelar");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.MensajeClasificacionIdiomas)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mensaje_clasificacion_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.MensajeClasificacionIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mensaje_clasificacion_idioma02");
        });

        modelBuilder.Entity<MensajeError>(entity =>
        {
            entity.HasKey(e => e.IdError);

            entity.ToTable("mensaje_error");

            entity.Property(e => e.IdError)
                .ValueGeneratedNever()
                .HasColumnName("id_error");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("mensaje");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<MensajeIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdIdioma, e.IdMensaje });

            entity.ToTable("mensaje_idioma");

            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdMensaje).HasColumnName("id_mensaje");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("mensaje");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.MensajeIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mensaje_idioma01");

            entity.HasOne(d => d.IdMensajeNavigation).WithMany(p => p.MensajeIdiomas)
                .HasForeignKey(d => d.IdMensaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mensaje_idioma02");
        });

        modelBuilder.Entity<Mese>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_meses_id");

            entity.ToTable("meses");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClaveMeses)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave_meses");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<MetaIndicador>(entity =>
        {
            entity.HasKey(e => e.IdIndicador);

            entity.ToTable("meta_indicador", "PowerLISTMS");

            entity.Property(e => e.IdIndicador)
                .ValueGeneratedNever()
                .HasColumnName("id_indicador");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreCampo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_campo");
        });

        modelBuilder.Entity<MetaTiempo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Fecha });

            entity.ToTable("meta_tiempo", "PowerLISTMS");

            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_empresa");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.MetaCostoMtto).HasColumnName("meta_costo_mtto");
            entity.Property(e => e.MetaCostoMttoXKm).HasColumnName("meta_costo_mtto_x_km");
            entity.Property(e => e.MetaGastosFijosAdmin).HasColumnName("meta_gastos_fijos_admin");
            entity.Property(e => e.MetaIngresoViaje).HasColumnName("meta_ingreso_viaje");
            entity.Property(e => e.MetaPromedioDiasCartera).HasColumnName("meta_promedio_dias_cartera");
            entity.Property(e => e.MetaRendimientoCombustible).HasColumnName("meta_rendimiento_combustible");
            entity.Property(e => e.MetaViajes).HasColumnName("meta_viajes");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("PK_metodo_pago_id_metodo_pago");

            entity.ToTable("metodo_pago");

            entity.HasIndex(e => e.Clave, "UQ_metodo_pago_clave").IsUnique();

            entity.Property(e => e.IdMetodoPago)
                .ValueGeneratedNever()
                .HasColumnName("id_metodo_pago");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<ModeloIum>(entity =>
        {
            entity.HasKey(e => e.IdModeloIa).HasName("pk_modelo_ia");

            entity.ToTable("modelo_ia");

            entity.Property(e => e.IdModeloIa)
                .ValueGeneratedNever()
                .HasColumnName("id_modelo_ia");
            entity.Property(e => e.CostoCache)
                .HasDefaultValueSql("((0))")
                .HasComment("Costo en USD por millon de tokens")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("costo_cache");
            entity.Property(e => e.CostoInput)
                .HasDefaultValueSql("((0))")
                .HasComment("Costo en USD por millon de tokens")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("costo_input");
            entity.Property(e => e.CostoOutput)
                .HasDefaultValueSql("((0))")
                .HasComment("Costo en USD por millon de tokens")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("costo_output");
            entity.Property(e => e.Modo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("modo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<MonedaMonedum>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PK_moneda_moneda_clave");

            entity.ToTable("moneda_moneda");

            entity.HasIndex(e => e.Clave, "UQ_moneda_moneda_clave").IsUnique();

            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdMonedaMoneda).HasColumnName("id_moneda_moneda");
            entity.Property(e => e.PorcentajeVariacion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("porcentaje_variacion");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.IdMoneda);

            entity.ToTable("moneda");

            entity.Property(e => e.IdMoneda)
                .ValueGeneratedNever()
                .HasColumnName("id_moneda");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipoMoneda).HasColumnName("id_tipo_moneda");
            entity.Property(e => e.Leyenda)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("leyenda");
            entity.Property(e => e.LeyendaMoneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("leyenda_moneda");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Moneda)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_moneda02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Moneda)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_moneda01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.MonedumIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_moneda04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.MonedumIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_moneda03");
        });

        modelBuilder.Entity<MttoUnidad>(entity =>
        {
            entity.HasKey(e => new { e.IdMtto, e.IdEmpresa });

            entity.ToTable("mtto_unidad");

            entity.Property(e => e.IdMtto).HasColumnName("id_mtto");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("correlativo");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaSigMtto)
                .HasColumnType("datetime")
                .HasColumnName("fecha_sig_mtto");
            entity.Property(e => e.Folio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Kms).HasColumnName("kms");
            entity.Property(e => e.KmsSigMtto).HasColumnName("kms_sig_mtto");
            entity.Property(e => e.Mantenimiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mantenimiento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.SigMtto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sig_mtto");
            entity.Property(e => e.TipoMtto).HasColumnName("tipo_mtto");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total");
            entity.Property(e => e.TotalManoObra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_mano_obra");
            entity.Property(e => e.TotalRefacc)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_refacc");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.MttoUnidadIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.MttoUnidadIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad03");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.MttoUnidads)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad01");
        });

        modelBuilder.Entity<MttoUnidadDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMtto, e.Consecutivo });

            entity.ToTable("mtto_unidad_detalle");

            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdMtto).HasColumnName("id_mtto");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Actividad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("actividad");
            entity.Property(e => e.IdTipoAct).HasColumnName("id_tipo_act");
            entity.Property(e => e.ManoObra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("mano_obra");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Refacciones)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("refacciones");

            entity.HasOne(d => d.Id).WithMany(p => p.MttoUnidadDetalles)
                .HasForeignKey(d => new { d.IdMtto, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_detalle01");
        });

        modelBuilder.Entity<MttoUnidadEstatus>(entity =>
        {
            entity.HasKey(e => e.TipoEstatus);

            entity.ToTable("mtto_unidad_estatus");

            entity.Property(e => e.TipoEstatus)
                .ValueGeneratedNever()
                .HasColumnName("tipo_estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<MttoUnidadEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.TipoEstatus, e.IdIdioma });

            entity.ToTable("mtto_unidad_estatus_idioma");

            entity.Property(e => e.TipoEstatus).HasColumnName("tipo_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.MttoUnidadEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_estatus_idioma_idioma");

            entity.HasOne(d => d.TipoEstatusNavigation).WithMany(p => p.MttoUnidadEstatusIdiomas)
                .HasForeignKey(d => d.TipoEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_estatus_idioma_tipo");
        });

        modelBuilder.Entity<MttoUnidadTipoActividad>(entity =>
        {
            entity.HasKey(e => e.IdTipoAct);

            entity.ToTable("mtto_unidad_tipo_actividad");

            entity.Property(e => e.IdTipoAct)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_act");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<MttoUnidadTipoActividadIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoAct, e.IdIdioma });

            entity.ToTable("mtto_unidad_tipo_actividad_idioma");

            entity.Property(e => e.IdTipoAct).HasColumnName("id_tipo_act");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.MttoUnidadTipoActividadIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_tipo_actividad_idioma_idioma");

            entity.HasOne(d => d.IdTipoActNavigation).WithMany(p => p.MttoUnidadTipoActividadIdiomas)
                .HasForeignKey(d => d.IdTipoAct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_tipo_actividad_idioma_actividad");
        });

        modelBuilder.Entity<MttoUnidadTipoMtto>(entity =>
        {
            entity.HasKey(e => e.TipoMtto);

            entity.ToTable("mtto_unidad_tipo_mtto");

            entity.Property(e => e.TipoMtto)
                .ValueGeneratedNever()
                .HasColumnName("tipo_mtto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<MttoUnidadTipoMttoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.TipoMtto, e.IdIdioma });

            entity.ToTable("mtto_unidad_tipo_mtto_idioma");

            entity.Property(e => e.TipoMtto).HasColumnName("tipo_mtto");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.MttoUnidadTipoMttoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_tipo_mtto_idioma_idioma");

            entity.HasOne(d => d.TipoMttoNavigation).WithMany(p => p.MttoUnidadTipoMttoIdiomas)
                .HasForeignKey(d => d.TipoMtto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_mtto_unidad_tipo_mtto_idioma_tipo");
        });

        modelBuilder.Entity<NominaTipo>(entity =>
        {
            entity.HasKey(e => e.IdTiponomina).HasName("PK_nomina_tipo_id");

            entity.ToTable("nomina_tipo");

            entity.Property(e => e.IdTiponomina).HasColumnName("id_tiponomina");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Tiponomina)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tiponomina");
        });

        modelBuilder.Entity<NotaCargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo);

            entity.ToTable("nota_cargo");

            entity.Property(e => e.IdCargo)
                .ValueGeneratedNever()
                .HasColumnName("id_cargo");
            entity.Property(e => e.ClaveConfirmacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveConfirmacion");
            entity.Property(e => e.EstatusCancelacion).HasColumnName("estatus_cancelacion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaSolicitudCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_solicitud_cancelacion");
            entity.Property(e => e.FolioClickb).HasColumnName("folio_clickb");
            entity.Property(e => e.IdDocumentoClickb).HasColumnName("id_documento_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdEstatusClickb).HasColumnName("id_estatus_clickb");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdMotivoCancelacion).HasColumnName("id_motivo_cancelacion");
            entity.Property(e => e.IdNotaCargoRelacionCancelacion).HasColumnName("id_nota_cargo_relacion_cancelacion");
            entity.Property(e => e.IdPlazaEmision).HasColumnName("id_plaza_emision");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdTipoPagoClickb).HasColumnName("id_tipo_pago_clickb");
            entity.Property(e => e.IdTipoPeru).HasColumnName("id_tipo_peru");
            entity.Property(e => e.IdTipodocClickb).HasColumnName("id_tipodoc_clickb");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoPago)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_pago");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("motivo_cancelacion");
            entity.Property(e => e.NombreTipodocClickb)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("nombre_tipodoc_clickb");
            entity.Property(e => e.NumCargo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_cargo");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SustituyeDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("sustituye_documento");
            entity.Property(e => e.UuidRelacionCancelacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("uuid_relacion_cancelacion");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.NotaCargos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.NotaCargos)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo04");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.NotaCargos)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo02");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.NotaCargoIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo06");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.NotaCargos)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo03");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.NotaCargoIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo07");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.NotaCargos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo05");

            entity.HasOne(d => d.IdTipoPeruNavigation).WithMany(p => p.NotaCargos)
                .HasForeignKey(d => d.IdTipoPeru)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo_id_tipo_peru");
        });

        modelBuilder.Entity<NotaCargoAdendum>(entity =>
        {
            entity.HasKey(e => new { e.IdCargo, e.IdAdenda, e.Consecutivo });

            entity.ToTable("nota_cargo_adenda");

            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Campo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.Valor)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAdendaNavigation).WithMany(p => p.NotaCargoAdenda)
                .HasForeignKey(d => d.IdAdenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo_adenda_02");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.NotaCargoAdenda)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo_adenda_01");
        });

        modelBuilder.Entity<NotaCargoCfdiRelacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nota_cargo_cfdi_relacion");

            entity.Property(e => e.FolioFactura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_factura");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdGuiaRelacionada).HasColumnName("id_guia_relacionada");
            entity.Property(e => e.TipoRelacion).HasColumnName("tipo_relacion");
            entity.Property(e => e.Uuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<NotaCargoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdCargo, e.Consecutivo });

            entity.ToTable("nota_cargo_detalle");

            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FactorIva)
                .HasDefaultValueSql("((0.16))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_iva");
            entity.Property(e => e.FactorRetencion)
                .HasDefaultValueSql("((0.04))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_retencion");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdObjetoImpuesto)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIva)
                .HasDefaultValueSql("((0.16))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasDefaultValueSql("((0.04))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoSubtotal)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_subtotal");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.NotaCargoDetalles)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo_detalle01");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.NotaCargoDetalles)
                .HasForeignKey(d => d.IdConcepto)
                .HasConstraintName("FK_nota_cargo_detalle02");
        });

        modelBuilder.Entity<NotaCargoEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("nota_cargo_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<NotaCargoEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("nota_cargo_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.NotaCargoEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.NotaCargoEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_cargo_estatus_idioma02");
        });

        modelBuilder.Entity<NotaCargoTipoPeru>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK_nota_cargo_tipo_peru_id_tipo");

            entity.ToTable("nota_cargo_tipo_peru");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<NotaCredito>(entity =>
        {
            entity.HasKey(e => e.IdCredito);

            entity.ToTable("nota_credito");

            entity.Property(e => e.IdCredito)
                .ValueGeneratedNever()
                .HasColumnName("id_credito");
            entity.Property(e => e.ClaveConfirmacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveConfirmacion");
            entity.Property(e => e.EstatusCancelacion).HasColumnName("estatus_cancelacion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelacion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaSolicitudCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_solicitud_cancelacion");
            entity.Property(e => e.FechaVencimientoPeru)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento_peru");
            entity.Property(e => e.FolioClickb).HasColumnName("folio_clickb");
            entity.Property(e => e.IdDocumentoClickb).HasColumnName("id_documento_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdEstatusClickb).HasColumnName("id_estatus_clickb");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdFormaPago).HasColumnName("id_forma_pago");
            entity.Property(e => e.IdFormaPagoPeru).HasColumnName("id_forma_pago_peru");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdMotivoCancelacion).HasColumnName("id_motivo_cancelacion");
            entity.Property(e => e.IdNotaCreditoRelacionCancelacion).HasColumnName("id_nota_credito_relacion_cancelacion");
            entity.Property(e => e.IdPlazaEmision).HasColumnName("id_plaza_emision");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdTipoPagoClickb).HasColumnName("id_tipo_pago_clickb");
            entity.Property(e => e.IdTipoPeru).HasColumnName("id_tipo_peru");
            entity.Property(e => e.IdTipodocClickb).HasColumnName("id_tipodoc_clickb");
            entity.Property(e => e.IdTipofacturarelacionada).HasColumnName("id_tipofacturarelacionada");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("motivo_cancelacion");
            entity.Property(e => e.NombreTipodocClickb)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("nombre_tipodoc_clickb");
            entity.Property(e => e.NumCredito)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_credito");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SustituyeDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("sustituye_documento");
            entity.Property(e => e.UuidRelacionCancelacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("uuid_relacion_cancelacion");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.NotaCreditos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.NotaCreditos)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito04");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.NotaCreditos)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito02");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.NotaCreditoIdIvaNavigations)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito06");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.NotaCreditos)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito03");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.NotaCreditoIdRetencionNavigations)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito07");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.NotaCreditos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito05");

            entity.HasOne(d => d.IdTipoPeruNavigation).WithMany(p => p.NotaCreditos)
                .HasForeignKey(d => d.IdTipoPeru)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito_id_tipo_peru");
        });

        modelBuilder.Entity<NotaCreditoAdendum>(entity =>
        {
            entity.HasKey(e => new { e.IdCredito, e.IdAdenda, e.Consecutivo });

            entity.ToTable("nota_credito_adenda");

            entity.Property(e => e.IdCredito).HasColumnName("id_credito");
            entity.Property(e => e.IdAdenda).HasColumnName("id_adenda");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Campo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("campo");
            entity.Property(e => e.Valor)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAdendaNavigation).WithMany(p => p.NotaCreditoAdenda)
                .HasForeignKey(d => d.IdAdenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito_adenda_02");

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.NotaCreditoAdenda)
                .HasForeignKey(d => d.IdCredito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito_adenda_01");
        });

        modelBuilder.Entity<NotaCreditoCfdiRelacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nota_credito_cfdi_relacion");

            entity.Property(e => e.FolioFactura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("folio_factura");
            entity.Property(e => e.IdCredito).HasColumnName("id_credito");
            entity.Property(e => e.IdGuiaRelacionada).HasColumnName("id_guia_relacionada");
            entity.Property(e => e.TipoRelacion).HasColumnName("tipo_relacion");
            entity.Property(e => e.Uuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<NotaCreditoCuotasPeru>(entity =>
        {
            entity.HasKey(e => new { e.IdCredito, e.Consecutivo }).HasName("PK__nota_cre__150E58D5F32ADD4E");

            entity.ToTable("nota_credito_cuotas_peru");

            entity.Property(e => e.IdCredito).HasColumnName("id_credito");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.NotaCreditoCuotasPerus)
                .HasForeignKey(d => d.IdCredito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nota_cred__id_cr__07B7078F");
        });

        modelBuilder.Entity<NotaCreditoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdCredito, e.Consecutivo });

            entity.ToTable("nota_credito_detalle");

            entity.Property(e => e.IdCredito).HasColumnName("id_credito");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FactorIva)
                .HasDefaultValueSql("((0.16))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_iva");
            entity.Property(e => e.FactorRetencion)
                .HasDefaultValueSql("((0.04))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_retencion");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdObjetoImpuesto)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.Monto)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoIva)
                .HasDefaultValueSql("((0.16))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_iva");
            entity.Property(e => e.MontoRetencion)
                .HasDefaultValueSql("((0.04))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_retencion");
            entity.Property(e => e.MontoSubtotal)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_subtotal");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.NotaCreditoDetalles)
                .HasForeignKey(d => d.IdConcepto)
                .HasConstraintName("FK_nota_credito_detalle02");

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.NotaCreditoDetalles)
                .HasForeignKey(d => d.IdCredito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito_detalle01");
        });

        modelBuilder.Entity<NotaCreditoEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("nota_credito_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<NotaCreditoEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("nota_credito_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.NotaCreditoEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.NotaCreditoEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_nota_credito_estatus_idioma02");
        });

        modelBuilder.Entity<NotaCreditoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("nota_credito_tipo");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<NotaCreditoTipoPeru>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK_nota_credito_tipo_peru_id_tipo");

            entity.ToTable("nota_credito_tipo_peru");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<NumUnidade>(entity =>
        {
            entity.HasKey(e => e.IdNumUnidades).HasName("PK__num_unid__146F0B36624EAB1E");

            entity.ToTable("num_unidades");

            entity.Property(e => e.IdNumUnidades)
                .ValueGeneratedNever()
                .HasColumnName("id_num_unidades");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('S/D')")
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Objetivo>(entity =>
        {
            entity.HasKey(e => e.IdObjetivo);

            entity.ToTable("objetivos");

            entity.Property(e => e.IdObjetivo)
                .ValueGeneratedNever()
                .HasColumnName("id_objetivo");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Ingresos)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ingresos");
            entity.Property(e => e.Periodo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("periodo");
            entity.Property(e => e.Viajes).HasColumnName("viajes");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Objetivos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_objetivos01");
        });

        modelBuilder.Entity<ObjetoImpuesto>(entity =>
        {
            entity.HasKey(e => e.IdObjetoImpuesto).HasName("PK__objeto_i__57B2C3275FFDE166");

            entity.ToTable("objeto_impuesto");

            entity.HasIndex(e => e.IdObjetoImpuesto, "UQ_id_objeto_impuesto").IsUnique();

            entity.Property(e => e.IdObjetoImpuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<ObjetoImpuestoIdioma>(entity =>
        {
            entity.HasKey(e => e.IdObjetoImpuesto).HasName("PK__objeto_i__57B2C327346E60C4");

            entity.ToTable("objeto_impuesto_idioma");

            entity.Property(e => e.IdObjetoImpuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_objeto_impuesto");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<OrdenCompraViaje>(entity =>
        {
            entity.HasKey(e => e.IdOrdenCompra).HasName("PK_orden_compra_viaje01");

            entity.ToTable("orden_compra_viaje");

            entity.Property(e => e.IdOrdenCompra)
                .ValueGeneratedNever()
                .HasColumnName("id_orden_compra");
            entity.Property(e => e.ComplementoPagoProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("complemento_pago_proveedor");
            entity.Property(e => e.FacturaProveedor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("factura_proveedor");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPlazaDestino).HasColumnName("id_plaza_destino");
            entity.Property(e => e.IdPlazaOrigen).HasColumnName("id_plaza_origen");
            entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");
            entity.Property(e => e.MontoCompra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_compra");
            entity.Property(e => e.MontoVenta)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_venta");
            entity.Property(e => e.NumOrdenCompra)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_orden_compra");
            entity.Property(e => e.NumPedido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("num_pedido");
            entity.Property(e => e.NumVale)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("num_vale");
            entity.Property(e => e.OrdenCompra)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("orden_compra");
            entity.Property(e => e.PesoBascula)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_bascula");
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("producto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Remision)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("remision");
            entity.Property(e => e.TonelajeCompra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tonelaje_compra");
            entity.Property(e => e.TonelajeRemision)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tonelaje_remision");
            entity.Property(e => e.TonelajeVenta)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tonelaje_venta");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.OrdenCompraViajes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orden_compra_viaje_id_empresa");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.OrdenCompraViajeIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orden_compra_viaje_id_ingreso");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.OrdenCompraViajeIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orden_compra_viaje_id_modifico");
        });

        modelBuilder.Entity<PagoEstado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("pago_estados");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PaisId).HasColumnName("pais_id");
        });

        modelBuilder.Entity<PagoPaise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("pago_paises");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PagosCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pagos_clientes");

            entity.ToTable("pagos_clientes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PagosCorte>(entity =>
        {
            entity.ToTable("pagos_cortes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComisionPromotor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("comision_promotor");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");
            entity.Property(e => e.EstatusComision)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus_comision");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.ObservacionesComision)
                .HasColumnType("text")
                .HasColumnName("observaciones_comision");
            entity.Property(e => e.PagoId).HasColumnName("pago_id");
            entity.Property(e => e.PartidaId).HasColumnName("partida_id");
            entity.Property(e => e.Unidades).HasColumnName("unidades");

            entity.HasOne(d => d.Empresa).WithMany(p => p.PagosCortes)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_pagos_cortes03");

            entity.HasOne(d => d.Pago).WithMany(p => p.PagosCortes)
                .HasForeignKey(d => d.PagoId)
                .HasConstraintName("FK_pagos_cortes01");

            entity.HasOne(d => d.Partida).WithMany(p => p.PagosCortes)
                .HasForeignKey(d => d.PartidaId)
                .HasConstraintName("FK_pagos_cortes02");
        });

        modelBuilder.Entity<PagosEmpresa>(entity =>
        {
            entity.ToTable("pagos_empresas", tb =>
                {
                    tb.HasTrigger("tr_datos_empresa");
                    tb.HasTrigger("tr_empresas_activo");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Cp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Delegacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delegacion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaCorte)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaCorte");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NombreDelContacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_del_contacto");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.Pais).HasColumnName("pais");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Premium).HasColumnName("premium");
            entity.Property(e => e.PromotorId).HasColumnName("promotor_id");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("razon_social");
            entity.Property(e => e.ReferenciaId).HasColumnName("referencia_id");
            entity.Property(e => e.ReferenciaOtro)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("referencia_otro");
            entity.Property(e => e.Rfc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UnidadesAgregadas).HasColumnName("unidades_agregadas");
            entity.Property(e => e.UnidadesContratadas).HasColumnName("unidades_contratadas");
            entity.Property(e => e.UnidadesPagadas).HasColumnName("unidades_pagadas");
            entity.Property(e => e.UsuarioContratoUnidades).HasColumnName("usuario_contrato_unidades");
            entity.Property(e => e.Vigencia)
                .HasColumnType("date")
                .HasColumnName("vigencia");
        });

        modelBuilder.Entity<PagosEstado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("pagos_estados");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PaisId).HasColumnName("pais_id");
        });

        modelBuilder.Entity<PagosFpago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pagos_fpagos");

            entity.ToTable("pagos_fpagos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clientid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clientid");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Forma)
                .HasColumnType("text")
                .HasColumnName("forma");
            entity.Property(e => e.Host)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Respuesta)
                .HasColumnType("text")
                .HasColumnName("respuesta");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("url");
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user");
        });

        modelBuilder.Entity<PagosFpagosRegla>(entity =>
        {
            entity.ToTable("pagos_fpagos_reglas");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FpagoId).HasColumnName("fpago_id");
            entity.Property(e => e.PorcentajeComision)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("porcentaje_comision");
        });

        modelBuilder.Entity<PagosGrupo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pagos_grupos");

            entity.ToTable("pagos_grupos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creado)
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Seguridad).HasColumnName("seguridad");
            entity.Property(e => e.Ts)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ts");
        });

        modelBuilder.Entity<PagosListimbrado>(entity =>
        {
            entity.ToTable("pagos_listimbrados");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proveedor");
            entity.Property(e => e.Saldo).HasColumnName("saldo");
        });

        modelBuilder.Entity<PagosPago>(entity =>
        {
            entity.ToTable("pagos_pagos", tb => tb.HasTrigger("Comisiones_Promotores_Pagos"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComisionPromotor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("comision_promotor");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DatosTransaccion)
                .HasColumnType("text")
                .HasColumnName("datos_transaccion");
            entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");
            entity.Property(e => e.Estatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FpagoId).HasColumnName("fpago_id");
            entity.Property(e => e.IdCorte).HasColumnName("id_corte");
            entity.Property(e => e.MontoPago).HasColumnName("monto_pago");
            entity.Property(e => e.Pagarpromotor)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pagarpromotor");
            entity.Property(e => e.PendienteFacturar).HasColumnName("pendiente_facturar");
            entity.Property(e => e.PromotorId).HasColumnName("promotor_id");

            entity.HasOne(d => d.Empresa).WithMany(p => p.PagosPagos)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_pagos_pagos01");

            entity.HasOne(d => d.Fpago).WithMany(p => p.PagosPagos)
                .HasForeignKey(d => d.FpagoId)
                .HasConstraintName("FK_pagos_pagos03");

            entity.HasOne(d => d.Promotor).WithMany(p => p.PagosPagos)
                .HasForeignKey(d => d.PromotorId)
                .HasConstraintName("FK_pagos_pagos02");
        });

        modelBuilder.Entity<PagosPaise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("pagos_paises");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PagosPartida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pagos_partidas");

            entity.ToTable("pagos_partidas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Base)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("base");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Edodecuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("edodecuenta");
            entity.Property(e => e.Meses).HasColumnName("meses");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pais)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pais");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Rangofinal).HasColumnName("rangofinal");
            entity.Property(e => e.Rangoinicial).HasColumnName("rangoinicial");
            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

            entity.HasOne(d => d.Servicio).WithMany(p => p.PagosPartida)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_pagos_partidas01");
        });

        modelBuilder.Entity<PagosPromotore>(entity =>
        {
            entity.ToTable("pagos_promotores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Banco).HasColumnName("banco");
            entity.Property(e => e.ClabeInterbancaria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clabe_interbancaria");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CuentaBancaria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cuenta_bancaria");
            entity.Property(e => e.FormaPago).HasColumnName("forma_pago");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PromotorLis).HasColumnName("promotor_lis");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razon_social");
            entity.Property(e => e.Slug)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("slug");
        });

        modelBuilder.Entity<PagosReferenciacontacto>(entity =>
        {
            entity.ToTable("pagos_referenciacontactos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<PagosRegla>(entity =>
        {
            entity.ToTable("pagos_reglas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.Creado)
                .HasColumnType("datetime")
                .HasColumnName("creado");
            entity.Property(e => e.GrupoId).HasColumnName("grupo_id");
            entity.Property(e => e.Modificado)
                .HasColumnType("datetime")
                .HasColumnName("modificado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Padre).HasColumnName("padre");
            entity.Property(e => e.Permitir).HasColumnName("permitir");
            entity.Property(e => e.Ts)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ts");

            entity.HasOne(d => d.Grupo).WithMany(p => p.PagosReglas)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pagos_reglas01");
        });

        modelBuilder.Entity<PagosServicio>(entity =>
        {
            entity.ToTable("pagos_servicios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PorcentajePromotor).HasColumnName("porcentaje_promotor");
            entity.Property(e => e.Webservice)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("webservice");
        });

        modelBuilder.Entity<PagosServiciosComisione>(entity =>
        {
            entity.ToTable("pagos_servicios_comisiones");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");
            entity.Property(e => e.PorcentajeLis).HasColumnName("porcentaje_lis");
            entity.Property(e => e.RangoFinalMeses).HasColumnName("rango_final_meses");
            entity.Property(e => e.RangoInicialMeses).HasColumnName("rango_inicial_meses");
            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

            entity.HasOne(d => d.Servicio).WithMany(p => p.PagosServiciosComisiones)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pagos_servicios_comisiones_01");
        });

        modelBuilder.Entity<PagosServicioscontratado>(entity =>
        {
            entity.ToTable("pagos_servicioscontratados");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");
            entity.Property(e => e.FechaContratacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_contratacion");
            entity.Property(e => e.PagoId).HasColumnName("pago_id");
            entity.Property(e => e.PromotorId).HasColumnName("promotor_id");
            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

            entity.HasOne(d => d.Empresa).WithMany(p => p.PagosServicioscontratados)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_pagos_servicioscontratados01");

            entity.HasOne(d => d.Promotor).WithMany(p => p.PagosServicioscontratados)
                .HasForeignKey(d => d.PromotorId)
                .HasConstraintName("FK_pagos_servicioscontratados03");

            entity.HasOne(d => d.Servicio).WithMany(p => p.PagosServicioscontratados)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_pagos_servicioscontratados02");
        });

        modelBuilder.Entity<PagosTimbrado>(entity =>
        {
            entity.ToTable("pagos_timbrados");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Saldo).HasColumnName("saldo");

            entity.HasOne(d => d.Empresa).WithMany(p => p.PagosTimbrados)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_pagos_timbrados_01");
        });

        modelBuilder.Entity<PagosTimbreslistmsli>(entity =>
        {
            entity.HasKey(e => new { e.ListimbresId, e.ListmstimbresId });

            entity.ToTable("pagos_timbreslistmslis");

            entity.Property(e => e.ListimbresId).HasColumnName("listimbres_id");
            entity.Property(e => e.ListmstimbresId).HasColumnName("listmstimbres_id");
            entity.Property(e => e.SaldoRelacionado).HasColumnName("saldo_relacionado");
        });

        modelBuilder.Entity<PagosTimbreszamli>(entity =>
        {
            entity.HasKey(e => new { e.ListimbresId, e.ZamtimbresId });

            entity.ToTable("pagos_timbreszamlis");

            entity.Property(e => e.ListimbresId).HasColumnName("listimbres_id");
            entity.Property(e => e.ZamtimbresId).HasColumnName("zamtimbres_id");
            entity.Property(e => e.SaldoRelacionado).HasColumnName("saldo_relacionado");
        });

        modelBuilder.Entity<PagosUsuario>(entity =>
        {
            entity.ToTable("pagos_usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Seguridad).HasColumnName("seguridad");
            entity.Property(e => e.Supervisor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("supervisor");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.Cliente).WithMany(p => p.PagosUsuarios)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_pagos_usuarios01");
        });

        modelBuilder.Entity<PagosUsuariosGrupo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pagos_usuarios_grupos");

            entity.ToTable("pagos_usuarios_grupos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GrupoId).HasColumnName("grupo_id");
            entity.Property(e => e.Seguridad).HasColumnName("seguridad");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Grupo).WithMany(p => p.PagosUsuariosGrupos)
                .HasForeignKey(d => d.GrupoId)
                .HasConstraintName("FK_pagos_usuarios_grupos01");

            entity.HasOne(d => d.Usuario).WithMany(p => p.PagosUsuariosGrupos)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_pagos_usuarios_grupos02");
        });

        modelBuilder.Entity<PagosZamlicencia>(entity =>
        {
            entity.ToTable("pagos_zamlicencias");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.LicenciaNet)
                .HasMaxLength(500)
                .HasColumnName("licenciaNET");
            entity.Property(e => e.LicenciaPb)
                .HasMaxLength(500)
                .HasColumnName("licenciaPB");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
        });

        modelBuilder.Entity<PagosZamtimbrado>(entity =>
        {
            entity.ToTable("pagos_zamtimbrados");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Saldo).HasColumnName("saldo");
        });

        modelBuilder.Entity<PagosZona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pagos_zonas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdZona)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_zona");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais);

            entity.ToTable("pais");

            entity.Property(e => e.IdPais)
                .ValueGeneratedNever()
                .HasColumnName("id_pais");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.ClavePeru)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("clave_peru");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdEmpresaModelo).HasColumnName("id_empresa_modelo");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdUnidadDistancia).HasColumnName("id_unidad_distancia");
            entity.Property(e => e.IdUnidadPeso).HasColumnName("id_unidad_peso");
            entity.Property(e => e.IdUnidadVolumen).HasColumnName("id_unidad_volumen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Region)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("region");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Pais)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pais05");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.Pais)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pais01");

            entity.HasOne(d => d.IdUnidadDistanciaNavigation).WithMany(p => p.PaiIdUnidadDistanciaNavigations)
                .HasForeignKey(d => d.IdUnidadDistancia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pais04");

            entity.HasOne(d => d.IdUnidadPesoNavigation).WithMany(p => p.PaiIdUnidadPesoNavigations)
                .HasForeignKey(d => d.IdUnidadPeso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pais02");

            entity.HasOne(d => d.IdUnidadVolumenNavigation).WithMany(p => p.PaiIdUnidadVolumenNavigations)
                .HasForeignKey(d => d.IdUnidadVolumen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pais03");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__pedido__6FF014892D0D5ACF");

            entity.ToTable("pedido");

            entity.Property(e => e.IdPedido).HasColumnName("id_pedido");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.Folio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatusPedido).HasColumnName("id_estatus_pedido");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");
            entity.Property(e => e.IdRuta).HasColumnName("id_ruta");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pedidodestinatario");

            entity.HasOne(d => d.IdEstatusPedidoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdEstatusPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pedidoestatus");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdRuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pedidoviaje_ruta");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pedidoviaje");
        });

        modelBuilder.Entity<Periodicidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_periodicidad_id");

            entity.ToTable("periodicidad");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClavePeriodicidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave_periodicidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<PermisionarioTarifa>(entity =>
        {
            entity.HasKey(e => e.IdTarifaPermisionario).HasName("PK_permisionario_tarifa01");

            entity.ToTable("permisionario_tarifa");

            entity.Property(e => e.IdTarifaPermisionario)
                .ValueGeneratedNever()
                .HasColumnName("id_tarifa_permisionario");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Factor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipoTarifa).HasColumnName("id_tipo_tarifa");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.PermisionarioTarifas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_id_empresa");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.PermisionarioTarifaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_id_ingreso");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.PermisionarioTarifaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_id_modifico");

            entity.HasOne(d => d.IdTipoTarifaNavigation).WithMany(p => p.PermisionarioTarifas)
                .HasForeignKey(d => d.IdTipoTarifa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_id_tipo_tarifa");
        });

        modelBuilder.Entity<PermisionarioTarifaConfiguracion>(entity =>
        {
            entity.HasKey(e => e.IdTarifaConfiguracion).HasName("PK_permisionario_tarifa_configuracion01");

            entity.ToTable("permisionario_tarifa_configuracion");

            entity.Property(e => e.IdTarifaConfiguracion)
                .ValueGeneratedNever()
                .HasColumnName("id_tarifa_configuracion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdLineaUnidad).HasColumnName("id_linea_unidad");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTarifaPermisionario).HasColumnName("id_tarifa_permisionario");
            entity.Property(e => e.ViajeTipo).HasColumnName("viaje_tipo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.PermisionarioTarifaConfiguracions)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_configuracion_id_empresa");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.PermisionarioTarifaConfiguracionIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_configuracion_id_ingreso");

            entity.HasOne(d => d.IdLineaUnidadNavigation).WithMany(p => p.PermisionarioTarifaConfiguracions)
                .HasForeignKey(d => d.IdLineaUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_configuracion_id_linea_unidad");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.PermisionarioTarifaConfiguracionIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_configuracion_id_modifico");

            entity.HasOne(d => d.IdTarifaPermisionarioNavigation).WithMany(p => p.PermisionarioTarifaConfiguracions)
                .HasForeignKey(d => d.IdTarifaPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_configuracion_id_tarifa");

            entity.HasOne(d => d.ViajeTipoNavigation).WithMany(p => p.PermisionarioTarifaConfiguracions)
                .HasForeignKey(d => d.ViajeTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_configuracion_viaje_tipo");
        });

        modelBuilder.Entity<PermisionarioTarifaRutum>(entity =>
        {
            entity.HasKey(e => new { e.IdTarifaPermisionario, e.IdRuta }).HasName("PK_permisionario_tarifa_ruta01");

            entity.ToTable("permisionario_tarifa_ruta");

            entity.Property(e => e.IdTarifaPermisionario).HasColumnName("id_tarifa_permisionario");
            entity.Property(e => e.IdRuta).HasColumnName("id_ruta");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.PermisionarioTarifaRuta)
                .HasForeignKey(d => d.IdRuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_ruta_id_ruta");

            entity.HasOne(d => d.IdTarifaPermisionarioNavigation).WithMany(p => p.PermisionarioTarifaRuta)
                .HasForeignKey(d => d.IdTarifaPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_ruta_id_tarifa_permisionario");
        });

        modelBuilder.Entity<PermisionarioTarifaTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoTarifa).HasName("PK_permisionario_tarifa_tipo01");

            entity.ToTable("permisionario_tarifa_tipo");

            entity.Property(e => e.IdTipoTarifa)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_tarifa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<PermisionarioTarifaTipoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoTarifa, e.IdIdioma }).HasName("PK_permisionario_tarifa_tipo_idioma01");

            entity.ToTable("permisionario_tarifa_tipo_idioma");

            entity.Property(e => e.IdTipoTarifa).HasColumnName("id_tipo_tarifa");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdTipoTarifaNavigation).WithMany(p => p.PermisionarioTarifaTipoIdiomas)
                .HasForeignKey(d => d.IdTipoTarifa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_permisionario_tarifa_tipo_idioma_id_tipo_tarifa");
        });

        modelBuilder.Entity<PermisionarioTipoConcepto>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK_permisionario_tipo_concepto01");

            entity.ToTable("permisionario_tipo_concepto");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.IdPersonal);

            entity.ToTable("personal");

            entity.Property(e => e.IdPersonal)
                .ValueGeneratedNever()
                .HasColumnName("id_personal");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido2");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Celular)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.ClaveinterbancariaSat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("claveinterbancaria_sat");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Correo)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("correo");
            entity.Property(e => e.Cuentabancaria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("cuentabancaria");
            entity.Property(e => e.Curp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("curp");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("departamento");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaContratacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_contratacion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.FechaVencContrato)
                .HasColumnType("datetime")
                .HasColumnName("fecha_venc_contrato");
            entity.Property(e => e.IdBancosat)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_bancosat");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdEmpleadoClickb).HasColumnName("id_empleado_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdJornada)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_jornada");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdPeriodicidad).HasColumnName("id_periodicidad");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegimen).HasColumnName("id_regimen");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipoContrato)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_tipo_contrato");
            entity.Property(e => e.IdTipoEmpleado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_tipo_empleado");
            entity.Property(e => e.Imei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IMEI");
            entity.Property(e => e.Imss)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imss");
            entity.Property(e => e.LineaUnidadPersonal)
                .HasDefaultValueSql("('0')")
                .HasColumnName("linea_unidad_personal");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NumEmpleado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("num_empleado");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.Numregidtrib)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numregidtrib");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OperadorExterno)
                .HasDefaultValueSql("('0')")
                .HasColumnName("operador_externo");
            entity.Property(e => e.PasswordRoutech)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("password_routech");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("regimen_fiscal");
            entity.Property(e => e.Rfc)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("rfc");
            entity.Property(e => e.RfcLabora)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("rfcLabora");
            entity.Property(e => e.Salariodiariointegrado)
                .HasDefaultValueSql("((1.0))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("salariodiariointegrado");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Sindicalizado).HasColumnName("sindicalizado");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('01')")
                .HasColumnName("tipo_persona");
            entity.Property(e => e.UsuarioRoutech)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("usuario_routech");

            entity.HasOne(d => d.IdBancosatNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdBancosat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal10");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal05");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal02");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.PersonalIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.PersonalIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal03");

            entity.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal06");

            entity.HasOne(d => d.IdTipoContratoNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdTipoContrato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal08");

            entity.HasOne(d => d.IdTipoEmpleadoNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdTipoEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal09");
        });

        modelBuilder.Entity<PersonalCatRiesgo>(entity =>
        {
            entity.HasKey(e => e.IdClaveSat);

            entity.ToTable("personal_cat_riesgo");

            entity.Property(e => e.IdClaveSat)
                .ValueGeneratedNever()
                .HasColumnName("id_clave_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<PersonalCategorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria);

            entity.ToTable("personal_categoria");

            entity.Property(e => e.IdCategoria)
                .ValueGeneratedNever()
                .HasColumnName("id_categoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRiesgo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_riesgo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.PersonalCategoria)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_categoria02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.PersonalCategoria)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_categoria01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.PersonalCategoriumIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_categoria04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.PersonalCategoriumIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_categoria03");
        });

        modelBuilder.Entity<PersonalEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("personal_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<PersonalEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("personal_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.PersonalEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.PersonalEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_estatus_idioma02");
        });

        modelBuilder.Entity<PersonalJornadum>(entity =>
        {
            entity.HasKey(e => e.IdJornada);

            entity.ToTable("personal_jornada");

            entity.Property(e => e.IdJornada)
                .ValueGeneratedNever()
                .HasColumnName("id_jornada");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("claveSAT");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<PersonalOperador>(entity =>
        {
            entity.HasKey(e => e.IdPersonal);

            entity.ToTable("personal_operador");

            entity.Property(e => e.IdPersonal)
                .ValueGeneratedNever()
                .HasColumnName("id_personal");
            entity.Property(e => e.FechaVencelicencia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencelicencia");
            entity.Property(e => e.Licencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("licencia");
            entity.Property(e => e.Tipolicencia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tipolicencia");

            entity.HasOne(d => d.IdPersonalNavigation).WithOne(p => p.PersonalOperador)
                .HasForeignKey<PersonalOperador>(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personal_operador01");
        });

        modelBuilder.Entity<PersonalPeriodicidad>(entity =>
        {
            entity.HasKey(e => e.IdPeriodicidad);

            entity.ToTable("personal_periodicidad");

            entity.Property(e => e.IdPeriodicidad)
                .ValueGeneratedNever()
                .HasColumnName("id_periodicidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<PersonalRegiman>(entity =>
        {
            entity.HasKey(e => e.IdRegimen);

            entity.ToTable("personal_regimen");

            entity.Property(e => e.IdRegimen).HasColumnName("id_regimen");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("clave_sat");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<PersonalTipoContrato>(entity =>
        {
            entity.HasKey(e => e.IdTipoContrato).HasName("PK_personal_tipo_contrato_id_tipo_contrato");

            entity.ToTable("personal_tipo_contrato");

            entity.Property(e => e.IdTipoContrato).HasColumnName("id_tipo_contrato");
            entity.Property(e => e.ClaveSat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("claveSAT");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<PersonalTipoEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdTipoEmpleado).HasName("PK_personal_tipo_empleado_id_tipo_empleado");

            entity.ToTable("personal_tipo_empleado");

            entity.Property(e => e.IdTipoEmpleado).HasColumnName("id_tipo_empleado");
            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<PersonalTipoPersona>(entity =>
        {
            entity.HasKey(e => e.IdTipoPersona).HasName("PK_personal_tipo_persona_id_tipo_persona");

            entity.ToTable("personal_tipo_persona");

            entity.Property(e => e.IdTipoPersona).HasColumnName("id_tipo_persona");
            entity.Property(e => e.Clave)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<PeticionIum>(entity =>
        {
            entity.HasKey(e => e.IdPeticionIa).HasName("pk_peticion_ia");

            entity.ToTable("peticion_ia");

            entity.Property(e => e.IdPeticionIa).HasColumnName("id_peticion_ia");
            entity.Property(e => e.CacheTokens)
                .HasDefaultValueSql("((0))")
                .HasComment("Tokens en cache")
                .HasColumnName("cache_tokens");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFuncionIa).HasColumnName("id_funcion_ia");
            entity.Property(e => e.IdModeloIa)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_modelo_ia");
            entity.Property(e => e.InputTokens)
                .HasDefaultValueSql("((0))")
                .HasComment("Tokens de entrada")
                .HasColumnName("input_tokens");
            entity.Property(e => e.IsFreeTier).HasColumnName("is_free_tier");
            entity.Property(e => e.OutputTokens)
                .HasDefaultValueSql("((0))")
                .HasComment("Tokens de salida")
                .HasColumnName("output_tokens");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.PeticionIa)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("fk_peticion_ia_empresa");

            entity.HasOne(d => d.IdFuncionIaNavigation).WithMany(p => p.PeticionIa)
                .HasForeignKey(d => d.IdFuncionIa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_peticion_ia_forma_pago");

            entity.HasOne(d => d.IdModeloIaNavigation).WithMany(p => p.PeticionIa)
                .HasForeignKey(d => d.IdModeloIa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_peticion_ia_modelo_ia");
        });

        modelBuilder.Entity<Plaza>(entity =>
        {
            entity.HasKey(e => e.IdPlaza);

            entity.ToTable("plaza");

            entity.HasIndex(e => new { e.NombreBusqueda, e.IdEmpresa }, "XAK_plaza01").IsUnique();

            entity.Property(e => e.IdPlaza)
                .ValueGeneratedNever()
                .HasColumnName("id_plaza");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(19, 12)")
                .HasColumnName("lat");
            entity.Property(e => e.Lon)
                .HasColumnType("decimal(19, 12)")
                .HasColumnName("lon");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NombrePlaza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_plaza");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Plazas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plaza02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Plazas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plaza01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.PlazaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plaza04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.PlazaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_plaza03");
        });

        modelBuilder.Entity<PreguntaFrecuente>(entity =>
        {
            entity.HasKey(e => e.IdPregunta);

            entity.ToTable("pregunta_frecuente");

            entity.Property(e => e.IdPregunta)
                .ValueGeneratedNever()
                .HasColumnName("id_pregunta");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Resumen)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("resumen");
            entity.Property(e => e.TextoAyuda)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("texto_ayuda");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.PreguntaFrecuentes)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pregunta_frecuente01");
        });

        modelBuilder.Entity<PreguntaVentana>(entity =>
        {
            entity.HasKey(e => new { e.IdPregunta, e.IdVentana });

            entity.ToTable("pregunta_ventana");

            entity.Property(e => e.IdPregunta).HasColumnName("id_pregunta");
            entity.Property(e => e.IdVentana).HasColumnName("id_ventana");
            entity.Property(e => e.VisibleVentana).HasColumnName("visible_ventana");

            entity.HasOne(d => d.IdPreguntaNavigation).WithMany(p => p.PreguntaVentanas)
                .HasForeignKey(d => d.IdPregunta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pregunta_ventana01");

            entity.HasOne(d => d.IdVentanaNavigation).WithMany(p => p.PreguntaVentanas)
                .HasForeignKey(d => d.IdVentana)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pregunta_ventana02");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto);

            entity.ToTable("producto");

            entity.Property(e => e.IdProducto)
                .ValueGeneratedNever()
                .HasColumnName("id_producto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DescripcionTipoMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("descripcion_tipo_materia");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdClaveMaterialPeligroso).HasColumnName("id_clave_material_peligroso");
            entity.Property(e => e.IdClaveUnidad)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_clave_unidad");
            entity.Property(e => e.IdClaveprodservCp).HasColumnName("id_claveprodserv_cp");
            entity.Property(e => e.IdEmbalaje).HasColumnName("id_embalaje");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFraccionArancelaria).HasColumnName("id_fraccion_arancelaria");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipoMateria).HasColumnName("id_tipo_materia");
            entity.Property(e => e.IdTipoembalaje).HasColumnName("id_tipoembalaje");
            entity.Property(e => e.IdTipoembalajeMp).HasColumnName("id_tipoembalaje_mp");
            entity.Property(e => e.IdUnidadMedidaPeso).HasColumnName("id_unidad_medida_peso");
            entity.Property(e => e.IdUnidadembalaje)
                .HasDefaultValueSql("((376))")
                .HasColumnName("id_unidadembalaje");
            entity.Property(e => e.MaterialPeligroso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("material_peligroso");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso");
            entity.Property(e => e.ValorMercancia)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("valor_mercancia");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_producto02");

            entity.HasOne(d => d.IdEmbalajeNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdEmbalaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_producto05");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_producto01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ProductoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_producto03");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ProductoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_producto04");
        });

        modelBuilder.Entity<ProductoDocumentoAduanero>(entity =>
        {
            entity.HasKey(e => e.IdDocumentoAduanero).HasName("PK__producto__B890F70FBC20B45A");

            entity.ToTable("producto_documento_aduanero");

            entity.Property(e => e.IdDocumentoAduanero).HasColumnName("id_documento_aduanero");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<ProductoTipoMaterium>(entity =>
        {
            entity.HasKey(e => e.IdTipoMateria).HasName("PK__producto__395C02A5CB7B7242");

            entity.ToTable("producto_tipo_materia");

            entity.Property(e => e.IdTipoMateria).HasColumnName("id_tipo_materia");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Profiling>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Profiling");

            entity.Property(e => e.Spid).HasColumnName("spid");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor);

            entity.ToTable("proveedor");

            entity.Property(e => e.IdProveedor)
                .ValueGeneratedNever()
                .HasColumnName("id_proveedor");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.CuentaBancaria)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cuenta_bancaria");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("rfc");
            entity.Property(e => e.Ruc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ruc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono_2");
            entity.Property(e => e.Telefono3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono_3");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor01");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor05");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ProveedorIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor03");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor08");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ProveedorIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor04");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor06");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor07");

            entity.HasMany(d => d.IdClientes).WithMany(p => p.IdProveedors)
                .UsingEntity<Dictionary<string, object>>(
                    "ProveedorCliente",
                    r => r.HasOne<Cliente>().WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_proveedor_cliente02"),
                    l => l.HasOne<Proveedor>().WithMany()
                        .HasForeignKey("IdProveedor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_proveedor_cliente01"),
                    j =>
                    {
                        j.HasKey("IdProveedor", "IdCliente");
                        j.ToTable("proveedor_cliente");
                        j.IndexerProperty<int>("IdProveedor").HasColumnName("id_proveedor");
                        j.IndexerProperty<int>("IdCliente").HasColumnName("id_cliente");
                    });
        });

        modelBuilder.Entity<ProveedorCombustible>(entity =>
        {
            entity.HasKey(e => e.IdProveedor);

            entity.ToTable("proveedor_combustible");

            entity.Property(e => e.IdProveedor)
                .ValueGeneratedNever()
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Consecutivo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("consecutivo");
            entity.Property(e => e.ControlaFolio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("controla_folio");
            entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");

            entity.HasOne(d => d.IdProveedorNavigation).WithOne(p => p.ProveedorCombustible)
                .HasForeignKey<ProveedorCombustible>(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor_combustible01");

            entity.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.ProveedorCombustibles)
                .HasForeignKey(d => d.IdTarifa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor_combustible02");
        });

        modelBuilder.Entity<ProveedorRol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("proveedor_rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("id_rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ProveedorRolIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdRol, e.IdIdioma });

            entity.ToTable("proveedor_rol_idioma");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ProveedorRolIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor_rol_idioma01");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.ProveedorRolIdiomas)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_proveedor_rol_idioma02");
        });

        modelBuilder.Entity<RegimenAduaneroGuium>(entity =>
        {
            entity.HasKey(e => e.IdRegimenAduaneroGuia);

            entity.ToTable("regimen_aduanero_guia");

            entity.Property(e => e.IdRegimenAduaneroGuia).HasColumnName("id_regimen_aduanero_guia");
            entity.Property(e => e.IdGuia).HasColumnName("id_guia");
            entity.Property(e => e.IdRegimenAduanero).HasColumnName("id_regimen_aduanero");

            entity.HasOne(d => d.IdGuiaNavigation).WithMany(p => p.RegimenAduaneroGuia)
                .HasForeignKey(d => d.IdGuia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_regimen_aduanero_guia_guia");

            entity.HasOne(d => d.IdRegimenAduaneroNavigation).WithMany(p => p.RegimenAduaneroGuia)
                .HasForeignKey(d => d.IdRegimenAduanero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_regimen_aduanero_guia");
        });

        modelBuilder.Entity<ReglasEliminacionImpresion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__reglas_e__3213E83FAD38C8B5");

            entity.ToTable("reglas_eliminacion_impresion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.IdImpresion).HasColumnName("id_impresion");
            entity.Property(e => e.IdPais).HasColumnName("idPais");
        });

        modelBuilder.Entity<RelacionTipo>(entity =>
        {
            entity.HasKey(e => e.IdRelacionTipo).HasName("PK_relacion_tipo_id_relacion_tipo");

            entity.ToTable("relacion_tipo");

            entity.HasIndex(e => e.Clave, "UQ_relacion_tipo_clave").IsUnique();

            entity.Property(e => e.IdRelacionTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_relacion_tipo");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Relacionllaveprimarium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("relacionllaveprimaria");

            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdPrimario).HasColumnName("id_primario");
            entity.Property(e => e.IdRelacion).HasColumnName("id_relacion");
            entity.Property(e => e.Identificador)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("identificador");
        });

        modelBuilder.Entity<RoutechEstatus>(entity =>
        {
            entity.HasKey(e => e.IdRoutechEstatus).HasName("PK__routech___61F4C150F374317C");

            entity.ToTable("routech_estatus");

            entity.Property(e => e.IdRoutechEstatus).HasColumnName("id_routech_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SeguridadAyudaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdIdioma, e.IdAyuda }).HasName("PK_seguridad_ayuda_idioma01");

            entity.ToTable("seguridad_ayuda_idioma");

            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdAyuda).HasColumnName("id_ayuda");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdAyudaNavigation).WithMany(p => p.SeguridadAyudaIdiomas)
                .HasForeignKey(d => d.IdAyuda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_ayuda_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.SeguridadAyudaIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_ayuda_idioma01");
        });

        modelBuilder.Entity<SeguridadAyudum>(entity =>
        {
            entity.HasKey(e => e.IdAyuda);

            entity.ToTable("seguridad_ayuda");

            entity.Property(e => e.IdAyuda)
                .ValueGeneratedNever()
                .HasColumnName("id_ayuda");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Llave)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("llave");
        });

        modelBuilder.Entity<SeguridadGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.ToTable("seguridad_grupo");

            entity.Property(e => e.IdGrupo)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo");
            entity.Property(e => e.Administrador)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("administrador");
            entity.Property(e => e.Clasegrupo).HasColumnName("clasegrupo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");

            entity.HasMany(d => d.IdMenus).WithMany(p => p.IdGrupos)
                .UsingEntity<Dictionary<string, object>>(
                    "SeguridadMenugrupo",
                    r => r.HasOne<SeguridadMenu>().WithMany()
                        .HasForeignKey("IdMenu")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_seguridad_menugrupo02"),
                    l => l.HasOne<SeguridadGrupo>().WithMany()
                        .HasForeignKey("IdGrupo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_seguridad_menugrupo01"),
                    j =>
                    {
                        j.HasKey("IdGrupo", "IdMenu");
                        j.ToTable("seguridad_menugrupo");
                        j.IndexerProperty<int>("IdGrupo").HasColumnName("id_grupo");
                        j.IndexerProperty<int>("IdMenu").HasColumnName("id_menu");
                    });
        });

        modelBuilder.Entity<SeguridadGrupoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdGrupo, e.IdIdioma });

            entity.ToTable("seguridad_grupo_idioma");

            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.SeguridadGrupoIdiomas)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_grupo_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.SeguridadGrupoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_grupo_idioma02");
        });

        modelBuilder.Entity<SeguridadMenu>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.ToTable("seguridad_menu");

            entity.Property(e => e.IdMenu)
                .ValueGeneratedNever()
                .HasColumnName("id_menu");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdMenupadre).HasColumnName("id_menupadre");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.RutaArchivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruta_archivo");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<SeguridadMenuAyudum>(entity =>
        {
            entity.HasKey(e => new { e.IdMenu, e.IdAyuda }).HasName("PK_seguridad_menu_ayuda01");

            entity.ToTable("seguridad_menu_ayuda");

            entity.Property(e => e.IdMenu).HasColumnName("id_menu");
            entity.Property(e => e.IdAyuda).HasColumnName("id_ayuda");
            entity.Property(e => e.RutaAyuda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruta_ayuda");

            entity.HasOne(d => d.IdAyudaNavigation).WithMany(p => p.SeguridadMenuAyuda)
                .HasForeignKey(d => d.IdAyuda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_menu_ayuda02");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.SeguridadMenuAyuda)
                .HasForeignKey(d => d.IdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seguridad_menu_ayuda01");
        });

        modelBuilder.Entity<SeguridadMenuIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdMenu, e.IdIdioma });

            entity.ToTable("seguridad_menu_idioma");

            entity.Property(e => e.IdMenu).HasColumnName("id_menu");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SerieCargo>(entity =>
        {
            entity.HasKey(e => e.IdSerie);

            entity.ToTable("serie_cargo");

            entity.Property(e => e.IdSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_serie");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.Formato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.IdControla).HasColumnName("id_controla");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipodocClickb).HasColumnName("id_tipodoc_clickb");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.PlazaEmision).HasColumnName("plaza_emision");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("prefijo");
            entity.Property(e => e.TipoFactura).HasColumnName("tipo_factura");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.SerieCargos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_cargo02");

            entity.HasOne(d => d.IdControlaNavigation).WithMany(p => p.SerieCargos)
                .HasForeignKey(d => d.IdControla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_cargo01");
        });

        modelBuilder.Entity<SerieControlaFolio>(entity =>
        {
            entity.HasKey(e => e.IdControla);

            entity.ToTable("serie_controla_folio");

            entity.Property(e => e.IdControla)
                .ValueGeneratedNever()
                .HasColumnName("id_controla");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<SerieControlaFolioIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdControla, e.IdIdioma });

            entity.ToTable("serie_controla_folio_idioma");

            entity.Property(e => e.IdControla).HasColumnName("id_controla");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdControlaNavigation).WithMany(p => p.SerieControlaFolioIdiomas)
                .HasForeignKey(d => d.IdControla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_controla_folio_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.SerieControlaFolioIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_controla_folio_idioma02");
        });

        modelBuilder.Entity<SerieCredito>(entity =>
        {
            entity.HasKey(e => e.IdSerie);

            entity.ToTable("serie_credito");

            entity.Property(e => e.IdSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_serie");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.Formato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.IdControla).HasColumnName("id_controla");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipodocClickb).HasColumnName("id_tipodoc_clickb");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.PlazaEmision).HasColumnName("plaza_emision");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("prefijo");
            entity.Property(e => e.TipoFactura).HasColumnName("tipo_factura");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.SerieCreditos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_credito02");

            entity.HasOne(d => d.IdControlaNavigation).WithMany(p => p.SerieCreditos)
                .HasForeignKey(d => d.IdControla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_credito01");
        });

        modelBuilder.Entity<SerieGuium>(entity =>
        {
            entity.HasKey(e => e.IdSerie);

            entity.ToTable("serie_guia");

            entity.Property(e => e.IdSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_serie");
            entity.Property(e => e.ComplementoCp).HasColumnName("complemento_cp");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.Formato)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.IdControla).HasColumnName("id_controla");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdTipodocClickb).HasColumnName("id_tipodoc_clickb");
            entity.Property(e => e.IsFactura).HasColumnName("is_factura");
            entity.Property(e => e.IsGuia).HasColumnName("is_guia");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.PlazaEmision).HasColumnName("plaza_emision");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("prefijo");
            entity.Property(e => e.TipoFactura).HasColumnName("tipo_factura");
            entity.Property(e => e.ValidezFiscal).HasColumnName("validez_fiscal");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.SerieGuia)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_guia02");

            entity.HasOne(d => d.IdControlaNavigation).WithMany(p => p.SerieGuia)
                .HasForeignKey(d => d.IdControla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_guia01");

            entity.HasOne(d => d.PlazaEmisionNavigation).WithMany(p => p.SerieGuia)
                .HasForeignKey(d => d.PlazaEmision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_guia03");
        });

        modelBuilder.Entity<SerieTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoSerie);

            entity.ToTable("serie_tipo");

            entity.Property(e => e.IdTipoSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_serie");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SerieTipoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoSerie, e.IdIdioma });

            entity.ToTable("serie_tipo_idioma");

            entity.Property(e => e.IdTipoSerie).HasColumnName("id_tipo_serie");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.SerieTipoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_tipo_idioma01");

            entity.HasOne(d => d.IdTipoSerieNavigation).WithMany(p => p.SerieTipoIdiomas)
                .HasForeignKey(d => d.IdTipoSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_serie_tipo_idioma02");
        });

        modelBuilder.Entity<Sesion>(entity =>
        {
            entity.HasKey(e => e.IdSesion);

            entity.ToTable("sesion");

            entity.Property(e => e.IdSesion).HasColumnName("id_sesion");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Navegador)
                .HasMaxLength(200)
                .HasColumnName("navegador");
            entity.Property(e => e.UltimaActividad)
                .HasColumnType("datetime")
                .HasColumnName("ultima_actividad");
        });

        modelBuilder.Entity<SesionUsuario>(entity =>
        {
            entity.HasKey(e => e.IdSesion).HasName("pk_sesion_usuario");

            entity.ToTable("sesion_usuario");

            entity.Property(e => e.IdSesion).HasColumnName("id_sesion");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Navegador)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("navegador");
            entity.Property(e => e.Token)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.UltimaActividad)
                .HasColumnType("datetime")
                .HasColumnName("ultima_actividad");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.SesionUsuarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sesion_usuario_empresa");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SesionUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sesion_usuario_usuario");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.IdSucursal);

            entity.ToTable("sucursal");

            entity.Property(e => e.IdSucursal)
                .ValueGeneratedNever()
                .HasColumnName("id_sucursal");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPlazaClickb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_plaza_clickb");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sucursal02");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sucursal01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.SucursalIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sucursal04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.SucursalIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sucursal03");
        });

        modelBuilder.Entity<Sugerencia>(entity =>
        {
            entity.HasKey(e => e.IdSugerencia);

            entity.ToTable("sugerencias");

            entity.Property(e => e.IdSugerencia)
                .ValueGeneratedNever()
                .HasColumnName("id_sugerencia");
            entity.Property(e => e.Descripcion1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion1");
            entity.Property(e => e.Descripcion2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion2");
            entity.Property(e => e.Descripcion3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion3");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Sugerencia)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sugerencias01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Sugerencia)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__sugerenci__id_es__18C19800");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Sugerencia)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sugerencias02");
        });

        modelBuilder.Entity<SugerenciaEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("sugerencia_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SugerenciaEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("sugerencia_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.SugerenciaEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sugerencia_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.SugerenciaEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sugerencia_estatus_idioma02");
        });

        modelBuilder.Entity<TasaCuotum>(entity =>
        {
            entity.HasKey(e => e.IdTasaCuota).HasName("PK_tasa_cuota_id_tasa_cuota");

            entity.ToTable("tasa_cuota");

            entity.Property(e => e.IdTasaCuota)
                .ValueGeneratedNever()
                .HasColumnName("id_tasa_cuota");
            entity.Property(e => e.Factor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("factor");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("impuesto");
            entity.Property(e => e.ValorMaximo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("valor_maximo");
        });

        modelBuilder.Entity<TipoCarga>(entity =>
        {
            entity.HasKey(e => e.IdTipoCarga).HasName("PK__tipo_car__5077A7FE26D18552");

            entity.ToTable("tipo_carga");

            entity.Property(e => e.IdTipoCarga)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_carga");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TipoConceptoContable>(entity =>
        {
            entity.HasKey(e => e.IdTipoConcepto).HasName("PK_tipo_concepto_contable01");

            entity.ToTable("tipo_concepto_contable");

            entity.Property(e => e.IdTipoConcepto)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_concepto");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoContribuyente>(entity =>
        {
            entity.HasKey(e => e.IdTipoContribuyente).HasName("PK_tipo_contribuyente01");

            entity.ToTable("tipo_contribuyente");

            entity.Property(e => e.IdTipoContribuyente)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_contribuyente");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoExportacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoExportacion).HasName("PK__tipo_exp__5755BB1648EF7A4D");

            entity.ToTable("tipo_exportacion");

            entity.HasIndex(e => e.IdTipoExportacion, "UQ_id_tipo_exportacion").IsUnique();

            entity.Property(e => e.IdTipoExportacion)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_exportacion");
            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<TipoExportacionIdioma>(entity =>
        {
            entity.HasKey(e => e.IdTipoExportacion).HasName("PK__tipo_exp__5755BB1695BC76A6");

            entity.ToTable("tipo_exportacion_idioma");

            entity.Property(e => e.IdTipoExportacion)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_exportacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoMonedum>(entity =>
        {
            entity.HasKey(e => e.IdTipoMoneda).HasName("PK_tipo_moneda_id_tipo");

            entity.ToTable("tipo_moneda");

            entity.Property(e => e.IdTipoMoneda)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_moneda");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoOperacionPeru>(entity =>
        {
            entity.HasKey(e => e.IdTipoOperacion).HasName("PK_tipo_operacion_peru_id_tipo_operacion");

            entity.ToTable("tipo_operacion_peru");

            entity.HasIndex(e => e.Clave, "UQ_clave_tipo_operacion_peru").IsUnique();

            entity.Property(e => e.IdTipoOperacion)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_operacion");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<TipoRelacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoRelacion).HasName("PK__tipo_rel__989EC7DBAF53C6A5");

            entity.ToTable("tipo_relacion");

            entity.HasIndex(e => e.IdTipoRelacion, "UQ_id_tipo_relacion").IsUnique();

            entity.Property(e => e.IdTipoRelacion)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_relacion");
            entity.Property(e => e.Clave)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<TipoRelacionIdioma>(entity =>
        {
            entity.HasKey(e => e.IdTipoRelacion).HasName("PK__tipo_rel__989EC7DBBD8DA37E");

            entity.ToTable("tipo_relacion_idioma");

            entity.Property(e => e.IdTipoRelacion)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_relacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TiposDocumento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.ToTable("tipos_documento");

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TiposDocumentoIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdDocumento, e.IdIdioma });

            entity.ToTable("tipos_documento_idioma");

            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.TiposDocumentoIdiomas)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tipos_documento_idioma02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.TiposDocumentoIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tipos_documento_idioma01");
        });

        modelBuilder.Entity<Tooltip>(entity =>
        {
            entity.HasKey(e => e.IdTooltip);

            entity.ToTable("tooltip");

            entity.Property(e => e.IdTooltip)
                .ValueGeneratedNever()
                .HasColumnName("id_tooltip");
            entity.Property(e => e.BuscarEnControl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("buscar_en_control");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Evento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("evento");
            entity.Property(e => e.IdControl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_control");
            entity.Property(e => e.IdControlPrincipal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_control_principal");
            entity.Property(e => e.IdFormControl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_form_control");
            entity.Property(e => e.IdVentana).HasColumnName("id_ventana");

            entity.HasOne(d => d.IdVentanaNavigation).WithMany(p => p.Tooltips)
                .HasForeignKey(d => d.IdVentana)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tooltip01");
        });

        modelBuilder.Entity<TooltipIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdTooltip, e.IdIdioma });

            entity.ToTable("tooltip_idioma");

            entity.Property(e => e.IdTooltip).HasColumnName("id_tooltip");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.MarcaAgua)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("marca_agua");
            entity.Property(e => e.TextoAyuda)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("texto_ayuda");

            entity.HasOne(d => d.IdTooltipNavigation).WithMany(p => p.TooltipIdiomas)
                .HasForeignKey(d => d.IdTooltip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tooltip_idioma01");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.IdUnidad);

            entity.ToTable("unidad");

            entity.Property(e => e.IdUnidad)
                .ValueGeneratedNever()
                .HasColumnName("id_unidad");
            entity.Property(e => e.Americana).HasColumnName("americana");
            entity.Property(e => e.Antena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("antena");
            entity.Property(e => e.Arrendamiento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("arrendamiento");
            entity.Property(e => e.DireccionGps)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("direccion_gps");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaGps)
                .HasColumnType("datetime")
                .HasColumnName("fecha_gps");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaReinicioOdometro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_reinicio_odometro");
            entity.Property(e => e.FechaSigMtto)
                .HasColumnType("datetime")
                .HasColumnName("fecha_sig_mtto");
            entity.Property(e => e.FechaVigencia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vigencia");
            entity.Property(e => e.IdArrendatario).HasColumnName("id_arrendatario");
            entity.Property(e => e.IdCentroCostoClickb).HasColumnName("id_centro_costo_clickb");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdLinea).HasColumnName("id_linea");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.IdParteTransporte).HasColumnName("id_parte_transporte");
            entity.Property(e => e.IdProveedorGps).HasColumnName("id_proveedor_gps");
            entity.Property(e => e.IdReinicioOdometro).HasColumnName("id_reinicio_odometro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdSubtiporem).HasColumnName("id_subtiporem");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("lat");
            entity.Property(e => e.Lon)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("lon");
            entity.Property(e => e.Modelo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.MotivoReinicioOdometro)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("motivo_reinicio_odometro");
            entity.Property(e => e.NoEjes).HasColumnName("no_ejes");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NumPermisoSct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num_permiso_sct");
            entity.Property(e => e.NumPolizaSeg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("num_poliza_seg");
            entity.Property(e => e.NumUnidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("num_unidad");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OdometroActual).HasColumnName("odometro_actual");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_bruto_vehicular");
            entity.Property(e => e.Placas)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("placas");
            entity.Property(e => e.RendimientoCombustible)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rendimiento_combustible");
            entity.Property(e => e.Seguro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seguro");
            entity.Property(e => e.TarjetaCirculacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("tarjeta_circulacion");
            entity.Property(e => e.Ultimaposicion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ultimaposicion");
            entity.Property(e => e.VerEmisionContaminante)
                .HasColumnType("datetime")
                .HasColumnName("ver_emision_contaminante");
            entity.Property(e => e.VerFisicaMecanica)
                .HasColumnType("datetime")
                .HasColumnName("ver_fisica_mecanica");
            entity.Property(e => e.Vin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vin");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad02");

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdLinea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad03");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad04");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad05");

            entity.HasOne(d => d.IdReinicioOdometroNavigation).WithMany(p => p.UnidadIdReinicioOdometroNavigations)
                .HasForeignKey(d => d.IdReinicioOdometro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_id_reinicio_odometro");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad06");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad07");
        });

        modelBuilder.Entity<UnidadAsignacion>(entity =>
        {
            entity.HasKey(e => e.IdAsignacion).HasName("PK__unidad_a__C3F7F96614D30C00");

            entity.ToTable("unidad_asignacion");

            entity.HasIndex(e => new { e.IdUnidad, e.IdElemento }, "UQ_unidad_elemento").IsUnique();

            entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");
            entity.Property(e => e.IdElemento).HasColumnName("id_elemento");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.UnidadAsignacions)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad");
        });

        modelBuilder.Entity<UnidadClave>(entity =>
        {
            entity.HasKey(e => e.IdClave).HasName("PK_unidad_clave_id_clave");

            entity.ToTable("unidad_clave");

            entity.Property(e => e.IdClave)
                .ValueGeneratedNever()
                .HasColumnName("id_clave");
            entity.Property(e => e.Clave)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<UnidadFianza>(entity =>
        {
            entity.HasKey(e => e.IdFianza);

            entity.ToTable("unidad_fianza");

            entity.Property(e => e.IdFianza)
                .ValueGeneratedNever()
                .HasColumnName("id_fianza");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInternacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_internacion");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.NumFianza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_fianza");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.UnidadFianzas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_fianza_03");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadFianzaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_fianza_02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadFianzaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_fianza_01");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.UnidadFianzas)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_fianza_04");
        });

        modelBuilder.Entity<UnidadLinea>(entity =>
        {
            entity.HasKey(e => e.IdLinea);

            entity.ToTable("unidad_linea");

            entity.Property(e => e.IdLinea)
                .ValueGeneratedNever()
                .HasColumnName("id_linea");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Correo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.CuentaBancaria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuenta_bancaria");
            entity.Property(e => e.DiasCredito).HasColumnName("dias_credito");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdInstitucionBancaria).HasColumnName("id_institucion_bancaria");
            entity.Property(e => e.IdIva).HasColumnName("id_iva");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRetencion).HasColumnName("id_retencion");
            entity.Property(e => e.IdTipoPersona).HasColumnName("id_tipo_persona");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_contacto");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroInterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero_interior");
            entity.Property(e => e.Numregidtrib)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numregidtrib");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.UnidadLineas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_linea01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadLineaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_linea02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadLineaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_linea03");
        });

        modelBuilder.Entity<UnidadMarca>(entity =>
        {
            entity.HasKey(e => e.IdMarca);

            entity.ToTable("unidad_marca");

            entity.Property(e => e.IdMarca)
                .ValueGeneratedNever()
                .HasColumnName("id_marca");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.UnidadMarcas)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_marca04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.UnidadMarcas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_marca01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadMarcaIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_marca02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadMarcaIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_marca03");
        });

        modelBuilder.Entity<UnidadMedidaClase>(entity =>
        {
            entity.HasKey(e => e.IdClase);

            entity.ToTable("unidad_medida_clase");

            entity.Property(e => e.IdClase)
                .ValueGeneratedNever()
                .HasColumnName("id_clase");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.UnidadMedidaClases)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_medida_clase01");
        });

        modelBuilder.Entity<UnidadMedidaClasificacion>(entity =>
        {
            entity.HasKey(e => e.IdClase);

            entity.ToTable("unidad_medida_clasificacion");

            entity.Property(e => e.IdClase)
                .ValueGeneratedNever()
                .HasColumnName("id_clase");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<UnidadMedidaIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidadMedida, e.IdIdioma });

            entity.ToTable("unidad_medida_idioma");

            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
        });

        modelBuilder.Entity<UnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.IdUnidadMedida);

            entity.ToTable("unidad_medida");

            entity.Property(e => e.IdUnidadMedida)
                .ValueGeneratedNever()
                .HasColumnName("id_unidad_medida");
            entity.Property(e => e.Esbase).HasColumnName("esbase");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FactorConversionabase)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("factor_conversionabase");
            entity.Property(e => e.IdClase).HasColumnName("id_clase");
            entity.Property(e => e.IdUnidadBase).HasColumnName("id_unidad_base");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.UnidadMedida)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_medida02");

            entity.HasOne(d => d.IdClaseNavigation).WithMany(p => p.UnidadMedida)
                .HasForeignKey(d => d.IdClase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_medida01");
        });

        modelBuilder.Entity<UnidadMotriz>(entity =>
        {
            entity.HasKey(e => e.IdUnidad);

            entity.ToTable("unidad_motriz");

            entity.Property(e => e.IdUnidad)
                .ValueGeneratedNever()
                .HasColumnName("id_unidad");
            entity.Property(e => e.CapacidadTanque1).HasColumnName("capacidad_tanque1");
            entity.Property(e => e.CapacidadTanque2).HasColumnName("capacidad_tanque2");
            entity.Property(e => e.Tanque2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .IsFixedLength()
                .HasColumnName("tanque2");
            entity.Property(e => e.TipoCombustible1).HasColumnName("tipo_combustible1");
            entity.Property(e => e.TipoCombustible2).HasColumnName("tipo_combustible2");
            entity.Property(e => e.UnidadMedidaTanque1).HasColumnName("unidad_medida_tanque1");
            entity.Property(e => e.UnidadMedidaTanque2).HasColumnName("unidad_medida_tanque2");

            entity.HasOne(d => d.IdUnidadNavigation).WithOne(p => p.UnidadMotriz)
                .HasForeignKey<UnidadMotriz>(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_motriz01");

            entity.HasOne(d => d.TipoCombustible1Navigation).WithMany(p => p.UnidadMotrizTipoCombustible1Navigations)
                .HasForeignKey(d => d.TipoCombustible1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_motriz03");

            entity.HasOne(d => d.TipoCombustible2Navigation).WithMany(p => p.UnidadMotrizTipoCombustible2Navigations)
                .HasForeignKey(d => d.TipoCombustible2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_motriz02");

            entity.HasOne(d => d.UnidadMedidaTanque1Navigation).WithMany(p => p.UnidadMotrizUnidadMedidaTanque1Navigations)
                .HasForeignKey(d => d.UnidadMedidaTanque1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_motriz05");

            entity.HasOne(d => d.UnidadMedidaTanque2Navigation).WithMany(p => p.UnidadMotrizUnidadMedidaTanque2Navigations)
                .HasForeignKey(d => d.UnidadMedidaTanque2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_motriz04");
        });

        modelBuilder.Entity<UnidadMtto>(entity =>
        {
            entity.HasKey(e => e.IdUnidad);

            entity.ToTable("unidad_mtto");

            entity.Property(e => e.IdUnidad)
                .ValueGeneratedNever()
                .HasColumnName("id_unidad");
            entity.Property(e => e.KmsSigMtto).HasColumnName("kms_sig_mtto");
            entity.Property(e => e.SigMtto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sig_mtto");

            entity.HasOne(d => d.IdUnidadNavigation).WithOne(p => p.UnidadMtto)
                .HasForeignKey<UnidadMtto>(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_mtto_unidad");
        });

        modelBuilder.Entity<UnidadPosicione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("unidad_posiciones");

            entity.Property(e => e.Angulo).HasColumnName("angulo");
            entity.Property(e => e.Consecutivo)
                .ValueGeneratedOnAdd()
                .HasColumnName("consecutivo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Poslat)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("poslat");
            entity.Property(e => e.Poslon)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("poslon");
            entity.Property(e => e.Velocidad)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("velocidad");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany()
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_posiciones02");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany()
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_posiciones01");
        });

        modelBuilder.Entity<UnidadPosicionesHistorial>(entity =>
        {
            entity.HasKey(e => e.Consecutivo).HasName("PK_unidad_posiciones_historial01");

            entity.ToTable("unidad_posiciones_historial");

            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Angulo).HasColumnName("angulo");
            entity.Property(e => e.Antena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("antena");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Direccion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Poslat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("poslat");
            entity.Property(e => e.Poslon)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("poslon");
            entity.Property(e => e.Velocidad)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("velocidad");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.UnidadPosicionesHistorials)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_posiciones_historial01");
        });

        modelBuilder.Entity<UnidadSeguimiento>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidad, e.IdSeguimiento });

            entity.ToTable("unidad_seguimiento");

            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.IdSeguimiento).HasColumnName("id_seguimiento");
            entity.Property(e => e.Actual).HasColumnName("actual");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdFianza).HasColumnName("id_fianza");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPlaza).HasColumnName("id_plaza");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Origen).HasColumnName("origen");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.UnidadSeguimientos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_01");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.UnidadSeguimientos)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_06");

            entity.HasOne(d => d.IdFianzaNavigation).WithMany(p => p.UnidadSeguimientos)
                .HasForeignKey(d => d.IdFianza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_08");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadSeguimientoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_05");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadSeguimientoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_04");

            entity.HasOne(d => d.IdPlazaNavigation).WithMany(p => p.UnidadSeguimientos)
                .HasForeignKey(d => d.IdPlaza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_03");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.UnidadSeguimientos)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_07");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.UnidadSeguimientos)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_02");
        });

        modelBuilder.Entity<UnidadSeguimientoEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("unidad_seguimiento_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatusViaje).HasColumnName("id_estatus_viaje");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.UnidadSeguimientoEstatuses)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_estatus_04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.UnidadSeguimientoEstatuses)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_estatus_01");

            entity.HasOne(d => d.IdEstatusViajeNavigation).WithMany(p => p.UnidadSeguimientoEstatuses)
                .HasForeignKey(d => d.IdEstatusViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_estatus_05");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadSeguimientoEstatusIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_estatus_02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadSeguimientoEstatusIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_estatus_03");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.UnidadSeguimientoEstatuses)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_seguimiento_estatus_06");
        });

        modelBuilder.Entity<UnidadTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("unidad_tipo");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.UnidadTipos)
                .HasForeignKey(d => d.Estatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_tipo04");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.UnidadTipos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_tipo01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.UnidadTipoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_tipo02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.UnidadTipoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_tipo03");
        });

        modelBuilder.Entity<UnidadTipoRol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("unidad_tipo_rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<UnidadTipoRolIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdRol, e.IdIdioma });

            entity.ToTable("unidad_tipo_rol_idioma");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.UnidadTipoRolIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_tipo_rol_idioma02");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.UnidadTipoRolIdiomas)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_unidad_tipo_rol_idioma01");
        });

        modelBuilder.Entity<UsoCfdi>(entity =>
        {
            entity.HasKey(e => e.IdUsoCfdi).HasName("PK_usoCFDI_id_usoCFDI");

            entity.ToTable("usoCFDI");

            entity.HasIndex(e => e.Clave, "UQ_usoCFDI_clave").IsUnique();

            entity.Property(e => e.IdUsoCfdi)
                .ValueGeneratedNever()
                .HasColumnName("id_usoCFDI");
            entity.Property(e => e.Clave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.PFisica)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("pFisica");
            entity.Property(e => e.PMoral)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("pMoral");
        });

        modelBuilder.Entity<UsoCfdiRegimenFiscal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_uso_cfdi_regimen_fiscal_id");

            entity.ToTable("uso_cfdi_regimen_fiscal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClaveRegimenFiscal)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("clave_regimen_fiscal");
            entity.Property(e => e.ClaveUsoCfdi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("clave_uso_cfdi");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Email, "XAK_usuario01").IsUnique();

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Administrador)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("administrador");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Celular)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Email2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("email2");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.ExtensionEmpresa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("extension_empresa");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre_busqueda");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Puesto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("puesto");
            entity.Property(e => e.Random).HasColumnName("random");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.TelefonoEmpresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono_empresa");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuario01");

            entity.HasMany(d => d.IdGrupos).WithMany(p => p.IdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioGrupo",
                    r => r.HasOne<SeguridadGrupo>().WithMany()
                        .HasForeignKey("IdGrupo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_usuario_grupo01"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_usuario_grupo02"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdGrupo");
                        j.ToTable("usuario_grupo");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("id_usuario");
                        j.IndexerProperty<int>("IdGrupo").HasColumnName("id_grupo");
                    });
        });

        modelBuilder.Entity<UsuarioConfiguracion>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("usuario_configuracion");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.AyudaActiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ayuda_activa");
            entity.Property(e => e.AyudaWizard)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ayuda_wizard");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.Tema)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tema");
        });

        modelBuilder.Entity<VCostoIum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_costo_ia");

            entity.Property(e => e.CostoCache)
                .HasColumnType("numeric(26, 11)")
                .HasColumnName("costo_cache");
            entity.Property(e => e.CostoInput)
                .HasColumnType("numeric(26, 11)")
                .HasColumnName("costo_input");
            entity.Property(e => e.CostoOutput)
                .HasColumnType("numeric(26, 11)")
                .HasColumnName("costo_output");
            entity.Property(e => e.CostoTotal)
                .HasColumnType("numeric(28, 11)")
                .HasColumnName("costo_total");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFuncionIa).HasColumnName("id_funcion_ia");
            entity.Property(e => e.IdModeloIa).HasColumnName("id_modelo_ia");
            entity.Property(e => e.IdPeticionIa).HasColumnName("id_peticion_ia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<VEmpresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Empresas");

            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Compania)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dirección)
                .HasMaxLength(247)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaContratacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Contratacion");
            entity.Property(e => e.FechaDemo).HasColumnType("datetime");
            entity.Property(e => e.IdEmpresa).HasColumnName("Id_empresa");
            entity.Property(e => e.IdPromotor).HasColumnName("idPromotor");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Paquete)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");
            entity.Property(e => e.PorVencer)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.Promotor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ReferenciaOtro)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Rfc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vigencia).HasColumnType("datetime");
            entity.Property(e => e.Zona)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEmpresasPerdido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Empresas_perdidos");

            entity.Property(e => e.Compania)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contrato)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaContratacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Fecha_Contratacion");
            entity.Property(e => e.FechaDemo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("Id_empresa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Paquete)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaqueteId).HasColumnName("PaqueteID");
            entity.Property(e => e.Promotor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ReferenciaOtro)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Vigencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEstadocuentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_estadocuenta");

            entity.Property(e => e.Abono)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("abono");
            entity.Property(e => e.Cargo)
                .HasColumnType("decimal(20, 6)")
                .HasColumnName("cargo");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.Folio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.FolioRelacionado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("folio_relacionado");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.Referencia)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.TipoDocumento).HasColumnName("tipo_documento");
        });

        modelBuilder.Entity<VEstadocuentum1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_estadocuenta", "PowerLISTMS");

            entity.Property(e => e.Abono)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("abono");
            entity.Property(e => e.Cargo)
                .HasColumnType("decimal(20, 6)")
                .HasColumnName("cargo");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_vencimiento");
            entity.Property(e => e.Folio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.FolioRelacionado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("folio_relacionado");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
            entity.Property(e => e.IdTipoviaje).HasColumnName("id_tipoviaje");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("num_factura");
            entity.Property(e => e.Referencia)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.TipoDocumento).HasColumnName("tipo_documento");
        });

        modelBuilder.Entity<VGasto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_gastos");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.IdTipoReferencia).HasColumnName("id_tipo_referencia");
            entity.Property(e => e.IdUnidadMotriz).HasColumnName("id_unidad_motriz");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("iva");
            entity.Property(e => e.MontoAnticipo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_anticipo");
            entity.Property(e => e.MontoGastoLiq)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_gasto_liq");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.NoViaje).HasColumnName("no_viaje");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("retencion");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SueldoOperador)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("sueldo_operador");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
            entity.Property(e => e.TotalKilometros)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_kilometros");
            entity.Property(e => e.TotalViajes).HasColumnName("total_viajes");
        });

        modelBuilder.Entity<VGastoLiq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_gasto_liq");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.IdPersonal).HasColumnName("id_personal");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("iva");
            entity.Property(e => e.MontoAnticipo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_anticipo");
            entity.Property(e => e.MontoGastoLiq)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_gasto_liq");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.NoViaje).HasColumnName("no_viaje");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumLiquidacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_liquidacion");
            entity.Property(e => e.Retencion)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("retencion");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("subtotal");
            entity.Property(e => e.SueldoOperador)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("sueldo_operador");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
            entity.Property(e => e.TotalKilometros)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_kilometros");
            entity.Property(e => e.TotalViajes).HasColumnName("total_viajes");
        });

        modelBuilder.Entity<VGastosAnalitica>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_gastos_analitica", "PowerLISTMS");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaLiquidacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_liquidacion");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdConcepto).HasColumnName("id_concepto");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.IdTipoReferencia).HasColumnName("id_tipo_referencia");
            entity.Property(e => e.IdUnidadMotriz).HasColumnName("id_unidad_motriz");
            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.Iva).HasColumnName("iva");
            entity.Property(e => e.MontoAnticipo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_anticipo");
            entity.Property(e => e.MontoGastoLiq)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_gasto_liq");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("monto_total");
            entity.Property(e => e.NoViaje).HasColumnName("no_viaje");
            entity.Property(e => e.Retencion).HasColumnName("retencion");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");
            entity.Property(e => e.SueldoOperador)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("sueldo_operador");
            entity.Property(e => e.TipoDoc).HasColumnName("tipo_doc");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalKilometros)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("total_kilometros");
            entity.Property(e => e.TotalViajes).HasColumnName("total_viajes");
        });

        modelBuilder.Entity<VSesionUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sesion_usuario");

            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdSesion).HasColumnName("id_sesion");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Navegador)
                .HasMaxLength(200)
                .HasColumnName("navegador");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.UltimaActividad)
                .HasColumnType("datetime")
                .HasColumnName("ultima_actividad");
            entity.Property(e => e.Usuario)
                .HasMaxLength(92)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Ventana>(entity =>
        {
            entity.HasKey(e => e.IdVentana);

            entity.ToTable("ventana");

            entity.Property(e => e.IdVentana)
                .ValueGeneratedNever()
                .HasColumnName("id_ventana");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_archivo");

            entity.HasMany(d => d.IdVideos).WithMany(p => p.IdVentanas)
                .UsingEntity<Dictionary<string, object>>(
                    "VideoVentana",
                    r => r.HasOne<Video>().WithMany()
                        .HasForeignKey("IdVideo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_video_ventana02"),
                    l => l.HasOne<Ventana>().WithMany()
                        .HasForeignKey("IdVentana")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_video_ventana01"),
                    j =>
                    {
                        j.HasKey("IdVentana", "IdVideo");
                        j.ToTable("video_ventana");
                        j.IndexerProperty<int>("IdVentana").HasColumnName("id_ventana");
                        j.IndexerProperty<int>("IdVideo").HasColumnName("id_video");
                    });
        });

        modelBuilder.Entity<Viaje>(entity =>
        {
            entity.HasKey(e => e.IdViaje);

            entity.ToTable("viaje");

            entity.HasIndex(e => e.IdLiquidacion, "IX_viaje_id_liquidacion");

            entity.HasIndex(e => new { e.NoViaje, e.IdEmpresa }, "XAK_viaje01").IsUnique();

            entity.Property(e => e.IdViaje)
                .ValueGeneratedNever()
                .HasColumnName("id_viaje");
            entity.Property(e => e.Combustible)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("combustible");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("correlativo");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaCancelado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cancelado");
            entity.Property(e => e.FechaCita)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cita");
            entity.Property(e => e.FechaFinViaje)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin_viaje");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaInicioViaje)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio_viaje");
            entity.Property(e => e.FechaLiberado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_liberado");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdConfigAutotransporte).HasColumnName("id_config_autotransporte");
            entity.Property(e => e.IdDolly).HasColumnName("id_dolly");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdEstatusViajeCustom).HasColumnName("id_estatus_viaje_custom");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdLiquidacion).HasColumnName("id_liquidacion");
            entity.Property(e => e.IdLiquidacionPermisionario).HasColumnName("id_liquidacion_permisionario");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.IdPermisionario).HasColumnName("id_permisionario");
            entity.Property(e => e.IdPlazaDestino).HasColumnName("id_plaza_destino");
            entity.Property(e => e.IdPlazaOrigen).HasColumnName("id_plaza_origen");
            entity.Property(e => e.IdRemolque1).HasColumnName("id_remolque1");
            entity.Property(e => e.IdRemolque2).HasColumnName("id_remolque2");
            entity.Property(e => e.IdRuta).HasColumnName("id_ruta");
            entity.Property(e => e.IdSegundoOperador).HasColumnName("id_segundo_operador");
            entity.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.IdTipopermisoStc).HasColumnName("id_tipopermiso_stc");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Instrucciones)
                .HasMaxLength(1700)
                .IsUnicode(false)
                .HasColumnName("instrucciones");
            entity.Property(e => e.KmsCargado).HasColumnName("kms_cargado");
            entity.Property(e => e.KmsCompensacion).HasColumnName("kms_compensacion");
            entity.Property(e => e.KmsVacio).HasColumnName("kms_vacio");
            entity.Property(e => e.KmsViaje)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("kms_viaje");
            entity.Property(e => e.Liberado).HasColumnName("liberado");
            entity.Property(e => e.LitrosAutorizados)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("litros_autorizados");
            entity.Property(e => e.NoViaje).HasColumnName("no_viaje");
            entity.Property(e => e.NumPermisoStc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num_permiso_stc");
            entity.Property(e => e.OdometroFinal).HasColumnName("odometro_final");
            entity.Property(e => e.OdometroInicial).HasColumnName("odometro_inicial");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("peso_bruto_vehicular");
            entity.Property(e => e.RendEsp)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rend_esp");
            entity.Property(e => e.RendViaje)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("rend_viaje");
            entity.Property(e => e.SegundoOperador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("segundo_operador");
            entity.Property(e => e.SueldoOperador)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("sueldo_operador");
            entity.Property(e => e.ViajeProgramado).HasColumnName("viaje_programado");
            entity.Property(e => e.ViajeVacio).HasColumnName("viaje_vacio");
            entity.Property(e => e.VolumenFinal)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("volumen_final");

            entity.HasOne(d => d.IdDollyNavigation).WithMany(p => p.ViajeIdDollyNavigations)
                .HasForeignKey(d => d.IdDolly)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje01");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje02");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje03");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ViajeIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje04");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje15");

            entity.HasOne(d => d.IdLiquidacionPermisionarioNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdLiquidacionPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_id_liquidacion_permisionario");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ViajeIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje05");

            entity.HasOne(d => d.IdOperadorNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdOperador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje06");

            entity.HasOne(d => d.IdPermisionarioNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdPermisionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_id_permisionario");

            entity.HasOne(d => d.IdPlazaDestinoNavigation).WithMany(p => p.ViajeIdPlazaDestinoNavigations)
                .HasForeignKey(d => d.IdPlazaDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje07");

            entity.HasOne(d => d.IdPlazaOrigenNavigation).WithMany(p => p.ViajeIdPlazaOrigenNavigations)
                .HasForeignKey(d => d.IdPlazaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje08");

            entity.HasOne(d => d.IdRemolque1Navigation).WithMany(p => p.ViajeIdRemolque1Navigations)
                .HasForeignKey(d => d.IdRemolque1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje09");

            entity.HasOne(d => d.IdRemolque2Navigation).WithMany(p => p.ViajeIdRemolque2Navigations)
                .HasForeignKey(d => d.IdRemolque2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje10");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdRuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje11");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje13");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.ViajeIdUnidadNavigations)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje14");
        });

        modelBuilder.Entity<ViajeEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("viaje_estatus");

            entity.Property(e => e.IdEstatus)
                .ValueGeneratedNever()
                .HasColumnName("id_estatus");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViajeEstatusIdioma>(entity =>
        {
            entity.HasKey(e => new { e.IdEstatus, e.IdIdioma });

            entity.ToTable("viaje_estatus_idioma");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ViajeEstatusIdiomas)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_estatus_idioma01");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.ViajeEstatusIdiomas)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_estatus_idioma02");
        });

        modelBuilder.Entity<ViajeProgramado>(entity =>
        {
            entity.HasKey(e => e.IdViaje).HasName("PK_viajeProgramado");

            entity.ToTable("viaje_programado");

            entity.Property(e => e.IdViaje)
                .ValueGeneratedNever()
                .HasColumnName("id_viaje");
            entity.Property(e => e.FechaCarga)
                .HasColumnType("datetime")
                .HasColumnName("fecha_carga");
            entity.Property(e => e.FechaDescarga)
                .HasColumnType("datetime")
                .HasColumnName("fecha_descarga");
            entity.Property(e => e.HoraCarga)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hora_carga");
            entity.Property(e => e.HoraDescarga)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hora_descarga");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdDestino).HasColumnName("id_destino");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdViaje1).HasColumnName("idViaje");
            entity.Property(e => e.Referencia)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("referencia");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ViajeProgramados)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente");

            entity.HasOne(d => d.IdDestinoNavigation).WithMany(p => p.ViajeProgramadoIdDestinoNavigations)
                .HasForeignKey(d => d.IdDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_destino");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ViajeProgramados)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_idempresa");

            entity.HasOne(d => d.IdOrigenNavigation).WithMany(p => p.ViajeProgramadoIdOrigenNavigations)
                .HasForeignKey(d => d.IdOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_origen");

            entity.HasOne(d => d.IdViaje1Navigation).WithMany(p => p.ViajeProgramados)
                .HasForeignKey(d => d.IdViaje1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_id_viaje");
        });

        modelBuilder.Entity<ViajeRutaRoutech>(entity =>
        {
            entity.HasKey(e => e.IdViaje).HasName("PK_viaje_ruta_routech_id_viaje");

            entity.ToTable("viaje_ruta_routech");

            entity.Property(e => e.IdViaje)
                .ValueGeneratedNever()
                .HasColumnName("id_viaje");
            entity.Property(e => e.FechaProceso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_proceso");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdRoutechEstatus).HasColumnName("id_routech_estatus");
            entity.Property(e => e.IdRutaRoutech).HasColumnName("id_ruta_routech");
            entity.Property(e => e.IdSesion).HasColumnName("id_sesion");

            entity.HasOne(d => d.IdRoutechEstatusNavigation).WithMany(p => p.ViajeRutaRouteches)
                .HasForeignKey(d => d.IdRoutechEstatus)
                .HasConstraintName("FK_viaje_ruta_routech_estatus");

            entity.HasOne(d => d.IdViajeNavigation).WithOne(p => p.ViajeRutaRoutech)
                .HasForeignKey<ViajeRutaRoutech>(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta_routech01");
        });

        modelBuilder.Entity<ViajeRutaTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("viaje_ruta_tipo");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ViajeRutaTipos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta_tipo01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ViajeRutaTipoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta_tipo02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ViajeRutaTipoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta_tipo03");
        });

        modelBuilder.Entity<ViajeRutum>(entity =>
        {
            entity.HasKey(e => e.IdRuta);

            entity.ToTable("viaje_ruta");

            entity.Property(e => e.IdRuta)
                .ValueGeneratedNever()
                .HasColumnName("id_ruta");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.IdPlazaDestino).HasColumnName("id_plaza_destino");
            entity.Property(e => e.IdPlazaOrigen).HasColumnName("id_plaza_origen");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.KmsRuta).HasColumnName("kms_ruta");
            entity.Property(e => e.LitrosAutorizados)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("litros_autorizados");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tiempo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("tiempo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ViajeRuta)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ViajeRutumIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ViajeRutumIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta03");

            entity.HasOne(d => d.IdPlazaOrigenNavigation).WithMany(p => p.ViajeRuta)
                .HasForeignKey(d => d.IdPlazaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta04");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.ViajeRuta)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_ruta05");
        });

        modelBuilder.Entity<ViajeSeguimientoControl>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Consecutivo });

            entity.ToTable("viaje_seguimiento_control");

            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.EstatusAnterior).HasColumnName("estatus_anterior");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ViajeSeguimientoControls)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_seguimiento_control02");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ViajeSeguimientoControls)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_seguimiento_control01");
        });

        modelBuilder.Entity<ViajeSeguimientoEstatus>(entity =>
        {
            entity.HasKey(e => new { e.IdViaje, e.IdSeguimiento });

            entity.ToTable("viaje_seguimiento_estatus");

            entity.HasIndex(e => e.IdViaje, "IX_viaje_seguimiento_estatus_id_viaje");

            entity.Property(e => e.IdViaje).HasColumnName("id_viaje");
            entity.Property(e => e.IdSeguimiento).HasColumnName("id_seguimiento");
            entity.Property(e => e.FechaEstatus)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.IdEstatusCustom).HasColumnName("id_estatus_custom");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("longitud");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdEstatusNavigation).WithMany(p => p.ViajeSeguimientoEstatuses)
                .HasForeignKey(d => d.IdEstatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_seguimiento_estatus02");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ViajeSeguimientoEstatuses)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_seguimiento_estatus03");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.ViajeSeguimientoEstatuses)
                .HasForeignKey(d => d.IdViaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_seguimiento_estatus01");
        });

        modelBuilder.Entity<ViajeTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("viaje_tipo");

            entity.Property(e => e.IdTipo)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ViajeTipos)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_tipo01");

            entity.HasOne(d => d.IdIngresoNavigation).WithMany(p => p.ViajeTipoIdIngresoNavigations)
                .HasForeignKey(d => d.IdIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_tipo02");

            entity.HasOne(d => d.IdModificoNavigation).WithMany(p => p.ViajeTipoIdModificoNavigations)
                .HasForeignKey(d => d.IdModifico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_viaje_tipo03");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.HasKey(e => e.IdVideo);

            entity.ToTable("video");

            entity.Property(e => e.IdVideo)
                .ValueGeneratedNever()
                .HasColumnName("id_video");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaModifico)
                .HasColumnType("datetime")
                .HasColumnName("fecha_modifico");
            entity.Property(e => e.IdClasificacion).HasColumnName("id_clasificacion");
            entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");
            entity.Property(e => e.IdIngreso).HasColumnName("id_ingreso");
            entity.Property(e => e.IdModifico).HasColumnName("id_modifico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.RutaImagen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruta_imagen");
            entity.Property(e => e.RutaVideo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ruta_video");
            entity.Property(e => e.Visiblemenu).HasColumnName("visiblemenu");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.Videos)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_video02");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.Videos)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_video01");
        });

        modelBuilder.Entity<VideoClasificacion>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion);

            entity.ToTable("video_clasificacion");

            entity.Property(e => e.IdClasificacion)
                .ValueGeneratedNever()
                .HasColumnName("id_clasificacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
