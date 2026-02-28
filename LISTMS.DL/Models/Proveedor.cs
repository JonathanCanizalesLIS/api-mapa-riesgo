using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Telefono2 { get; set; } = null!;

    public string Telefono3 { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string CuentaBancaria { get; set; } = null!;

    public int IdRol { get; set; }

    public string Observaciones { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int IdIva { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Estatus { get; set; } = null!;

    public string Ruc { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<ConceptosContable> ConceptosContables { get; set; } = new List<ConceptosContable>();

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual ProveedorRol IdRolNavigation { get; set; } = null!;

    public virtual ProveedorCombustible? ProveedorCombustible { get; set; }

    public virtual ICollection<Cliente> IdClientes { get; set; } = new List<Cliente>();
}
