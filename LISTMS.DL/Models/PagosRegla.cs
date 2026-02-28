using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosRegla
{
    public int GrupoId { get; set; }

    public string? Nombre { get; set; }

    public int? Orden { get; set; }

    public string? Accion { get; set; }

    public byte? Permitir { get; set; }

    public byte? Padre { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public byte[]? Ts { get; set; }

    public int Id { get; set; }

    public virtual PagosGrupo Grupo { get; set; } = null!;
}
