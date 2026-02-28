using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaViaje
{
    public int IdGuia { get; set; }

    public int IdOperador { get; set; }

    public int IdSegundoOperador { get; set; }

    public int IdTipoPermisoSct { get; set; }

    public string NumeroPermisoSct { get; set; } = null!;

    public int IdUnidad { get; set; }

    public int? IdRemolque { get; set; }

    public int? IdSegundoRemolque { get; set; }

    public int IdConfiguracionVehicular { get; set; }

    public decimal PesoBrutoVehicular { get; set; }

    public virtual CConfigAutotransporte IdConfiguracionVehicularNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual Personal IdOperadorNavigation { get; set; } = null!;

    public virtual Unidad? IdRemolqueNavigation { get; set; }

    public virtual Personal IdSegundoOperadorNavigation { get; set; } = null!;

    public virtual Unidad? IdSegundoRemolqueNavigation { get; set; }

    public virtual CTipoPermisoSct IdTipoPermisoSctNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
