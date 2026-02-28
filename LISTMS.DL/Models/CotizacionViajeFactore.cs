using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CotizacionViajeFactore
{
    public int IdCotizacion { get; set; }

    public int IdEmpresa { get; set; }

    public int IdTipoViaje { get; set; }

    public decimal CostoCombustible { get; set; }

    public decimal RendimientoCargado { get; set; }

    public decimal RendimientoVacio { get; set; }

    public decimal Mantenimiento { get; set; }

    public decimal OperadorVacio { get; set; }

    public decimal OperadorCargado { get; set; }

    public decimal Llantas { get; set; }

    public decimal Viaticos { get; set; }

    public decimal Arrendamiento { get; set; }

    public decimal Factor { get; set; }

    public decimal Depreciacion { get; set; }

    public decimal OtrosDia { get; set; }

    public int CostoCombustibleChk { get; set; }

    public int RendimientoCargadoChk { get; set; }

    public int RendimientoVacioChk { get; set; }

    public int MantenimientoChk { get; set; }

    public int OperadorVacioChk { get; set; }

    public int OperadorCargadoChk { get; set; }

    public int LlantasChk { get; set; }

    public int ViaticosChk { get; set; }

    public int ArrendamientoChk { get; set; }

    public int FactorChk { get; set; }

    public int DepreciacionChk { get; set; }

    public int OtrosDiaChk { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int OtrosKmChk { get; set; }

    public decimal OtrosKm { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ViajeTipo IdTipoViajeNavigation { get; set; } = null!;
}
