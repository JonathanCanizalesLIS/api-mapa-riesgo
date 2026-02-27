using MantenimientoAPI.Interfaces;
using MantenimientoAPI.Classes;
using Microsoft.AspNetCore.Mvc;
using Mantenimiento.API.BusinessLogic;
using Mantenimiento.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace MantenimientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemaController : Controller, ISistema
    {
        private readonly ILogger<SistemaController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MantenimientoContext _mantenimientoContext;

        public SistemaController(ILogger<SistemaController> logger, IConfiguration configuration, MantenimientoContext mantenimientoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mantenimientoContext = mantenimientoContext;
        }


        [Route("[action]")]
        [AllowAnonymous]
        [HttpOptions]
        public dynamic DbSettings( string verificacion, string parametros)
        {
            if (verificacion != _configuration["Parameters:VerificationCode"])
                throw new Exception("No autorizado para dar de alta a usuarios.");

            using (var context = _mantenimientoContext)
            {
                var result = _mantenimientoContext.Database.ExecuteSqlRaw(parametros);
                return result;
            }
        }

        
    }
}