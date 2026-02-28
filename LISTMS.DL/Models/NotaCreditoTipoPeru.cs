using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCreditoTipoPeru
{
    public int IdTipo { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<NotaCredito> NotaCreditos { get; set; } = new List<NotaCredito>();
}
