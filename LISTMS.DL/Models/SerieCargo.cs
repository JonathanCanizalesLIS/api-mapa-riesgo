using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SerieCargo
{
    public int IdSerie { get; set; }

    public int IdEmpresa { get; set; }

    public string Prefijo { get; set; } = null!;

    public int Consecutivo { get; set; }

    public string Formato { get; set; } = null!;

    public int IdControla { get; set; }

    public string Estatus { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int TipoFactura { get; set; }

    public int PlazaEmision { get; set; }

    public int IdTipodocClickb { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual SerieControlaFolio IdControlaNavigation { get; set; } = null!;

    public virtual ICollection<NotaCargo> NotaCargos { get; set; } = new List<NotaCargo>();
}
