using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConsultaVistum
{
    public int IdVista { get; set; }

    public int IdConsulta { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Dselect { get; set; } = null!;

    public string Dfrom { get; set; } = null!;

    public string Dwhere { get; set; } = null!;

    public string Dorderby { get; set; } = null!;

    public int Publica { get; set; }

    public int IdEmpresa { get; set; }

    public int VistaDefault { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Cte { get; set; } = null!;

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();

    public virtual ICollection<ConsultaVistaDetalle> ConsultaVistaDetalles { get; set; } = new List<ConsultaVistaDetalle>();

    public virtual Consultum IdConsultaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
