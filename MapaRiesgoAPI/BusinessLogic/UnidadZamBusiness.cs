using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Constants;
using ZAM.DL.Models;
using MapaRiesgo.DL.Models;

namespace MapaRiesgo.API.BusinessLogic
{
    public class UnidadZamBusiness: Base
    {
        private readonly MapaRiesgoContext _mapaRiesgoContext;

        public UnidadZamBusiness(
             MapaRiesgoContext mapaRiesgoContext,
             IConfiguration configuration,
             IHttpContextAccessor httpContextAccessor
         ) : base(configuration, httpContextAccessor, mapaRiesgoContext)
        {
            _mapaRiesgoContext = mapaRiesgoContext;
        }

        public Response SincronizacionUnidades(List<UnidadesZam> ListUnidades)
        {
            var unidadesZam = ListUnidades;

            if (!unidadesZam.Any())
                return new Response
                {
                    Id = 0,
                    Status = StatusCodes.Status204NoContent,
                    Message = "No hay unidades con Lat/Lon válida"
                };

            var idsExternos = unidadesZam.Select(x => x.IdUnidad).ToList();

            var existentes = _mapaRiesgoContext.Unidads
                .Where(u => idsExternos.Contains(u.IdUnidad) && u.IdSistemaOrigen == (int)SistemaEnumerable.Sistema.ZAM)
                .ToList();

            foreach (var b in unidadesZam)
            {
                var existente = existentes.FirstOrDefault(x => x.IdUnidad == b.IdUnidad.ToString() && x.IdSistemaOrigen == (int)SistemaEnumerable.Sistema.ZAM);

                if (existente == null)
                {
                    _mapaRiesgoContext.Unidads.Add(new MapaRiesgo.DL.Models.Unidad
                    {
                        IdUnidad = b.IdUnidad,
                        IdSistemaOrigen = (int)SistemaEnumerable.Sistema.ZAM,
                        Unidad1 = b.Unidad1,
                        Latitud = b.Latitud,
                        Longitud = b.Longitud,
                        IdOperador = b.IdOperador,
                        IdEmpresa = b.IdEmpresa,
                    });
                }
                else
                {
                    existente.Unidad1 = b.Unidad1;
                    existente.Latitud = b.Latitud;
                    existente.Longitud = b.Longitud;
                    existente.IdOperador = b.IdOperador;
                    existente.IdEmpresa = b.IdEmpresa;

                    _mapaRiesgoContext.Unidads.Update(existente);
                }
            }

            _mapaRiesgoContext.SaveChanges();

            return new Response
            {
                Id = unidadesZam.Count,
                Status = StatusCodes.Status200OK,
                Message = $"Se sincronizaron {unidadesZam.Count} unidades correctamente"
            };
        }
    }
}
