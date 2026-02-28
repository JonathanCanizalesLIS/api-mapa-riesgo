using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionIdioma
{
    public int IdIdioma { get; set; }

    public int IdImpresion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual Impresion IdImpresionNavigation { get; set; } = null!;

    public virtual ICollection<ImpresionDetalleIdioma> ImpresionDetalleIdiomas { get; set; } = new List<ImpresionDetalleIdioma>();
}
