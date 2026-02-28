using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeRutum
{
    public int IdRuta { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdPlazaOrigen { get; set; }

    public int IdPlazaDestino { get; set; }

    public int IdTipo { get; set; }

    public int KmsRuta { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public decimal Tiempo { get; set; }

    public decimal LitrosAutorizados { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaOrigenNavigation { get; set; } = null!;

    public virtual ViajeRutaTipo IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionSueldoRutum> LiquidacionSueldoRuta { get; set; } = new List<LiquidacionSueldoRutum>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<PermisionarioTarifaRutum> PermisionarioTarifaRuta { get; set; } = new List<PermisionarioTarifaRutum>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
