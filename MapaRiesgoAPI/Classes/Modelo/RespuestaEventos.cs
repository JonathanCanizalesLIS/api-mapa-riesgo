namespace MapaRiesgo.API.Classes.Modelo
{
    public class RespuestaEventos
    {
        public List<Evento> Accidentes { get; set; }
        public List<Evento> Bloqueos { get; set; }
        public List<Evento> Robos { get; set; }
        public List<Evento> Otros { get; set; }
    }
}
