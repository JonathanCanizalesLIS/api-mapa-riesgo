using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VGasto
{
    public int TipoDoc { get; set; }

    public int IdEmpresa { get; set; }

    public int IdClasificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal MontoAnticipo { get; set; }

    public decimal MontoGastoLiq { get; set; }

    public decimal MontoTotal { get; set; }

    public int TotalViajes { get; set; }

    public decimal TotalKilometros { get; set; }

    public decimal SueldoOperador { get; set; }

    public int IdUnidadMotriz { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Retencion { get; set; }

    public int IdViaje { get; set; }

    public int IdTipoReferencia { get; set; }

    public int NoViaje { get; set; }

    public int IdLiquidacion { get; set; }

    public string Estatus { get; set; } = null!;
}
