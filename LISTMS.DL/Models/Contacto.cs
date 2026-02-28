using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Contacto
{
    public int IdContacto { get; set; }

    public string? Nombre { get; set; }

    public string Apellido1 { get; set; } = null!;

    public string Apellido2 { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string Telefono1 { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono2 { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int IdProveedor { get; set; }

    public int IdEmpresa { get; set; }

    public int IdPuesto { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual ContactoPuesto IdPuestoNavigation { get; set; } = null!;
}
