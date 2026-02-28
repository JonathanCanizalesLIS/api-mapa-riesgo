using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MensajeClasificacion
{
    public int IdClasificacion { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<MensajeClasificacionIdioma> MensajeClasificacionIdiomas { get; set; } = new List<MensajeClasificacionIdioma>();
}
