using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MensajeError
{
    public int IdError { get; set; }

    public string Mensaje { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;
}
