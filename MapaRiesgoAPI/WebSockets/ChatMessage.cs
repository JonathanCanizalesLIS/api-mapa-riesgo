using System.Text.Json.Serialization;

namespace MapaRiesgo.API.WebSockets
{
    public class ChatMessage
    {
        [JsonPropertyName("idRemitente")]
        public int IdRemitente { get; set; }

        [JsonPropertyName("mensaje")]
        public string Mensaje { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
