using ElectronicDataInterchange.API.Classes;
using LISTMS.DL.Models;
using MapaRiesgo.API.BusinessLogic;
using MapaRiesgo.API.Classes.Modelo;
using MapaRiesgo.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MapaRiesgo.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UnidadController : ControllerBase
    {
        private readonly ILogger<UnidadController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MapaRiesgoContext _mapaRiesgoContext;
        private readonly ListmsContext _listmsContext;
        private readonly UnidadBusiness _unidadBusiness;

        public UnidadController(
            ILogger<UnidadController> logger,
            IConfiguration configuration,
            MapaRiesgoContext mapaRiesgoContext,
            ListmsContext listmsContext, UnidadBusiness unidadBusiness)
        {
            _logger = logger;
            _configuration = configuration;
            _mapaRiesgoContext = mapaRiesgoContext;
            _listmsContext = listmsContext;
            _unidadBusiness = unidadBusiness;
        }

        [Route("[action]")]
        [HttpGet]
        public Response<List<Classes.Modelo.Unidad>> GetAll()
        {
            try {
                return _unidadBusiness.GetAll();
            }
            catch(Exception ex) {
                _logger.LogError(ex, "Error al obtener unidades");

                return new Response<List<Classes.Modelo.Unidad>>
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al obtener unidades: {ex.Message}"
                };
            }
        }

        [Route("[action]")]
        [HttpGet]
        public Response SincronizacionUnidades()
        {
            try
            {
                return _unidadBusiness.SincronizacionUnidades();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en SincronizacionUnidades");

                return new Response
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al sincronizar unidades: {ex.Message}"
                };
            }
        }


        [Route("[action]")]
        [HttpGet]
        [Authorize]
        public Response<RespuestaEventos> ObtenerEventos()
        {
            using (_mapaRiesgoContext)
            {
                return _unidadBusiness.ObtenerEventos();
            }
        }



    }
}