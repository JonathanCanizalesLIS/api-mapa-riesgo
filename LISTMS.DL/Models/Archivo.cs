using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Archivo
{
    public int IdArchivo { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Tipo { get; set; }

    public long Bytes { get; set; }

    public string Ruta { get; set; } = null!;

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public string? Estatus { get; set; }

    public virtual ICollection<GuiaEvidenciaFoto> GuiaEvidenciaFotos { get; set; } = new List<GuiaEvidenciaFoto>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
