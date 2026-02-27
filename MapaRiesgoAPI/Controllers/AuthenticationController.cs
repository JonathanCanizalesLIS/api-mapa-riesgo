using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Classes.Autenticacion;
using ElectronicDataInterchange.API.Interfaces;
using ElectronicDataInterchange.BusinessLogic;
using MapaRiesgo.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ElectronicDataInterchange.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AuthenticationController : Controller, IAuthentication
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MapaRiesgoContext _mapaRiesgoContext;

        public AuthenticationController(ILogger<AuthenticationController> logger, IConfiguration configuration, MapaRiesgoContext mapaRiesgoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mapaRiesgoContext = mapaRiesgoContext;
        }


        [AllowAnonymous]
        [Route("[action]")]
        [HttpPost]
        public Response<SesionConsulta> Authenticate(string username, string password)
        {
            Response<SesionConsulta> response = new Response<SesionConsulta>();

            using (var listmsContext = _mapaRiesgoContext)
            {
                response = new AuthenticationBusiness(listmsContext, _configuration, HttpContext).Authenticate(username, password);

                if (response.Status != 200)
                    this.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

                return response;
            }
        }


        //[Authorize]
        //[Route("[action]")]
        //[HttpGet]
        //public IEnumerable<AnticipoConsulta> ConsultarAnticipos([FromQuery] FiltroAnticipo filtro)
        //{
        //    using (var listmsContext = _listmsContext)
        //        return new AnticipoBusiness(listmsContext, _configuration, this.HttpContext).ConsultarAnticipos(filtro);            

        //}

        //[Authorize]
        //[Route("[action]")]
        //[HttpGet]
        //public IEnumerable<AnticipoConceptoConsulta> ConsultarConceptosAnticipos([FromQuery] FiltroAnticipo filtro)
        //{
        //    using (var listmsContext = _listmsContext)
        //        return new AnticipoBusiness(listmsContext, _configuration, this.HttpContext).ConsultarConceptosAnticipos(filtro);            

        //}

        //[Authorize]
        //[Route("[action]")]
        //[HttpPost]
        //public Response<AnticipoConsulta> AgregarAnticipo([FromBody] AnticipoInsertar anticipo)
        //{
        //    using (var listmsContext = _listmsContext)
        //        return new AnticipoBusiness(listmsContext, _configuration, this.HttpContext).AgregarAnticipo(anticipo);
        //}


        //[Authorize]
        //[Route("[action]")]
        //[HttpPut]
        //public Response<AnticipoConsulta> ActualizarAnticipo([FromBody] AnticipoInsertar anticipo)
        //{
        //    using (var listmsContext = _listmsContext)
        //        return new AnticipoBusiness(listmsContext, _configuration, this.HttpContext).ActualizarAnticipo(anticipo);
        //}

        //[Authorize]
        //[Route("[action]")]
        //[HttpDelete]
        //public Response<AnticipoConsulta> EliminarAnticipo([FromQuery] int idAnticipo)
        //{
        //    using (var listmsContext = _listmsContext)
        //        return new AnticipoBusiness(listmsContext, _configuration, this.HttpContext).CancelarAnticipo(idAnticipo);
        //}

 
    }
}
