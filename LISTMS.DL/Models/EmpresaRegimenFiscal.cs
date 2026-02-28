using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EmpresaRegimenFiscal
{
    public int IdRegimenfiscal { get; set; }

    public string Descripcion { get; set; } = null!;

    public string ClaveSat { get; set; } = null!;

    public string PFisica { get; set; } = null!;

    public string PMoral { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
