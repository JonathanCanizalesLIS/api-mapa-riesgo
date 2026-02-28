using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionSueldoTipo
{
    public int TipoSueldo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<LiquidacionSueldoTipoIdioma> LiquidacionSueldoTipoIdiomas { get; set; } = new List<LiquidacionSueldoTipoIdioma>();

    public virtual ICollection<LiquidacionSueldo> LiquidacionSueldos { get; set; } = new List<LiquidacionSueldo>();
}
