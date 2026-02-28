using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConcepto
{
    public int IdConcepto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int ReporteImpuestos { get; set; }

    public int IdIngreso { get; set; }

    public int IdConceptoPadre { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdGrupo { get; set; }

    public int IdModifico { get; set; }

    public int IdClasificacion { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdEmpresa { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public int IdTipoReferencia { get; set; }

    public string DesglosaIva { get; set; } = null!;

    public string DesglosaRetencion { get; set; } = null!;

    public int IdRetencion { get; set; }

    public virtual ICollection<BancoMovimientoDetalle> BancoMovimientoDetalles { get; set; } = new List<BancoMovimientoDetalle>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracionIdConcepto1Navigations { get; set; } = new List<EmpresaConfiguracion>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracionIdConcepto2Navigations { get; set; } = new List<EmpresaConfiguracion>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracionIdConceptoIngresosNavigations { get; set; } = new List<EmpresaConfiguracion>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual BancoConceptoGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual BancoConceptoTipoReferencium IdTipoReferenciaNavigation { get; set; } = null!;
}
