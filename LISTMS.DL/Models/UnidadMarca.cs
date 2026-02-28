using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMarca
{
    public int IdMarca { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();
}
