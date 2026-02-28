using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Pai
{
    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }

    public string Region { get; set; } = null!;

    public int IdUnidadPeso { get; set; }

    public int IdUnidadVolumen { get; set; }

    public int IdUnidadDistancia { get; set; }

    public string Clave { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdEmpresaModelo { get; set; }

    public string ClavePeru { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadDistanciaNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadPesoNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadVolumenNavigation { get; set; } = null!;

    public virtual ICollection<InterfazProveedoresGp> InterfazProveedoresGps { get; set; } = new List<InterfazProveedoresGp>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
