using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendaCampo
{
    public int IdAdenda { get; set; }

    public int Consecutivo { get; set; }

    public string Campo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Requerido { get; set; }

    public bool Obligatorio { get; set; }

    public virtual ICollection<ElectronicoAdendaCamposDefault> ElectronicoAdendaCamposDefaults { get; set; } = new List<ElectronicoAdendaCamposDefault>();

    public virtual ElectronicoAdendum IdAdendaNavigation { get; set; } = null!;

    public virtual ElectronicoAdendaCamposRequerido RequeridoNavigation { get; set; } = null!;
}
