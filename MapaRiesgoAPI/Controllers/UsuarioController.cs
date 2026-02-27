using MantenimientoAPI.Interfaces;
using MantenimientoAPI.Classes;
using Microsoft.AspNetCore.Mvc;
using Mantenimiento.API.BusinessLogic;
using Mantenimiento.DL.Models;
using Microsoft.AspNetCore.Authorization;

namespace MantenimientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller, IUsuario
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MantenimientoContext _mantenimientoContext;

        public UsuarioController(ILogger<UsuarioController> logger, IConfiguration configuration, MantenimientoContext mantenimientoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mantenimientoContext = mantenimientoContext;
        }


        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public IEnumerable<UsuarioConsulta> ConsultarUsuario()
        {
            using (var context = _mantenimientoContext)
                return new UsuarioBusiness(_mantenimientoContext).ConsultarUsuario();
        }

        [Route("[action]")]
        [AllowAnonymous]
        [HttpPost]
        public string AgregarUsuario(UsuarioInsertar Usuario)
        {
            if (Usuario.CodigoVerificacion != _configuration["Parameters:VerificationCode"])
                throw new Exception("No autorizado para dar de alta a usuarios.");

            using (var context = _mantenimientoContext)
                return new UsuarioBusiness(_mantenimientoContext).AgregarUsuario(Usuario);
        }

        [Route("[action]")]
        [Authorize]
        [HttpPut]
        public string ActualizarUsuario(UsuarioInsertar Usuario)
        {
            using (var context = _mantenimientoContext)
                return new UsuarioBusiness(_mantenimientoContext).ActualizarUsuario(Usuario);
        }

        [Route("[action]")]
        [Authorize]
        [HttpDelete]
        public string EliminarUsuario(int idUsuario)
        {
            using (var context = _mantenimientoContext)
                return new UsuarioBusiness(_mantenimientoContext).EliminarUsuario(idUsuario);
        }

        [Route("[action]")]
        [Authorize]
        [HttpPatch]
        public string RestablecerContraseña(int idUsuario, string contraseñaNueva, string repetirContraseña)
        {
            using (var context = _mantenimientoContext)
                return new UsuarioBusiness(_mantenimientoContext).RestablecerContraseña(idUsuario, contraseñaNueva, repetirContraseña);
        }
    }
}