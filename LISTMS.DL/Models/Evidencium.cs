using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Evidencium
{
    public int IdEvidencia { get; set; }

    public int IdEmpresa { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<ConvenioEvidencium> ConvenioEvidencia { get; set; } = new List<ConvenioEvidencium>();

    public virtual ICollection<GuiaEvidencium> GuiaEvidencia { get; set; } = new List<GuiaEvidencium>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
