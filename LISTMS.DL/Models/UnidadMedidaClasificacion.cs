using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMedidaClasificacion
{
    public int IdClase { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
