using MantenimientoAPI.Classes;
using MantenimientoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Mantenimiento.API.Classes;
using Mantenimiento.API.Handlers;
using Mantenimiento.API.Constants;
using LISTMS.DL.Models;
using Mantenimiento.API.Interfaces;
using WSLISTMSClickbalance;

namespace Mantenimiento.API.BusinessLogic
{
    public class MantenimientoBusiness : IMantenimiento
    {

        //private MantenimientoContext MantenimientoContext;
        //private ListmsContext ListmsContext;
        //public MantenimientoBusiness(MantenimientoContext mantenimientoContext, ListmsContext listmsContext)
        //{
        //    MantenimientoContext = mantenimientoContext;
        //    ListmsContext = listmsContext;
        //}


        //private Dictionary<int, int> MantenimientoEstatusLISTMS_Taller = new Dictionary<int, int>()
        //{           // Taller   -  LISTMS   
        //    {1, 1}, // Bitácora Abierta         -  Abierta
        //    {2, 1}, // Bitácora terminada (Unidad en taller)  -  Abierta
        //    {3, 2}, // Bitácora terminada (Unidad liberada) - Cerrada
        //    {4, 3}, // Bitácora Cancelada   - Cancelada
        //};

        //public IEnumerable<MantenimientoConsulta> ConsultarMantenimientos(MantenimientoFiltros filtros)
        //{
        //    filtros.SelectTop();
        //    return MantenimientoContext.MantenimientoUnidads
        //        .Include(i => i.IdMantenimientoTipoNavigation)
        //        .Include(i => i.IdMantenimientoEstatusNavigation)
        //        .Include(i => i.IdSistemaNavigation)
        //        .Include(i => i.IdUnidadNavigation)
        //        .Include(i => i.IdUnidadNavigation.IdMarcaNavigation)
        //        .Include(i => i.IdUnidadNavigation.IdUnidadTipoNavigation)
        //        .Include(i => i.Requisicions)
        //        

        //        // Filtro obligatorio
        //        .Where(i => i.IdEmpresa == filtros.idEmpresa)
        //        // Filtros Opcionales. Si el filtro viene nulo, se ignora y devuelde todos los registros disponibles
        //        .Where(i => !string.IsNullOrEmpty(filtros.estatus) ? i.Estatus == filtros.estatus : true)
        //        .Where(i => filtros.idMantenimiento.HasValue ? i.IdMantenimiento == filtros.idMantenimiento : true)
        //        .Where(i => filtros.idTipoUnidad.HasValue ? i.IdUnidadNavigation.IdUnidadTipo == filtros.idTipoUnidad : true)
        //        .Where(i => filtros.idUnidad.HasValue ? i.IdUnidad == filtros.idUnidad : true)
        //        .Where(i => filtros.idMarca.HasValue ? i.IdUnidadNavigation.IdMarca == filtros.idMarca : true)
        //        .Where(i => (filtros.fechaFinal.HasValue && filtros.fechaInicial.HasValue) ? i.FechaIngreso >= filtros.fechaInicial && i.FechaIngreso <= filtros.fechaFinal : true)

