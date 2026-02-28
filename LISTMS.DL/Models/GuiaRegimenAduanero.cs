using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaRegimenAduanero
{
    public int IdRegimenAduanero { get; set; }

    public string? Clave { get; set; }

    public string? Descripcion { get; set; }

    public string? ImpoExpo { get; set; }

    public string? Entrada { get; set; }

    public string? Salida { get; set; }

    public string? Estatus { get; set; }

    public virtual ICollection<RegimenAduaneroGuium> RegimenAduaneroGuia { get; set; } = new List<RegimenAduaneroGuium>();
}
