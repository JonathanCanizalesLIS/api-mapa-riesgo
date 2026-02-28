using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class RegimenAduaneroGuium
{
    public int IdRegimenAduaneroGuia { get; set; }

    public int IdGuia { get; set; }

    public int IdRegimenAduanero { get; set; }

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual GuiaRegimenAduanero IdRegimenAduaneroNavigation { get; set; } = null!;
}
