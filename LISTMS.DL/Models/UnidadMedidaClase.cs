using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMedidaClase
{
    public int IdClase { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<UnidadMedidum> UnidadMedida { get; set; } = new List<UnidadMedidum>();
}
