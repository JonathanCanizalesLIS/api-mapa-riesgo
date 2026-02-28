using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class InterfaceConfiguracion
{
    public int IdInterface { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public string TipoFrecuencia { get; set; } = null!;

    public int Frecuencia { get; set; }

    public DateTime FechaSiguiente { get; set; }

    public string UrlApi { get; set; } = null!;
}
