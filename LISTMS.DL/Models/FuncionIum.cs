using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FuncionIum
{
    public int IdFuncionIa { get; set; }

    public int? IdModeloIa { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? LimiteInput { get; set; }

    public int? LimiteOutput { get; set; }

    public int? LimiteRequest { get; set; }

    public virtual ModeloIum? IdModeloIaNavigation { get; set; }

    public virtual ICollection<PeticionIum> PeticionIa { get; set; } = new List<PeticionIum>();
}
