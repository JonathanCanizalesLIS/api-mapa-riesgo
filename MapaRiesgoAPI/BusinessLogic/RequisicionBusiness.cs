using MantenimientoAPI.Classes;
using MantenimientoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Mantenimiento.API.Constants;
using Mantenimiento.API.Classes;
using Mantenimiento.API.Classes.DatosExcel;
using MantenimientoAPI.BusinessLogic;
using ClosedXML.Excel;

namespace Mantenimiento.API.BusinessLogic
{

    public class MovimientoRequisicion
    {
    //    public int IdMovimiento { get; set; }   
    //    public int IdRequisicion { get; set; }

    //    public DL.Models.MovimientoInsumo Movimiento { get; set; }
    //    public Requisicion Requisicion { get; set; }
    //}
    //public class RequisicionBusiness : IRequisicion
    //{

    //    private MantenimientoContext MantenimientoContext;
    //    public RequisicionBusiness(MantenimientoContext mantenimientoContext)
    //    {
    //        MantenimientoContext = mantenimientoContext;
    //    }

    //    public IEnumerable<RequisicionConsulta> ConsultarRequisicion(RequisicionFiltros filtros)
    //    {
    //        return MantenimientoContext.Requisicions
    //            .Include(r => r.IdRequisicionEstatusNavigation)
    //            .Include(r => r.IdAlmacenNavigation)
    //            .Include(r => r.IdSistemaNavigation)
    //            .Include(r => r.IdMovimientos)
    //            .Include(r => r.IdIngresoNavigation)

    //            // Filtro obligatorio
    //            .Where(i => i.IdEmpresa == filtros.idEmpresa)
    //            // Filtros Opcionales. Si el filtro viene nulo, se ignora y devuelde todos los registros disponibles
    //            .Where(i => !string.IsNullOrEmpty(filtros.estatus) ? i.Estatus == filtros.estatus : true)
    //            .Where(i => filtros.idRequisicionEstatus.HasValue ? i.IdRequisicionEstatus == filtros.idRequisicionEstatus : true)
    //            .Where(i => filtros.idAlmacen.HasValue ? i.IdAlmacen == filtros.idAlmacen : true)
    //            .Where(i => filtros.idRequisicion.HasValue ? i.IdRequisicion == filtros.idRequisicion : true)
    //            .Where(i => (filtros.fechaFinal.HasValue && filtros.fechaInicial.HasValue) ? i.FechaIngreso >= filtros.fechaInicial && i.FechaIngreso <= filtros.fechaFinal : true)

    //            .Select(query => new RequisicionConsulta
    //            {
    //                IdRequisicion = query.IdRequisicion,
    //                IdAlmacen = query.IdAlmacen,
    //                IdSistema = query.IdSistema,
    //                IdRequisicionEstatus = query.IdRequisicionEstatus,
    //                IdEmpresa = query.IdEmpresa,
    //                Folio = query.Folio,
    //                Nombre =  query.Nombre,
    //                Minimo = query.Minimo,
    //                Maximo = query.Maximo,
    //                IdIngreso = query.IdIngreso,
    //                IdModifico = query.IdModifico,
    //                Usuario = $"{ query.IdIngresoNavigation.Nombre } { query.IdIngresoNavigation.ApellidoPaterno } { query.IdIngresoNavigation.ApellidoMaterno }".Trim(),
    //                Estatus = query.Estatus,
    //                AlmacenNombre =  query.IdAlmacenNavigation.Nombre,
    //                MotivoCancelacion = query.MotivoCancelacion,
    //                Insumos = query.IdMovimientos.Select(mi => new MantenimientoAPI.Classes.MovimientoInsumoConsulta
    //                {
    //                    IdMovimiento = mi.IdMovimiento,
    //                    IdInsumo = mi.IdInsumo, 
    //                    Cantidad = mi.Cantidad,
    //                    Costo = mi.Costo,
    //                    Total = mi.Total,
    //                    Factura = mi.Factura,
    //                    Observaciones = mi.Observaciones,
    //                    IdUsuario = mi.IdUsuario,
    //                    Minimo = mi.IdInsumoNavigation.Minimo.Value,
    //                    Maximo = mi.IdInsumoNavigation.Maximo.Value,
    //                    Existencia =  MantenimientoContext.Existencia.Where(e => e.IdInsumo == mi.IdInsumo).First().Existencia.Value

    //                }).ToList(),
    //                IdMantenimiento = query.IdMantenimiento,
    //                RequisicionEstatus =  query.IdRequisicionEstatusNavigation.Nombre,
    //                Sistema =  query.IdSistemaNavigation.Nombre,
    //                FechaIngreso = query.FechaIngreso,
    //                FechaModifico = query.FechaModifico
    //            }).OrderByDescending(o => o.IdRequisicion).ToArray();

    //    }

    //    private string ObtenerFolio(RequisicionInsertar requisicion)
    //    {
    //        string folioAnterior = MantenimientoContext.Requisicions.Where(r => r.IdEmpresa == requisicion.IdEmpresa).OrderByDescending(o => o.IdRequisicion).FirstOrDefault()?.Folio;

