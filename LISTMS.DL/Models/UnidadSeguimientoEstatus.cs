using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadSeguimientoEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaModifico { get; set; }

    public int IdEmpresa { get; set; }

    public int IdModifico { get; set; }

    public int IdIngreso { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdRol { get; set; }

    public int IdEstatusViaje { get; set; }

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracions { get; set; } = new List<EmpresaConfiguracion>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ViajeEstatus IdEstatusViajeNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual UnidadTipoRol IdRolNavigation { get; set; } = null!;

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientos { get; set; } = new List<UnidadSeguimiento>();
}
