using Microsoft.EntityFrameworkCore;
using ElectronicDataInterchange.API.Classes.Autenticacion;
using MapaRiesgo.DL.Models;

namespace ElectronicDataInterchange.API.Classes
{
    public abstract class Base
    {
        public IConfiguration Configuration { get; set; }
        public Session Session { get; set; }
        public MapaRiesgoContext MapaRiesgoContext;
        protected readonly IHttpContextAccessor _httpContextAccessor;



        public Base(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, MapaRiesgoContext mapaRiesgoContext)
        {
            Configuration = configuration;

            _httpContextAccessor = httpContextAccessor;

            MapaRiesgoContext = mapaRiesgoContext;
            mapaRiesgoContext.Database.SetConnectionString(Configuration.GetConnectionString("MapaRiesgoSQLServerDatabase"));

            Session = LoadSessionVariables();

        }

        private Session LoadSessionVariables()
        {

            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
                return new Session();

            if (!httpContext.Request.Headers.ContainsKey("Authorization"))
                return new Session();

            int idEmpresa = 0;
            int.TryParse(httpContext.Request.Headers["IdEmpresa"], out idEmpresa);

            int idEdiUsuario = 0;
            int.TryParse(httpContext.Request.Headers["IdEdiUsuario"], out idEdiUsuario);

            return new Session
            {
                IdEmpresa = idEmpresa,
                IdEdiUsuario = idEdiUsuario
            };
        }


    }
}
