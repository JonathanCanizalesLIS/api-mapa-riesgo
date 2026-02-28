using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Idioma
{
    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<AlarmaFrecuenciaIdioma> AlarmaFrecuenciaIdiomas { get; set; } = new List<AlarmaFrecuenciaIdioma>();

    public virtual ICollection<AlarmaTipoIdioma> AlarmaTipoIdiomas { get; set; } = new List<AlarmaTipoIdioma>();

    public virtual ICollection<AnticipoEstatusIdioma> AnticipoEstatusIdiomas { get; set; } = new List<AnticipoEstatusIdioma>();

    public virtual ICollection<Ayudum> Ayuda { get; set; } = new List<Ayudum>();

    public virtual ICollection<BancoConceptoClasificacionIdioma> BancoConceptoClasificacionIdiomas { get; set; } = new List<BancoConceptoClasificacionIdioma>();

    public virtual ICollection<BancoConceptoNaturalezaIdioma> BancoConceptoNaturalezaIdiomas { get; set; } = new List<BancoConceptoNaturalezaIdioma>();

    public virtual ICollection<BancoConceptoTipoReferenciaIdioma> BancoConceptoTipoReferenciaIdiomas { get; set; } = new List<BancoConceptoTipoReferenciaIdioma>();

    public virtual ICollection<BancoMovimientoEstatusIdioma> BancoMovimientoEstatusIdiomas { get; set; } = new List<BancoMovimientoEstatusIdioma>();

    public virtual ICollection<BancoMovimientoRolIdioma> BancoMovimientoRolIdiomas { get; set; } = new List<BancoMovimientoRolIdioma>();

    public virtual ICollection<BancoMovimientoTipoReferenciaIdioma> BancoMovimientoTipoReferenciaIdiomas { get; set; } = new List<BancoMovimientoTipoReferenciaIdioma>();

    public virtual ICollection<BancoSolicitudEstatusIdioma> BancoSolicitudEstatusIdiomas { get; set; } = new List<BancoSolicitudEstatusIdioma>();

    public virtual ICollection<BancoSolicitudFrecuenciaIdioma> BancoSolicitudFrecuenciaIdiomas { get; set; } = new List<BancoSolicitudFrecuenciaIdioma>();

    public virtual ICollection<ClienteMetodoPagoIdioma> ClienteMetodoPagoIdiomas { get; set; } = new List<ClienteMetodoPagoIdioma>();

    public virtual ICollection<ClienteTipoRolIdioma> ClienteTipoRolIdiomas { get; set; } = new List<ClienteTipoRolIdioma>();

    public virtual ICollection<CombustibleEstatusIdioma> CombustibleEstatusIdiomas { get; set; } = new List<CombustibleEstatusIdioma>();

    public virtual ICollection<ConsultaAlineacionIdioma> ConsultaAlineacionIdiomas { get; set; } = new List<ConsultaAlineacionIdioma>();

    public virtual ICollection<ConsultaDetalleIdioma> ConsultaDetalleIdiomas { get; set; } = new List<ConsultaDetalleIdioma>();

    public virtual ICollection<ElectronicoAdendaCamposRequeridoIdioma> ElectronicoAdendaCamposRequeridoIdiomas { get; set; } = new List<ElectronicoAdendaCamposRequeridoIdioma>();

    public virtual ICollection<ElectronicoAdendaIdioma> ElectronicoAdendaIdiomas { get; set; } = new List<ElectronicoAdendaIdioma>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracions { get; set; } = new List<EmpresaConfiguracion>();

    public virtual ICollection<EstatusCatalogoIdioma> EstatusCatalogoIdiomas { get; set; } = new List<EstatusCatalogoIdioma>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<EtiquetaIdioma> EtiquetaIdiomas { get; set; } = new List<EtiquetaIdioma>();

    public virtual ICollection<FacturaEstatusIdioma> FacturaEstatusIdiomas { get; set; } = new List<FacturaEstatusIdioma>();

    public virtual ICollection<FacturaRelacioncobroEstatusIdioma> FacturaRelacioncobroEstatusIdiomas { get; set; } = new List<FacturaRelacioncobroEstatusIdioma>();

    public virtual ICollection<GuiaEstatusIdioma> GuiaEstatusIdiomas { get; set; } = new List<GuiaEstatusIdioma>();

    public virtual ICollection<GuiaTipoCobroIdioma> GuiaTipoCobroIdiomas { get; set; } = new List<GuiaTipoCobroIdioma>();

    public virtual ICollection<GuiaTipoDocumentoIdioma> GuiaTipoDocumentoIdiomas { get; set; } = new List<GuiaTipoDocumentoIdioma>();

    public virtual ICollection<ImpresionDetalleIdioma> ImpresionDetalleIdiomas { get; set; } = new List<ImpresionDetalleIdioma>();

    public virtual ICollection<ImpresionIdioma> ImpresionIdiomas { get; set; } = new List<ImpresionIdioma>();

    public virtual ICollection<ImpresionSeccionesIdioma> ImpresionSeccionesIdiomas { get; set; } = new List<ImpresionSeccionesIdioma>();

    public virtual ICollection<ImpuestoClasificacionIdioma> ImpuestoClasificacionIdiomas { get; set; } = new List<ImpuestoClasificacionIdioma>();

    public virtual ICollection<LiquidacionEstatusIdioma> LiquidacionEstatusIdiomas { get; set; } = new List<LiquidacionEstatusIdioma>();

    public virtual ICollection<LiquidacionPermisionarioEstatusIdioma> LiquidacionPermisionarioEstatusIdiomas { get; set; } = new List<LiquidacionPermisionarioEstatusIdioma>();

    public virtual ICollection<LiquidacionSueldoTipoIdioma> LiquidacionSueldoTipoIdiomas { get; set; } = new List<LiquidacionSueldoTipoIdioma>();

    public virtual ICollection<LiquidacionTipoAdeudoIdioma> LiquidacionTipoAdeudoIdiomas { get; set; } = new List<LiquidacionTipoAdeudoIdioma>();

    public virtual ICollection<MensajeClasificacionIdioma> MensajeClasificacionIdiomas { get; set; } = new List<MensajeClasificacionIdioma>();

    public virtual ICollection<MensajeIdioma> MensajeIdiomas { get; set; } = new List<MensajeIdioma>();

    public virtual ICollection<MttoUnidadEstatusIdioma> MttoUnidadEstatusIdiomas { get; set; } = new List<MttoUnidadEstatusIdioma>();

    public virtual ICollection<MttoUnidadTipoActividadIdioma> MttoUnidadTipoActividadIdiomas { get; set; } = new List<MttoUnidadTipoActividadIdioma>();

    public virtual ICollection<MttoUnidadTipoMttoIdioma> MttoUnidadTipoMttoIdiomas { get; set; } = new List<MttoUnidadTipoMttoIdioma>();

    public virtual ICollection<NotaCargoEstatusIdioma> NotaCargoEstatusIdiomas { get; set; } = new List<NotaCargoEstatusIdioma>();

    public virtual ICollection<NotaCreditoEstatusIdioma> NotaCreditoEstatusIdiomas { get; set; } = new List<NotaCreditoEstatusIdioma>();

    public virtual ICollection<Pai> Pais { get; set; } = new List<Pai>();

    public virtual ICollection<PersonalEstatusIdioma> PersonalEstatusIdiomas { get; set; } = new List<PersonalEstatusIdioma>();

    public virtual ICollection<PreguntaFrecuente> PreguntaFrecuentes { get; set; } = new List<PreguntaFrecuente>();

    public virtual ICollection<ProveedorRolIdioma> ProveedorRolIdiomas { get; set; } = new List<ProveedorRolIdioma>();

    public virtual ICollection<SeguridadAyudaIdioma> SeguridadAyudaIdiomas { get; set; } = new List<SeguridadAyudaIdioma>();

    public virtual ICollection<SeguridadGrupoIdioma> SeguridadGrupoIdiomas { get; set; } = new List<SeguridadGrupoIdioma>();

    public virtual ICollection<SerieControlaFolioIdioma> SerieControlaFolioIdiomas { get; set; } = new List<SerieControlaFolioIdioma>();

    public virtual ICollection<SerieTipoIdioma> SerieTipoIdiomas { get; set; } = new List<SerieTipoIdioma>();

    public virtual ICollection<SugerenciaEstatusIdioma> SugerenciaEstatusIdiomas { get; set; } = new List<SugerenciaEstatusIdioma>();

    public virtual ICollection<TiposDocumentoIdioma> TiposDocumentoIdiomas { get; set; } = new List<TiposDocumentoIdioma>();

    public virtual ICollection<UnidadTipoRolIdioma> UnidadTipoRolIdiomas { get; set; } = new List<UnidadTipoRolIdioma>();

    public virtual ICollection<ViajeEstatusIdioma> ViajeEstatusIdiomas { get; set; } = new List<ViajeEstatusIdioma>();

    public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
}
