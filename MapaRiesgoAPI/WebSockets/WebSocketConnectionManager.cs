using System.Collections.Concurrent;
using System.Net.WebSockets;

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

        public async Task SendMessageAsync(int idDestinatario, string message)
        {
            var socket = GetSocket(idDestinatario);

            if (socket == null || socket.State != WebSocketState.Open)
                return;
            var buffer = System.Text.Encoding.UTF8.GetBytes(message);
            await socket.SendAsync(
                new ArraySegment<byte>(buffer),
                WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public bool IsConnected(int idUsuario) {
            var socket = GetSocket(idUsuario);
            return socket != null && socket.State == WebSocketState.Open;
        }
    }
}
