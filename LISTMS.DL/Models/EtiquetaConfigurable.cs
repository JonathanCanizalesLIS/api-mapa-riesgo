using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EtiquetaConfigurable
{
    public string IdEtiqueta { get; set; } = null!;

    public string NombreConfigurable { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Etiquetum IdEtiquetaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
