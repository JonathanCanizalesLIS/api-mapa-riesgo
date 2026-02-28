using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendaCamposRequerido
{
    public int IdRequerido { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ElectronicoAdendaCampo> ElectronicoAdendaCampos { get; set; } = new List<ElectronicoAdendaCampo>();

    public virtual ICollection<ElectronicoAdendaCamposRequeridoIdioma> ElectronicoAdendaCamposRequeridoIdiomas { get; set; } = new List<ElectronicoAdendaCamposRequeridoIdioma>();
}
