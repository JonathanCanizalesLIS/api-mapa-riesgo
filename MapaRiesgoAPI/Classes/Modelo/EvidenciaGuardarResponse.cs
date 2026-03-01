using Newtonsoft.Json;

namespace ElectronicDataInterchange.API.Classes.Modelo
{
    /// <summary>
    /// Respuesta al guardar una evidencia
    /// </summary>
    public class EvidenciaGuardarResponse
    {
        [JsonProperty("idEvento")]
        public int IdEvento { get; set; }

        [JsonProperty("nombreFoto")]
        public string NombreFoto { get; set; }

        [JsonProperty("latitud")]
        public double Latitud { get; set; }

        [JsonProperty("longitud")]
        public double Longitud { get; set; }

        [JsonProperty("fecha")]
        public DateTime Fecha { get; set; }
    }
}
