using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MonedaMonedum
{
    public int IdMonedaMoneda { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal PorcentajeVariacion { get; set; }
}
