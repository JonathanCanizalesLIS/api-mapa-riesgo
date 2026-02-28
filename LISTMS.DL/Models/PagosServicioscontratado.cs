using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosServicioscontratado
{
    public int? EmpresaId { get; set; }

    public int? PromotorId { get; set; }

    public int? ServicioId { get; set; }

    public DateTime? FechaContratacion { get; set; }

    public int Id { get; set; }

    public int? PagoId { get; set; }

    public int? Cantidad { get; set; }

    public virtual PagosEmpresa? Empresa { get; set; }

    public virtual PagosPromotore? Promotor { get; set; }

    public virtual PagosServicio? Servicio { get; set; }
}
