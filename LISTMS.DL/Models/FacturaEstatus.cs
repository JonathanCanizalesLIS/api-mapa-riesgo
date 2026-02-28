using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FacturaEstatus
{
    public int IdEstatus { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<FacturaEstatusIdioma> FacturaEstatusIdiomas { get; set; } = new List<FacturaEstatusIdioma>();
}
