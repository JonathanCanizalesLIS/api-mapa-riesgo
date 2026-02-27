namespace ElectronicDataInterchange.API.Classes.Autenticacion
{
    public abstract class SesionBase
    {
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEmpresaExterno { get; set; }
        public string Token { get; set; } = null!;
        public DateTime? FechaInicio { get; set; }
        public DateTime? UltimaActividad { get; set; }
        public string? Navegador { get; set; }
    }

    public class SesionConsulta : SesionBase
    {
 
    }

    public class SessionToken
    {
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
