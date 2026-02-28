using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaEvidenciaFoto
{
    public int IdGuia { get; set; }

    public int IdEvidencia { get; set; }

    public int Consecutivo { get; set; }

    public string Name { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Foto { get; set; } = null!;

    public int IdFoto { get; set; }

    public DateTime Fecha { get; set; }

    public int IdArchivo { get; set; }

    public virtual GuiaEvidencium Id { get; set; } = null!;

    public virtual Archivo IdArchivoNavigation { get; set; } = null!;
}
