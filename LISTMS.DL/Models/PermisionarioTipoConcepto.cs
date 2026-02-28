using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PermisionarioTipoConcepto
{
    public int IdTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ConceptoPermisionario> ConceptoPermisionarios { get; set; } = new List<ConceptoPermisionario>();
}
