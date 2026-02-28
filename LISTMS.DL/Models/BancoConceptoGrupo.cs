using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoGrupo
{
    public int IdGrupo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdNaturaleza { get; set; }

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual ICollection<BancoConcepto> BancoConceptos { get; set; } = new List<BancoConcepto>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual BancoConceptoNaturaleza IdNaturalezaNavigation { get; set; } = null!;
}
