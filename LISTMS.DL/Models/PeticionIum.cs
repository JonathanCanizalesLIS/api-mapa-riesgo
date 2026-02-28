using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PeticionIum
{
    public long IdPeticionIa { get; set; }

    /// <summary>
    /// Tokens de entrada
    /// </summary>
    public int? InputTokens { get; set; }

    /// <summary>
    /// Tokens en cache
    /// </summary>
    public int? CacheTokens { get; set; }

    /// <summary>
    /// Tokens de salida
    /// </summary>
    public int? OutputTokens { get; set; }

    public int? IdEmpresa { get; set; }

    public int IdFuncionIa { get; set; }

    public int IdModeloIa { get; set; }

    public DateTime Fecha { get; set; }

    public bool IsFreeTier { get; set; }

    public virtual Empresa? IdEmpresaNavigation { get; set; }

    public virtual FuncionIum IdFuncionIaNavigation { get; set; } = null!;

    public virtual ModeloIum IdModeloIaNavigation { get; set; } = null!;
}
