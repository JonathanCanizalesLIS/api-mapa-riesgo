using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Plaza
{
    public int IdPlaza { get; set; }

    public string NombrePlaza { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public decimal Lat { get; set; }

    public decimal Lon { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Convenio> ConvenioIdPlazaDestinoNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Convenio> ConvenioIdPlazaOrigenNavigations { get; set; } = new List<Convenio>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<Guium> GuiumIdPlazaDestinoNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdPlazaEmisionNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdPlazaOrigenNavigations { get; set; } = new List<Guium>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<SerieGuium> SerieGuia { get; set; } = new List<SerieGuium>();

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientos { get; set; } = new List<UnidadSeguimiento>();

    public virtual ICollection<Viaje> ViajeIdPlazaDestinoNavigations { get; set; } = new List<Viaje>();

    public virtual ICollection<Viaje> ViajeIdPlazaOrigenNavigations { get; set; } = new List<Viaje>();

    public virtual ICollection<ViajeProgramado> ViajeProgramadoIdDestinoNavigations { get; set; } = new List<ViajeProgramado>();

    public virtual ICollection<ViajeProgramado> ViajeProgramadoIdOrigenNavigations { get; set; } = new List<ViajeProgramado>();

    public virtual ICollection<ViajeRutum> ViajeRuta { get; set; } = new List<ViajeRutum>();
}
