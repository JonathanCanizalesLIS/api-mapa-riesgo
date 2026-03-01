using Newtonsoft.Json;

namespace ElectronicDataInterchange.API.Classes.Modelo
{
    /// <summary>
    /// Modelo simplificado para recibir evidencias que se guardan en la tabla evento
    /// </summary>
    public class EvidenciaGuardarRequest
    {
        [JsonProperty("nombreFoto")]
        public string NombreFoto { get; set; }

        [JsonProperty("latitud")]
        public double Latitud { get; set; }

        [JsonProperty("longitud")]
        public double Longitud { get; set; }

        [JsonProperty("tipoFoto")]
        public string? TipoFoto { get; set; }

        [JsonProperty("idEmpresa")]
        public int IdEmpresa { get; set; }
    }
}
