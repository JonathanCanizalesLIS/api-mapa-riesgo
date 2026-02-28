using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpresionDetalle
{
    public int IdImpresion { get; set; }

    public int Consecutivo { get; set; }

    public int IdSeccion { get; set; }

    public string NombreExterno { get; set; } = null!;

    public string NombreInterno { get; set; } = null!;

    public decimal PosicionX { get; set; }

    public decimal PosicionY { get; set; }

    public decimal Alto { get; set; }

    public decimal Ancho { get; set; }

    public int Size { get; set; }

    public int Requerido { get; set; }

    public int Renglones { get; set; }

    public int Detalle { get; set; }

    public int Alinear { get; set; }

    public decimal Espacioizq { get; set; }

    public decimal Espaciotop { get; set; }

    public int Border { get; set; }

    public int Texto { get; set; }

    public int Cantidadconletra { get; set; }

    public string TipoDato { get; set; } = null!;

    public string Formato { get; set; } = null!;

    public int NoPagina { get; set; }

    public int IdImagen { get; set; }

    public int Negrita { get; set; }

    public int Imprimircero { get; set; }

    public int Orden { get; set; }

    public virtual ImpresionSeccione Id { get; set; } = null!;

    public virtual Imagene IdImagenNavigation { get; set; } = null!;

    public virtual Impresion IdImpresionNavigation { get; set; } = null!;

    public virtual ICollection<ImpresionDetalleIdioma> ImpresionDetalleIdiomas { get; set; } = new List<ImpresionDetalleIdioma>();
}
