using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoCertificado
{
    public int IdCertificado { get; set; }

    public int IdEmpresa { get; set; }

    public string NoCertificado { get; set; } = null!;

    public string SerieCertificado { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public DateTime FechaInicial { get; set; }

    public DateTime FechaFinal { get; set; }

    public string RutaCer { get; set; } = null!;

    public string RutaKey { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string UserBuzone { get; set; } = null!;

    public string PasswordBuzone { get; set; } = null!;

    public string FiletypeBuzone { get; set; } = null!;

    public string UserCancel { get; set; } = null!;

    public string PasswordCancel { get; set; } = null!;

    public string NumActivacion { get; set; } = null!;

    public string? UserBuzoneant { get; set; }

    public string? PasswordBuzoneant { get; set; }

    public string UserDetecno { get; set; } = null!;

    public string PasswordDetecno { get; set; } = null!;

    public virtual ICollection<Electronico> Electronicos { get; set; } = new List<Electronico>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
