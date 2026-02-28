using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Personal
{
    public int IdPersonal { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido1 { get; set; } = null!;

    public string Apellido2 { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public int IdEstatus { get; set; }

    public string Telefono { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public DateTime? FechaNacimiento { get; set; }

    public DateTime? FechaContratacion { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdProveedor { get; set; }

    public string Imss { get; set; } = null!;

    public DateTime? FechaVencContrato { get; set; }

    public int IdRegimen { get; set; }

    public int IdJornada { get; set; }

    public int IdPeriodicidad { get; set; }

    public string ClaveinterbancariaSat { get; set; } = null!;

    public string? Curp { get; set; }

    public string Rfc { get; set; } = null!;

    public int IdTipoContrato { get; set; }

    public int IdTipoEmpleado { get; set; }

    public string Cuentabancaria { get; set; } = null!;

    public string RfcLabora { get; set; } = null!;

    public int IdBancosat { get; set; }

    public decimal Salariodiariointegrado { get; set; }

    public bool Sindicalizado { get; set; }

    public string Imei { get; set; } = null!;

    public string UsuarioRoutech { get; set; } = null!;

    public string PasswordRoutech { get; set; } = null!;

    public int OperadorExterno { get; set; }

    public int LineaUnidadPersonal { get; set; }

    public string NumEmpleado { get; set; } = null!;

    public string Departamento { get; set; } = null!;

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

    public string TipoPersona { get; set; } = null!;

    public string? RegimenFiscal { get; set; }

    public string? Correo { get; set; }

    public int IdEmpleadoClickb { get; set; }

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<ConceptosContable> ConceptosContableIdOperadorNavigations { get; set; } = new List<ConceptosContable>();

    public virtual ICollection<ConceptosContable> ConceptosContableIdPersonalNavigations { get; set; } = new List<ConceptosContable>();

    public virtual BancoBancosat IdBancosatNavigation { get; set; } = null!;

    public virtual PersonalCategorium IdCategoriaNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual PersonalEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual PersonalTipoContrato IdTipoContratoNavigation { get; set; } = null!;

    public virtual PersonalTipoEmpleado IdTipoEmpleadoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();

    public virtual PersonalOperador? PersonalOperador { get; set; }

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
