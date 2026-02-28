using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionDetalleIdioma
{
    public int IdIdioma { get; set; }

    public int IdImpresion { get; set; }

    public int Consecutivo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ImpresionIdioma IdI { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual ImpresionDetalle ImpresionDetalle { get; set; } = null!;
}
