using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadTipoRol
{
    public int IdRol { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<UnidadSeguimientoEstatus> UnidadSeguimientoEstatuses { get; set; } = new List<UnidadSeguimientoEstatus>();

    public virtual ICollection<UnidadTipoRolIdioma> UnidadTipoRolIdiomas { get; set; } = new List<UnidadTipoRolIdioma>();

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();
}
