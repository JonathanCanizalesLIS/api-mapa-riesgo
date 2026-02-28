using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteMetodoPagoIdioma
{
    public int IdMetodoPago { get; set; }

    public int IdIdioma { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string? Clave { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
