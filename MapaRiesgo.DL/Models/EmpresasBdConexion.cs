using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class EmpresasBdConexion
{
    public int IdConexion { get; set; }

    public int IdSistemaOrigen { get; set; }

    public int IdEmpresa { get; set; }

    public string ServerBd { get; set; } = null!;

    public string NameBd { get; set; } = null!;

    public string UsuarioBd { get; set; } = null!;

    public string PasswordBd { get; set; } = null!;

    public string? Estatus { get; set; }
}
