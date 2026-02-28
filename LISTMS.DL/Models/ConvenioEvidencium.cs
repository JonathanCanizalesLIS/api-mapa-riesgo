using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConvenioEvidencium
{
    public int IdEmpresa { get; set; }

    public int IdConvenio { get; set; }

    public int IdCliente { get; set; }

    public int IdEvidencia { get; set; }

    public int Consecutivo { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Convenio IdConvenioNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Evidencium IdEvidenciaNavigation { get; set; } = null!;
}
