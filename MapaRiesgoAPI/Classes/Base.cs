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
        public HttpContext HttpContext;



        public Base(IConfiguration configuration, HttpContext httpContext, MapaRiesgoContext mapaRiesgoContext)
        {
            Configuration = configuration;

            HttpContext = httpContext;

            MapaRiesgoContext = mapaRiesgoContext;
            mapaRiesgoContext.Database.SetConnectionString(Configuration.GetConnectionString("MapaRiesgoSQLServerDatabase"));

            Session = LoadSessionVariables(httpContext);

        }

        private Session LoadSessionVariables(HttpContext httpContext)
        {
            //Si no cuenta con token de autenticación, devuelve una sesión vacía
            if (!httpContext.Request.Headers.Where(request => request.Key == "Authorization").Any())
                return new Session();


            int idEmpresa = 0;
            int.TryParse(httpContext.Request.Headers.Where(request => request.Key == "IdEmpresa").First().Value, out idEmpresa);

            int idEdiUsuario = 0;
            int.TryParse(httpContext.Request.Headers.Where(request => request.Key == "IdEdiUsuario").First().Value, out idEdiUsuario);

            Session = new Session
            {
                IdEmpresa = idEmpresa,
                IdEdiUsuario = idEdiUsuario,
            };

            return Session;
        }


    }
}
