using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdEmbalaje { get; set; }

    public int IdUnidadMedidaPeso { get; set; }

    public decimal Peso { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string MaterialPeligroso { get; set; } = null!;

    public int IdClaveMaterialPeligroso { get; set; }

    public int IdClaveprodservCp { get; set; }

    public decimal ValorMercancia { get; set; }

    public int IdTipoembalajeMp { get; set; }

    public int IdFraccionArancelaria { get; set; }

    public int IdClaveUnidad { get; set; }

    public int IdTipoMateria { get; set; }

    public string DescripcionTipoMateria { get; set; } = null!;

    public int IdUnidadembalaje { get; set; }

    public int IdTipoembalaje { get; set; }

    public virtual ICollection<ConvenioProducto> ConvenioProductos { get; set; } = new List<ConvenioProducto>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<GuiaProducto> GuiaProductos { get; set; } = new List<GuiaProducto>();

    public virtual Embalaje IdEmbalajeNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
