using System.Net.WebSockets;

namespace MapaRiesgo.API.WebSockets
{
    public class ChatWebSocketHandler
    {
        private readonly WebSocketConnectionManager _manager;

        public ChatWebSocketHandler(WebSocketConnectionManager manager)
        {
            _manager = manager;
        }

        public async Task Handle(int idUsuario, WebSocket socket)
        {
            _manager.AddSocket(idUsuario, socket);

            var buffer = new byte[1024 * 4];

            try
            {
                var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            }
            catch (Exception ex) { }


        }
    }
}
