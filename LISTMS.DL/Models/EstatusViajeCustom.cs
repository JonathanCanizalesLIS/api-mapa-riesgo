using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EstatusViajeCustom
{
    public int IdEstatusViaje { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public string Estatus { get; set; } = null!;
}
