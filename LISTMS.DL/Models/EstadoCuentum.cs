using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EstadoCuentum
{
    public int IdEstadoCuenta { get; set; }

    public int Id { get; set; }

    public int IdEmpresa { get; set; }

    public int UnidadesContratadas { get; set; }

    public int UnidadesPropias { get; set; }

    public string? Periodo { get; set; }

    public DateTime Vigencia { get; set; }

    public int DiaCorte { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
