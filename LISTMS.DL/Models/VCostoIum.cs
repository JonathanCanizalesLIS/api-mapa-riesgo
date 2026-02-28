using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VCostoIum
{
    public int IdFuncionIa { get; set; }

    public string? Nombre { get; set; }

    public int? IdEmpresa { get; set; }

    public long IdPeticionIa { get; set; }

    public int IdModeloIa { get; set; }

    public decimal? CostoInput { get; set; }

    public decimal? CostoCache { get; set; }

    public decimal? CostoOutput { get; set; }

    public decimal? CostoTotal { get; set; }

    public DateTime Fecha { get; set; }
}
