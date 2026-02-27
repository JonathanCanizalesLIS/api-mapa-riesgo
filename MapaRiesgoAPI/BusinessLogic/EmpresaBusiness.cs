using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using LISTMS.DL.Models;
using Mantenimiento.API.Classes;
using Mantenimiento.API.Classes.DatosExcel;
using Mantenimiento.API.Constants;
using MantenimientoAPI.BusinessLogic;
using MantenimientoAPI.Classes;
using MantenimientoAPI.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Mantenimiento.API.BusinessLogic
{
    public class EmpresaBusiness : IEmpresa
    {

        private ListmsContext _listmsContext;
        public EmpresaBusiness(ListmsContext listmsContext)
        {
            _listmsContext = listmsContext;
        }

        public IEnumerable<EmpresaConsulta> ConsultarEmpresa(EmpresaFiltros filtros)
        {
            return null;
            //return MantenimientoContext.Empresas
            //    .Include(i => i.IdEmpresaPresentacionNavigation)
            //    .Include(i => i.IdEmpresaTipoNavigation)
            //    .Include(i => i.IdSistemaNavigation)
            //    .Include(i => i.IdAlmacenNavigation)
            //    // Filtro obligatorio
            //    .Where(i => i.IdEmpresa == filtros.idEmpresa)
            //    // Filtros Opcionales. Si el filtro viene nulo, se ignora y devuelde todos los registros disponibles
            //    .Where(i => !string.IsNullOrEmpty(filtros.estatus) ? i.Estatus == filtros.estatus : true)
            //    .Where(i => filtros.idAlmacen.HasValue ? i.IdAlmacen == filtros.idAlmacen : true)
            //    .Where(i => filtros.idEmpresa.HasValue ? i.IdEmpresa == filtros.idEmpresa : true)
            //    .Where(i => filtros.idTipoEmpresa.HasValue ? i.IdEmpresaTipo == filtros.idTipoEmpresa : true)
            //    .Where(i => (filtros.fechaFinal.HasValue && filtros.fechaInicial.HasValue) ? i.FechaIngreso >= filtros.fechaInicial && i.FechaIngreso <= filtros.fechaFinal : true)

            //    .Select(query => new EmpresaConsulta
            //    {
            //        IdEmpresa = query.IdEmpresa,
            //        IdEmpresaTipo = query.IdEmpresaTipo,
            //        IdEmpresaPresentacion = query.IdEmpresaPresentacion,
            //        IdSistema = query.IdSistema,
            //        IdAlmacen = query.IdAlmacen,
            //        Almacen = query.IdAlmacenNavigation.Nombre,
            //        Sistema = query.IdSistemaNavigation.Nombre,
            //        IdEmpresa = query.IdEmpresa,
            //        Nombre = query.Nombre,
            //        Inicial = query.Inicial,
            //        Minimo = query.Minimo,
            //        Maximo = query.Maximo,
            //        IdIngreso = query.IdIngreso,
            //        IdModifico = query.IdModifico,
            //        Estatus = query.Estatus,
            //        EmpresaTipo = query.IdEmpresaTipoNavigation.Nombre,
            //        EmpresaPresentacion = query.IdEmpresaPresentacionNavigation.Nombre,
            //        FechaIngreso = query.FechaIngreso,
            //        FechaModifico = query.FechaModifico
            //    }).OrderByDescending(o => o.IdEmpresa).ToArray();
        }

    }
}
