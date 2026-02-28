using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaProductoIdentificacion
{
    public int IdGuia { get; set; }

    public int Consecutivo { get; set; }

    public int IdProducto { get; set; }

    public int IdOrigen { get; set; }

    public int IdDestino { get; set; }

    public string NumGuiaIdentificacion { get; set; } = null!;

    public string DescripcionGuiaIdentificacion { get; set; } = null!;

    public decimal PesoGuiaIdentificacion { get; set; }

    public virtual Guium IdGuiaNavigation { get; set; } = null!;
}
