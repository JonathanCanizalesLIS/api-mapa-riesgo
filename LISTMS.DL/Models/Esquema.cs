using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Esquema
{
    public int IdEsquema { get; set; }

    public string Nombre { get; set; } = null!;

    public int Tope { get; set; }

    public int IdAnticipo { get; set; }

    public int IdVale { get; set; }

    public int IdGuia { get; set; }

    public int IdViaje { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdCredito { get; set; }

    public int IdCargo { get; set; }

    public int IdRegistroie { get; set; }

    public int IdFacturacion { get; set; }

    public int IdControlpago { get; set; }

    public int IdSolicitud { get; set; }

    public int IdRelacion { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
