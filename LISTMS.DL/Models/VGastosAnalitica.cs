using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VGastosAnalitica
{
    public int TipoDoc { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdViaje { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime? Fecha { get; set; }

    public int IdConcepto { get; set; }

    public int IdClasificacion { get; set; }

    public string Concepto { get; set; } = null!;

    public decimal MontoAnticipo { get; set; }

    public decimal MontoGastoLiq { get; set; }

    public decimal MontoTotal { get; set; }

    public int TotalViajes { get; set; }

    public decimal TotalKilometros { get; set; }

    public int IdUnidadMotriz { get; set; }

    public double? Cantidad { get; set; }

    public double? Subtotal { get; set; }

    public double? Iva { get; set; }

    public double? Retencion { get; set; }

    public double? Total { get; set; }

    public int IdTipoReferencia { get; set; }

    public int NoViaje { get; set; }

    public decimal SueldoOperador { get; set; }

    public DateTime FechaLiquidacion { get; set; }

    public int IdEstatus { get; set; }
}
