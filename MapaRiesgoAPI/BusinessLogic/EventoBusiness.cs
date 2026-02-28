using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Constants;
using LISTMS.DL.Models;
using MapaRiesgo.API.Classes.Modelo;
using MapaRiesgo.DL.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using Evento = MapaRiesgo.API.Classes.Modelo.Evento;

namespace MapaRiesgo.API.BusinessLogic
{
    public class EventoBusiness : Base
    {
        private readonly MapaRiesgoContext _mapaRiesgoContext;
        private readonly ListmsContext _listmsContext;

        public EventoBusiness(
             ListmsContext listmsContext,
             MapaRiesgoContext mapaRiesgoContext,
             IConfiguration configuration,
             HttpContextAccessor httpContextAccessor
         ) : base(configuration, httpContextAccessor, mapaRiesgoContext)
        {
            _listmsContext = listmsContext;
            _mapaRiesgoContext = mapaRiesgoContext;
        }

        public Response<List<Evento>> ObtenerEventos(int idTipoEvento)
        {
            var idSistema = _mapaRiesgoContext.Usuarios.Where(u => u.IdEmpresa == this.Session.IdEmpresa).First().IdSistemaOrigen;

            var eventos = _mapaRiesgoContext.Eventos
                .Where(e => e.IdSistemaOrigen == idSistema)
                .Select(s => new Evento
                {
                    IdEvento = s.IdEvento,
                    IdTipoEvento = s.IdTipoEvento,
                    Latitud = s.Latitud,
                    Longitud = s.Longitud,
                    Evidencia = s.Evidencia,
                    Fecha = s.Fecha,
                    IdSistemaOrigen = s.IdSistemaOrigen,
                    IdEmpresa = s.IdEmpresa

                }).ToList();


            return new Response<List<Evento>>
            {
                Id = 0,
                Status = StatusCodes.Status200OK,
                Message = $"Se obtuvieron eventos de viaje correctamente",
                Data = eventos
            };
        }
    }

   
}
