using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PersonalEstatusIdioma> PersonalEstatusIdiomas { get; set; } = new List<PersonalEstatusIdioma>();

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
