using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Unidad
{
    public int IdUnidad { get; set; }

    public string? NumUnidad { get; set; }

    public int IdEmpresa { get; set; }

    public int IdLinea { get; set; }

    public int IdMarca { get; set; }

    public int IdTipo { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Placas { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public int IdRol { get; set; }

    public int NoEjes { get; set; }

    public string Estatus { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public DateTime FechaSigMtto { get; set; }

    public decimal RendimientoCombustible { get; set; }

    public string? Seguro { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Modelo { get; set; }

    public string Arrendamiento { get; set; } = null!;

    public int IdProveedorGps { get; set; }

    public string Antena { get; set; } = null!;

    public string Ultimaposicion { get; set; } = null!;

    public decimal Lat { get; set; }

    public decimal Lon { get; set; }

    public int OdometroActual { get; set; }

    public string MotivoReinicioOdometro { get; set; } = null!;

    public int IdOperador { get; set; }

    public string DireccionGps { get; set; } = null!;

    public DateTime? FechaGps { get; set; }

    public int IdReinicioOdometro { get; set; }

    public DateTime? FechaReinicioOdometro { get; set; }

    public string NumPolizaSeg { get; set; } = null!;

    public int IdSubtiporem { get; set; }

    public int IdArrendatario { get; set; }

    public string NumPermisoSct { get; set; } = null!;

    public int IdParteTransporte { get; set; }

    public DateTime? VerFisicaMecanica { get; set; }

    public DateTime? VerEmisionContaminante { get; set; }

    public decimal PesoBrutoVehicular { get; set; }

    public string TarjetaCirculacion { get; set; } = null!;

    public int IdCentroCostoClickb { get; set; }

    public int Americana { get; set; }

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual UnidadLinea IdLineaNavigation { get; set; } = null!;

    public virtual UnidadMarca IdMarcaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Usuario IdReinicioOdometroNavigation { get; set; } = null!;

    public virtual UnidadTipoRol IdRolNavigation { get; set; } = null!;

    public virtual UnidadTipo IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();

    public virtual ICollection<MttoUnidad> MttoUnidads { get; set; } = new List<MttoUnidad>();

    public virtual ICollection<UnidadAsignacion> UnidadAsignacions { get; set; } = new List<UnidadAsignacion>();

    public virtual ICollection<UnidadFianza> UnidadFianzas { get; set; } = new List<UnidadFianza>();

    public virtual UnidadMotriz? UnidadMotriz { get; set; }

    public virtual UnidadMtto? UnidadMtto { get; set; }

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientos { get; set; } = new List<UnidadSeguimiento>();

    public virtual ICollection<Viaje> ViajeIdDollyNavigations { get; set; } = new List<Viaje>();

    public virtual ICollection<Viaje> ViajeIdRemolque1Navigations { get; set; } = new List<Viaje>();

    public virtual ICollection<Viaje> ViajeIdRemolque2Navigations { get; set; } = new List<Viaje>();

    public virtual ICollection<Viaje> ViajeIdUnidadNavigations { get; set; } = new List<Viaje>();
}
