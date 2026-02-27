using MantenimientoAPI.Interfaces;
using MantenimientoAPI.Classes;
using Microsoft.AspNetCore.Mvc;
using Mantenimiento.API.BusinessLogic;
using Mantenimiento.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Mantenimiento.API.Classes;

namespace MantenimientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : Controller, IEmpresa
    {
        private readonly ILogger<EmpresaController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MantenimientoContext _mantenimientoContext;

        public EmpresaController(ILogger<EmpresaController> logger, IConfiguration configuration, MantenimientoContext mantenimientoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mantenimientoContext = mantenimientoContext;
        }


        [Route("[action]")]
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<EmpresaConsulta> ConsultarEmpresa([FromQuery] EmpresaFiltros filtros)
        {
            using (var context = _mantenimientoContext)
                return new EmpresaBusiness(_mantenimientoContext).ConsultarEmpresa(filtros);
        }

        [Route("[action]")]
        [AllowAnonymous]
        [HttpPost]
        public Response AgregarEmpresa(EmpresaInsertar Empresa)
        {
            using (var context = _mantenimientoContext)
            {
                var response = new EmpresaBusiness(_mantenimientoContext).AgregarEmpresa(Empresa);
                return response;
            }
        }

        [Route("[action]")]
        [Authorize]
        [HttpPut]
        public string ActualizarEmpresa(EmpresaInsertar Empresa)
        {
            using (var context = _mantenimientoContext)
                return new EmpresaBusiness(_mantenimientoContext).ActualizarEmpresa(Empresa);
        }

        [Route("[action]")]
        [Authorize]
        [HttpDelete]
        public string EliminarEmpresa(int idEmpresa)
        {
            using (var context = _mantenimientoContext)
                return new EmpresaBusiness(_mantenimientoContext).EliminarEmpresa(idEmpresa);
        }

        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public IEnumerable<NotificacionCalendario> ObtenerNotificaciones([FromQuery] EmpresaFiltros filtros)
        {
            filtros.idEmpresa = int.Parse(HttpContext.Request.Headers.Where(request => request.Key == "IdEmpresa").First().Value);

            using (var context = _mantenimientoContext)
                return new EmpresaBusiness(_mantenimientoContext).ObtenerNotificaciones(filtros);
        }
    }
}