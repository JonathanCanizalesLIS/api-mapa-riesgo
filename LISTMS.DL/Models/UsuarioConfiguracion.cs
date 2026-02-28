using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UsuarioConfiguracion
{
    public int IdUsuario { get; set; }

    public string Tema { get; set; } = null!;

    public int IdSucursal { get; set; }

    public string AyudaActiva { get; set; } = null!;

    public bool? AyudaWizard { get; set; }
}
