using ElectronicDataInterchange.API.Classes.Autenticacion;
using ElectronicDataInterchange.API.Classes;

namespace ElectronicDataInterchange.API.Interfaces
{
    public interface IAuthentication
    {
        public Response<SesionConsulta> Authenticate(string username, string password);
    }
}
