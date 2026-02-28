using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoTipoReferencium
{
    public int IdTipoReferencia { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<BancoConceptoTipoReferenciaIdioma> BancoConceptoTipoReferenciaIdiomas { get; set; } = new List<BancoConceptoTipoReferenciaIdioma>();

    public virtual ICollection<BancoConcepto> BancoConceptos { get; set; } = new List<BancoConcepto>();
}
