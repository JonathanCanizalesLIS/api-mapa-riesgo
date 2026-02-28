using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoClasificacion
{
    public int IdClasificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BancoConceptoClasificacionIdioma> BancoConceptoClasificacionIdiomas { get; set; } = new List<BancoConceptoClasificacionIdioma>();

    public virtual ICollection<LiquidacionConcepto> LiquidacionConceptos { get; set; } = new List<LiquidacionConcepto>();
}
