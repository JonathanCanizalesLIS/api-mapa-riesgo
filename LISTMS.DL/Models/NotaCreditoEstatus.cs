using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCreditoEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<NotaCargoEstatusIdioma> NotaCargoEstatusIdiomas { get; set; } = new List<NotaCargoEstatusIdioma>();

    public virtual ICollection<NotaCreditoEstatusIdioma> NotaCreditoEstatusIdiomas { get; set; } = new List<NotaCreditoEstatusIdioma>();

    public virtual ICollection<NotaCredito> NotaCreditos { get; set; } = new List<NotaCredito>();
}
