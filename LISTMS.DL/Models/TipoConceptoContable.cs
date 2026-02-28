using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TipoConceptoContable
{
    public int IdTipoConcepto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<ConceptosContable> ConceptosContables { get; set; } = new List<ConceptosContable>();
}
