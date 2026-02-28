using ElectronicDataInterchange.API.Classes;
using LISTMS.DL.Models;
using MapaRiesgo.API.BusinessLogic;
using MapaRiesgo.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MapaRiesgo.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class EventoController : Controller
    {
        private readonly ILogger<UnidadController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MapaRiesgoContext _mapaRiesgoContext;
        private readonly ListmsContext _listmsContext;
        private readonly EventoBusiness _eventoBusiness;

        public EventoController(
            ILogger<UnidadController> logger,
            IConfiguration configuration,
            MapaRiesgoContext mapaRiesgoContext,
            ListmsContext listmsContext, EventoBusiness eventoBusiness)
        {
            _logger = logger;
            _configuration = configuration;
            _mapaRiesgoContext = mapaRiesgoContext;
            _listmsContext = listmsContext;
            _eventoBusiness = eventoBusiness;
        }

        [Route("[action]")]
        [HttpGet]
        [Authorize]
        public Response<List<MapaRiesgo.API.Classes.Modelo.Evento>> ObtenerEventos(int idTipoEvento)
        {
            using (_mapaRiesgoContext)
            {
                return new EventoBusiness(_listmsContext, _mapaRiesgoContext, _configuration, null).ObtenerEventos(idTipoEvento);
            }
        }
    }
}