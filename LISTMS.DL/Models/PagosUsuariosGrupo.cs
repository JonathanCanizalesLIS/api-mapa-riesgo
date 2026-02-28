using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosUsuariosGrupo
{
    public int? UsuarioId { get; set; }

    public int? GrupoId { get; set; }

    public int? Seguridad { get; set; }

    public int Id { get; set; }

    public virtual PagosGrupo? Grupo { get; set; }

    public virtual PagosUsuario? Usuario { get; set; }
}
