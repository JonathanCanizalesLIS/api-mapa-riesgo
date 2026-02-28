using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

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

            await _manager.SendMessageToAllAsync(idUsuario, JsonSerializer.Serialize(new
            {
                tipo = "conexion",
                idUsuario,
                mensaje = $"Usuario {idUsuario} se conectó"
            }));

            var buffer = new byte[1024 * 4];

            try
            {
                while (socket.State == WebSocketState.Open)
                {
                    var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await _manager.RemoveSocket(idUsuario);
                        break;
                    }

                    var json = Encoding.UTF8.GetString(buffer, 0, result.Count);

                    // ✅ try/catch interno, si falla no cierra la conexión
                    try
                    {
                        var mensaje = JsonSerializer.Deserialize<ChatMessage>(json);
                        if (mensaje == null) continue;

                        mensaje.IdRemitente = idUsuario;
                        mensaje.Fecha = DateTime.Now;

                        await _manager.SendMessageToAllAsync(idUsuario, JsonSerializer.Serialize(mensaje));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"⚠️ Mensaje inválido de usuario {idUsuario}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error WebSocket usuario {idUsuario}: {ex.Message}");
                await _manager.RemoveSocket(idUsuario);
            }
        }
    }
}