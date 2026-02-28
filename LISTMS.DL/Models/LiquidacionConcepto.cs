using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionConcepto
{
    public int IdConcepto { get; set; }

    public int IdClasificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public int IdCombustible { get; set; }

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdComplemento { get; set; }

    public int IdComplementoAtributo { get; set; }

    public int IdTipoGastoClickb { get; set; }

    public int IdTipoGasto { get; set; }

    public virtual ICollection<ConvenioLiquidacionGasto> ConvenioLiquidacionGastos { get; set; } = new List<ConvenioLiquidacionGasto>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracions { get; set; } = new List<EmpresaConfiguracion>();

    public virtual BancoConceptoClasificacion IdClasificacionNavigation { get; set; } = null!;

    public virtual Combustible IdCombustibleNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionGasto> LiquidacionGastos { get; set; } = new List<LiquidacionGasto>();
}