            //        .Select(query => new MantenimientoConsulta
            //        {
            //            IdMantenimiento = query.IdMantenimiento,
            //            IdMantenimientoExterno = query.IdMantenimientoExterno,
            //            Folio = query.Folio,
            //            IdSistema = query.IdSistema,
            //            IdEmpresa = query.IdEmpresa,
            //            Nombre = query.Nombre,
            //            IdUnidad = query.IdUnidad,
            //            Unidad = query.IdUnidadNavigation.Nombre,
            //            IdMarca = query.IdUnidadNavigation.IdMarca,
            //            Marca = query.IdUnidadNavigation.IdMarcaNavigation.Nombre,
            //            IdTipoUnidad = query.IdUnidadNavigation.IdUnidadTipo,
            //            TipoUnidad = query.IdUnidadNavigation.IdUnidadTipoNavigation.Nombre,
            //            IdMantenimientoTipo = query.IdMantenimientoTipo,
            //            IdMantenimientoEstatus = query.IdMantenimientoEstatus,
            //            Kms = query.Kms,
            //            SiguienteMantenimiento = query.SiguienteMantenimiento,
            //            KmsSiguienteMantenimiento = query.KmsSiguienteMantenimiento,
            //            FechaSiguienteMantenimiento = query.FechaSiguienteMantenimiento,
            //            TotalManoObra = query.MantenimientoUnidadActividads.Sum(s => s.ManoObra),
            //            TotalRefacciones = query.MantenimientoUnidadRefaccions.Sum(s => s.Costo),
            //            TotalMantenimiento = query.MantenimientoUnidadRefaccions.Sum(s => s.Costo) + (decimal)query.MantenimientoUnidadActividads.Sum(s => s.Refacciones),
            //            Observaciones = query.Observaciones,
            //            Correlativo = query.Correlativo,
            //            Sistema = query.IdSistemaNavigation.Nombre,
            //            FechaIngreso = query.FechaIngreso,
            //            FechaModifico = query.FechaModifico,
            //            IdIngreso = query.IdIngreso,
            //            IdModifico = query.IdModifico,
            //            Estatus = query.Estatus,
            //            MantenimientoEstatus = query.IdMantenimientoEstatusNavigation.Nombre,
            //            MantenimientoTipo =  query.IdMantenimientoTipoNavigation.Nombre,
            //            MotivoCancelacion = query.MotivoCancelacion,
            //            MantenimientoUnidadActividades = query.MantenimientoUnidadActividads.Select(a => new MantenimientoActividadConsulta
            //            {
            //                IdMantenimientoActividad = a.IdMantenimientoActividad,
            //                IdMantenimiento = a.IdMantenimiento,
            //                IdSistema = a.IdSistema,
            //                IdActividadTipo = a.IdActividadTipo,
            //                IdActividad = a.IdActividad,
            //                IdEmpresa = a.IdEmpresa,
            //                Consecutivo = a.Consecutivo,
            //                Nombre = a.Nombre,
            //                ManoObra = a.ManoObra,
            //                Refacciones = a.Refacciones,
            //                Observaciones = a.Observaciones,
            //                IdSecuencia = a.IdActividadNavigation.IdSecuencia,
            //                Secuencia = a.IdActividadNavigation.IdSecuenciaNavigation.Nombre,
            //                Sistema = a.IdSistemaNavigation.Nombre,
            //                FolioFiscal = a.IdFacturaElectronicaNavigation.Uuid,
            //                IdFacturaElectronica = a.IdFacturaElectronica,
            //                FechaIngreso = a.FechaIngreso,
            //                FechaModifico = a.FechaModifico,
            //                IdIngreso = a.IdIngreso,
            //                IdModifico = a.IdModifico,
            //                Estatus = a.Estatus,
            //                IdActividadEstatus = a.IdActividadEstatus,

            //            }).ToArray(),
            //            MantenimientoUnidadRefacciones = query.MantenimientoUnidadRefaccions.Select(r => new Classes.MantenimientoRefaccionConsulta
            //            {
            //                IdMantenimientoRefaccion  = r.IdMantenimientoRefaccion,
            //                IdMantenimientoActividad = r.IdMantenimientoActividad,
            //                IdMantenimiento = r.IdMantenimiento,
            //                IdRequisicion = r.IdRequisicion,
            //                FolioRequisicion = r.IdRequisicionNavigation.Folio,
            //                IdSecuencia = r.IdSecuencia,
            //                IdInsumo = r.IdInsumo,
            //                Insumo = r.IdInsumoNavigation.Nombre,
            //                IdUnidadMedida = r.IdUnidadMedida,
            //                UnidadMedida = r.IdUnidadMedidaNavigation.Nombre,
            //                Cantidad = r.Cantidad,
            //                Observaciones = r.Observaciones,
            //                Costo = r.Costo,
            //                IdAlmacen = r.IdInsumoNavigation.IdAlmacen,
            //                Almacen = r.IdInsumoNavigation.IdAlmacenNavigation.Nombre
            //            })

            //        }).OrderByDescending(o => o.IdMantenimiento).Take(filtros.cantidadRegistros.Value).ToArray();
            //}

