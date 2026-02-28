using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiLine
{
    public int IdEdiLine { get; set; }

    public string ShipmentStatusIndicatorCode { get; set; } = null!;

    public string ShipmentStatusAppointmentReasonCode { get; set; } = null!;

    public string ShipmentAppointmentStatusCode { get; set; } = null!;

    public string ShipmentStatusAppointmentReasonCode1 { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string TimeCode { get; set; } = null!;

    public int IdEdiShipmentStatus { get; set; }

    public virtual EdiShipmentStatus IdEdiShipmentStatusNavigation { get; set; } = null!;
}
