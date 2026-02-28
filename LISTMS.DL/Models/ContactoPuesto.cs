using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ContactoPuesto
{
    public int IdPuesto { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Estatus { get; set; } = null!;

    public int? IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual ICollection<Alarma> Alarmas { get; set; } = new List<Alarma>();

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa? IdEmpresaNavigation { get; set; }

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