            //private string ObtenerFolio(MantenimientoInsertar mantenimiento)
            //{
            //    string folioAnterior = MantenimientoContext.MantenimientoUnidads.Where(r => r.IdEmpresa == mantenimiento.IdEmpresa).OrderByDescending(o => o.IdMantenimiento).FirstOrDefault()?.Folio;

            //    if (folioAnterior == null)
            //        return string.Format("{0:D8}", 1);

            //    var numFolio = int.Parse(folioAnterior) + 1;
            //    return string.Format("{0:D8}", numFolio);
            //}

            //public Response AgregarMantenimiento(MantenimientoInsertar mantenimiento)
            //{

            //    try
            //    {
            //        MantenimientoUnidad nuevo = new MantenimientoUnidad()
            //        {
            //            IdMantenimiento = mantenimiento.IdMantenimiento,
            //            Folio = ObtenerFolio(mantenimiento),
            //            IdSistema = mantenimiento.IdSistema,
            //            IdEmpresa = mantenimiento.IdEmpresa,
            //            Nombre = mantenimiento.Nombre,
            //            IdUnidad = mantenimiento.IdUnidad,
            //            IdMantenimientoTipo = mantenimiento.IdMantenimientoTipo,
            //            IdMantenimientoEstatus = mantenimiento.IdMantenimientoEstatus,
            //            Kms = mantenimiento.Kms,
            //            SiguienteMantenimiento = mantenimiento.SiguienteMantenimiento,
            //            KmsSiguienteMantenimiento = mantenimiento.KmsSiguienteMantenimiento,
            //            FechaSiguienteMantenimiento = mantenimiento.FechaSiguienteMantenimiento,
            //            Observaciones = mantenimiento.Observaciones,
            //            Correlativo = mantenimiento.Correlativo,
            //            MotivoCancelacion = mantenimiento.MotivoCancelacion,
            //            IdIngreso = mantenimiento.IdModifico,
            //            IdModifico = mantenimiento.IdModifico,
            //            FechaIngreso = mantenimiento.FechaIngreso,
            //            FechaModifico = DateTime.Now,
            //            Estatus = "A",

            //            MantenimientoUnidadActividads = mantenimiento.MantenimientoUnidadActividades.Select(a => new MantenimientoUnidadActividad
            //            {
            //                IdMantenimientoActividad = 0,
            //                IdMantenimiento = 0,
            //                IdSistema = a.IdSistema,
            //                IdActividadTipo = a.IdActividadTipo,
            //                IdEmpresa = a.IdEmpresa,
            //                Consecutivo = a.Consecutivo,
            //                Nombre = a.Nombre,
            //                ManoObra = a.ManoObra,
            //                Refacciones = a.Refacciones,
            //                Observaciones = a.Observaciones,
            //                IdFacturaElectronica = a.IdFacturaElectronica,
            //                IdActividad = a.IdActividad,
            //                IdActividadEstatus = a.IdActividadEstatus.Value,                        
            //                IdIngreso = a.IdModifico,
            //                IdModifico = a.IdModifico,
            //                FechaIngreso = DateTime.Now,
            //                FechaModifico = DateTime.Now,
            //                Estatus = "A"
            //            }).ToArray(),

            //            MantenimientoUnidadRefaccions = mantenimiento.MantenimientoUnidadRefacciones.Select(r => new MantenimientoUnidadRefaccion
            //            {
            //                IdMantenimientoRefaccion = 0,
            //                IdMantenimientoActividad = r.IdMantenimientoActividad,
            //                IdMantenimiento = r.IdMantenimiento,
            //                IdInsumo = r.IdInsumo,
            //                IdUnidadMedida = r.IdUnidadMedida,
            //                Cantidad = r.Cantidad,
            //                Observaciones = r.Observaciones,
            //                IdSecuencia = r.IdSecuencia,
            //                IdRequisicion = r.IdRequisicion,
            //                Costo = r.Costo
            //            }).ToArray(),
            //        };

            //        MantenimientoContext.MantenimientoUnidads.Add(nuevo);
            //        MantenimientoContext.SaveChanges();


            //        try
            //        {
            //            ActualizarFechaMantenimientoUnidad(nuevo);
            //            AgregarMantenimientoLISTMS(nuevo);

