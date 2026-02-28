using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendaCliente
{
    public int IdAdenda { get; set; }

    public int IdCliente { get; set; }

    public int Consecutivo { get; set; }

    public string Campo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public int Requerido { get; set; }

    public bool Obligatorio { get; set; }

    public virtual ElectronicoAdendum IdAdendaNavigation { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
