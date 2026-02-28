using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiLoadTender
{
    public int IdEdiLoadTender { get; set; }

    public int IdEdiUsuario { get; set; }

    public string LoadTender204 { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? ReservationActionCode { get; set; }

    public string? Estatus { get; set; }

    public DateTime Fecha { get; set; }

    public string ShipmentIdentificationNumber { get; set; } = null!;

    public DateTime? FechaReservacion { get; set; }

    public int? IdViajeAsignado { get; set; }

    public virtual ICollection<EdiShipmentStatus> EdiShipmentStatuses { get; set; } = new List<EdiShipmentStatus>();

    public virtual EdiUsuario IdEdiUsuarioNavigation { get; set; } = null!;

    public virtual Viaje? IdViajeAsignadoNavigation { get; set; }
}
