using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadAyudum
{
    public int IdAyuda { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Llave { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<SeguridadAyudaIdioma> SeguridadAyudaIdiomas { get; set; } = new List<SeguridadAyudaIdioma>();

    public virtual ICollection<SeguridadMenuAyudum> SeguridadMenuAyuda { get; set; } = new List<SeguridadMenuAyudum>();
}
