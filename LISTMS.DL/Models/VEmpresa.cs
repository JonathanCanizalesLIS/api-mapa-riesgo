using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VEmpresa
{
    public int Id { get; set; }

    public int? IdEmpresa { get; set; }

    public string? Compania { get; set; }

    public string? Rfc { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Dirección { get; set; }

    public string? Estado { get; set; }

    public string Pais { get; set; } = null!;

    public string? Zona { get; set; }

    public string Contrato { get; set; } = null!;

    public string? Promotor { get; set; }

    public DateTime? FechaDemo { get; set; }

    public DateTime? Vigencia { get; set; }

    public DateTime? FechaContratacion { get; set; }

    public int? PaqueteId { get; set; }

    public string? Paquete { get; set; }

    public string? Referencia { get; set; }

    public string ReferenciaOtro { get; set; } = null!;

    public int? UnidadesPropias { get; set; }

    public int? UnidadesOtros { get; set; }

    public int? Viajes { get; set; }

    public int? Anticipos { get; set; }

    public int? Vales { get; set; }

    public int? Liquidaciones { get; set; }

    public int? Guias { get; set; }

    public int? Facturas { get; set; }

    public string PorVencer { get; set; } = null!;

    public int? IdPromotor { get; set; }

    public string? Activo { get; set; }
}
