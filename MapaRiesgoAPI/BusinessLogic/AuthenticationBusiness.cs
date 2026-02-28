using ElectronicDataInterchange.API.Classes;
using ElectronicDataInterchange.API.Classes.Autenticacion;
using ElectronicDataInterchange.API.Interfaces;
using LISTMS.DL.Models;
using MapaRiesgo.DL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ElectronicDataInterchange.BusinessLogic
{
    public class AuthenticationBusiness : Base, IAuthentication
    {
        public AuthenticationBusiness(MapaRiesgoContext mapaRiesgoContext, IConfiguration configuration, HttpContext httpContext) : base(configuration, httpContext, mapaRiesgoContext)
        {

        }

        public Response<SesionConsulta> Authenticate(string username, string password)
        {
            var user = this.MapaRiesgoContext.Usuarios
                .Include(u => u.Sesions)
                //.Include(u => u.IdFuncionalidads)
                .Where(u => u.Username == username.Trim()).FirstOrDefault();

            if (user == null)
                return new Response<SesionConsulta>
                {
                    Id = 0,
                    Message = "El usuario no existe",
                    Status = StatusCodes.Status500InternalServerError,
                    Data = null
                };


            //PassPhrase        ^767383847783!
            //Salt              &?
            //Algorithm         SHA1
            //Iterations        2
            //Init Vector       ^767383847783! &?
            //KeySize           128
            string dbContraseña = (user.Encripcion) ? Encription.DesencriptaPass(user.Password, "^767383847783!", "&?", "SHA1", 2, "^767383847783!&?", 128) : user.Password;

            if (!dbContraseña.Equals(password))
                return new Response<SesionConsulta>
                {
                    Id = 0,
                    Message = "La contraseña para el usuario ingresado es incorrecta",
                    Status = StatusCodes.Status500InternalServerError,
                    Data = null
                };

            var sesion = this.MapaRiesgoContext.Sesions.Where(s => s.IdUsuario == user.IdUsuario).FirstOrDefault();

            //if (sesion != null)
            //{
            //    AgregarHistorico(sesion);
            //}

            sesion = new Sesion
            {
                IdSesion = sesion?.IdSesion ?? 0,
                IdUsuario = user.IdUsuario,
                Token = GenerateJSONWebToken(user),
                FechaInicio = DateTime.Now,
                UltimaActividad = DateTime.Now,
                Navegador = this.HttpContext.Request.Headers.UserAgent.ToString(),
            };
            if (sesion.IdSesion == 0)
                this.MapaRiesgoContext.Sesions.Add(sesion);
            else
                this.MapaRiesgoContext.Sesions.Update(sesion);

            this.MapaRiesgoContext.SaveChanges();

            return new Response<SesionConsulta>
            {
                Id = 0,
                Message = "Sesión iniciada",
                Status = StatusCodes.Status200OK,
                Data = new SesionConsulta
                {
                    IdUsuario = sesion.IdUsuario,
                    IdEmpresa = user.IdEmpresa,
                    Token = sesion.Token,
                    FechaInicio = sesion.FechaInicio,
                    UltimaActividad = sesion.UltimaActividad,
                    Navegador = sesion.Navegador
                }
            };

        }


        private void AgregarHistorico(Sesion sesionUsuario)
        {
            this.MapaRiesgoContext.Sesions.Add(new Sesion
            {
                IdSesion = sesionUsuario.IdSesion,
                FechaInicio = sesionUsuario.FechaInicio,
                UltimaActividad = sesionUsuario.UltimaActividad,
                Navegador = sesionUsuario.Navegador
            });
            this.MapaRiesgoContext.SaveChanges();
        }


        private string GenerateJSONWebToken(Usuario usuario)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(Configuration["Jwt:Issuer"],
                  Configuration["Jwt:Issuer"],
                  new List<Claim> {
                    //new Claim(ClaimTypes.Email, usuario.Email),
                    //new Claim(ClaimTypes.Role, usuario.Puesto),
                    new Claim(ClaimTypes.UserData, usuario.IdUsuario.ToString())
                    },
                  signingCredentials: credentials, 
                  expires: DateTime.Now.ToLocalTime().AddSeconds(int.Parse(Configuration["Parameters:InactivityExpirationTime"]))
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }



    }


}
