using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string Calle { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Delegacion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string Numerointerior { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Telefono2 { get; set; } = null!;

    public string Telefono3 { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public int IdEsquema { get; set; }

    public string? RegimenFiscal { get; set; }

    public string? RegistroPatronal { get; set; }

    public int? IdNumUnidades { get; set; }

    public string DiaHoraLocalizar { get; set; } = null!;

    public int IdTipoCarga { get; set; }

    public int IdRegimenfiscal { get; set; }

    public int IdTipoPersona { get; set; }

    public string Curp { get; set; } = null!;

    public bool Contrato { get; set; }

    public int IdRazonSocial { get; set; }

    public int SaldoRoutech { get; set; }

    public int IdUsuarioAceptocontrato { get; set; }

    public DateTime FechaAceptocontrato { get; set; }

    public int ActualizaOdometroUnidad { get; set; }

    public int IdDescripcionFlete { get; set; }

    public string CodigoUbigeo { get; set; } = null!;

    public DateTime AlertaVigencia { get; set; }

    public string CambiosMovac { get; set; } = null!;

    public int SaldoPermisionario { get; set; }

    public string UsoProrroga { get; set; } = null!;

    public string UsoProrrogaSoporte { get; set; } = null!;

    public string ArchivoConstanciaFiscal { get; set; } = null!;

    public int SaldoPlanner { get; set; }

    public DateTime? VigenciaPlanner { get; set; }

    public int SaldoEmbarcador { get; set; }

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();

    public virtual ICollection<AnticipoConcepto> AnticipoConceptos { get; set; } = new List<AnticipoConcepto>();

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<Archivo> Archivos { get; set; } = new List<Archivo>();

    public virtual ICollection<BancoConceptoGrupo> BancoConceptoGrupos { get; set; } = new List<BancoConceptoGrupo>();

    public virtual ICollection<BancoConcepto> BancoConceptos { get; set; } = new List<BancoConcepto>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<Banco> Bancos { get; set; } = new List<Banco>();

    public virtual ICollection<ClienteRecEnt> ClienteRecEnts { get; set; } = new List<ClienteRecEnt>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<CombustibleTarifa> CombustibleTarifas { get; set; } = new List<CombustibleTarifa>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<Combustible> Combustibles { get; set; } = new List<Combustible>();

    public virtual ICollection<ConceptoPermisionario> ConceptoPermisionarios { get; set; } = new List<ConceptoPermisionario>();

    public virtual ICollection<ConceptosContable> ConceptosContables { get; set; } = new List<ConceptosContable>();

    public virtual ICollection<ContactoPuesto> ContactoPuestos { get; set; } = new List<ContactoPuesto>();

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();

    public virtual ICollection<ConvenioAnticipo> ConvenioAnticipos { get; set; } = new List<ConvenioAnticipo>();

    public virtual ICollection<ConvenioEvidencium> ConvenioEvidencia { get; set; } = new List<ConvenioEvidencium>();

    public virtual ICollection<ConvenioLiquidacion> ConvenioLiquidacions { get; set; } = new List<ConvenioLiquidacion>();

    public virtual ICollection<Convenio> Convenios { get; set; } = new List<Convenio>();

    public virtual ICollection<CotizacionViajeFactore> CotizacionViajeFactores { get; set; } = new List<CotizacionViajeFactore>();

    public virtual ICollection<CuentaCliente> CuentaClientes { get; set; } = new List<CuentaCliente>();

    public virtual ICollection<EdiUsuario> EdiUsuarios { get; set; } = new List<EdiUsuario>();

    public virtual ICollection<ElectronicoCertificado> ElectronicoCertificados { get; set; } = new List<ElectronicoCertificado>();

    public virtual ICollection<ElectronicoPeruTicket> ElectronicoPeruTickets { get; set; } = new List<ElectronicoPeruTicket>();

    public virtual ICollection<Electronico> Electronicos { get; set; } = new List<Electronico>();

    public virtual ICollection<Embalaje> Embalajes { get; set; } = new List<Embalaje>();

    public virtual EmpresaClickbalance? EmpresaClickbalance { get; set; }

    public virtual EmpresaConfiguracion? EmpresaConfiguracion { get; set; }

    public virtual ICollection<EmpresaProveedoresGp> EmpresaProveedoresGps { get; set; } = new List<EmpresaProveedoresGp>();

    public virtual ICollection<EstadoCuentum> EstadoCuenta { get; set; } = new List<EstadoCuentum>();

    public virtual ICollection<EtiquetaConfigurable> EtiquetaConfigurables { get; set; } = new List<EtiquetaConfigurable>();

    public virtual ICollection<Evidencium> Evidencia { get; set; } = new List<Evidencium>();

    public virtual ICollection<FacturaPago> FacturaPagos { get; set; } = new List<FacturaPago>();

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobros { get; set; } = new List<FacturaRelacioncobro>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual ICollection<GuiaConcepto> GuiaConceptos { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<GuiaEvidencium> GuiaEvidencia { get; set; } = new List<GuiaEvidencium>();

    public virtual ICollection<GuiaTituloAdicional> GuiaTituloAdicionals { get; set; } = new List<GuiaTituloAdicional>();

    public virtual Esquema IdEsquemaNavigation { get; set; } = null!;

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual NumUnidade? IdNumUnidadesNavigation { get; set; }

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual EmpresaRegimenFiscal IdRegimenfiscalNavigation { get; set; } = null!;

    public virtual TipoCarga IdTipoCargaNavigation { get; set; } = null!;

    public virtual PersonalTipoPersona IdTipoPersonaNavigation { get; set; } = null!;

    public virtual ICollection<Imagene> Imagenes { get; set; } = new List<Imagene>();

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptos { get; set; } = new List<LiquidacionConcepto>();

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<LiquidacionSueldoRelacion> LiquidacionSueldoRelacions { get; set; } = new List<LiquidacionSueldoRelacion>();

    public virtual ICollection<LiquidacionSueldo> LiquidacionSueldos { get; set; } = new List<LiquidacionSueldo>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();

    public virtual ICollection<Monedum> Moneda { get; set; } = new List<Monedum>();

    public virtual ICollection<NotaCargo> NotaCargos { get; set; } = new List<NotaCargo>();

    public virtual ICollection<NotaCredito> NotaCreditos { get; set; } = new List<NotaCredito>();

    public virtual ICollection<Objetivo> Objetivos { get; set; } = new List<Objetivo>();

    public virtual ICollection<OrdenCompraViaje> OrdenCompraViajes { get; set; } = new List<OrdenCompraViaje>();

    public virtual ICollection<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracions { get; set; } = new List<PermisionarioTarifaConfiguracion>();

    public virtual ICollection<PermisionarioTarifa> PermisionarioTarifas { get; set; } = new List<PermisionarioTarifa>();

    public virtual ICollection<PersonalCategorium> PersonalCategoria { get; set; } = new List<PersonalCategorium>();

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();

    public virtual ICollection<PeticionIum> PeticionIa { get; set; } = new List<PeticionIum>();

    public virtual ICollection<Plaza> Plazas { get; set; } = new List<Plaza>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();

    public virtual ICollection<SesionUsuario> SesionUsuarios { get; set; } = new List<SesionUsuario>();

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();

    public virtual ICollection<Sugerencia> Sugerencia { get; set; } = new List<Sugerencia>();

    public virtual ICollection<UnidadLinea> UnidadLineas { get; set; } = new List<UnidadLinea>();

    public virtual ICollection<UnidadMarca> UnidadMarcas { get; set; } = new List<UnidadMarca>();

    public virtual ICollection<UnidadSeguimientoEstatus> UnidadSeguimientoEstatuses { get; set; } = new List<UnidadSeguimientoEstatus>();

    public virtual ICollection<UnidadTipo> UnidadTipos { get; set; } = new List<UnidadTipo>();

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<ViajeProgramado> ViajeProgramados { get; set; } = new List<ViajeProgramado>();

    public virtual ICollection<ViajeRutum> ViajeRuta { get; set; } = new List<ViajeRutum>();

    public virtual ICollection<ViajeRutaTipo> ViajeRutaTipos { get; set; } = new List<ViajeRutaTipo>();

    public virtual ICollection<ViajeSeguimientoControl> ViajeSeguimientoControls { get; set; } = new List<ViajeSeguimientoControl>();

    public virtual ICollection<ViajeTipo> ViajeTipos { get; set; } = new List<ViajeTipo>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();

    public virtual ICollection<ElectronicoAdendum> IdAdenda { get; set; } = new List<ElectronicoAdendum>();
}
