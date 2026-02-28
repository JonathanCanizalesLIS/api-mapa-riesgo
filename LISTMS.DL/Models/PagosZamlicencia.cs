using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosZamlicencia
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public string? Estatus { get; set; }

    public string? LicenciaPb { get; set; }

    public string? LicenciaNet { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
