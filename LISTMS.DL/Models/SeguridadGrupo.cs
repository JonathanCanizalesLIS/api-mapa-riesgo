using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadGrupo
{
    public int IdGrupo { get; set; }

    public int Clasegrupo { get; set; }

    public string Administrador { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<BotonesSeguridad> BotonesSeguridads { get; set; } = new List<BotonesSeguridad>();

    public virtual ICollection<SeguridadGrupoIdioma> SeguridadGrupoIdiomas { get; set; } = new List<SeguridadGrupoIdioma>();

    public virtual ICollection<SeguridadMenu> IdMenus { get; set; } = new List<SeguridadMenu>();

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