            //        }
            //        catch { }

            //        return new Response
            //        {
            //            Id = nuevo.IdMantenimiento,
            //            Status = StatusCodes.Status200OK,
            //            Message = "Orden de trabajo agregado correctamente"
            //        };
            //    }
            //    catch (Exception ex)
            //    {
            //        return new Response
            //        {
            //            Id = 0,
            //            Status = StatusCodes.Status500InternalServerError,
            //            Message = "Ocurrió un error al guardar la información." + ex.InnerException?.Message
            //        };
            //    }
            //}


            //public Response ActualizarMantenimiento(MantenimientoInsertar mantenimiento)
            //{
            //    var Empresa = MantenimientoContext.Empresas.Where(e => e.IdEmpresa == mantenimiento.IdEmpresa).First();
            //    var Unidad = MantenimientoContext.Unidads.Where(u => u.IdUnidad == mantenimiento.IdUnidad).First();

            //    var actualizado = MantenimientoContext.MantenimientoUnidads
            //        .Include(i => i.MantenimientoUnidadActividads)
            //        .Include(i => i.MantenimientoUnidadRefaccions)
            //        .Where(i => i.IdMantenimiento == mantenimiento.IdMantenimiento).First();

            //    actualizado.IdMantenimiento = mantenimiento.IdMantenimiento;
            //    actualizado.IdMantenimientoExterno = mantenimiento.IdMantenimientoExterno;
            //    actualizado.Folio = mantenimiento.Folio;
            //    actualizado.IdSistema = mantenimiento.IdSistema;
            //    actualizado.IdEmpresa = mantenimiento.IdEmpresa;
            //    actualizado.Nombre = mantenimiento.Nombre;
            //    actualizado.IdUnidad = mantenimiento.IdUnidad;
            //    actualizado.IdMantenimientoTipo = mantenimiento.IdMantenimientoTipo;
            //    actualizado.IdMantenimientoEstatus = mantenimiento.IdMantenimientoEstatus;
            //    actualizado.Kms = mantenimiento.Kms;
            //    actualizado.SiguienteMantenimiento = mantenimiento.SiguienteMantenimiento;
            //    actualizado.KmsSiguienteMantenimiento = mantenimiento.KmsSiguienteMantenimiento;
            //    actualizado.FechaSiguienteMantenimiento = mantenimiento.FechaSiguienteMantenimiento;
            //    actualizado.Observaciones = mantenimiento.Observaciones;
            //    actualizado.Correlativo = mantenimiento.Correlativo;
            //    actualizado.MotivoCancelacion = mantenimiento.MotivoCancelacion;

            //    actualizado.IdIngreso = mantenimiento.IdModifico;
            //    actualizado.IdModifico =  actualizado.IdModifico;
            //    actualizado.FechaIngreso =  mantenimiento.FechaIngreso;
            //    actualizado.FechaModifico = DateTime.Now;
            //    actualizado.Estatus = mantenimiento.Estatus;

            //    actualizado.MantenimientoUnidadActividads = mantenimiento.MantenimientoUnidadActividades.Select(a => new MantenimientoUnidadActividad
            //    {
            //        IdMantenimientoActividad = a.IdMantenimientoActividad,
            //        IdMantenimiento = a.IdMantenimiento,
            //        IdSistema = a.IdSistema,
            //        IdActividadTipo = a.IdActividadTipo,
            //        IdEmpresa = a.IdEmpresa,
            //        Consecutivo = a.Consecutivo,
            //        Nombre = a.Nombre,
            //        ManoObra = a.ManoObra,
            //        Refacciones = a.Refacciones,
            //        Observaciones = a.Observaciones,
            //        IdFacturaElectronica = a.IdFacturaElectronica,
            //        IdActividad = a.IdActividad,
            //        IdActividadEstatus = a.IdActividadEstatus.Value,
            //        IdIngreso = mantenimiento.IdModifico,
            //        IdModifico = mantenimiento.IdModifico,
            //        FechaIngreso = actualizado.MantenimientoUnidadActividads.Where(ac => ac.IdMantenimientoActividad == a.IdMantenimientoActividad).FirstOrDefault()?.FechaIngreso ?? DateTime.Now,
            //        FechaModifico = DateTime.Now,
            //        Estatus = "A"

