using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AnticipoEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<AnticipoEstatusIdioma> AnticipoEstatusIdiomas { get; set; } = new List<AnticipoEstatusIdioma>();

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
