using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaConcepto
{
    public int IdConcepto { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public string DesglosaIva { get; set; } = null!;

    public string DesglosaRetencion { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdEmbalaje { get; set; }

    public int IdClaveprodserv { get; set; }

    public int IdClaveUnidad { get; set; }

    public int IdRetencion { get; set; }

    public string IdProductoClickb { get; set; } = null!;

    public string CodigoProdClickb { get; set; } = null!;

    public string IdAlmacenClickb { get; set; } = null!;

    public int IdObjetoImpuesto { get; set; }

    public int IdIva { get; set; }

    public virtual ICollection<ConvenioOtro> ConvenioOtros { get; set; } = new List<ConvenioOtro>();

    public virtual ICollection<GuiaOtro> GuiaOtros { get; set; } = new List<GuiaOtro>();

    public virtual UnidadClave IdClaveUnidadNavigation { get; set; } = null!;

    public virtual ClaveProductoServicio IdClaveprodservNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Impuesto IdIvaNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;

    public virtual ICollection<NotaCargoDetalle> NotaCargoDetalles { get; set; } = new List<NotaCargoDetalle>();

    public virtual ICollection<NotaCreditoDetalle> NotaCreditoDetalles { get; set; } = new List<NotaCreditoDetalle>();
}
