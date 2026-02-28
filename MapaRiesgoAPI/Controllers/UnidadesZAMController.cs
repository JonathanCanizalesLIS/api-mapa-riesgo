using ElectronicDataInterchange.API.Classes;
using LISTMS.DL.Models;
using MapaRiesgo.API.BusinessLogic;
using MapaRiesgo.DL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ZAM.DL.Models;

namespace MapaRiesgo.API.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UnidadesZAMController : ControllerBase
    {
        private readonly EmpresasBDConexionBusiness _empresasBdConexionBusiness;
        private readonly UnidadZamBusiness _unidadZamBusiness;
        public UnidadesZAMController(EmpresasBDConexionBusiness empresasBdConexionBusiness, UnidadZamBusiness unidadZamBusiness)
        {
            _empresasBdConexionBusiness = empresasBdConexionBusiness;
            _unidadZamBusiness = unidadZamBusiness;
        }
        private ZAM.DL.UnidadesZamDL myDL = new ZAM.DL.UnidadesZamDL();

        private string GeneraConexion(EmpresasBdConexion rowConexion)
        {
            try
            {
                string ConexionString = "Data Source=" + rowConexion.ServerBd + ";Initial Catalog=" + rowConexion.NameBd + ";User ID=" + rowConexion.UsuarioBd + ";Password=" + rowConexion.PasswordBd + "; TrustServerCertificate=True; MultipleActiveResultSets=True";


                return ConexionString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("[action]")]
        public string GetPosicionUnidades()
        {
            try
            {
                string conexion = "";
                List<UnidadesZam> posicionesZam = new List<UnidadesZam>();
                var response = _empresasBdConexionBusiness.GetAll();
                if (response.Status == 200)
                {
                    //leer las conexiones y consultar las unidades
                    foreach (var item in response.Data)
                    {
                        conexion = GeneraConexion(item);

                        //Consultar unidades Zam
                        posicionesZam = myDL.GetUltimaPosicionUnidadesZam(conexion);
                        _unidadZamBusiness.SincronizacionUnidades(posicionesZam);

                    }
                }

                return JsonConvert.SerializeObject(new
                {
                    Id = response.Id,
                    Status = response.Status,
                    Message = ""
                });
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new
                {
                    Id = 0,
                    Status = StatusCodes.Status500InternalServerError,
                    Message = $"Error al sincronizar unidades: {ex.Message}"
                });
            }
        }


    }
}

