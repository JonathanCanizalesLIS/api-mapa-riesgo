using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadLinea
{
    public int IdLinea { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Estatus { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int IdInstitucionBancaria { get; set; }

    public string CuentaBancaria { get; set; } = null!;

    public int IdIva { get; set; }

    public int IdRetencion { get; set; }

    public int DiasCredito { get; set; }

    public int IdTipoPersona { get; set; }

    public string NombreContacto { get; set; } = null!;

    public int IdProveedor { get; set; }

    public string Numregidtrib { get; set; } = null!;

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Calle { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string NumeroInterior { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracions { get; set; } = new List<PermisionarioTarifaConfiguracion>();

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
