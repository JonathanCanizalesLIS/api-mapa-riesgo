using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClaveProductoServicio
{
    public int IdClaveprodserv { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<GuiaConcepto> GuiaConceptos { get; set; } = new List<GuiaConcepto>();

    public virtual ICollection<Guium> GuiumIdClaveprodservManiobrasNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdClaveprodservSeguroNavigations { get; set; } = new List<Guium>();
}
