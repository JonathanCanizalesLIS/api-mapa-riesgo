using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Viaje
{
    public int IdViaje { get; set; }

    public int IdEmpresa { get; set; }

    public int NoViaje { get; set; }

    public DateTime Fecha { get; set; }

    public int IdEstatus { get; set; }

    public decimal KmsViaje { get; set; }

    public int IdRemolque1 { get; set; }

    public int IdRemolque2 { get; set; }

    public int IdUnidad { get; set; }

    public int IdDolly { get; set; }

    public int IdPlazaOrigen { get; set; }

    public int IdPlazaDestino { get; set; }

    public int IdOperador { get; set; }

    public int Liberado { get; set; }

    public int IdTipo { get; set; }

    public int IdSucursal { get; set; }

    public DateTime? FechaLiberado { get; set; }

    public DateTime? FechaInicioViaje { get; set; }

    public DateTime? FechaFinViaje { get; set; }

    public DateTime? FechaCancelado { get; set; }

    public DateTime? FechaCita { get; set; }

    public string? Instrucciones { get; set; }

    public int IdIngreso { get; set; }

    public int IdRuta { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int KmsCompensacion { get; set; }

    public int KmsCargado { get; set; }

    public int KmsVacio { get; set; }

    public decimal RendEsp { get; set; }

    public decimal Combustible { get; set; }

    public decimal RendViaje { get; set; }

    public int IdLiquidacion { get; set; }

    public decimal SueldoOperador { get; set; }

    public int ViajeVacio { get; set; }

    public int ViajeProgramado { get; set; }

    public string Correlativo { get; set; } = null!;

    public string SegundoOperador { get; set; } = null!;

    public int OdometroInicial { get; set; }

    public int OdometroFinal { get; set; }

    public int IdOrdenCompra { get; set; }

    public int IdPermisionario { get; set; }

    public int IdLiquidacionPermisionario { get; set; }

    public int IdConfigAutotransporte { get; set; }

    public int IdTipopermisoStc { get; set; }

    public string NumPermisoStc { get; set; } = null!;

    public decimal PesoBrutoVehicular { get; set; }

    public decimal LitrosAutorizados { get; set; }

    public int IdEstatusViajeCustom { get; set; }

    public int IdSegundoOperador { get; set; }

    public decimal? VolumenFinal { get; set; }

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<EdiLoadTender> EdiLoadTenders { get; set; } = new List<EdiLoadTender>();

    public virtual ICollection<EdiShipmentStatus> EdiShipmentStatuses { get; set; } = new List<EdiShipmentStatus>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual Unidad IdDollyNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ViajeEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Liquidacion IdLiquidacionNavigation { get; set; } = null!;

    public virtual LiquidacionPermisionario IdLiquidacionPermisionarioNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Personal IdOperadorNavigation { get; set; } = null!;

    public virtual UnidadLinea IdPermisionarioNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaDestinoNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaOrigenNavigation { get; set; } = null!;

    public virtual Unidad IdRemolque1Navigation { get; set; } = null!;

    public virtual Unidad IdRemolque2Navigation { get; set; } = null!;

    public virtual ViajeRutum IdRutaNavigation { get; set; } = null!;

    public virtual ViajeTipo IdTipoNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionGuium> LiquidacionGuia { get; set; } = new List<LiquidacionGuium>();

    public virtual ICollection<LiquidacionPermisionarioGuium> LiquidacionPermisionarioGuia { get; set; } = new List<LiquidacionPermisionarioGuium>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientos { get; set; } = new List<UnidadSeguimiento>();

    public virtual ICollection<ViajeProgramado> ViajeProgramados { get; set; } = new List<ViajeProgramado>();

    public virtual ViajeRutaRoutech? ViajeRutaRoutech { get; set; }

    public virtual ICollection<ViajeSeguimientoEstatus> ViajeSeguimientoEstatuses { get; set; } = new List<ViajeSeguimientoEstatus>();
}
