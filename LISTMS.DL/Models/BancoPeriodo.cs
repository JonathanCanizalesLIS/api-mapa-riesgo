using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoPeriodo
{
    public int IdPeriodo { get; set; }

    public int IdBanco { get; set; }

    public string Periodo { get; set; } = null!;

    public decimal SaldoInicial { get; set; }

    public decimal MontoPeriodo { get; set; }

    public decimal SaldoFinal { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Banco IdBancoNavigation { get; set; } = null!;
}
