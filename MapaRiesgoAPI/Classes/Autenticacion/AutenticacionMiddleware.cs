using MapaRiesgo.DL.Models;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.Swagger;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Web.Http.Description;
using IOperationFilter = Swashbuckle.Swagger.IOperationFilter;

namespace ElectronicDataInterchange.API.Classes.Autenticacion
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AutenticacionMiddleware
    {
        private readonly RequestDelegate _next;
        private static IConfiguration _configuration;
        private static MapaRiesgoContext _mapaRiesgoContext;

        public AutenticacionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, MapaRiesgoContext mapaRiesgoContext, IConfiguration configuration)
        {
                _configuration = configuration;
            _mapaRiesgoContext = mapaRiesgoContext;

                //_listmsContext.Database.SetConnectionString(_configuration.GetConnectionString("ListmsSQLServerDatabase"));
                

                var x = _mapaRiesgoContext.Database.GetConnectionString();
                //if (string.IsNullOrEmpty(x))

                var path = httpContext.Request.Path;
                if (path.HasValue &&
                    path.Value.StartsWith("/api/Authentication/Authenticate") ||
                    path.Value.StartsWith("/api/ElectronicDataInterchange/AssignLoadTenderToRoadTrip") ||
                    path.Value.StartsWith("/api/AI/Test")
                    )

                    return _next(httpContext);
                //    httpContext.Response.Redirect("/login/index");

                if (!ValidateSession(httpContext, mapaRiesgoContext))
                    throw new UnauthorizedAccessException("Error de autenticación");

                return _next(httpContext);
            
        }

        private static bool ValidateSession(HttpContext httpContext, MapaRiesgoContext listmsContext)
        {
            string accessToken = httpContext.Request.Headers.Authorization;
            // Decodifica JWT
            var jwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(accessToken.Replace("Bearer ", ""));
            var idUsuario = int.Parse(jwtSecurityToken.Claims.Where(c => c.Type == ClaimTypes.UserData).FirstOrDefault().Value);
            var token = accessToken.Replace("Bearer ", "");

           
            //Busca sesión del usuario
            var sesion = listmsContext.Sesions
                .Include(u => u.IdUsuarioNavigation)
                .Where(s => s.IdUsuario == idUsuario).FirstOrDefault();

            var expirationDate = DateTime.UnixEpoch
                                .AddSeconds(int.Parse(jwtSecurityToken.Claims.Where(c => c.Type == "exp").First().Value))
                                .ToLocalTime();
            
            if(DateTime.Now > expirationDate)
                throw new UnauthorizedAccessException("Authentication error. The user session has expired");

            if (sesion.Token != token)
                    throw new UnauthorizedAccessException("Authentication error. Invalid session token");


            httpContext.Request.Headers.Add("IdUsuario", sesion.IdUsuario.ToString());
            //httpContext.Request.Headers.Add("IdEmpresa", sesion..IdEmpresa.ToString());
   


            sesion.UltimaActividad = DateTime.Now;
            listmsContext.Sesions.Update(sesion);
            listmsContext.SaveChanges();

            return true;
        }


        //private void IntegracionClickBalance(EmpresaClickbalance empresaCb)
        //{

        //}

    }


    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AutenticacionMiddleware>();
        }
    }

    public class AddAuthorizationHeaderParameterOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters != null)
            {
                operation.parameters.Add(new Parameter
                {
                    name = "Authorization",
                    @in = "header",
                    description = "access token",
                    required = true,
                    type = "string"
                });
            }
        }
    }
}