using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VEmpresasPerdido
{
    public int Id { get; set; }

    public int IdEmpresa { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Zona { get; set; }

    public string? Estado { get; set; }

    public string Pais { get; set; } = null!;

    public string? Compania { get; set; }

    public string? Nombre { get; set; }

    public string Contrato { get; set; } = null!;

    public string? Promotor { get; set; }

    public string? FechaDemo { get; set; }

    public string? Vigencia { get; set; }

    public string? FechaContratacion { get; set; }

    public int? PaqueteId { get; set; }

    public string? Paquete { get; set; }

    public string? Referencia { get; set; }

    public string ReferenciaOtro { get; set; } = null!;

    public int? UnidadesPropias { get; set; }

    public int? UnidadesOtros { get; set; }

    public int? Viajes { get; set; }

    public int? Liquidaciones { get; set; }

    public int? Guias { get; set; }

    public int? Facturas { get; set; }

    public int? Anticipos { get; set; }

    public int? MesesContratados { get; set; }

    public int? Periodo { get; set; }

    public int? Anio { get; set; }
}
