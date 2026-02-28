using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ElectronicoGuium> ElectronicoGuia { get; set; } = new List<ElectronicoGuium>();

    public virtual ICollection<ElectronicoLiquidacionDirectum> ElectronicoLiquidacionDirecta { get; set; } = new List<ElectronicoLiquidacionDirectum>();

    public virtual ICollection<ElectronicoLiquidacion> ElectronicoLiquidacions { get; set; } = new List<ElectronicoLiquidacion>();

    public virtual ICollection<ElectronicoNotaCargo> ElectronicoNotaCargos { get; set; } = new List<ElectronicoNotaCargo>();

    public virtual ICollection<ElectronicoNotaCredito> ElectronicoNotaCreditos { get; set; } = new List<ElectronicoNotaCredito>();
}
