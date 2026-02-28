using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EstatusPedido
{
    public int IdEstatusPedido { get; set; }

    public string Clave { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
