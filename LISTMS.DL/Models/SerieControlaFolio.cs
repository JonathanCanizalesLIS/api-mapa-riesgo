using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SerieControlaFolio
{
    public int IdControla { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SerieCargo> SerieCargos { get; set; } = new List<SerieCargo>();

    public virtual ICollection<SerieControlaFolioIdioma> SerieControlaFolioIdiomas { get; set; } = new List<SerieControlaFolioIdioma>();

    public virtual ICollection<SerieCredito> SerieCreditos { get; set; } = new List<SerieCredito>();

    public virtual ICollection<SerieGuium> SerieGuia { get; set; } = new List<SerieGuium>();
}
