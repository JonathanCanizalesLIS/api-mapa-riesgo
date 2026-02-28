using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCargoEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<NotaCargo> NotaCargos { get; set; } = new List<NotaCargo>();
}
