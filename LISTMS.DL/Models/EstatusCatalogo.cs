using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EstatusCatalogo
{
    public string Estatus { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<AlarmaTipo> AlarmaTipos { get; set; } = new List<AlarmaTipo>();

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();

    public virtual ICollection<AnticipoConcepto> AnticipoConceptos { get; set; } = new List<AnticipoConcepto>();

    public virtual ICollection<BancoConceptoGrupo> BancoConceptoGrupos { get; set; } = new List<BancoConceptoGrupo>();

    public virtual ICollection<BancoConcepto> BancoConceptos { get; set; } = new List<BancoConcepto>();

    public virtual ICollection<BancoMovimientoRol> BancoMovimientoRols { get; set; } = new List<BancoMovimientoRol>();

    public virtual ICollection<BancoPeriodo> BancoPeriodos { get; set; } = new List<BancoPeriodo>();

    public virtual ICollection<Banco> Bancos { get; set; } = new List<Banco>();

    public virtual ICollection<ClienteMetodoPagoIdioma> ClienteMetodoPagoIdiomas { get; set; } = new List<ClienteMetodoPagoIdioma>();

    public virtual ICollection<ClienteMetodoPago> ClienteMetodoPagos { get; set; } = new List<ClienteMetodoPago>();

    public virtual ICollection<CombustibleTarifa> CombustibleTarifas { get; set; } = new List<CombustibleTarifa>();

    public virtual ICollection<Combustible> Combustibles { get; set; } = new List<Combustible>();

    public virtual ICollection<ContactoPuesto> ContactoPuestos { get; set; } = new List<ContactoPuesto>();

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();

    public virtual ICollection<ConvenioAnticipo> ConvenioAnticipos { get; set; } = new List<ConvenioAnticipo>();

    public virtual ICollection<ConvenioLiquidacion> ConvenioLiquidacions { get; set; } = new List<ConvenioLiquidacion>();

    public virtual ICollection<Convenio> Convenios { get; set; } = new List<Convenio>();

    public virtual ICollection<ElectronicoCertificado> ElectronicoCertificados { get; set; } = new List<ElectronicoCertificado>();

    public virtual ICollection<Embalaje> Embalajes { get; set; } = new List<Embalaje>();

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();

    public virtual ICollection<EstatusCatalogoIdioma> EstatusCatalogoIdiomas { get; set; } = new List<EstatusCatalogoIdioma>();

    public virtual ICollection<GuiaTituloAdicional> GuiaTituloAdicionals { get; set; } = new List<GuiaTituloAdicional>();

    public virtual ICollection<Idioma> Idiomas { get; set; } = new List<Idioma>();

    public virtual ICollection<Imagene> Imagenes { get; set; } = new List<Imagene>();

    public virtual ICollection<Monedum> Moneda { get; set; } = new List<Monedum>();

    public virtual ICollection<Pai> Pais { get; set; } = new List<Pai>();

    public virtual ICollection<PersonalCategorium> PersonalCategoria { get; set; } = new List<PersonalCategorium>();

    public virtual ICollection<Plaza> Plazas { get; set; } = new List<Plaza>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();

    public virtual ICollection<SerieCargo> SerieCargos { get; set; } = new List<SerieCargo>();

    public virtual ICollection<SerieCredito> SerieCreditos { get; set; } = new List<SerieCredito>();

    public virtual ICollection<SerieGuium> SerieGuia { get; set; } = new List<SerieGuium>();

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();

    public virtual ICollection<UnidadFianza> UnidadFianzas { get; set; } = new List<UnidadFianza>();

    public virtual ICollection<UnidadMarca> UnidadMarcas { get; set; } = new List<UnidadMarca>();

    public virtual ICollection<UnidadMedidum> UnidadMedida { get; set; } = new List<UnidadMedidum>();

    public virtual ICollection<UnidadMedidaClase> UnidadMedidaClases { get; set; } = new List<UnidadMedidaClase>();

    public virtual ICollection<UnidadSeguimientoEstatus> UnidadSeguimientoEstatuses { get; set; } = new List<UnidadSeguimientoEstatus>();

    public virtual ICollection<UnidadTipo> UnidadTipos { get; set; } = new List<UnidadTipo>();
}
