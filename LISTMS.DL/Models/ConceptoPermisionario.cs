using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConceptoPermisionario
{
    public int IdConcepto { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdTipoConcepto { get; set; }

    public string CalculaRetencion { get; set; } = null!;

    public string CalculaIva { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public int IdIngreso { get; set; }

    public DateTime? FechaModifico { get; set; }

    public int IdModifico { get; set; }

    public int IdRetencion { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual PermisionarioTipoConcepto IdTipoConceptoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionPermisionarioDetalle> LiquidacionPermisionarioDetalles { get; set; } = new List<LiquidacionPermisionarioDetalle>();
}
