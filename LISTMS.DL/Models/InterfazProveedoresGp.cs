using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class InterfazProveedoresGp
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public int ConfigurarUsuario { get; set; }

    public int ConfigurarContrasenia { get; set; }

    public int ConfigurarEmpresa { get; set; }

    public int ConfigurarFecha { get; set; }

    public int ConfigurarToken { get; set; }

    public int IdPais { get; set; }

    public string? Webservice { get; set; }

    public string? RutaImagen { get; set; }

    public virtual ICollection<EmpresaProveedoresGp> EmpresaProveedoresGps { get; set; } = new List<EmpresaProveedoresGp>();

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<UnidadPosicionesHistorial> UnidadPosicionesHistorials { get; set; } = new List<UnidadPosicionesHistorial>();
}
