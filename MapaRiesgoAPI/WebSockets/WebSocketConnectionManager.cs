using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;

namespace MapaRiesgo.API.WebSockets
{
    public class WebSocketConnectionManager
    {
        private readonly ConcurrentDictionary<int, WebSocket> _sockets = new();

        public void AddSocket(int idUsuario, WebSocket socket)
        {
            _sockets[idUsuario] = socket;
        }

        public async Task RemoveSocket(int idUsuario)
        {
            if (_sockets.TryRemove(idUsuario, out var socket))
            {
                if (socket.State == WebSocketState.Open)
                    await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Conexion cerrada", CancellationToken.None);
            }
        }

        public WebSocket? GetSocket(int idUsuario)
        {
            _sockets.TryGetValue(idUsuario, out var socket);
            return socket;
        }

        public async Task SendMessageToAllAsync(int idRemitente, string message)
        {
            var buffer = Encoding.UTF8.GetBytes(message);

            foreach (var (idUsuario, socket) in _sockets)
            {

                if (idUsuario == idRemitente) continue;

                if (socket.State == WebSocketState.Open)
                    await socket.SendAsync(
                        new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }

    }
}
