using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaEvidencium
{
    public int IdGuia { get; set; }

    public int IdEvidencia { get; set; }

    public int IdEmpresa { get; set; }

    public bool Entregado { get; set; }

    public virtual ICollection<GuiaEvidenciaFoto> GuiaEvidenciaFotos { get; set; } = new List<GuiaEvidenciaFoto>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Evidencium IdEvidenciaNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;
}
