using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoNaturaleza
{
    public int IdNaturaleza { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<BancoConceptoGrupo> BancoConceptoGrupos { get; set; } = new List<BancoConceptoGrupo>();

    public virtual ICollection<BancoConceptoNaturalezaIdioma> BancoConceptoNaturalezaIdiomas { get; set; } = new List<BancoConceptoNaturalezaIdioma>();
}
