using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Impresion
{
    public int IdImpresion { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ImpresionDetalle> ImpresionDetalles { get; set; } = new List<ImpresionDetalle>();

    public virtual ICollection<ImpresionIdioma> ImpresionIdiomas { get; set; } = new List<ImpresionIdioma>();

    public virtual ICollection<ImpresionSeccione> ImpresionSecciones { get; set; } = new List<ImpresionSeccione>();

    public virtual ICollection<ImpresionSeccionesIdioma> ImpresionSeccionesIdiomas { get; set; } = new List<ImpresionSeccionesIdioma>();
}
