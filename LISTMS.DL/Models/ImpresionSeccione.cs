using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionSeccione
{
    public int IdImpresion { get; set; }

    public int IdSeccion { get; set; }

    public string Nombre { get; set; } = null!;

    public int Orden { get; set; }

    public virtual Impresion IdImpresionNavigation { get; set; } = null!;

    public virtual ICollection<ImpresionDetalle> ImpresionDetalles { get; set; } = new List<ImpresionDetalle>();
}
