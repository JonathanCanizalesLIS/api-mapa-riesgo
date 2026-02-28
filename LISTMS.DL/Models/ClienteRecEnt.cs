using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteRecEnt
{
    public int IdRecEnt { get; set; }

    public int IdEmpresa { get; set; }

    public int IdCliente { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public string Direccion { get; set; } = null!;

    public string Municipio { get; set; } = null!;

    public string Numregidtrib { get; set; } = null!;

    public int IdPais { get; set; }

    public int IdEstado { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string Calle { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string NumeroInterior { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public string OrigenIdSat { get; set; } = null!;

    public string DestinoIdSat { get; set; } = null!;

    public string DetalleDireccion { get; set; } = null!;

    public string ClaveCiudad { get; set; } = null!;

    public string ClaveMunicipio { get; set; } = null!;

    public string ClaveColonia { get; set; } = null!;

    public virtual ICollection<Convenio> ConvenioIdEntregaEnNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Convenio> ConvenioIdRecogerEnNavigations { get; set; } = new List<Convenio>();

    public virtual ICollection<Guium> GuiumIdEntregaEnNavigations { get; set; } = new List<Guium>();

    public virtual ICollection<Guium> GuiumIdRecogerEnNavigations { get; set; } = new List<Guium>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
