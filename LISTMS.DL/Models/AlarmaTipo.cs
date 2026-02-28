using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AlarmaTipo
{
    public int IdTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Estatus { get; set; }

    public virtual ICollection<AlarmaTipoIdioma> AlarmaTipoIdiomas { get; set; } = new List<AlarmaTipoIdioma>();

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();

    public virtual EstatusCatalogo? EstatusNavigation { get; set; }
}
