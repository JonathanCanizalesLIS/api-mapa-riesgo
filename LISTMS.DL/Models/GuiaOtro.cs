using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaOtro
{
    public int IdGuia { get; set; }

    public int Consecutivo { get; set; }

    public int IdConcepto { get; set; }

    public decimal Monto { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public string CartaPorte { get; set; } = null!;

    public int? PkGuiaOtros { get; set; }

    public decimal Cantidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdRetencion { get; set; }

    public int? IdObjetoImpuesto { get; set; }

    public decimal MontoResico { get; set; }

    public decimal FactorResico { get; set; }

    public virtual GuiaConcepto IdConceptoNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;
}
