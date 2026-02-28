using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConvenioAnticipoDesglose
{
    public int IdConvenio { get; set; }

    public int IdConcepto { get; set; }

    public decimal Monto { get; set; }

    public virtual AnticipoConcepto IdConceptoNavigation { get; set; } = null!;

    public virtual ConvenioAnticipo IdConvenioNavigation { get; set; } = null!;
}
