using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Sucursal
{
    public int IdSucursal { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string IdPlazaClickb { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<ClienteCobranza> ClienteCobranzas { get; set; } = new List<ClienteCobranza>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobros { get; set; } = new List<FacturaRelacioncobro>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
