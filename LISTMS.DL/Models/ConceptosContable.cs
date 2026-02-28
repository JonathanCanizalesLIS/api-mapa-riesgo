using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConceptosContable
{
    public int IdConceptoContable { get; set; }

    public int IdTipoConcepto { get; set; }

    public int IdConcepto { get; set; }

    public int IdEmpresa { get; set; }

    public int IdCliente { get; set; }

    public int IdProveedor { get; set; }

    public int IdPersonal { get; set; }

    public int IdOperador { get; set; }

    public string CuentaContable { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public int IdUsuarioIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdUsuarioModifico { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdInstitucionBancaria { get; set; }

    public string ContableTipoConcepto { get; set; } = null!;

    public string ContableInstitucionBancaria { get; set; } = null!;

    public string ContableConcepto { get; set; } = null!;

    public string ContableClasificacion { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Personal IdOperadorNavigation { get; set; } = null!;

    public virtual Personal IdPersonalNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual TipoConceptoContable IdTipoConceptoNavigation { get; set; } = null!;
}
