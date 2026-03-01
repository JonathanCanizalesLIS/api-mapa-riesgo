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

            var accidentesQuery = _mapaRiesgoContext.Eventos
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
                    Radio = s.IdTipoEventoNavigation.Radio,
                    Color = "#e53935"
                })                
                .ToList();



            var accidentes = new List<MapaRiesgo.API.Classes.Modelo.Evento>();

            if (accidentesQuery.Any())
            {
                foreach (var accidente in accidentesQuery)
                {
                    if (CalculateDistance((double)accidente.Latitud, (double)accidente.Longitud, (double)accidentesQuery[0].Latitud, (double)accidentesQuery[0].Longitud) < accidentesQuery[0].Radio) 
                    {
                        accidentes.Add(accidente);
                    }
                }
            }


            var bloqueosQuery = _mapaRiesgoContext.Eventos
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
                    Radio = s.IdTipoEventoNavigation.Radio,
                    Color = "#F26522"
                })
                .ToList();


            var bloqueos = new List<MapaRiesgo.API.Classes.Modelo.Evento>();

            if (bloqueosQuery.Any())
            {
                foreach (var bloqueo in bloqueosQuery)
                {
                    if (CalculateDistance((double)bloqueo.Latitud, (double)bloqueo.Longitud, (double)bloqueosQuery[0].Latitud, (double)bloqueosQuery[0].Longitud) < bloqueosQuery[0].Radio)
                    {
                        accidentes.Add(bloqueo);
                    }
                }
            }

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





        public double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // Earth's radius in kilometers
            const double EarthRadius = 6371.0;

            // Convert degrees to radians
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);

            // Haversine formula
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return EarthRadius * c;
        }
        private double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }



    }
}
