using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Estado
{
    public int IdEstado { get; set; }

    public int IdPais { get; set; }

    public string? Nombre { get; set; }

    public string Clave { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string ClaveSat { get; set; } = null!;

    public int? IdZona { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
