using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadMenu
{
    public int IdMenu { get; set; }

    public int IdMenupadre { get; set; }

    public int Orden { get; set; }

    public string Estatus { get; set; } = null!;

    public string RutaArchivo { get; set; } = null!;

    public int Version { get; set; }

    public virtual ICollection<AyudaMenu> AyudaMenus { get; set; } = new List<AyudaMenu>();

    public virtual ICollection<BotonesSeguridad> BotonesSeguridads { get; set; } = new List<BotonesSeguridad>();

    public virtual ICollection<SeguridadMenuAyudum> SeguridadMenuAyuda { get; set; } = new List<SeguridadMenuAyudum>();

    public virtual ICollection<SeguridadGrupo> IdGrupos { get; set; } = new List<SeguridadGrupo>();
}
