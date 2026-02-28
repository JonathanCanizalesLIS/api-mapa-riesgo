using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaAdicional
{
    public int IdGuia { get; set; }

    public int IdAdicional { get; set; }

    public string Valor { get; set; } = null!;

    public virtual GuiaTituloAdicional IdAdicionalNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;
}
