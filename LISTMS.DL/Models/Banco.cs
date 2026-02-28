using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Banco
{
    public int IdBanco { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public int IdTipo { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdModifico { get; set; }

    public string InstitucionBancaria { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdMoneda { get; set; }

    public decimal SaldoInicial { get; set; }

    public int IdUsuario { get; set; }

    public int IdBancosat { get; set; }

    public string NoCuenta { get; set; } = null!;

    public int? IdCuentaClickb { get; set; }

    public int? IdFormaPagoClickb { get; set; }

    public int IdTipoCobroClickb { get; set; }

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoPeriodo> BancoPeriodos { get; set; } = new List<BancoPeriodo>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracions { get; set; } = new List<EmpresaConfiguracion>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;
}
