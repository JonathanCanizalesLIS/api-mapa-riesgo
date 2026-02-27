using MantenimientoAPI.Interfaces;
using MantenimientoAPI.Classes;
using Microsoft.AspNetCore.Mvc;
using Mantenimiento.API.BusinessLogic;
using Mantenimiento.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Mantenimiento.API.Classes;
using LISTMS.DL.Models;

namespace MantenimientoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MantenimientoController : Controller, IMantenimiento
    {
        private readonly ILogger<MantenimientoController> _logger;
        private readonly IConfiguration _configuration;
        private readonly MantenimientoContext _mantenimientoContext;
        private readonly ListmsContext _listmsContext;

        public MantenimientoController(ILogger<MantenimientoController> logger, IConfiguration configuration, MantenimientoContext mantenimientoContext, ListmsContext ListmsContext)
        {
            _logger = logger;
            _configuration = configuration;
            _mantenimientoContext = mantenimientoContext;
            _listmsContext = ListmsContext;
        }


        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public IEnumerable<MantenimientoConsulta> ConsultarMantenimientos([FromQuery] MantenimientoFiltros filtros)
        {
            using (var context = _mantenimientoContext)
                return new MantenimientoBusiness(_mantenimientoContext, _listmsContext).ConsultarMantenimientos(filtros);
        }

        [Route("[action]")]
        [Authorize]
        [HttpPost]
        public Response AgregarMantenimiento(MantenimientoInsertar mantenimiento)
        {
            using (var context = _mantenimientoContext)
            {
                var response = new MantenimientoBusiness(_mantenimientoContext, _listmsContext).AgregarMantenimiento(mantenimiento);
                HttpContext.Response.StatusCode = response.Status;
                return response;
            }
        }

        [Route("[action]")]
        [Authorize]
        [HttpPut]
        public Response ActualizarMantenimiento(MantenimientoInsertar mantenimiento)
        {
            using (var context = _mantenimientoContext)
                return new MantenimientoBusiness(_mantenimientoContext, _listmsContext).ActualizarMantenimiento(mantenimiento);
        }

        [Route("[action]")]
        [Authorize]
        [HttpDelete]
        public Response EliminarMantenimiento(int idMantenimiento)
        {
            using (var context = _mantenimientoContext)
                return new MantenimientoBusiness(_mantenimientoContext, _listmsContext).EliminarMantenimiento(idMantenimiento);
        }


        public struct ConsultaPlanMantenimiento
        {
            public List<SecuenciaConsulta> Secuencias { get; set; }
            public MantenimientoConsulta Mantenimiento { get; set; }
        }


        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public ConsultaPlanMantenimiento ConsultarPlanDeMantenimiento([FromQuery] MantenimientoFiltros filtros)
        {
            using (var context = _mantenimientoContext)
            {
                var unidad = new UnidadBusiness(_mantenimientoContext, null).ConsultarUnidad(new UnidadFiltros {
                    IdUnidad = filtros.idUnidad,
                    IdSistema = filtros.idSistema.Value,
                    IdEmpresa = filtros.idEmpresa
                }).FirstOrDefault();

                var ultimosMantenimientos = new MantenimientoBusiness(_mantenimientoContext, _listmsContext).ConsultarMantenimientos(new MantenimientoFiltros
                {
                    idUnidad = unidad.IdUnidad,
                    idEmpresa = unidad.IdEmpresa,
                    estatus = "A"
                });
                    
                var planMantenimiento = new PlanMantenimientoBusiness(_mantenimientoContext).ConsultarPlanMantenimiento(new PlanMantenimientoBaseFiltros { IdUnidadTipo = unidad.IdUnidadTipo, IdEmpresa = unidad.IdEmpresa });
                
                if (!planMantenimiento.Any())
                    return new ConsultaPlanMantenimiento();

                var mantenimiento = new ConsultaPlanMantenimiento
                {
                    Secuencias = new List<SecuenciaConsulta>(),
                    Mantenimiento = new MantenimientoConsulta(),
                };

                foreach (var secuencia in planMantenimiento.First().Secuencias) {

                    var ultimo = ultimosMantenimientos?.Where(um => um.MantenimientoUnidadActividades.Where(a => a.IdSecuencia == secuencia.IdSecuencia).Any()).FirstOrDefault();
                    var tiempoTranscurrido = ((ultimo?.FechaIngreso.Ticks ?? 0) / 1000000) + secuencia.Tiempo;
                    var tiempoActual = DateTime.Now.Ticks / 1000000;

                    if (ultimo == null || (unidad.Odometro - ultimo.Kms) >= secuencia.Kilometraje && (secuencia.IdSecuenciaTipo == 1 || secuencia.IdSecuenciaTipo == 3) ||
                        (tiempoTranscurrido < tiempoActual) && (secuencia.IdSecuenciaTipo == 2 || secuencia.IdSecuenciaTipo == 3))
                    {
                       mantenimiento.Secuencias.Add(secuencia);
                    }
                }


                //foreach (var secuencia in planMantenimiento.First().Secuencias)
                //{
                //    var ultimo = ultimosMantenimientos?.Where(um => um.MantenimientoUnidadActividades.Where(a => a.IdSecuencia == secuencia.IdSecuencia).Any()).FirstOrDefault();
                //    var kmSiguiente = (unidad.Odometro - ultimo.Kms) >= secuencia.Kilometraje ? secuencia.Kilometraje : (unidad.Odometro - ultimo.Kms);
                //}

                var siguientesKm = planMantenimiento.First().Secuencias.Select(s =>
                {
                    var ultimo = ultimosMantenimientos?.Where(um => um.MantenimientoUnidadActividades.Where(a => a.IdSecuencia == s.IdSecuencia).Any()).FirstOrDefault();
                    var kmSiguiente = (unidad.Odometro - (ultimo?.Kms ?? 0)) >= s.Kilometraje ? (unidad.Odometro + s.Kilometraje) : (s.Kilometraje + unidad.Odometro - (unidad.Odometro - ultimo?.Kms));
                    return new { kmSiguiente, s };
                }).ToList();

                var proximo = siguientesKm.OrderBy(s => s.kmSiguiente).First();

                mantenimiento.Mantenimiento.SiguienteMantenimiento = proximo.s.Nombre;
                mantenimiento.Mantenimiento.KmsSiguienteMantenimiento = proximo.kmSiguiente ?? 0;
                mantenimiento.Mantenimiento.FechaSiguienteMantenimiento = DateTime.Now.AddSeconds(proximo.s.Tiempo.Value);


                return mantenimiento;
            }
        }

        [Route("[action]")]
        [Authorize]
        [HttpGet]
        public MantenimientoConsulta CalcularSiguienteMantenimiento([FromQuery] MantenimientoFiltros filtros)
        {
            using (var context = _mantenimientoContext)
            {
                var unidad = new UnidadBusiness(_mantenimientoContext, null).ConsultarUnidad(new UnidadFiltros
                {
                    IdUnidad = filtros.idUnidad,
                    IdSistema = filtros.idSistema.Value,
                    IdEmpresa = filtros.idEmpresa
                }).FirstOrDefault();

                return new MantenimientoConsulta();
            }

        }

            [Route("[action]")]
        [Authorize]
        [HttpPost]
        public dynamic ExportarMantenimientoExcel([FromBody] MantenimientoFiltros filtros)
        {
            using (var context = _mantenimientoContext)
            {
                var rutaArchivo = new MantenimientoBusiness(_mantenimientoContext, _listmsContext).ExportarMantenimientoExcel(filtros);

                using var stream = new FileStream(rutaArchivo, FileMode.Open);
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);

                return Ok(File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Órdenes de trabajo.xlsx"));
            }

        }
    }
}