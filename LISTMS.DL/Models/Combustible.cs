using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Combustible
{
    public int IdCombustible { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual ICollection<CombustibleTarifaDetalle> CombustibleTarifaDetalles { get; set; } = new List<CombustibleTarifaDetalle>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<Iep> Ieps { get; set; } = new List<Iep>();

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptos { get; set; } = new List<LiquidacionConcepto>();

    public virtual ICollection<UnidadMotriz> UnidadMotrizTipoCombustible1Navigations { get; set; } = new List<UnidadMotriz>();

    public virtual ICollection<UnidadMotriz> UnidadMotrizTipoCombustible2Navigations { get; set; } = new List<UnidadMotriz>();
}
