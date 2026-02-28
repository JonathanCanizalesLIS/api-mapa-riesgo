using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Etiquetum
{
    public string IdEtiqueta { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<EtiquetaConfigurable> EtiquetaConfigurables { get; set; } = new List<EtiquetaConfigurable>();

    public virtual ICollection<EtiquetaIdioma> EtiquetaIdiomas { get; set; } = new List<EtiquetaIdioma>();
}
