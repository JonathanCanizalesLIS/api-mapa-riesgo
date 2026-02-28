using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VGastoLiq
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public string NumLiquidacion { get; set; } = null!;

    public int IdLiquidacion { get; set; }

    public int IdClasificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal MontoAnticipo { get; set; }

    public decimal MontoGastoLiq { get; set; }

    public decimal MontoTotal { get; set; }

    public int IdPersonal { get; set; }

    public int TotalViajes { get; set; }

    public decimal TotalKilometros { get; set; }

    public int NoViaje { get; set; }

    public int IdViaje { get; set; }

    public decimal SueldoOperador { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Retencion { get; set; }

    public int TipoDoc { get; set; }
}
