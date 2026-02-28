using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Classes.Modelo;
using MapaRiesgo.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicDataInterchange.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class EvidenciaController : Controller
    {
        private readonly ILogger<EvidenciaController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MapaRiesgoContext _mapaRiesgoContext;

        public EvidenciaController(ILogger<EvidenciaController> logger, IConfiguration configuration, MapaRiesgoContext mapaRiesgoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mapaRiesgoContext = mapaRiesgoContext;
        }

        /// <summary>
        /// Recibe datos de evidencia
        /// </summary>
        /// <param name="evidencia">Datos de la evidencia</param>
        /// <returns>Respuesta con el resultado del proceso</returns>
        [AllowAnonymous]
        [HttpPost]
        [Route("[action]")]
        public Response<EvidenciaRequest> RecibirEvidencia([FromBody] EvidenciaRequest evidencia)
        {
            try
            {
                if (evidencia == null)
                {
                    return new Response<EvidenciaRequest>
                    {
                        Id = 0,
                        Status = StatusCodes.Status400BadRequest,
                        Message = "Los datos de evidencia son requeridos",
                        HasError = true,
                        Data = null
                    };
                }

                // Aquí puedes agregar la lógica para procesar y guardar la evidencia
                // Por ejemplo: guardar en base de datos, validar datos, etc.

                _logger.LogInformation($"Evidencia recibida: {evidencia.NombreFoto}, IdEvidencia: {evidencia.IdEvidencia}");

                return new Response<EvidenciaRequest>
                {
                    Id = evidencia.IdEvidencia,
                    Status = StatusCodes.Status200OK,
                    Message = "Evidencia recibida exitosamente",
                    HasError = false,
                    Data = evidencia
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al procesar la evidencia");
                
                return new Response<EvidenciaRequest>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al procesar la evidencia: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Obtiene los datos de una evidencia por ID
        /// </summary>
        /// <param name="idEvidencia">ID de la evidencia</param>
        /// <returns>Datos de la evidencia</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("[action]/{idEvidencia}")]
        public Response<EvidenciaRequest> ObtenerEvidencia(int idEvidencia)
        {
            try
            {
                // Aquí puedes agregar la lógica para obtener la evidencia desde la base de datos
                // Por ahora retorna un ejemplo

                if (idEvidencia <= 0)
                {
                    return new Response<EvidenciaRequest>
                    {
                        Id = 0,
                        Status = StatusCodes.Status400BadRequest,
                        Message = "ID de evidencia inválido",
                        HasError = true,
                        Data = null
                    };
                }

                // Simulación de búsqueda - reemplazar con lógica real
                var evidencia = new EvidenciaRequest
                {
                    IdEvidencia = idEvidencia,
                    // Otros campos se llenarían desde la base de datos
                };

                return new Response<EvidenciaRequest>
                {
                    Id = idEvidencia,
                    Status = StatusCodes.Status200OK,
                    Message = "Evidencia obtenida exitosamente",
                    HasError = false,
                    Data = evidencia
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al obtener la evidencia {idEvidencia}");
                
                return new Response<EvidenciaRequest>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al obtener la evidencia: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Obtiene una lista de evidencias por ID de pedido
        /// </summary>
        /// <param name="idPedido">ID del pedido</param>
        /// <returns>Lista de evidencias</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("[action]/{idPedido}")]
        public Response<List<EvidenciaRequest>> ObtenerEvidenciasPorPedido(int idPedido)
        {
            try
            {
                if (idPedido <= 0)
                {
                    return new Response<List<EvidenciaRequest>>
                    {
                        Id = 0,
                        Status = StatusCodes.Status400BadRequest,
                        Message = "ID de pedido inválido",
                        HasError = true,
                        Data = null
                    };
                }

                // Aquí puedes agregar la lógica para obtener las evidencias desde la base de datos
                var evidencias = new List<EvidenciaRequest>();

                return new Response<List<EvidenciaRequest>>
                {
                    Id = idPedido,
                    Status = StatusCodes.Status200OK,
                    Message = $"Se encontraron {evidencias.Count} evidencias",
                    HasError = false,
                    Data = evidencias
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al obtener evidencias del pedido {idPedido}");
                
                return new Response<List<EvidenciaRequest>>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al obtener evidencias: {ex.Message}",
                    HasError = true,
                    Data = null
                };
            }
        }
    }
}
