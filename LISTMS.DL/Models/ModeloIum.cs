using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ModeloIum
{
    public int IdModeloIa { get; set; }

    public string? Nombre { get; set; }

    /// <summary>
    /// Costo en USD por millon de tokens
    /// </summary>
    public decimal? CostoInput { get; set; }

    /// <summary>
    /// Costo en USD por millon de tokens
    /// </summary>
    public decimal? CostoCache { get; set; }

    /// <summary>
    /// Costo en USD por millon de tokens
    /// </summary>
    public decimal? CostoOutput { get; set; }

    public string? Modo { get; set; }

    public virtual ICollection<FuncionIum> FuncionIa { get; set; } = new List<FuncionIum>();

    public virtual ICollection<PeticionIum> PeticionIa { get; set; } = new List<PeticionIum>();
}
