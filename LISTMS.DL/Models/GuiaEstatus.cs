using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaEstatus
{
    public int IdEstatus { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual ICollection<GuiaEstatusIdioma> GuiaEstatusIdiomas { get; set; } = new List<GuiaEstatusIdioma>();
}