            //    }).ToList();

            //    actualizado.MantenimientoUnidadRefaccions = mantenimiento.MantenimientoUnidadRefacciones.Select(r => new MantenimientoUnidadRefaccion
            //    {
            //        IdMantenimientoRefaccion = r.IdMantenimientoRefaccion,
            //        IdMantenimientoActividad = r.IdMantenimientoActividad,
            //        IdMantenimiento = r.IdMantenimiento,
            //        IdInsumo = r.IdInsumo,
            //        IdUnidadMedida = r.IdUnidadMedida,
            //        Cantidad = r.Cantidad,
            //        Observaciones = r.Observaciones,
            //        IdRequisicion = r.IdRequisicion,
            //        IdSecuencia = r.IdSecuencia,
            //        Costo = r.Costo
            //    }).ToList();


            //    //Actualizar Actividades. Elimina de BD las actividades que ya no se encuentran en la lista.
            //    var actividades = MantenimientoContext.MantenimientoUnidadActividads.Where(act => act.IdMantenimiento == mantenimiento.IdMantenimiento).ToList();
            //    var deleteActividad = actividades.Where(act => mantenimiento.MantenimientoUnidadActividades.All(mAct => mAct.IdMantenimientoActividad!= act.IdMantenimientoActividad)).ToList();
            //    MantenimientoContext.MantenimientoUnidadActividads.RemoveRange(deleteActividad);

            //    //Actualizar Refacciones. Elimina de BD las refacciones que ya no se encuentran en la lista.
            //    var refacciones = MantenimientoContext.MantenimientoUnidadRefaccions.Where(rec => rec.IdMantenimiento == mantenimiento.IdMantenimiento).ToList();
            //    var deleteRefaccion = refacciones.Where(rec => mantenimiento.MantenimientoUnidadRefacciones.All(mRef => mRef.IdMantenimientoRefaccion != rec.IdMantenimientoRefaccion)).ToList();
            //    MantenimientoContext.MantenimientoUnidadRefaccions.RemoveRange(deleteRefaccion);
            //    MantenimientoContext.SaveChanges();

            //    //Actualizar mantenimiento (Orden de trabajo)
            //    MantenimientoContext.MantenimientoUnidads.Update(actualizado);
            //    MantenimientoContext.SaveChanges();

            //    try
            //    {
            //        ActualizarFechaMantenimientoUnidad(actualizado);
            //        SincronizarMantenimiento(Empresa.IdSistema, Empresa.IdEmpresa, mantenimiento.IdMantenimientoExterno ,Unidad.IdUnidadExterno);
            //    }
            //    catch { }

            //    return new Response
            //    {
            //        Id = actualizado.IdMantenimiento,
            //        Status = StatusCodes.Status200OK,
            //        Message = "Orden de trabajo actualizada correctamente"
            //    };
            //}




            //public Response EliminarMantenimiento(int idMantenimiento)
            //{
            //    var baja = MantenimientoContext.MantenimientoUnidads.Where(m => m.IdMantenimiento == idMantenimiento).First();

            //    MantenimientoContext.MantenimientoUnidads.Update(baja);
            //    MantenimientoContext.SaveChanges();

            //    return new Response
            //    {
            //        Id = baja.IdMantenimiento,
            //        Status = StatusCodes.Status200OK,
            //        Message = "Orden de trabajo eliminada correctamente"
            //    };
            //}

            //public Response ActualizarRefaccionesRequisicion(RequisicionInsertar requisicion)
            //{
            //    //Si la requisición se encuentra surtida, asigna el precio promedio a la lista de refacciones
            //    List<Existencium> existencias = new List<Existencium>();
            //    if (requisicion.IdRequisicionEstatus == 1)
            //        existencias = MantenimientoContext.Existencia.Where(e => requisicion.Insumos.Select(r => r.IdInsumo).ToArray().Contains(e.IdInsumo)).ToList();

            //    var mantenimiento = ConsultarMantenimientos(new MantenimientoFiltros()
            //    {
            //        idEmpresa = requisicion.IdEmpresa,
            //        idMantenimiento = requisicion.IdMantenimiento
            //    }).First();

