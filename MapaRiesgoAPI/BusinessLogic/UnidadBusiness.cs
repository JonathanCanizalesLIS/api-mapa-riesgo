using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Constants;
using LISTMS.DL.Models;
using MapaRiesgo.DL.Models;
using Microsoft.EntityFrameworkCore;

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

        public Response<List<MapaRiesgo.DL.Models.Unidad>> GetAll()
        {
            var unidades = _mapaRiesgoContext.Unidads.OrderByDescending(u => u.Unidad1).ToList();

            return new Response<List<MapaRiesgo.DL.Models.Unidad>>
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
                .OrderByDescending(u => u.IdUnidad)
                .Take(2)
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

            var idsExternos = unidadesUnicas.Select(x => x.IdUnidad).ToList();

            var existentes = _mapaRiesgoContext.Unidads
                .Where(u => idsExternos.Contains(u.IdUnidad))
                .ToList();

            foreach (var b in unidadesUnicas)
            {
                var existente = existentes.FirstOrDefault(x => x.IdUnidad == b.IdUnidad);

                if (existente == null)
                {
                    _mapaRiesgoContext.Unidads.Add(new MapaRiesgo.DL.Models.Unidad
                    {
                        IdUnidad = b.IdUnidad,
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

    }
}
