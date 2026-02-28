using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FacturaXml
{
    public int Id { get; set; }

    public int IdFactura { get; set; }

    public string NumFactura { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaConsumo { get; set; }

    public string KeyProveedor { get; set; } = null!;

    public string Xmltimsa { get; set; } = null!;

    public int Procesado { get; set; }

    public int Enviado { get; set; }

    public int CodigoError { get; set; }

    public string? MensajeError { get; set; }
}
