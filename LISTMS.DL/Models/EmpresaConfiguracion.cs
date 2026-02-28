using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EmpresaConfiguracion
{
    public int IdEmpresa { get; set; }

    public string FormatoFecha { get; set; } = null!;

    public int IdIdioma { get; set; }

    public string Region { get; set; } = null!;

    public int Moneda { get; set; }

    public int IdUndMedPeso { get; set; }

    public int IdUndMedVol { get; set; }

    public int IdUndMedDist { get; set; }

    public string ControlaFolioAnticipo { get; set; } = null!;

    public string SeparadorMiles { get; set; } = null!;

    public string SeparadorDecimales { get; set; } = null!;

    public int IdConcepto1 { get; set; }

    public int IdConcepto2 { get; set; }

    public int IdBanco { get; set; }

    public int DiasAlertaMttoUnidad { get; set; }

    public int IdConceptoLiquidacionContra { get; set; }

    public int IdConceptoIngresos { get; set; }

    public int IdEstatusUnidad { get; set; }

    public int CantidadTimbresAlerta { get; set; }

    public int? DiasAvisoPolizaAmarillo { get; set; }

    public int? DiasAvisoPolizaRojo { get; set; }

    public int? DiasAvisoSigmttoAmarillo { get; set; }

    public int? DiasAvisoSigmttoRojo { get; set; }

    public string? RestringirConceptosAnticipo { get; set; }

    public int? IdConceptoPercepcion { get; set; }

    public int? IdConceptoDeduccion { get; set; }

    public string? ClientePemex { get; set; }

    public string CalculaIsr { get; set; } = null!;

    public string DescontarHorasFe { get; set; } = null!;

    public string IntegracionPlanner { get; set; } = null!;

    public string IntegracionRoutech { get; set; } = null!;

    public string VersionIntegracionRoutech { get; set; } = null!;

    public string ClienteClickBalance { get; set; } = null!;

    public string IsFacturaVolumen { get; set; } = null!;

    public string OrdenCompraVje { get; set; } = null!;

    public string EmpresaPermisionario { get; set; } = null!;

    public string IntegracionPortalEmbarcador { get; set; } = null!;

    public string SincronizacionPortalEmbarcador { get; set; } = null!;

    public string VersionCfdi { get; set; } = null!;

    public string IsEditIvaRet { get; set; } = null!;

    public string RendXViaje { get; set; } = null!;

    public string ColConceptoDescTesoreria { get; set; } = null!;

    public string IntegracionBfiskur { get; set; } = null!;

    public string ProdUnidadIngValFiscal { get; set; } = null!;

    public string VersionComplementoCp { get; set; } = null!;

    public bool LitrosAutorizados { get; set; }

    public bool EstatusViajeCustom { get; set; }

    public string SincronizacionTaller { get; set; } = null!;

    public string ImpuestoLocal { get; set; } = null!;

    public int GuiaViaje { get; set; }

    public int ImportMasCal { get; set; }

    public int FleteLiquidacion { get; set; }

    public int ViajeProgramado { get; set; }

    public bool AdendaPostTimbrado { get; set; }

    public int SueldoViaje { get; set; }

    public string HabilitarIa { get; set; } = null!;

    public int UtilidadViaje { get; set; }

    public decimal LimiteConsumoIa { get; set; }

    public int ValidacionesViaje { get; set; }

    public int Contenedor { get; set; }

    public virtual Banco IdBancoNavigation { get; set; } = null!;

    public virtual BancoConcepto IdConcepto1Navigation { get; set; } = null!;

    public virtual BancoConcepto IdConcepto2Navigation { get; set; } = null!;

    public virtual BancoConcepto IdConceptoIngresosNavigation { get; set; } = null!;

    public virtual LiquidacionConcepto IdConceptoLiquidacionContraNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual UnidadSeguimientoEstatus IdEstatusUnidadNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUndMedDistNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUndMedPesoNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUndMedVolNavigation { get; set; } = null!;

    public virtual Monedum MonedaNavigation { get; set; } = null!;
}
