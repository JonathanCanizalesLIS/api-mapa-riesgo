using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionVistaDetalle
{
    public int IdVista { get; set; }

    public int Consecutivo { get; set; }

    public string NombreExterno { get; set; } = null!;

    public string NombreInterno { get; set; } = null!;

    public decimal PosicionX { get; set; }

    public decimal PosicionY { get; set; }

    public decimal Alto { get; set; }

    public decimal Ancho { get; set; }

    public int Size { get; set; }

    public int IdSeccion { get; set; }

    public int Requerido { get; set; }

    public int Renglones { get; set; }

    public int Detalle { get; set; }

    public int Alinear { get; set; }

    public decimal Espacioizq { get; set; }

    public decimal Espaciotop { get; set; }

    public int Border { get; set; }

    public string Texto { get; set; } = null!;

    public int Cantidadconletra { get; set; }

    public string TipoDato { get; set; } = null!;

    public string Formato { get; set; } = null!;

    public int NoPagina { get; set; }

    public int IdImagen { get; set; }

    public int Negrita { get; set; }

    public int Imprimircero { get; set; }

    public virtual Imagene IdImagenNavigation { get; set; } = null!;
}
