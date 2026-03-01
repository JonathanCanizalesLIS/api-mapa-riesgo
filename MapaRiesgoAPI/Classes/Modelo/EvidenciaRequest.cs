using Newtonsoft.Json;

namespace ElectronicDataInterchange.API.Classes.Modelo
{
    public class EvidenciaRequest
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("nombreFoto")]
        public string NombreFoto { get; set; }

        [JsonProperty("extencionFoto")]
        public string ExtencionFoto { get; set; }

        [JsonProperty("idEmpresa")]
        public int IdEmpresa { get; set; }

        [JsonProperty("realizoAlta")]
        public int RealizoAlta { get; set; }

        [JsonProperty("tipoFoto")]
        public string TipoFoto { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("idParada")]
        public int IdParada { get; set; }

        [JsonProperty("idPedido")]
        public int IdPedido { get; set; }

        [JsonProperty("idEvidencia")]
        public int IdEvidencia { get; set; }

        [JsonProperty("longitud")]
        public double Longitud { get; set; }

        [JsonProperty("latitud")]
        public double Latitud { get; set; }

        [JsonProperty("idRuta")]
        public int IdRuta { get; set; }

        [JsonProperty("idOperador")]
        public int IdOperador { get; set; }

        [JsonProperty("observación")]
        public string Observacion { get; set; }
    }
}
