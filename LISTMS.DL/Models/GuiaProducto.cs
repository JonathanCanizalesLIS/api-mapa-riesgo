using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaProducto
{
    public int IdGuia { get; set; }

    public int Consecutivo { get; set; }

    public int IdProducto { get; set; }

    public decimal Cantidad { get; set; }

    public int IdEmbalaje { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Peso { get; set; }

    public int IdUnidadMedidaPeso { get; set; }

    public decimal PesoBase { get; set; }

    public decimal Volumen { get; set; }

    public int IdUnidadMedidaVolumen { get; set; }

    public decimal VolumenBase { get; set; }

    public int IdUnidadMedidaPesoBase { get; set; }

    public int IdUnidadMedidaVolumenBase { get; set; }

    public int IdRemitenteProd { get; set; }

    public int IdOrigen { get; set; }

    public int IdDestinatarioProd { get; set; }

    public int IdDestino { get; set; }

    public decimal PesoKg { get; set; }

    public decimal ValorMercancia { get; set; }

    public int IdFraccionArancelaria { get; set; }

    public string UuidCemercioExt { get; set; } = null!;

    public decimal KmRecorridos { get; set; }

    public string Pedimento { get; set; } = null!;

    public int IdDocumentoAduanero { get; set; }

    public string FolioDocumentoAduanero { get; set; } = null!;

    public string RfcImportador { get; set; } = null!;

    public int IdUnidadClave { get; set; }

    public int? IdMoneda { get; set; }

    public virtual Embalaje IdEmbalajeNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaPesoBaseNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaPesoNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaVolumenBaseNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaVolumenNavigation { get; set; } = null!;
}
