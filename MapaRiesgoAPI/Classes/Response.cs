using Newtonsoft.Json;

namespace ElectronicDataInterchange.API.Classes
{

    public class Response<T> where T : class
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("hasError")]
        public bool HasError { get; set; }
        [JsonProperty("data")]
        public T? Data { get; set; }
    }


    public class Response
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("hasError")]
        public bool HasError { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
