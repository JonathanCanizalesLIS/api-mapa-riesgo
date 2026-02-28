using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Alarma
{
    public int IdAlarma { get; set; }

    public int IdTipo { get; set; }

    public int IdFrecuencia { get; set; }

    public int IdProveedor { get; set; }

    public int IdPuesto { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime FechaSiguiente { get; set; }

    public int RepetirCada { get; set; }

    public string Estatus { get; set; } = null!;

    public int Filtro1 { get; set; }

    public string Filtro2 { get; set; } = null!;

    public string Filtro3 { get; set; } = null!;

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual AlarmaLog? AlarmaLog { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ConsultaVistum Filtro1Navigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual AlarmaFrecuencium IdFrecuenciaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual ContactoPuesto IdPuestoNavigation { get; set; } = null!;

    public virtual AlarmaTipo IdTipoNavigation { get; set; } = null!;
}
