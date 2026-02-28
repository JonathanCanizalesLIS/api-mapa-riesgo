using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosPromotore
{
    public string? Name { get; set; }

    public string? Correo { get; set; }

    public string? Password { get; set; }

    public string? Slug { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? Activo { get; set; }

    public int Id { get; set; }

    public int? PromotorLis { get; set; }

    public string? RazonSocial { get; set; }

    public int? Banco { get; set; }

    public string? CuentaBancaria { get; set; }

    public string? ClabeInterbancaria { get; set; }

    public int? FormaPago { get; set; }

    public virtual ICollection<PagosPago> PagosPagos { get; set; } = new List<PagosPago>();

    public virtual ICollection<PagosServicioscontratado> PagosServicioscontratados { get; set; } = new List<PagosServicioscontratado>();
}
