using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConvenioOtro
{
    public int IdConvenio { get; set; }

    public int Consecutivo { get; set; }

    public int IdConcepto { get; set; }

    public decimal Monto { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal Cantidad { get; set; }

    public int IdObjetoImpuesto { get; set; }

    public virtual GuiaConcepto IdConceptoNavigation { get; set; } = null!;
}
