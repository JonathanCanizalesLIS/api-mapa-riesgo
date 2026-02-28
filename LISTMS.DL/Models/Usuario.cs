using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Email { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email2 { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public string TelefonoEmpresa { get; set; } = null!;

    public string ExtensionEmpresa { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Puesto { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public string? Administrador { get; set; }

    public int Random { get; set; }

    public virtual ICollection<Alarma> AlarmaIdIngresoNavigations { get; set; } = new List<Alarma>();

    public virtual ICollection<Alarma> AlarmaIdModificoNavigations { get; set; } = new List<Alarma>();

    public virtual ICollection<AnticipoConcepto> AnticipoConceptoIdIngresoNavigations { get; set; } = new List<AnticipoConcepto>();

    public virtual ICollection<AnticipoConcepto> AnticipoConceptoIdModificoNavigations { get; set; } = new List<AnticipoConcepto>();

    public virtual ICollection<Anticipo> AnticipoIdIngresoNavigations { get; set; } = new List<Anticipo>();

    public virtual ICollection<Anticipo> AnticipoIdModificoNavigations { get; set; } = new List<Anticipo>();

    public virtual ICollection<Aviso> Avisos { get; set; } = new List<Aviso>();

    public virtual ICollection<BancoConceptoGrupo> BancoConceptoGrupoIdIngresoNavigations { get; set; } = new List<BancoConceptoGrupo>();

    public virtual ICollection<BancoConceptoGrupo> BancoConceptoGrupoIdModificoNavigations { get; set; } = new List<BancoConceptoGrupo>();

    public virtual ICollection<BancoConcepto> BancoConceptoIdIngresoNavigations { get; set; } = new List<BancoConcepto>();

    public virtual ICollection<BancoConcepto> BancoConceptoIdModificoNavigations { get; set; } = new List<BancoConcepto>();

    public virtual ICollection<Banco> BancoIdIngresoNavigations { get; set; } = new List<Banco>();

    public virtual ICollection<Banco> BancoIdModificoNavigations { get; set; } = new List<Banco>();

    public virtual ICollection<BancoMovimiento> BancoMovimientoIdIngresoNavigations { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoMovimiento> BancoMovimientoIdModificoNavigations { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitud> BancoSolicitudIdIngresoNavigations { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<BancoSolicitud> BancoSolicitudIdModificoNavigations { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<Cliente> ClienteIdIngresoNavigations { get; set; } = new List<Cliente>();

    public virtual ICollection<Cliente> ClienteIdModificoNavigations { get; set; } = new List<Cliente>();

    public virtual ICollection<Combustible> CombustibleIdIngresoNavigations { get; set; } = new List<Combustible>();

    public virtual ICollection<Combustible> CombustibleIdModificoNavigations { get; set; } = new List<Combustible>();

    public virtual ICollection<CombustibleTarifa> CombustibleTarifaIdIngresoNavigations { get; set; } = new List<CombustibleTarifa>();

    public virtual ICollection<CombustibleTarifa> CombustibleTarifaIdModificoNavigations { get; set; } = new List<CombustibleTarifa>();

    public virtual ICollection<CombustibleVale> CombustibleValeIdIngresoNavigations { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<CombustibleVale> CombustibleValeIdModificoNavigations { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<ConceptoPermisionario> ConceptoPermisionarioIdIngresoNavigations { get; set; } = new List<ConceptoPermisionario>();

    public virtual ICollection<ConceptoPermisionario> ConceptoPermisionarioIdModificoNavigations { get; set; } = new List<ConceptoPermisionario>();

    public virtual ICollection<ConsultaVistum> ConsultaVistumIdIngresoNavigations { get; set; } = new List<ConsultaVistum>();

    public virtual ICollection<ConsultaVistum> ConsultaVistumIdModificoNavigations { get; set; } = new List<ConsultaVistum>();

    public virtual ICollection<Contacto> ContactoIdIngresoNavigations { get; set; } = new List<Contacto>();

    public virtual ICollection<Contacto> ContactoIdModificoNavigations { get; set; } = new List<Contacto>();

    public virtual ICollection<ContactoPuesto> ContactoPuestoIdIngresoNavigations { get; set; } = new List<ContactoPuesto>();

    public virtual ICollection<ContactoPuesto> ContactoPuestoIdModificoNavigations { get; set; } = new List<ContactoPuesto>();

    public virtual ICollection<ConvenioAnticipo> ConvenioAnticipoIdIngresoNavigations { get; set; } = new List<ConvenioAnticipo>();

    public virtual ICollection<ConvenioAnticipo> ConvenioAnticipoIdModificoNavigations { get; set; } = new List<ConvenioAnticipo>();

    public virtual ICollection<Convenio> ConvenioIdIngresoNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Convenio> ConvenioIdModificoNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<ConvenioLiquidacion> ConvenioLiquidacionIdIngresoNavigations { get; set; } = new List<ConvenioLiquidacion>();

    public virtual ICollection<ConvenioLiquidacion> ConvenioLiquidacionIdModificoNavigations { get; set; } = new List<ConvenioLiquidacion>();

    public virtual ICollection<CotizacionViajeFactore> CotizacionViajeFactoreIdIngresoNavigations { get; set; } = new List<CotizacionViajeFactore>();

    public virtual ICollection<CotizacionViajeFactore> CotizacionViajeFactoreIdModificoNavigations { get; set; } = new List<CotizacionViajeFactore>();

    public virtual ICollection<CuentaCliente> CuentaClienteIdIngresoNavigations { get; set; } = new List<CuentaCliente>();

    public virtual ICollection<CuentaCliente> CuentaClienteIdModificoNavigations { get; set; } = new List<CuentaCliente>();

    public virtual ICollection<ElectronicoCertificado> ElectronicoCertificadoIdIngresoNavigations { get; set; } = new List<ElectronicoCertificado>();

    public virtual ICollection<ElectronicoCertificado> ElectronicoCertificadoIdModificoNavigations { get; set; } = new List<ElectronicoCertificado>();

    public virtual ICollection<Electronico> ElectronicoIdIngresoNavigations { get; set; } = new List<Electronico>();

    public virtual ICollection<Electronico> ElectronicoIdModificoNavigations { get; set; } = new List<Electronico>();

    public virtual ICollection<ElectronicoPeruTicket> ElectronicoPeruTicketIdIngresoNavigations { get; set; } = new List<ElectronicoPeruTicket>();

    public virtual ICollection<ElectronicoPeruTicket> ElectronicoPeruTicketIdModificoNavigations { get; set; } = new List<ElectronicoPeruTicket>();

    public virtual ICollection<Embalaje> EmbalajeIdIngresoNavigations { get; set; } = new List<Embalaje>();

    public virtual ICollection<Embalaje> EmbalajeIdModificoNavigations { get; set; } = new List<Embalaje>();

    public virtual ICollection<EtiquetaConfigurable> EtiquetaConfigurableIdIngresoNavigations { get; set; } = new List<EtiquetaConfigurable>();

    public virtual ICollection<EtiquetaConfigurable> EtiquetaConfigurableIdModificoNavigations { get; set; } = new List<EtiquetaConfigurable>();

    public virtual ICollection<FacturaPago> FacturaPagoIdIngresoNavigations { get; set; } = new List<FacturaPago>();

    public virtual ICollection<FacturaPago> FacturaPagoIdModificoNavigations { get; set; } = new List<FacturaPago>();

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobroIdIngresoNavigations { get; set; } = new List<FacturaRelacioncobro>();

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobroIdModificoNavigations { get; set; } = new List<FacturaRelacioncobro>();

    public virtual ICollection<GuiaConcepto> GuiaConceptoIdIngresoNavigations { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<GuiaConcepto> GuiaConceptoIdModificoNavigations { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<GuiaTituloAdicional> GuiaTituloAdicionalIdIngresoNavigations { get; set; } = new List<GuiaTituloAdicional>();

    public virtual ICollection<GuiaTituloAdicional> GuiaTituloAdicionalIdModificoNavigations { get; set; } = new List<GuiaTituloAdicional>();

    public virtual ICollection<Guium> GuiumIdIngresoNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdModificoNavigations { get; set; } = new List<Guium>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<Iep> IepIdIngresoNavigations { get; set; } = new List<Iep>();

    public virtual ICollection<Iep> IepIdModificoNavigations { get; set; } = new List<Iep>();

    public virtual ICollection<Imagene> ImageneIdIngresoNavigations { get; set; } = new List<Imagene>();

    public virtual ICollection<Imagene> ImageneIdModificoNavigations { get; set; } = new List<Imagene>();

    public virtual ICollection<Impuesto> ImpuestoIdIngresoNavigations { get; set; } = new List<Impuesto>();

    public virtual ICollection<Impuesto> ImpuestoIdModificoNavigations { get; set; } = new List<Impuesto>();

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptoIdIngresoNavigations { get; set; } = new List<LiquidacionConcepto>();

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptoIdModificoNavigations { get; set; } = new List<LiquidacionConcepto>();

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<Liquidacion> LiquidacionIdIngresoNavigations { get; set; } = new List<Liquidacion>();

    public virtual ICollection<Liquidacion> LiquidacionIdModificoNavigations { get; set; } = new List<Liquidacion>();

    public virtual ICollection<Liquidacion> LiquidacionIdUsuarioCanceloNavigations { get; set; } = new List<Liquidacion>();

    public virtual ICollection<Liquidacion> LiquidacionIdUsuarioPagoNavigations { get; set; } = new List<Liquidacion>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarioIdIngresoNavigations { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarioIdModificoNavigations { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarioIdUsuarioCanceloNavigations { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarioIdUsuarioPagoNavigations { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<LiquidacionSueldo> LiquidacionSueldoIdIngresoNavigations { get; set; } = new List<LiquidacionSueldo>();

    public virtual ICollection<LiquidacionSueldo> LiquidacionSueldoIdModificoNavigations { get; set; } = new List<LiquidacionSueldo>();

    public virtual ICollection<LiquidacionSueldoRelacion> LiquidacionSueldoRelacionIdIngresoNavigations { get; set; } = new List<LiquidacionSueldoRelacion>();

    public virtual ICollection<LiquidacionSueldoRelacion> LiquidacionSueldoRelacionIdModificoNavigations { get; set; } = new List<LiquidacionSueldoRelacion>();

    public virtual ICollection<Monedum> MonedumIdIngresoNavigations { get; set; } = new List<Monedum>();

    public virtual ICollection<Monedum> MonedumIdModificoNavigations { get; set; } = new List<Monedum>();

    public virtual ICollection<MttoUnidad> MttoUnidadIdIngresoNavigations { get; set; } = new List<MttoUnidad>();

    public virtual ICollection<MttoUnidad> MttoUnidadIdModificoNavigations { get; set; } = new List<MttoUnidad>();

    public virtual ICollection<OrdenCompraViaje> OrdenCompraViajeIdIngresoNavigations { get; set; } = new List<OrdenCompraViaje>();

    public virtual ICollection<OrdenCompraViaje> OrdenCompraViajeIdModificoNavigations { get; set; } = new List<OrdenCompraViaje>();

    public virtual ICollection<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracionIdIngresoNavigations { get; set; } = new List<PermisionarioTarifaConfiguracion>();

    public virtual ICollection<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracionIdModificoNavigations { get; set; } = new List<PermisionarioTarifaConfiguracion>();

    public virtual ICollection<PermisionarioTarifa> PermisionarioTarifaIdIngresoNavigations { get; set; } = new List<PermisionarioTarifa>();

    public virtual ICollection<PermisionarioTarifa> PermisionarioTarifaIdModificoNavigations { get; set; } = new List<PermisionarioTarifa>();

    public virtual ICollection<PersonalCategorium> PersonalCategoriumIdIngresoNavigations { get; set; } = new List<PersonalCategorium>();

    public virtual ICollection<PersonalCategorium> PersonalCategoriumIdModificoNavigations { get; set; } = new List<PersonalCategorium>();

    public virtual ICollection<Personal> PersonalIdIngresoNavigations { get; set; } = new List<Personal>();

    public virtual ICollection<Personal> PersonalIdModificoNavigations { get; set; } = new List<Personal>();

    public virtual ICollection<Plaza> PlazaIdIngresoNavigations { get; set; } = new List<Plaza>();

    public virtual ICollection<Plaza> PlazaIdModificoNavigations { get; set; } = new List<Plaza>();

    public virtual ICollection<Producto> ProductoIdIngresoNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoIdModificoNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Proveedor> ProveedorIdIngresoNavigations { get; set; } = new List<Proveedor>();

    public virtual ICollection<Proveedor> ProveedorIdModificoNavigations { get; set; } = new List<Proveedor>();

    public virtual ICollection<SesionUsuario> SesionUsuarios { get; set; } = new List<SesionUsuario>();

    public virtual ICollection<Sucursal> SucursalIdIngresoNavigations { get; set; } = new List<Sucursal>();

    public virtual ICollection<Sucursal> SucursalIdModificoNavigations { get; set; } = new List<Sucursal>();

    public virtual ICollection<Sugerencia> Sugerencia { get; set; } = new List<Sugerencia>();

    public virtual ICollection<UnidadFianza> UnidadFianzaIdIngresoNavigations { get; set; } = new List<UnidadFianza>();

    public virtual ICollection<UnidadFianza> UnidadFianzaIdModificoNavigations { get; set; } = new List<UnidadFianza>();

    public virtual ICollection<Unidad> UnidadIdIngresoNavigations { get; set; } = new List<Unidad>();

    public virtual ICollection<Unidad> UnidadIdModificoNavigations { get; set; } = new List<Unidad>();

    public virtual ICollection<Unidad> UnidadIdReinicioOdometroNavigations { get; set; } = new List<Unidad>();

    public virtual ICollection<UnidadLinea> UnidadLineaIdIngresoNavigations { get; set; } = new List<UnidadLinea>();

    public virtual ICollection<UnidadLinea> UnidadLineaIdModificoNavigations { get; set; } = new List<UnidadLinea>();

    public virtual ICollection<UnidadMarca> UnidadMarcaIdIngresoNavigations { get; set; } = new List<UnidadMarca>();

    public virtual ICollection<UnidadMarca> UnidadMarcaIdModificoNavigations { get; set; } = new List<UnidadMarca>();

    public virtual ICollection<UnidadSeguimientoEstatus> UnidadSeguimientoEstatusIdIngresoNavigations { get; set; } = new List<UnidadSeguimientoEstatus>();

    public virtual ICollection<UnidadSeguimientoEstatus> UnidadSeguimientoEstatusIdModificoNavigations { get; set; } = new List<UnidadSeguimientoEstatus>();

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientoIdIngresoNavigations { get; set; } = new List<UnidadSeguimiento>();

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientoIdModificoNavigations { get; set; } = new List<UnidadSeguimiento>();

    public virtual ICollection<UnidadTipo> UnidadTipoIdIngresoNavigations { get; set; } = new List<UnidadTipo>();

    public virtual ICollection<UnidadTipo> UnidadTipoIdModificoNavigations { get; set; } = new List<UnidadTipo>();

    public virtual ICollection<Viaje> ViajeIdIngresoNavigations { get; set; } = new List<Viaje>();

    public virtual ICollection<Viaje> ViajeIdModificoNavigations { get; set; } = new List<Viaje>();

    public virtual ICollection<ViajeRutaTipo> ViajeRutaTipoIdIngresoNavigations { get; set; } = new List<ViajeRutaTipo>();

    public virtual ICollection<ViajeRutaTipo> ViajeRutaTipoIdModificoNavigations { get; set; } = new List<ViajeRutaTipo>();

    public virtual ICollection<ViajeRutum> ViajeRutumIdIngresoNavigations { get; set; } = new List<ViajeRutum>();

    public virtual ICollection<ViajeRutum> ViajeRutumIdModificoNavigations { get; set; } = new List<ViajeRutum>();

    public virtual ICollection<ViajeSeguimientoEstatus> ViajeSeguimientoEstatuses { get; set; } = new List<ViajeSeguimientoEstatus>();

    public virtual ICollection<ViajeTipo> ViajeTipoIdIngresoNavigations { get; set; } = new List<ViajeTipo>();

    public virtual ICollection<ViajeTipo> ViajeTipoIdModificoNavigations { get; set; } = new List<ViajeTipo>();

    public virtual ICollection<SeguridadGrupo> IdGrupos { get; set; } = new List<SeguridadGrupo>();
}
