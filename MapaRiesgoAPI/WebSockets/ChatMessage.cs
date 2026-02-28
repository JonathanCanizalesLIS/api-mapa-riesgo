namespace MapaRiesgo.API.WebSockets
{
    public class ChatMessage
    {
        public int IdRemitente { get; set; }
        public int IdDestinatario { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