            //    var insumosRequisicion = requisicion.Insumos.ToList<MantenimientoAPI.Classes.MovimientoInsumo>();
            //    var refacciones = mantenimiento.MantenimientoUnidadRefacciones.Where(ur => ur.IdRequisicion == requisicion.IdRequisicion).ToList<MantenimientoRefaccionConsulta>();

            //    var actualizar = insumosRequisicion.FullOuterJoin(refacciones, a => a.IdInsumo, b => b.IdInsumo, (a, b, id) => new MantenimientoRefaccionConsulta
            //    {
            //        IdMantenimientoRefaccion = b?.IdMantenimientoRefaccion ?? 0,
            //        IdMantenimientoActividad = b?.IdMantenimientoActividad ?? 0,
            //        IdMantenimiento = b?.IdMantenimiento ?? mantenimiento.IdMantenimiento,
            //        IdInsumo = b?.IdInsumo ?? a.IdInsumo,
            //        IdUnidadMedida = b?.IdUnidadMedida ?? 1,
            //        Cantidad = b?.Cantidad ?? a.Cantidad,
            //        Observaciones = b?.Observaciones ?? a.Observaciones,
            //        IdSecuencia = b?.IdSecuencia ?? null,
            //        IdRequisicion = requisicion?.IdRequisicion ?? null,
            //        Costo = existencias.Where(e => e.IdInsumo == b.IdInsumo).FirstOrDefault()?.PrecioPromedio ?? 0,
            //    }).ToArray();


            //    var update = mantenimiento.MantenimientoUnidadRefacciones
            //        .Where(ur => ur.IdRequisicion != requisicion.IdRequisicion)
            //        .Where(ur => ur.IdRequisicion != null && mantenimiento.MantenimientoUnidadRefacciones.Select(r => r.IdInsumo).Contains(ur.IdInsumo)).ToList();
            //    update.AddRange(actualizar);            
            //    mantenimiento.MantenimientoUnidadRefacciones = update;

            //    ActualizarMantenimiento((MantenimientoInsertar) mantenimiento);

            //    //var delete = refacciones.Where(ur => ur.IdRequisicion == null && 
            //    //                 ur.IdMantenimiento == mantenimiento.IdMantenimiento &&
            //    //                 mantenimiento.MantenimientoUnidadRefacciones.Select(r => r.IdInsumo).Contains(ur.IdInsumo)).ToList();
            //    //delete.ForEach(ur => EliminarMantenimiento(ur.IdMantenimiento));
            //    //MantenimientoContext.MantenimientoUnidadRefaccions.RemoveRange(delete);
            //    //MantenimientoContext.SaveChanges();

            //    return new Response
            //    {
            //        Id = 0,
            //        Message = "OK",
            //        Status = StatusCodes.Status200OK
            //    };
            //}

            //private void ActualizarFechaMantenimientoUnidad(MantenimientoUnidad mantenimiento)
            //{
            //    var Empresa = MantenimientoContext.Empresas.Where(e => e.IdEmpresa == mantenimiento.IdEmpresa).First();
            //    var unidad = MantenimientoContext.Unidads.Where(u => u.IdUnidad == mantenimiento.IdUnidad).First();

            //    unidad.FechaSiguienteMantenimiento = mantenimiento.FechaIngreso;

            //    MantenimientoContext.Update(unidad);
            //    MantenimientoContext.SaveChanges();

            //    var unidadBusiness = new UnidadBusiness(MantenimientoContext, ListmsContext);
            //    var sincronizacion = unidadBusiness.SincronizarUnidadExterna(Empresa.IdSistema, Empresa.IdEmpresa, unidad.IdUnidadExterno);
            //}


            //public dynamic ExportarMantenimientoExcel(MantenimientoFiltros filtros)
            //{
            //    var rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Assets/Temporal/Mantenimientos{ filtros.idEmpresa }.xlsx");

