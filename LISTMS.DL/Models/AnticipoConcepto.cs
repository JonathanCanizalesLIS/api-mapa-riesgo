using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AnticipoConcepto
{
    public int IdConcepto { get; set; }

    public int IdEmpresa { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual ICollection<AnticipoDesglose> AnticipoDesgloses { get; set; } = new List<AnticipoDesglose>();

    public virtual ICollection<ConvenioAnticipoDesglose> ConvenioAnticipoDesgloses { get; set; } = new List<ConvenioAnticipoDesglose>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
