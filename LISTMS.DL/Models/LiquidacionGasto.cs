using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionGasto
{
    public int IdLiquidacion { get; set; }

    public int Consecutivo { get; set; }

    public int IdConcepto { get; set; }

    public decimal Cantidad { get; set; }

    public int IdUnidadMedidaVolumen { get; set; }

    public decimal VolumenBase { get; set; }

    public decimal MontoSubtota { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal MontoTotal { get; set; }

    public string Referencia { get; set; } = null!;

    public int? ConceptoGasto { get; set; }

    public int? IdConvenioLiquidacion { get; set; }

    public int IdConceptoAnticipoLiq { get; set; }

    public string? FolioFiscal { get; set; }

    public int IdTipoGastoClickb { get; set; }

    public int IdAsociadoDeudorClickb { get; set; }

    public int IdFormaPagoClickb { get; set; }

    public int IdCentroCostoClickb { get; set; }

    public int IdDocumentoGastoClickb { get; set; }

    public string FolioDocumentoGastoClickb { get; set; } = null!;

    public int IdViaje { get; set; }

    public virtual LiquidacionConcepto IdConceptoNavigation { get; set; } = null!;

    public virtual Liquidacion IdLiquidacionNavigation { get; set; } = null!;
}
