using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMedidaIdioma
{
    public int IdUnidadMedida { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public string? Nombre { get; set; }

    public int IdIdioma { get; set; }

    public string Estatus { get; set; } = null!;
}
