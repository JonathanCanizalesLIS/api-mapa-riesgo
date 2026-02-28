using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FacturaPagoDetalle
{
    public decimal DepositoMonto { get; set; }

    public decimal DepositoTipoCambio { get; set; }

    public decimal DepositoMontomonedabase { get; set; }

    public decimal GuiaMonto { get; set; }

    public decimal GuiaTipoCambio { get; set; }

    public decimal GuiaMontomonedabase { get; set; }

    public int IdPago { get; set; }

    public int IdGuia { get; set; }

    public decimal GuiaMontoAjuste { get; set; }

    public decimal GuiaMontoSaldo { get; set; }

    public int IdPagoElectronico { get; set; }

    public int IdPagoDetraccion { get; set; }

    public int IdCargo { get; set; }

    public int TipoDocumento { get; set; }

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual FacturaPago IdPagoNavigation { get; set; } = null!;
}
