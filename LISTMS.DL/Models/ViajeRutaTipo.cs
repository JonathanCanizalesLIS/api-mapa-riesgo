using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeRutaTipo
{
    public int IdTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<ViajeRutum> ViajeRuta { get; set; } = new List<ViajeRutum>();
}
