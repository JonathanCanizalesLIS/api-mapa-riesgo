using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalJornadum
{
    public int IdJornada { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string ClaveSat { get; set; } = null!;
}
