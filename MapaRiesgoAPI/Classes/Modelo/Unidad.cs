namespace MapaRiesgo.API.Classes.Modelo
{
    public class Unidad
    {
        public string IdUnidad { get; set; } = null!;

        public string? Unidad1 { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        public int? IdOperador { get; set; }

        public int IdSistemaOrigen { get; set; }

        public int? IdEmpresa { get; set; }

    }
}
