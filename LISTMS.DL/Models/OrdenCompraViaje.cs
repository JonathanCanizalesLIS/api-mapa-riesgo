using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class OrdenCompraViaje
{
    public int IdOrdenCompra { get; set; }

    public string NumOrdenCompra { get; set; } = null!;

    public string OrdenCompra { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string NumPedido { get; set; } = null!;

    public string NumVale { get; set; } = null!;

    public string Proveedor { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public DateTime? FechaPago { get; set; }

    public string FacturaProveedor { get; set; } = null!;

    public string ComplementoPagoProveedor { get; set; } = null!;

    public decimal TonelajeCompra { get; set; }

    public decimal MontoCompra { get; set; }

    public string Remision { get; set; } = null!;

    public decimal TonelajeRemision { get; set; }

    public decimal MontoVenta { get; set; }

    public decimal TonelajeVenta { get; set; }

    public decimal PesoBascula { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdIngreso { get; set; }

    public DateTime? FechaModifico { get; set; }

    public int IdModifico { get; set; }

    public int? IdRemitente { get; set; }

    public int? IdPlazaOrigen { get; set; }

    public int? IdDestinatario { get; set; }

    public int? IdPlazaDestino { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