    //        if (folioAnterior == null)
    //            return string.Format("{0:D8}", 1);

    //        var numFolio = int.Parse(folioAnterior) + 1;
    //        return string.Format("{0:D8}", numFolio);
    //    }

    //    public Response AgregarRequisicion(RequisicionInsertar requisicion)
    //    {
    //        try
    //        {
    //            Requisicion nuevo = new Requisicion()
    //            {
    //                IdRequisicion = requisicion.IdRequisicion,
    //                IdAlmacen = requisicion.IdAlmacen,
    //                IdSistema = requisicion.IdSistema,
    //                IdRequisicionEstatus = requisicion.IdRequisicionEstatus,
    //                IdEmpresa = requisicion.IdEmpresa,
    //                IdMovimientos = requisicion.Insumos.Select(i => new DL.Models.MovimientoInsumo
    //                {
    //                    IdMovimiento = 0,
    //                    IdInsumo = i.IdInsumo,
    //                    Cantidad = i.Cantidad,
    //                    Costo = null,
    //                    Total = null,
    //                    Factura = null,
    //                    Observaciones = i.Observaciones,
    //                    IdUsuario = requisicion.IdModifico
    //                }).ToList(),
    //                IdMantenimiento = requisicion.IdMantenimiento ?? throw new Exception("La requisición debe estar relacionada a una orden de trabajo"),
    //                Nombre = requisicion.Nombre,
    //                Folio = ObtenerFolio(requisicion),
    //                Minimo = 0,
    //                Maximo = 0,
    //                MotivoCancelacion = requisicion.MotivoCancelacion,
    //                IdIngreso = requisicion.IdIngreso,
    //                IdModifico = requisicion.IdModifico,
    //                Estatus = "A",
    //                FechaIngreso = DateTime.Now,
    //                FechaModifico = DateTime.Now
    //            };

    //            MantenimientoContext.Requisicions.Add(nuevo);
    //            MantenimientoContext.SaveChanges();

    //            return new Response()
    //            {
    //                Id = nuevo.IdRequisicion,
    //                Status = StatusCodes.Status200OK,
    //                Message = "Requisición agregada correctamente."
    //            };
    //        } catch (Exception ex)
    //        {
    //            return new Response()
    //            {
    //                Id = 0,
    //                Status = StatusCodes.Status400BadRequest,
    //                Message = ex.InnerException?.Message ?? ex.Message
    //            };
    //        }
    //    }


    //    public Response ActualizarRequisicion(RequisicionInsertar requisicion)
    //    {
    //        try
    //        {
    //            var actualizado = MantenimientoContext.Requisicions
    //            .Include(r => r.IdMovimientos)
    //            .Where(r => r.IdRequisicion == requisicion.IdRequisicion).FirstOrDefault();

    //            MantenimientoContext.MovimientoInsumos.RemoveRange(actualizado.IdMovimientos);

    //            actualizado.IdRequisicion = requisicion.IdRequisicion;
    //            actualizado.Folio = requisicion.Folio;
    //            actualizado.IdAlmacen = requisicion.IdAlmacen;
    //            actualizado.IdSistema = requisicion.IdSistema;
    //            actualizado.IdRequisicionEstatus = requisicion.IdRequisicionEstatus;
    //            actualizado.IdEmpresa = requisicion.IdEmpresa;
    //            actualizado.Nombre = requisicion.Nombre;
    //            actualizado.Minimo = 0;
    //            actualizado.Maximo = 0;
    //            actualizado.MotivoCancelacion = requisicion.MotivoCancelacion;
    //            actualizado.IdMantenimiento = requisicion.IdMantenimiento ?? throw new Exception("La requisición debe estar relacionada a una orden de trabajo");
    //            actualizado.IdMovimientos = requisicion.Insumos.Select(i => new DL.Models.MovimientoInsumo
    //            {
    //                IdMovimiento = 0,
    //                IdInsumo = i.IdInsumo,
    //                Cantidad = i.Cantidad,
    //                Costo = null,
    //                Total = null,
    //                Factura = null,
    //                Observaciones = i.Observaciones,
    //                IdUsuario = requisicion.IdModifico
    //            }).ToList();
    //            actualizado.IdIngreso = actualizado.IdIngreso;
    //            actualizado.IdModifico = requisicion.IdModifico;
    //            actualizado.Estatus = actualizado.Estatus;
    //            actualizado.FechaIngreso = actualizado.FechaIngreso;
    //            actualizado.FechaModifico = DateTime.Now;

    //            MantenimientoContext.Requisicions.Update(actualizado);
    //            MantenimientoContext.SaveChanges();

    //            return new Response()
    //            {
    //                Id = actualizado.IdRequisicion,
    //                Status = StatusCodes.Status200OK,
    //                Message = "Requisición actualizada correctamente."
    //            };

    //        }catch (Exception ex)
    //        {
    //            return new Response()
    //            {
    //                Id = 0,
    //                Status = StatusCodes.Status400BadRequest,
    //                Message = ex.InnerException?.Message ?? ex.Message
    //            };
    //        }
    //    }


