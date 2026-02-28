using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EmpresaClickbalance
{
    public int IdEmpresa { get; set; }

    public int EmpresaCb { get; set; }

    public string Usuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string IdProductoFlete { get; set; } = null!;

    public string CodigoProductoFlete { get; set; } = null!;

    public string IdProductoAutopista { get; set; } = null!;

    public string CodigoProductoAutopista { get; set; } = null!;

    public string IdProductoManiobras { get; set; } = null!;

    public string CodigoProductoManiobras { get; set; } = null!;

    public string IdProductoSeguro { get; set; } = null!;

    public string CodigoProductoSeguro { get; set; } = null!;

    public int IdUsuario { get; set; }

    public int IdTipoGastoAnticipo { get; set; }

    public int IdTipoGastoVales { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
