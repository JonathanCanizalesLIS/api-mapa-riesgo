using System.Data;
using Microsoft.Data.SqlClient;
using System.Net.NetworkInformation;
using ZAM.DL.Models;
using Dapper;

namespace ZAM.DL
{
    public class UnidadesZamDL
    {
        public List<UnidadesZam> GetUltimaPosicionUnidadesZam(string conexionString)
        {
            try
            {
                DataTable ldtDetalle = new DataTable();

                SqlConnection conn = new SqlConnection(conexionString);
                /*string nameSP = "sp_consultar_posicion_unidades";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameSP;
                cmd.Connection = conn;
                cmd.CommandTimeout = 6000;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(ldtDetalle);*/

                var posicionesZam = conn.Query<UnidadesZam>(
                    "sp_consultar_posicion_unidades", // Nombre del SP
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return posicionesZam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
