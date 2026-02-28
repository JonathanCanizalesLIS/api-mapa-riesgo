using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AnticipoDesglose
{
    public int IdAnticipo { get; set; }

    public int IdConcepto { get; set; }

    public decimal Monto { get; set; }

    public virtual Anticipo IdAnticipoNavigation { get; set; } = null!;

    public virtual AnticipoConcepto IdConceptoNavigation { get; set; } = null!;
}
