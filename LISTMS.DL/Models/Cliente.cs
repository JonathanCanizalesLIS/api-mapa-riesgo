using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NumCliente { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string Calle { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Delegacion { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string NumeroInterior { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdRol { get; set; }

    public int IdPlaza { get; set; }

    public int IdMetodoPago { get; set; }

    public string NoCuenta { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public int IdFormaPago { get; set; }

    public int IdUsoCfdi { get; set; }

    public string Numregidtrib { get; set; } = null!;

    public int TipoContribuyente { get; set; }

    public string Correo { get; set; } = null!;

    public string IsAseguradora { get; set; } = null!;

    public string IdClienteClickb { get; set; } = null!;

    public string IdDireccionClickb { get; set; } = null!;

    public string OrigenIdSat { get; set; } = null!;

    public string DestinoIdSat { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string? TipoPersona { get; set; }

    public string? RegimenFiscal { get; set; }

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ClienteCobranza? ClienteCobranza { get; set; }

    public virtual ICollection<ClienteContacto> ClienteContactos { get; set; } = new List<ClienteContacto>();

    public virtual ICollection<ClienteRecEnt> ClienteRecEnts { get; set; } = new List<ClienteRecEnt>();

    public virtual ICollection<ConceptosContable> ConceptosContables { get; set; } = new List<ConceptosContable>();

    public virtual ICollection<ConvenioEvidencium> ConvenioEvidencia { get; set; } = new List<ConvenioEvidencium>();

    public virtual ICollection<Convenio> ConvenioIdClienteNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Convenio> ConvenioIdDestinatarioNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Convenio> ConvenioIdRemitenteNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<CuentasBancariasPeru> CuentasBancariasPerus { get; set; } = new List<CuentasBancariasPeru>();

    public virtual ICollection<EdiUsuario> EdiUsuarios { get; set; } = new List<EdiUsuario>();

    public virtual ICollection<ElectronicoAdendaCliente> ElectronicoAdendaClientes { get; set; } = new List<ElectronicoAdendaCliente>();

    public virtual ICollection<Electronico> Electronicos { get; set; } = new List<Electronico>();

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobros { get; set; } = new List<FacturaRelacioncobro>();

    public virtual ICollection<Guium> GuiumIdClienteNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdDestinatarioNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdRemitenteNavigations { get; set; } = new List<Guium>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual MetodoPago IdFormaPagoNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual ClienteMetodoPago IdMetodoPagoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaNavigation { get; set; } = null!;

    public virtual ClienteTipoRol IdRolNavigation { get; set; } = null!;

    public virtual UsoCfdi IdUsoCfdiNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientos { get; set; } = new List<UnidadSeguimiento>();

    public virtual ICollection<ViajeProgramado> ViajeProgramados { get; set; } = new List<ViajeProgramado>();

    public virtual ICollection<Proveedor> IdProveedors { get; set; } = new List<Proveedor>();
}
