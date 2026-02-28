using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoBancosat
{
    public int IdBancosat { get; set; }

    public string ClaveSat { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int? IdBancoPais { get; set; }

    public string RfcBanco { get; set; } = null!;

    public virtual ICollection<CuentaCliente> CuentaClientes { get; set; } = new List<CuentaCliente>();

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
