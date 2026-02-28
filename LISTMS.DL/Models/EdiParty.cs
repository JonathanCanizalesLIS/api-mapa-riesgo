using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiParty
{
    public int IdEdiParty { get; set; }

    public int IdEdiShipmentStatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string EntityIdentifierCode { get; set; } = null!;

    public string IdentificationCodeQualifier { get; set; } = null!;

    public string IdentificationCode { get; set; } = null!;

    public string? Address { get; set; }

    public string? Address1 { get; set; }

    public string? CityName { get; set; }

    public string? StateProvinceCode { get; set; }

    public string? PostalCode { get; set; }

    public string? CountryCode { get; set; }

    public string? CodigoFecha { get; set; }

    public DateTime? Fecha { get; set; }

    public string? TimeQualifier { get; set; }

    public virtual EdiShipmentStatus IdEdiShipmentStatusNavigation { get; set; } = null!;
}
