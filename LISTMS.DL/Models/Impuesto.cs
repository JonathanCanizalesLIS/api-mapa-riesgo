using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Impuesto
{
    public int IdImpuesto { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Factor { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdClasificacion { get; set; }

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string IsObjetoDeIva { get; set; } = null!;

    public virtual ICollection<ClienteCobranza> ClienteCobranzaIdIvaNavigations { get; set; } = new List<ClienteCobranza>();

    public virtual ICollection<ClienteCobranza> ClienteCobranzaIdRetencionNavigations { get; set; } = new List<ClienteCobranza>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<ConceptoPermisionario> ConceptoPermisionarios { get; set; } = new List<ConceptoPermisionario>();

    public virtual ICollection<Convenio> ConvenioIdIvaNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Convenio> ConvenioIdRetencionNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<GuiaConcepto> GuiaConceptoIdIvaNavigations { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<GuiaConcepto> GuiaConceptoIdRetencionNavigations { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<GuiaOtro> GuiaOtros { get; set; } = new List<GuiaOtro>();

    public virtual ICollection<Guium> GuiumIdIvaNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdRetencionNavigations { get; set; } = new List<Guium>();

    public virtual ImpuestoClasificacion IdClasificacionNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptoIdIvaNavigations { get; set; } = new List<LiquidacionConcepto>();

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptoIdRetencionNavigations { get; set; } = new List<LiquidacionConcepto>();

    public virtual ICollection<LiquidacionPermisionarioDetalle> LiquidacionPermisionarioDetalles { get; set; } = new List<LiquidacionPermisionarioDetalle>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<NotaCargo> NotaCargoIdIvaNavigations { get; set; } = new List<NotaCargo>();

    public virtual ICollection<NotaCargo> NotaCargoIdRetencionNavigations { get; set; } = new List<NotaCargo>();

    public virtual ICollection<NotaCredito> NotaCreditoIdIvaNavigations { get; set; } = new List<NotaCredito>();

    public virtual ICollection<NotaCredito> NotaCreditoIdRetencionNavigations { get; set; } = new List<NotaCredito>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
