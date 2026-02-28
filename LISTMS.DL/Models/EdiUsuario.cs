using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiUsuario
{
    public int IdEdiUsuario { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpresa { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Estatus { get; set; }

    public bool HabilitaEncripcion { get; set; }

    public string IsaId { get; set; } = null!;

    public string GsId { get; set; } = null!;

    public string IsaQualifier { get; set; } = null!;

    public virtual ICollection<EdiLoadTender> EdiLoadTenders { get; set; } = new List<EdiLoadTender>();

    public virtual ICollection<EdiSesionUsuario> EdiSesionUsuarios { get; set; } = new List<EdiSesionUsuario>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
