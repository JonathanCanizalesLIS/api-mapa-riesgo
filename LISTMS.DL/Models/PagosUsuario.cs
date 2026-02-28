using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosUsuario
{
    public int? ClienteId { get; set; }

    public int? Seguridad { get; set; }

    public string? Name { get; set; }

    public string? Usuario { get; set; }

    public string Password { get; set; } = null!;

    public string? Correo { get; set; }

    public string? Supervisor { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? Activo { get; set; }

    public int Id { get; set; }

    public virtual PagosCliente? Cliente { get; set; }

    public virtual ICollection<PagosUsuariosGrupo> PagosUsuariosGrupos { get; set; } = new List<PagosUsuariosGrupo>();
}
