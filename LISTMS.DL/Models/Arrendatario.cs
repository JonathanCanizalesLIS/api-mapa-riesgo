using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Arrendatario
{
    public int IdArrendatario { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreBusqueda { get; set; } = null!;

    public string Rfc { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Calle { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string NumeroInterior { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string Referencia { get; set; } = null!;

    public string Numregidtrib { get; set; } = null!;

    public string NombreContacto { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }
}
