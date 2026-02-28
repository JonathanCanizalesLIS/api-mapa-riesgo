using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpuestoClasificacion
{
    public int IdClasificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ImpuestoClasificacionIdioma> ImpuestoClasificacionIdiomas { get; set; } = new List<ImpuestoClasificacionIdioma>();

    public virtual ICollection<Impuesto> Impuestos { get; set; } = new List<Impuesto>();
}