    //    public Response EliminarRequisicion(int idRequisicion)
    //    {
    //        var baja = MantenimientoContext.Requisicions.Where(r => r.IdRequisicion == idRequisicion).First();
    //        baja.Estatus = "B";
    //        MantenimientoContext.Requisicions.Update(baja);
    //        MantenimientoContext.SaveChanges();

    //        return new Response()
    //        {
    //            Id = baja.IdRequisicion,
    //            Status = StatusCodes.Status200OK,
    //            Message = "Requisición eliminada correctamente."
    //        };
    //    }


    //    public bool DescargarLayoutRequisicionExcel(string rutaArchivo, int idEmpresa)
    //    {
    //        var rutaLayout = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Assets/Format", "Formato Requisiciones.xlsx");

    //        var catalogos = new
    //        {
    //            Almacenes = new AlmacenBusiness(MantenimientoContext).ConsultarAlmacen(new AlmacenFiltros() { IdEmpresa = idEmpresa }).ToArray(),
    //            Insumos = new InsumoBusiness(MantenimientoContext).ConsultarInsumo(new InsumoFiltros() { idEmpresa = idEmpresa }).ToArray(),
    //            EstatusRequisicion = new CatalogoBusiness(MantenimientoContext).ConsultarEstatusRequisicion().ToArray()
    //        };

    //        try
    //        {


    //            File.Copy(rutaLayout, rutaArchivo, true);

    //            using var wbook = new XLWorkbook(rutaArchivo);
    //            var doc = wbook.Worksheet("Catálogos");


    //            for (int i = 0; i < catalogos.Insumos.Count(); i++)
    //            {
    //                doc.Cell(i + 2, 1).Value = catalogos.Insumos[i].Nombre;
    //            }
    //            for (int i = 0; i < catalogos.Almacenes.Count(); i++)
    //            {
    //                doc.Cell(i + 2, 2).Value = catalogos.Almacenes[i].Nombre;
    //            }

    //            for (int i = 0; i < catalogos.EstatusRequisicion.Count(); i++)
    //            {
    //                doc.Cell(i + 2, 3).Value = catalogos.EstatusRequisicion[i].Nombre;
    //            }
    //            wbook.SaveAs(rutaArchivo);

    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception(ex.Message + " " + rutaArchivo);
    //        }
    //        return true;

    //    }

    //    public dynamic ExportarRequisicionExcel(RequisicionFiltros filtros)
    //    {
    //        var rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Assets/Temporal/Requisiciones{filtros.idEmpresa}.xlsx");
    //        var insumos = MantenimientoContext.Insumos.Where(i => i.IdEmpresa == filtros.idEmpresa).ToArray();

    //        List<object> requisiciones = new List<object>();
    //        ConsultarRequisicion(filtros).ToList().ForEach(r => requisiciones.AddRange(r.Insumos.Select(i => new
    //        {
    //            Folio = r.Folio ?? "",
    //            Nombre = r.Nombre,
    //            Insumo = insumos.Where(ins => ins.IdInsumo == i.IdInsumo).FirstOrDefault().Nombre,
    //            CantidadSolicitada = i.Cantidad.ToString(),
    //            Almacen = r.AlmacenNombre,
    //            Observaciones = i.Observaciones,
    //            Ingreso = r.Usuario,
    //            FechaIngreso = r.FechaIngreso.ToString()
    //        }).ToArray().ToList<object>()));

    //        GeneradorExcel oCreadorExcel = new GeneradorExcel(rutaArchivo);

    //        oCreadorExcel.CrearReporteConsulta(new EncabezadosExcel().ConsultaRequisicionHeaders, 
    //            new DetallesExcel { 
    //                Titulo = "Requisiciones",
    //                FechaCreacion = DateTime.Now.ToString("dd/MM/yyyy")
    //            }, requisiciones);
    //        return rutaArchivo;
    //    }   


    //    public string GetBasePath() => AppDomain.CurrentDomain.BaseDirectory;

    //    public IEnumerable<Response> CargaMasivaRequisiciones(IFormFile file, int? idEmpresa)
    //    {
    //        var lectorExcel = new LectorExcel();
    //        lectorExcel.Leer(file);
    //        var datos = lectorExcel.ObtenerDatos();

    //        var catalogos = new
    //        {
    //            Almacenes = new AlmacenBusiness(MantenimientoContext).ConsultarAlmacen(new AlmacenFiltros() { IdEmpresa = (int) idEmpresa }),
    //            Insumos = new InsumoBusiness(MantenimientoContext).ConsultarInsumo(new InsumoFiltros() { idEmpresa = 999 }),
    //            EstatusRequisicion = new CatalogoBusiness(MantenimientoContext).ConsultarEstatusRequisicion()
    //        };

    //        var requisiciones = new ExcelModelBuilder().ConvertirRequisiciones(datos, catalogos);

    //        List<Response> responses = new List<Response>();
    //        foreach (RequisicionInsertar requisicion in requisiciones)
    //        {
    //            responses.Add(AgregarRequisicion(requisicion));
    //        }

    //        return responses;
    //    }
    }
}
