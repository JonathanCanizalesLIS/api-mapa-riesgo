using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendum
{
    public int IdAdenda { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<ElectronicoAdendaCampo> ElectronicoAdendaCampos { get; set; } = new List<ElectronicoAdendaCampo>();

    public virtual ICollection<ElectronicoAdendaCliente> ElectronicoAdendaClientes { get; set; } = new List<ElectronicoAdendaCliente>();

    public virtual ICollection<ElectronicoAdendaIdioma> ElectronicoAdendaIdiomas { get; set; } = new List<ElectronicoAdendaIdioma>();

    public virtual ICollection<GuiaAdendum> GuiaAdenda { get; set; } = new List<GuiaAdendum>();

    public virtual ICollection<NotaCargoAdendum> NotaCargoAdenda { get; set; } = new List<NotaCargoAdendum>();

    public virtual ICollection<NotaCreditoAdendum> NotaCreditoAdenda { get; set; } = new List<NotaCreditoAdendum>();

    public virtual ICollection<Empresa> IdEmpresas { get; set; } = new List<Empresa>();
}
