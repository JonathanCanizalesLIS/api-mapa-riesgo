using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConsultaAlineacion
{
    public int IdAlineacion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ConsultaAlineacionIdioma> ConsultaAlineacionIdiomas { get; set; } = new List<ConsultaAlineacionIdioma>();
}
