using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadClave
{
    public int IdClave { get; set; }

    public string Clave { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int IdPais { get; set; }

    public virtual ICollection<GuiaConcepto> GuiaConceptos { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<Guium> GuiumIdClaveUnidadAutopistaNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdClaveUnidadFleteNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdClaveUnidadManiobrasNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdClaveUnidadSeguroNavigations { get; set; } = new List<Guium>();
}
