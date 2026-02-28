using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class TipoEvento
{
    public int IdTipoEvento { get; set; }

    public string? Tipo { get; set; }

    /// <summary>
    /// Duracion en minutos que el evento se mostrará en pantalla
    /// </summary>
    public int Duracion { get; set; }

    /// <summary>
    /// Numero de eventos requeridos para ser mostrado en el mapa
    /// </summary>
    public int Conteo { get; set; }

    /// <summary>
    /// Radio en kilómetros que se debe considerar
    /// </summary>
    public int Radio { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
