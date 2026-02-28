using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoMovimientoEstatus
{
    public string Estatus { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BancoMovimientoEstatusIdioma> BancoMovimientoEstatusIdiomas { get; set; } = new List<BancoMovimientoEstatusIdioma>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();
}
