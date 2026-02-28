using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Constants;
using LISTMS.DL.Models;
using MapaRiesgo.DL.Models;
using Microsoft.EntityFrameworkCore;

namespace MapaRiesgo.API.BusinessLogic
{
    public class EmpresasBDConexionBusiness: Base
    {
        private readonly MapaRiesgoContext _mapaRiesgoContext;

        public EmpresasBDConexionBusiness(
             ListmsContext listmsContext,
             MapaRiesgoContext mapaRiesgoContext,
             IConfiguration configuration,
             IHttpContextAccessor httpContextAccessor
         ) : base(configuration, httpContextAccessor, mapaRiesgoContext)
        {
            _mapaRiesgoContext = mapaRiesgoContext;
        }

        public Response<List<MapaRiesgo.DL.Models.EmpresasBdConexion>> GetAll()
        {
            var Conexiones = _mapaRiesgoContext.EmpresasBdConexions.Where(e => e.IdSistemaOrigen == (int)SistemaEnumerable.Sistema.ZAM && e.Estatus == "A").ToList();

            return new Response<List<MapaRiesgo.DL.Models.EmpresasBdConexion>>
            {
                Id = Conexiones.Count,
                Status = StatusCodes.Status200OK,
                Message = $"Se obtuvieron {Conexiones.Count} Conexiones correctamente",
                Data = Conexiones
            };
        }

    }
}
