using MantenimientoAPI.BusinessLogic;
using MantenimientoAPI.Classes;
using MantenimientoAPI.Interfaces;
using Mantenimiento.DL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Mantenimiento.API.Interfaces;
using Mantenimiento.API.Classes;

namespace MantenimientoAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class CatalogoClickbalanceController : Controller, ICatalogoClickbalance
    {
        private readonly ILogger<CatalogoController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MantenimientoContext _mantenimientoContext;

        public CatalogoClickbalanceController(ILogger<CatalogoController> logger, IConfiguration configuration, MantenimientoContext mantenimientoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mantenimientoContext = mantenimientoContext;
        }


        [Authorize]
        [Route("[action]")]
        [HttpGet]
        public Response<dynamic> ObtenerAlmacenes()
        {
            using (var context = _mantenimientoContext)
                return new CatalogoClickbalanceBusiness(_mantenimientoContext, HttpContext).ObtenerAlmacenes();
        }


        [Authorize]
        [Route("[action]")]
        [HttpGet]
        public Response<dynamic> ObtenerExistencias(int idAlmacen)
        {
            using (var context = _mantenimientoContext)
                return new CatalogoClickbalanceBusiness(_mantenimientoContext, HttpContext).ObtenerExistencias(idAlmacen);
        }


        [Authorize]
        [Route("[action]")]
        [HttpGet]
        public Response<dynamic> ObtenerProveedores()
        {
            using (var context = _mantenimientoContext)
                return new CatalogoClickbalanceBusiness(_mantenimientoContext, HttpContext).ObtenerProveedores();
        }
    }
}
