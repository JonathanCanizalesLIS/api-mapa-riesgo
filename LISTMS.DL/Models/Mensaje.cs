using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Mensaje
{
    public int IdMensaje { get; set; }

    public int IdClasificacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Parametros { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual ICollection<MensajeIdioma> MensajeIdiomas { get; set; } = new List<MensajeIdioma>();
}
