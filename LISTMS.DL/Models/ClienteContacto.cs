using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteContacto
{
    public int IdContacto { get; set; }

    public int IdCliente { get; set; }

    public string NombreContacto { get; set; } = null!;

    public string Apellido1Contacto { get; set; } = null!;

    public string Apellido2Contacto { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public string PuestoContacto { get; set; } = null!;

    public string Email1Contacto { get; set; } = null!;

    public string Email2Contacto { get; set; } = null!;

    public string MovilContacto { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
