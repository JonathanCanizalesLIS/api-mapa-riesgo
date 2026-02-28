using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Anticipo
{
    public int IdAnticipo { get; set; }

    public string NumAnticipo { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdPersonal { get; set; }

    public decimal MontoAnticipo { get; set; }

    public int IdEstatus { get; set; }

    public DateTime FechaAnticipo { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdViaje { get; set; }

    public int IdMoneda { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdSolicitud { get; set; }

    public int IdUsuarioPago { get; set; }

    public DateTime? FechaPago { get; set; }

    public string ReferenciaPago { get; set; } = null!;

    public int? IdConvenio { get; set; }

    public string AnticipoEnviadoRoutech { get; set; } = null!;

    public int IdTipoGastoClickb { get; set; }

    public int IdAsociadoDeudorClickb { get; set; }

    public int IdFormaPagoClickb { get; set; }

    public int IdDocumentoGastoClickb { get; set; }

    public string FolioDocumentoGastoClickb { get; set; } = null!;

    public int IdCentroCostoClickb { get; set; }

    public virtual ICollection<AnticipoDesglose> AnticipoDesgloses { get; set; } = new List<AnticipoDesglose>();

    public virtual ConvenioAnticipo? IdConvenioNavigation { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual AnticipoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual Personal IdPersonalNavigation { get; set; } = null!;

    public virtual BancoSolicitud IdSolicitudNavigation { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
