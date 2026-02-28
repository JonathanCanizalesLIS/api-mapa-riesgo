using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Liquidacion
{
    public int IdLiquidacion { get; set; }

    public int IdEmpresa { get; set; }

    public int IdPersonal { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdModifico { get; set; }

    public decimal MontoAnticipo { get; set; }

    public decimal MontoPercepcion { get; set; }

    public decimal MontoGasto { get; set; }

    public decimal MontoTotal { get; set; }

    public int IdUnidadMotriz { get; set; }

    public string NumLiquidacion { get; set; } = null!;

    public int IdEstatus { get; set; }

    public decimal RendReseteo { get; set; }

    public DateTime Fecha { get; set; }

    public int IdSolicitud { get; set; }

    public string ReferenciaPago { get; set; } = null!;

    public DateTime? FechaPago { get; set; }

    public int IdUsuarioPago { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public int IdUsuarioCancelo { get; set; }

    public int IdTipoAdeudo { get; set; }

    public int ReferenciaAdeudo { get; set; }

    public int IdMoneda { get; set; }

    public int MotorElectrico { get; set; }

    public int IdSucursal { get; set; }

    public decimal TotalKilometros { get; set; }

    public int TotalViajes { get; set; }

    public int? IdConvenioLiquidacion { get; set; }

    public int IdTiponomina { get; set; }

    public DateTime FechaInicial { get; set; }

    public DateTime FechaFinal { get; set; }

    public int Numdiaspagados { get; set; }

    public string ClaveConfirmacion { get; set; } = null!;

    public decimal Imss { get; set; }

    public decimal Isr { get; set; }

    public decimal Infonavit { get; set; }

    public decimal OtrasDeducciones { get; set; }

    public decimal OtrasPercepciones { get; set; }

    public int OdometroInicial { get; set; }

    public int OdometroFinal { get; set; }

    public int ActualizaUnidad { get; set; }

    public string Observaciones { get; set; } = null!;

    public decimal SubsidioEmpleo { get; set; }

    public int? IdTipoSueldo { get; set; }

    public int? IdTipoViaje { get; set; }

    public int IdTipoComprobacionGastoClickb { get; set; }

    public int IdAsociadoDeudorClickb { get; set; }

    public int IdComprobacionGastoCb { get; set; }

    public string FolioComprobacionGastoCb { get; set; } = null!;

    public decimal Rendimiento { get; set; }

    public virtual ICollection<ElectronicoLiquidacion> ElectronicoLiquidacions { get; set; } = new List<ElectronicoLiquidacion>();

    public virtual ConvenioLiquidacion? IdConvenioLiquidacionNavigation { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual LiquidacionEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Personal IdPersonalNavigation { get; set; } = null!;

    public virtual BancoSolicitud IdSolicitudNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual LiquidacionTipoAdeudo IdTipoAdeudoNavigation { get; set; } = null!;

    public virtual NominaTipo IdTiponominaNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadMotrizNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioCanceloNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioPagoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionGasto> LiquidacionGastos { get; set; } = new List<LiquidacionGasto>();

    public virtual ICollection<LiquidacionGuium> LiquidacionGuia { get; set; } = new List<LiquidacionGuium>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
