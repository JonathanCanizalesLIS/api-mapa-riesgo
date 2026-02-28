using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public string Folio { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdCliente { get; set; }

    public int IdRemitente { get; set; }

    public int IdDestinatario { get; set; }

    public int IdRuta { get; set; }

    public int IdEstatusPedido { get; set; }

    public int IdViaje { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual EstatusPedido IdEstatusPedidoNavigation { get; set; } = null!;

    public virtual ViajeRutum IdRutaNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
