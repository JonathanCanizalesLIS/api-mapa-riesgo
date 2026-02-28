using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FacturaRelacioncobroEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<FacturaRelacioncobroEstatusIdioma> FacturaRelacioncobroEstatusIdiomas { get; set; } = new List<FacturaRelacioncobroEstatusIdioma>();

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobros { get; set; } = new List<FacturaRelacioncobro>();
}
