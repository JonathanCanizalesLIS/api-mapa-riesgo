using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Monedum
{
    public int IdMoneda { get; set; }

    public string Nombre { get; set; } = null!;

    public string LeyendaMoneda { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Leyenda { get; set; } = null!;

    public int IdTipoMoneda { get; set; }

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<Banco> Bancos { get; set; } = new List<Banco>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<Convenio> Convenios { get; set; } = new List<Convenio>();

    public virtual ICollection<CuentasBancariasPeru> CuentasBancariasPerus { get; set; } = new List<CuentasBancariasPeru>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracions { get; set; } = new List<EmpresaConfiguracion>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<FacturaRelacioncobro> FacturaRelacioncobros { get; set; } = new List<FacturaRelacioncobro>();

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();

    public virtual ICollection<NotaCargo> NotaCargos { get; set; } = new List<NotaCargo>();

    public virtual ICollection<NotaCredito> NotaCreditos { get; set; } = new List<NotaCredito>();
}
