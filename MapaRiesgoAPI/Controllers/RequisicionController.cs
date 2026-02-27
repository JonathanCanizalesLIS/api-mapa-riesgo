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
    public class RequisicionController : Controller, IRequisicion
    {
        private readonly ILogger<RequisicionController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MantenimientoContext _mantenimientoContext;

        public RequisicionController(ILogger<RequisicionController> logger, IConfiguration configuration, MantenimientoContext mantenimientoContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mantenimientoContext = mantenimientoContext;
        }


        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public IEnumerable<RequisicionConsulta> ConsultarRequisicion([FromQuery] RequisicionFiltros filtros)
        {
            using (var context = _mantenimientoContext)
                return new RequisicionBusiness(_mantenimientoContext).ConsultarRequisicion(filtros);
        }

        [Route("[action]")]
        [Authorize]
        [HttpPost]
        public Response AgregarRequisicion(RequisicionInsertar Requisicion)
        {
            using (var context = _mantenimientoContext)
            {
                var response = new RequisicionBusiness(_mantenimientoContext).AgregarRequisicion(Requisicion);
                if (response.Id > 0)
                {
                    Requisicion.IdRequisicion = response.Id;
                    new ExistenciaBusiness(_mantenimientoContext).ActualizarRequisicionAExistencia(response.Id);
                    var resp = new MantenimientoBusiness(_mantenimientoContext, null).ActualizarRefaccionesRequisicion(Requisicion);
                }
                return response;
            }
        }

        [Route("[action]")]
        [Authorize]
        [HttpPut]
        public Response ActualizarRequisicion(RequisicionInsertar Requisicion)
        {
            using (var context = _mantenimientoContext)
            {
                var requisicion = new RequisicionBusiness(_mantenimientoContext).ActualizarRequisicion(Requisicion);
                if(requisicion.Id > 0)
                {
                    new ExistenciaBusiness(_mantenimientoContext).ActualizarRequisicionAExistencia(requisicion.Id);
                    var resp = new MantenimientoBusiness(_mantenimientoContext, null).ActualizarRefaccionesRequisicion(Requisicion);
                }
                return requisicion;
            }
        }

        [Route("[action]")]
        [Authorize]
        [HttpDelete]
        public Response EliminarRequisicion(int idRequisicion)
        {
            using (var context = _mantenimientoContext)
                return new RequisicionBusiness(_mantenimientoContext).EliminarRequisicion(idRequisicion);
        }

        [Route("[action]")]
        [Authorize]
        [HttpPost]
        public dynamic ExportarRequisicionExcel([FromBody] RequisicionFiltros filtros)
        {
            using (var context = _mantenimientoContext)
            {
                var rutaArchivo = new RequisicionBusiness(_mantenimientoContext).ExportarRequisicionExcel(filtros);

                using var stream = new FileStream(rutaArchivo, FileMode.Open);
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                
                return Ok(File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Requisiciones.xlsx"));
            }

        }



        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public dynamic DescargarFormatoRequisicionExcel()
        {
            int idEmpresa = int.Parse(HttpContext.Request.Headers.Where(request => request.Key == "IdEmpresa").First().Value);
            var rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Temporal", $"Layout Recepciones { idEmpresa }.xlsx");

            try
            {
                using (var context = _mantenimientoContext)
                    new RequisicionBusiness(_mantenimientoContext).DescargarLayoutRequisicionExcel(rutaArchivo, idEmpresa);

                using var stream = new FileStream(rutaArchivo, FileMode.Open);
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                return Ok(File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Formato Requisiciones.xlsx"));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }

        [Route("[action]")]
        [Authorize]
        [HttpPost]
        public IEnumerable<Response> CargaMasivaRequisiciones(IFormFile file, int? idEmpresa)
        {
            using (var context = _mantenimientoContext)
                return new RequisicionBusiness(_mantenimientoContext).CargaMasivaRequisiciones(file, idEmpresa);
        }
    }
}