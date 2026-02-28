using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AlarmaFrecuencium
{
    public int IdFrecuencia { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AlarmaFrecuenciaIdioma> AlarmaFrecuenciaIdiomas { get; set; } = new List<AlarmaFrecuenciaIdioma>();

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();
}
