using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ProveedorRol
{
    public int IdRol { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ProveedorRolIdioma> ProveedorRolIdiomas { get; set; } = new List<ProveedorRolIdioma>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
