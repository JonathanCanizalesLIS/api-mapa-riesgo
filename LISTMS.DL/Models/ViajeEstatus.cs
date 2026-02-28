using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<UnidadSeguimientoEstatus> UnidadSeguimientoEstatuses { get; set; } = new List<UnidadSeguimientoEstatus>();

    public virtual ICollection<ViajeEstatusIdioma> ViajeEstatusIdiomas { get; set; } = new List<ViajeEstatusIdioma>();

    public virtual ICollection<ViajeSeguimientoControl> ViajeSeguimientoControls { get; set; } = new List<ViajeSeguimientoControl>();

    public virtual ICollection<ViajeSeguimientoEstatus> ViajeSeguimientoEstatuses { get; set; } = new List<ViajeSeguimientoEstatus>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