            //    var mantenimientos = ConsultarMantenimientos(filtros).Select(x => new
            //    {
            //        Ot = x.IdMantenimiento.ToString(),
            //        Fecha = x.FechaIngreso.ToString(),
            //        Unidad = x.Unidad,
            //        Tipo = x.TipoUnidad,
            //        Marca= x.Marca,
            //        TipoServicio = x.MantenimientoTipo,
            //        Mantenimiento = x.Nombre,
            //        SiguienteMantenimiento = x.SiguienteMantenimiento,
            //        ManoObra = x.TotalManoObra.ToString(),
            //        Refacciones = x.TotalRefacciones.ToString(),
            //    }).ToList<object>();

            //    GeneradorExcel oCreadorExcel = new GeneradorExcel(rutaArchivo);

            //    oCreadorExcel.CrearReporteConsulta(new EncabezadosExcel().ConsultaMantenimientoHeaders,
            //        new DetallesExcel { 
            //            Titulo = "Orden de trabajo",
            //            FechaCreacion = DateTime.Now.ToString("dd/MM/yyyy")
            //        }, mantenimientos);
            //    return rutaArchivo;
            //}

            //public Response SincronizarMantenimiento(int idSistema, int idEmpresa, int? idMantenimientoExterno = null, int? idUnidadExterno = null)
            //{
            //    switch (idSistema)
            //    {
            //        case (int)SistemaEnumerable.Sistema.LISTMS: return SincronizarMantenimientoTaller_LISTMS(idEmpresa, idMantenimientoExterno, idUnidadExterno);
            //        case (int)SistemaEnumerable.Sistema.ZAM: return null;
            //        default: return null;
            //    }
            //}
            //private Response SincronizarMantenimientoTaller_LISTMS(int idEmpresa, int? idMantenimientoExterno, int? idUnidadExterno)
            //{
            //    var Empresa = MantenimientoContext.Empresas.Where(e => e.IdEmpresa == idEmpresa).First();

            //    var MantenimientoTaller = MantenimientoContext.MantenimientoUnidads
            //        .Include(i => i.MantenimientoUnidadActividads)
            //        .Include(i => i.MantenimientoUnidadRefaccions)
            //        .Where(mantenimiento => idMantenimientoExterno.HasValue ? mantenimiento.IdMantenimientoExterno == idMantenimientoExterno : true)
            //        .Where(mantenimiento => mantenimiento.IdEmpresa == idEmpresa).ToList<DL.Models.MantenimientoUnidad>();
            //        //.Where(mantenimiento => idUnidadExterno.HasValue ? mantenimiento.IdUnidadNavigation.IdUnidadExterno == idUnidadExterno : true)

            //    var MantenimientoListms = ListmsContext.MttoUnidads
            //        .Where(mtto => idMantenimientoExterno.HasValue ? mtto.IdMtto == idMantenimientoExterno : true)
            //        .Where(mtto => idUnidadExterno.HasValue ? mtto.IdUnidad == idUnidadExterno : true)
            //        .Where(mtto => mtto.IdEmpresa == Empresa.IdEmpresaExterno)
            //        .ToList<LISTMS.DL.Models.MttoUnidad>();


            //    // a : LISTMS   b : Taller
            //    var actualizar = MantenimientoListms.FullOuterJoin(MantenimientoTaller, a => a?.IdMtto, b => b.IdMantenimientoExterno, (a, b, id) => new LISTMS.DL.Models.MttoUnidad
            //    {
            //        IdMtto = a?.IdMtto ?? b.IdMantenimientoExterno,
            //        IdUnidad = a.IdUnidad,
            //        TipoMtto = b?.IdMantenimientoTipo ?? a.TipoMtto,
            //        Mantenimiento = b?.Nombre ?? a?.Mantenimiento,
            //        IdEstatus = MantenimientoEstatusLISTMS_Taller[b.IdMantenimientoEstatus],
            //        Kms = b?.Kms ?? a.Kms,
            //        SigMtto = b?.SiguienteMantenimiento ?? a.SigMtto,
            //        KmsSigMtto = b?.KmsSiguienteMantenimiento ?? a.KmsSigMtto,
            //        Fecha = b?.FechaIngreso ?? a.FechaIngreso,
            //        FechaSigMtto = b?.FechaSiguienteMantenimiento ?? a.FechaSigMtto,
            //        Total = b.MantenimientoUnidadActividads.Sum(s => s.ManoObra) + b.MantenimientoUnidadActividads.Sum(s => s.Refacciones),
            //        TotalRefacc = b.MantenimientoUnidadRefaccions.Sum(s => s.Costo),
            //        TotalManoObra = b.MantenimientoUnidadActividads.Sum(s => s.ManoObra),
            //        Observaciones = b.Observaciones,
            //        IdEmpresa = a.IdEmpresa,
            //        IdIngreso = 0,
            //        IdModifico = 1,
            //        FechaIngreso = DateTime.Now,
            //        FechaModifico = DateTime.Now,
            //        Correlativo = b.Correlativo
            //    })
            //    .ToList();

