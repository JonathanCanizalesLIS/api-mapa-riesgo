using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosFpago
{
    public string? Name { get; set; }

    public string? Forma { get; set; }

    public string? Host { get; set; }

    public string? Url { get; set; }

    public string? User { get; set; }

    public string? Password { get; set; }

    public string? Clientid { get; set; }

    public string? Mode { get; set; }

    public string? Descripcion { get; set; }

    public string? Respuesta { get; set; }

    public int Id { get; set; }

    public virtual ICollection<PagosPago> PagosPagos { get; set; } = new List<PagosPago>();
}
