using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionSeccionesIdioma
{
    public int IdIdioma { get; set; }

    public int IdImpresion { get; set; }

    public int IdSeccion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual Impresion IdImpresionNavigation { get; set; } = null!;
}
