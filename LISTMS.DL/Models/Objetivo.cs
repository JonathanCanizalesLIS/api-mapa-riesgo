using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Objetivo
{
    public int IdObjetivo { get; set; }

    public int IdEmpresa { get; set; }

    public string Periodo { get; set; } = null!;

    public decimal Ingresos { get; set; }

    public int Viajes { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
