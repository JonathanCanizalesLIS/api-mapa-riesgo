using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Constants;
using LISTMS.DL.Models;
using MapaRiesgo.API.Classes.Modelo;
using MapaRiesgo.DL.Models;

namespace MapaRiesgo.API.BusinessLogic
{
    public class UnidadBusiness : Base
    {
        private readonly MapaRiesgoContext _mapaRiesgoContext;
        private readonly ListmsContext _listmsContext;

        public UnidadBusiness(
            ListmsContext listmsContext,
            MapaRiesgoContext mapaRiesgoContext,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor
        ) : base(configuration, httpContextAccessor, mapaRiesgoContext)
        {
            _listmsContext = listmsContext;
            _mapaRiesgoContext = mapaRiesgoContext;
        }

        public Response<List<Classes.Modelo.Unidad>> GetAll()
        {
            var unidades = _mapaRiesgoContext.Unidads.OrderByDescending(u => u.Unidad1).Select(s => new Classes.Modelo.Unidad
            {
                IdUnidad = s.IdUnidad,
                Unidad1 = s.Unidad1,
                Latitud = s.Latitud,
                Longitud = s.Longitud,
                IdOperador = s.IdOperador,
                IdSistemaOrigen = s.IdSistemaOrigen,
                IdEmpresa = s.IdEmpresa
            }).ToList();

            return new Response<List<Classes.Modelo.Unidad>>
            {
                Id = unidades.Count,
                Status = StatusCodes.Status200OK,
                Message = $"Se obtuvieron {unidades.Count} unidades correctamente",
                Data = unidades
            };
        }
        public Response SincronizacionUnidades()
        {
            var unidadesListms = _listmsContext.Unidads
                .Where(u => u.Lat != 0m && u.Lon != 0m)
                .ToList();

            if (!unidadesListms.Any())
                return new Response
                {
                    Id = 0,
                    Status = StatusCodes.Status204NoContent,
                    Message = "No hay unidades con Lat/Lon válida"
                };

            var unidadesUnicas = unidadesListms
                .GroupBy(u => u.IdUnidad)
                .Select(g => g.First())
                .ToList();

            var idsExternos = unidadesUnicas.Select(x => x.IdUnidad.ToString()).ToList();

            var existentes = _mapaRiesgoContext.Unidads
                .Where(u => idsExternos.Contains(u.IdUnidad))
                .ToList();

            foreach (var b in unidadesUnicas)
            {
                var existente = existentes.FirstOrDefault(x => x.IdUnidad == b.IdUnidad.ToString());

                if (existente == null)
                {
                    _mapaRiesgoContext.Unidads.Add(new MapaRiesgo.DL.Models.Unidad
                    {
                        IdUnidad = b.IdUnidad.ToString(),
                        IdSistemaOrigen = (int)SistemaEnumerable.Sistema.LISTMS,
                        Unidad1 = b.NumUnidad,
                        Latitud = b.Lat,
                        Longitud = b.Lon,
                        IdOperador = b.IdOperador,
                        IdEmpresa = b.IdEmpresa,
                    });
                }
                else
                {
                    existente.Unidad1 = b.NumUnidad;
                    existente.Latitud = b.Lat;
                    existente.Longitud = b.Lon;
                    existente.IdOperador = b.IdOperador;
                    existente.IdEmpresa = b.IdEmpresa;

                    _mapaRiesgoContext.Unidads.Update(existente);
                }
            }

            _mapaRiesgoContext.SaveChanges();

            return new Response
            {
                Id = unidadesUnicas.Count,
                Status = StatusCodes.Status200OK,
                Message = $"Se sincronizaron {unidadesUnicas.Count} unidades correctamente"
            };
        }


        public Response<RespuestaEventos> ObtenerEventos()
        {
            var idUsuario = int.Parse(this._httpContextAccessor.HttpContext.Request.Headers["IdUsuario"]);
            var idSistema = _mapaRiesgoContext.Usuarios.Where(u => u.IdUsuario == idUsuario).First().IdSistemaOrigen;

            var accidentes = _mapaRiesgoContext.Eventos
                .Where(e => e.IdSistemaOrigen == idSistema)
                .Where(e => e.IdTipoEvento == 1)
                .Where(e => DateTime.Now < e.Fecha.AddMinutes(e.IdTipoEventoNavigation.Duracion))
                .Select(s => new MapaRiesgo.API.Classes.Modelo.Evento
                {
                    IdEvento = s.IdEvento,
                    IdTipoEvento = s.IdTipoEvento,
                    Latitud = s.Latitud,
                    Longitud = s.Longitud,
                    Evidencia = s.Evidencia,
                    Fecha = s.Fecha,
                    IdSistemaOrigen = s.IdSistemaOrigen,
                    IdEmpresa = s.IdEmpresa,
                    Color = "#e53935"
                })                
                .ToList();

            var bloqueos = _mapaRiesgoContext.Eventos
                .Where(e => e.IdSistemaOrigen == idSistema)
                .Where(e => e.IdTipoEvento == 2)
                .Where(e => DateTime.Now < e.Fecha.AddMinutes(e.IdTipoEventoNavigation.Duracion))
                .Select(s => new MapaRiesgo.API.Classes.Modelo.Evento
                {
                    IdEvento = s.IdEvento,
                    IdTipoEvento = s.IdTipoEvento,
                    Latitud = s.Latitud,
                    Longitud = s.Longitud,
                    Evidencia = s.Evidencia,
                    Fecha = s.Fecha,
                    IdSistemaOrigen = s.IdSistemaOrigen,
                    IdEmpresa = s.IdEmpresa,
                    Color = "#F26522"
                })
                .ToList();

            return new Response<RespuestaEventos>
            {
                Id = 0,
                Status = StatusCodes.Status200OK,
                Message = $"Se obtuvieron eventos de viaje correctamente",
                Data = new RespuestaEventos
                {
                    Accidentes = accidentes,
                    Bloqueos = bloqueos
                }
            };
        }

    }
}
