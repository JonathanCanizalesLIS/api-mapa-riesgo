namespace MapaRiesgo.API.Classes.Modelo
{
    public class Evento
    {
        public int IdEvento { get; set; }

        public int IdTipoEvento { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        public string? Evidencia { get; set; }

        public DateTime Fecha { get; set; }

        public int IdSistemaOrigen { get; set; }

        public int IdEmpresa { get; set; }
        public string Color { get; set; }

    }
}
