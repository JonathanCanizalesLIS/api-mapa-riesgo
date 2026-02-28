using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionVistum
{
    public int IdImpresion { get; set; }

    public int IdVista { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public int TipoPapel { get; set; }

    public string TipoLetra { get; set; } = null!;

    public int Medida { get; set; }

    public decimal Alto { get; set; }

    public decimal Ancho { get; set; }

    public string Estatus { get; set; } = null!;

    public int NoPaginas { get; set; }
}
