using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConvenioAnticipo
{
    public int IdConvenio { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public decimal MontoAnticipo { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual ICollection<Anticipo> Anticipos { get; set; } = new List<Anticipo>();

    public virtual ICollection<ConvenioAnticipoDesglose> ConvenioAnticipoDesgloses { get; set; } = new List<ConvenioAnticipoDesglose>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