            //    MantenimientoListms = actualizar;

            //    ListmsContext.MttoUnidads.UpdateRange(MantenimientoListms);
            //    ListmsContext.SaveChanges();

            //    return new Response
            //    {
            //        Id = 1,
            //        Status = StatusCodes.Status200OK,
            //        Message = "Se han Actualizado las 'Unidades' de LISTMS correctamente"
            //    };
            //}

            //private Response AgregarMantenimientoLISTMS(MantenimientoUnidad mantenimiento)
            //{
            //    //var mantenimiento = ConsultarMantenimientos(new MantenimientoFiltros { idMantenimiento = idMantenimiento }).First();
            //    var unidad = MantenimientoContext.Unidads.Where(u => u.IdUnidad == mantenimiento.IdUnidad).First();
            //    var Empresa = MantenimientoContext.Empresas.Where(e => e.IdEmpresa == mantenimiento.IdEmpresa).First();

            //    var mantenimientoLISTMS = new MttoUnidad()
            //    {
            //        IdMtto = ListmsContext.MttoUnidads.OrderByDescending(o => o.IdMtto).First().IdMtto + 1 ,
            //        IdUnidad = unidad.IdUnidadExterno.Value,
            //        TipoMtto = mantenimiento.IdMantenimientoTipo,
            //        Mantenimiento = mantenimiento.Nombre,
            //        IdEstatus = MantenimientoEstatusLISTMS_Taller[mantenimiento.IdMantenimientoEstatus],
            //        Kms = mantenimiento.Kms,
            //        SigMtto = mantenimiento.SiguienteMantenimiento,
            //        KmsSigMtto = mantenimiento.KmsSiguienteMantenimiento,
            //        Fecha = mantenimiento.FechaIngreso,
            //        FechaSigMtto = mantenimiento.FechaSiguienteMantenimiento,
            //        Total = mantenimiento.MantenimientoUnidadActividads.Sum(s => s.ManoObra) + mantenimiento.MantenimientoUnidadRefaccions.Sum(s => s.Costo),
            //        TotalManoObra = mantenimiento.MantenimientoUnidadActividads.Sum(s => s.ManoObra),
            //        TotalRefacc = mantenimiento.MantenimientoUnidadRefaccions.Sum(s => s.Costo),
            //        Observaciones = mantenimiento.Observaciones,
            //        IdEmpresa = (int)Empresa.IdEmpresaExterno,
            //        IdIngreso = 0,
            //        IdModifico = 1,
            //        FechaIngreso = DateTime.Now,
            //        FechaModifico = DateTime.Now,
            //        Correlativo = mantenimiento.Correlativo,
            //        Folio=mantenimiento.Folio
            //    };

            //    ListmsContext.MttoUnidads.Add(mantenimientoLISTMS);
            //    ListmsContext.SaveChanges();

            //    //var actualizar = MantenimientoContext.MantenimientoUnidads.Where(m => m.IdMantenimiento == mantenimiento.)
            //    mantenimiento.IdMantenimientoExterno = mantenimientoLISTMS.IdMtto;
            //    MantenimientoContext.MantenimientoUnidads.Update(mantenimiento);
            //    MantenimientoContext.SaveChanges();

            //    return new Response
            //    {
            //        Id = 1,
            //        Status = StatusCodes.Status200OK,
            //        Data = mantenimientoLISTMS.IdMtto, 
            //        Message = "Se han Actualizado las 'Unidades' de LISTMS correctamente"
            //    };
            //}



        }
}
