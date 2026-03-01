using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ElectronicDataInterchange.API.Classes.Modelo
{
    /// <summary>
    /// Modelo simplificado para recibir evidencias que se guardan en la tabla evento
    /// </summary>
    public class EvidenciaGuardarRequest
    {
        [JsonProperty("nombreFoto")]
        [Required(ErrorMessage = "El nombre de la foto es requerido")]
        public string NombreFoto { get; set; }

        [JsonProperty("latitud")]
        [Required(ErrorMessage = "La latitud es requerida")]
        public double Latitud { get; set; }

        [JsonProperty("longitud")]
        [Required(ErrorMessage = "La longitud es requerida")]
        public double Longitud { get; set; }

        [JsonProperty("tipoFoto")]
        public string? TipoFoto { get; set; }

        [JsonProperty("idEmpresa")]
        [Required(ErrorMessage = "El ID de empresa es requerido")]
        public int IdEmpresa { get; set; }
    }
}
