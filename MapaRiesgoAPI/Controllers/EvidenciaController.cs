using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Classes.Modelo;
using MapaRiesgo.API.BusinessLogic;
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
        private readonly EvidenciaBusiness _evidenciaBusiness;

        public EvidenciaController(
            ILogger<EvidenciaController> logger, 
            IConfiguration configuration, 
            MapaRiesgoContext mapaRiesgoContext,
            EvidenciaBusiness evidenciaBusiness)
        {
            _logger = logger;
            _configuration = configuration;
            _mapaRiesgoContext = mapaRiesgoContext;
            _evidenciaBusiness = evidenciaBusiness;
        }

        /// <summary>
        /// Recibe datos de evidencia y los guarda en la tabla evento
        /// </summary>
        /// <param name="evidencia">Datos de la evidencia</param>
        /// <returns>Respuesta con el resultado del proceso</returns>
        [AllowAnonymous]
        [HttpPost]
        [Route("[action]")]
        public Response<EvidenciaGuardarResponse> RecibirEvidencia([FromBody] EvidenciaGuardarRequest evidencia)
        {
            try
            {
                _logger.LogInformation($"Recibiendo evidencia: {evidencia?.NombreFoto}");

                var response = _evidenciaBusiness.GuardarEvidencia(evidencia);

                if (response.HasError)
                    HttpContext.Response.StatusCode = response.Status;

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al procesar la evidencia en el controlador");
                
                return new Response<EvidenciaGuardarResponse>
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
                var response = _evidenciaBusiness.ObtenerEvidenciaPorId(idEvidencia);

                if (response.HasError)
                    HttpContext.Response.StatusCode = response.Status;

                return response;
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
        /// Obtiene una lista de evidencias por ID de empresa/razón social
        /// </summary>
        /// <param name="idEmpresa">ID de la empresa</param>
        /// <returns>Lista de evidencias</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("[action]/{idEmpresa}")]
        public Response<List<EvidenciaRequest>> ObtenerEvidenciasPorEmpresa(int idEmpresa)
        {
            try
            {
                var response = _evidenciaBusiness.ObtenerEvidenciasPorEmpresa(idEmpresa);

                if (response.HasError)
                    HttpContext.Response.StatusCode = response.Status;

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al obtener evidencias de la empresa {idEmpresa}");
                
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
