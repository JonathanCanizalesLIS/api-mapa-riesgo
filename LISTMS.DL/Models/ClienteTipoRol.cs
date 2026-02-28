using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteTipoRol
{
    public int IdRol { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ClienteTipoRolIdioma> ClienteTipoRolIdiomas { get; set; } = new List<ClienteTipoRolIdioma>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
