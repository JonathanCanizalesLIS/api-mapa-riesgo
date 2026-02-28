using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpresa { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Estatus { get; set; }

    public bool Encripcion { get; set; }

    public int IdSistemaOrigen { get; set; }

    public virtual SistemaOrigen IdSistemaOrigenNavigation { get; set; } = null!;

    public virtual ICollection<Sesion> Sesions { get; set; } = new List<Sesion>();
}
