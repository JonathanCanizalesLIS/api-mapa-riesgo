using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaTituloAdicional
{
    public int IdAdicional { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<GuiaAdicional> GuiaAdicionals { get; set; } = new List<GuiaAdicional>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
