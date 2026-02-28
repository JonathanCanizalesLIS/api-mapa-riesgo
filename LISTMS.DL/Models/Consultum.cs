using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Consultum
{
    public int IdConsulta { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Dfrom { get; set; } = null!;

    public string Dwhere { get; set; } = null!;

    public string Dorderby { get; set; } = null!;

    public int IdVentana { get; set; }

    public virtual ICollection<ConsultaDetalle> ConsultaDetalles { get; set; } = new List<ConsultaDetalle>();

    public virtual ICollection<ConsultaVistum> ConsultaVista { get; set; } = new List<ConsultaVistum>();

    public virtual Ventana IdVentanaNavigation { get; set; } = null!;
}
