using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FacturaPago
{
    public decimal DepositoMontoSaldo { get; set; }

    public int IdPago { get; set; }

    public int? IdMovimiento { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public decimal DepositoMontoAjuste { get; set; }

    public decimal TipoCambio { get; set; }

    public int Retimbrado { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual BancoMovimiento? IdMovimientoNavigation { get; set; }
}
