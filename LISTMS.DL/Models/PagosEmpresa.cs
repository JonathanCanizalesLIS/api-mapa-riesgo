using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosEmpresa
{
    public string? Name { get; set; }

    public int Id { get; set; }

    public string? RazonSocial { get; set; }

    public string? Rfc { get; set; }

    public string? Calle { get; set; }

    public string? Colonia { get; set; }

    public int? Estado { get; set; }

    public string? Delegacion { get; set; }

    public int? Pais { get; set; }

    public string? Cp { get; set; }

    public string? Numero { get; set; }

    public string? NumeroInterior { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Password { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? Activo { get; set; }

    public int? PromotorId { get; set; }

    public string? Ciudad { get; set; }

    public DateTime? Vigencia { get; set; }

    public string? NombreDelContacto { get; set; }

    public int Premium { get; set; }

    public int ReferenciaId { get; set; }

    public string ReferenciaOtro { get; set; } = null!;

    public DateTime FechaCorte { get; set; }

    public int UnidadesContratadas { get; set; }

    public int UsuarioContratoUnidades { get; set; }

    public int UnidadesPagadas { get; set; }

    public int UnidadesAgregadas { get; set; }

    public virtual ICollection<PagosCorte> PagosCortes { get; set; } = new List<PagosCorte>();

    public virtual ICollection<PagosPago> PagosPagos { get; set; } = new List<PagosPago>();

    public virtual ICollection<PagosServicioscontratado> PagosServicioscontratados { get; set; } = new List<PagosServicioscontratado>();

    public virtual ICollection<PagosTimbrado> PagosTimbrados { get; set; } = new List<PagosTimbrado>();
}
