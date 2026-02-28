using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaTipoCobro
{
    public int IdTipoCobro { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Convenio> Convenios { get; set; } = new List<Convenio>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual ICollection<GuiaTipoCobroIdioma> GuiaTipoCobroIdiomas { get; set; } = new List<GuiaTipoCobroIdioma>();
}
