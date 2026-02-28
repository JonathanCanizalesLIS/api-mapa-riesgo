using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BotonesSeguridad
{
    public int IdMenu { get; set; }

    public int IdGrupo { get; set; }

    public int IdBoton { get; set; }

    public virtual Botone IdBotonNavigation { get; set; } = null!;

    public virtual SeguridadGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual SeguridadMenu IdMenuNavigation { get; set; } = null!;
}
