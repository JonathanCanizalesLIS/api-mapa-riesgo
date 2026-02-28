using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Electronico
{
    public int IdDocumento { get; set; }

    public int IdEmpresa { get; set; }

    public int TipoDoc { get; set; }

    public int IdCliente { get; set; }

    public string RfcEmisor { get; set; } = null!;

    public string RfcReceptor { get; set; } = null!;

    public int IdCertificado { get; set; }

    public string Prefijo { get; set; } = null!;

    public int Folio { get; set; }

    public decimal Subtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public string TipoComprobante { get; set; } = null!;

    public int EstadoComprobante { get; set; }

    public string CadenaOriginal1 { get; set; } = null!;

    public string CadenaOriginal2 { get; set; } = null!;

    public string CadenaOriginal3 { get; set; } = null!;

    public string SelloContribuyente { get; set; } = null!;

    public string SelloProveedor { get; set; } = null!;

    public int IdTimbre { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public string CadenaSat1 { get; set; } = null!;

    public string CadenaSat2 { get; set; } = null!;

    public string ValorQr { get; set; } = null!;

    public string Uuid { get; set; } = null!;

    public string NoCertificadoSat { get; set; } = null!;

    public string FechaTimbrado { get; set; } = null!;

    public string ProveedorTimbrado { get; set; } = null!;

    public string IdCcp { get; set; } = null!;

    public string CcpQr { get; set; } = null!;

    public decimal MontoResico { get; set; }

    public decimal Total { get; set; }

    public decimal MontoLocalRetencion { get; set; }

    public virtual ICollection<ElectronicoGuium> ElectronicoGuia { get; set; } = new List<ElectronicoGuium>();

    public virtual ICollection<ElectronicoLiquidacionDirectum> ElectronicoLiquidacionDirecta { get; set; } = new List<ElectronicoLiquidacionDirectum>();

    public virtual ICollection<ElectronicoLiquidacion> ElectronicoLiquidacions { get; set; } = new List<ElectronicoLiquidacion>();

    public virtual ICollection<ElectronicoNotaCargo> ElectronicoNotaCargos { get; set; } = new List<ElectronicoNotaCargo>();

    public virtual ICollection<ElectronicoNotaCredito> ElectronicoNotaCreditos { get; set; } = new List<ElectronicoNotaCredito>();

    public virtual ElectronicoCertificado IdCertificadoNavigation { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
