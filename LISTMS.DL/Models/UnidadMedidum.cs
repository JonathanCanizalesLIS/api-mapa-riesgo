using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMedidum
{
    public int IdUnidadMedida { get; set; }

    public int IdClase { get; set; }

    public int Esbase { get; set; }

    public decimal FactorConversionabase { get; set; }

    public int IdUnidadBase { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual ICollection<CombustibleVale> CombustibleValeIdUnidadMedidaBaseNavigations { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<CombustibleVale> CombustibleValeIdUnidadMedidaNavigations { get; set; } = new List<CombustibleVale>();

    public virtual ICollection<ConvenioProducto> ConvenioProductoIdUnidadMedidaPesoBaseNavigations { get; set; } = new List<ConvenioProducto>();

    public virtual ICollection<ConvenioProducto> ConvenioProductoIdUnidadMedidaPesoNavigations { get; set; } = new List<ConvenioProducto>();

    public virtual ICollection<ConvenioProducto> ConvenioProductoIdUnidadMedidaVolumenBaseNavigations { get; set; } = new List<ConvenioProducto>();

    public virtual ICollection<ConvenioProducto> ConvenioProductoIdUnidadMedidaVolumenNavigations { get; set; } = new List<ConvenioProducto>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracionIdUndMedDistNavigations { get; set; } = new List<EmpresaConfiguracion>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracionIdUndMedPesoNavigations { get; set; } = new List<EmpresaConfiguracion>();

    public virtual ICollection<EmpresaConfiguracion> EmpresaConfiguracionIdUndMedVolNavigations { get; set; } = new List<EmpresaConfiguracion>();

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual ICollection<GuiaProducto> GuiaProductoIdUnidadMedidaPesoBaseNavigations { get; set; } = new List<GuiaProducto>();

    public virtual ICollection<GuiaProducto> GuiaProductoIdUnidadMedidaPesoNavigations { get; set; } = new List<GuiaProducto>();

    public virtual ICollection<GuiaProducto> GuiaProductoIdUnidadMedidaVolumenBaseNavigations { get; set; } = new List<GuiaProducto>();

    public virtual ICollection<GuiaProducto> GuiaProductoIdUnidadMedidaVolumenNavigations { get; set; } = new List<GuiaProducto>();

    public virtual UnidadMedidaClase IdClaseNavigation { get; set; } = null!;

    public virtual ICollection<Pai> PaiIdUnidadDistanciaNavigations { get; set; } = new List<Pai>();

    public virtual ICollection<Pai> PaiIdUnidadPesoNavigations { get; set; } = new List<Pai>();

    public virtual ICollection<Pai> PaiIdUnidadVolumenNavigations { get; set; } = new List<Pai>();

    public virtual ICollection<UnidadMotriz> UnidadMotrizUnidadMedidaTanque1Navigations { get; set; } = new List<UnidadMotriz>();

    public virtual ICollection<UnidadMotriz> UnidadMotrizUnidadMedidaTanque2Navigations { get; set; } = new List<UnidadMotriz>();
}
