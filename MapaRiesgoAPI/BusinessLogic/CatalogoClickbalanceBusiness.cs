using LISTMS.DL.Models;
using Mantenimiento.API.Classes;
using Mantenimiento.API.Interfaces;
using WSLISTMSClickbalance;

namespace MantenimientoAPI.BusinessLogic
{
    public class CatalogoClickbalanceBusiness : ICatalogoClickbalance
    {
        public struct CredentialsCB
        {
            public string UsuarioCB { get; set; }
            public string ContraseñaCB { get; set; }
            public string EmpresaCB { get; set; }
        }


        private ListmsContext _listmsContext;
        private HttpContext HttpContext;
        private CredentialsCB credencialsCB;
        public CatalogoClickbalanceBusiness(ListmsContext listmsContext, HttpContext httpContext)
        {
            _listmsContext = listmsContext;
            HttpContext = httpContext;


            credencialsCB = new CredentialsCB
            {
                UsuarioCB = HttpContext.Request.Headers.Where(request => request.Key == "UsuarioCB").First().Value,
                ContraseñaCB = HttpContext.Request.Headers.Where(request => request.Key == "ContraseñaCB").First().Value,
                EmpresaCB = HttpContext.Request.Headers.Where(request => request.Key == "EmpresaCB").First().Value,
            };

            //var headers = HttpContext.Request.Headers.ToDictionary(o => o.Key, o => o.Value);

            //var x = headers.Select(h  => new CredentialsCB {
            //    UsuarioCB = h.,
            //    ContraseñaCB = h["ContraseñaCB"].ToString(),
            //    EmpresaCB = h["EmpresaCB"].ToString(),
            //});
        }

        public Response<object> ObtenerAlmacenes()
        {
            var clickbalance = new WSLISTMSClickbalance.WSLISTMSClickBalanceSoapClient(new WSLISTMSClickBalanceSoapClient.EndpointConfiguration());
            //var clickbalance = new WSLISTMSClickbalance.WSLISTMSClickBalanceSoapClient(new WSLISTMSClickBalanceSoapClient.EndpointConfiguration(), "http://localhost/WSLISTMS-CLICKBALANCE/Clickbalance/WSLISTMSClickBalance.asmx");


            var x = clickbalance.GetAlmacenes2CBAsync(credencialsCB.UsuarioCB, credencialsCB.ContraseñaCB, credencialsCB.EmpresaCB).Result;

            if (x.HasError)
                throw new Exception(x.Message);

            return new Response<object>
            {
                Id = 0,
                Status = (int)StatusCodes.Status200OK,
                HasError = false,
                Message = "Ok",
                Data = x.Data
            };
        }

        public Response<dynamic> ObtenerExistencias(int idAlmacen)
        {
            if (idAlmacen == 0)
                idAlmacen = 1;

            var clickbalance = new WSLISTMSClickbalance.WSLISTMSClickBalanceSoapClient(new WSLISTMSClickBalanceSoapClient.EndpointConfiguration());

            var response1 = clickbalance.GetProductos2CBAsync(credencialsCB.UsuarioCB, credencialsCB.ContraseñaCB, credencialsCB.EmpresaCB, "").Result;


            var response2 = clickbalance.GetExistenciasCBAsync(credencialsCB.UsuarioCB, credencialsCB.ContraseñaCB, credencialsCB.EmpresaCB, idAlmacen.ToString(), "").Result;


            if (response1.HasError || response2.HasError)
                throw new Exception(response1.Message + response2.Message);

            var productos = response1.Data;
            var existencias = response2.Data;

            var result = (from e in existencias
                          join p in productos on e.idproducto equals p.id
                          select new
                          {
                              id = p.id,
                              codigo = p.codigo,
                              item = p.item,
                              nombre = p.nombre,
                              numero = p.numero,
                              moneda = p.moneda,
                              unidad_id = p.unidad_id,
                              estatus = p.estatus,
                              ultimo_costo = p.ultimo_costo,
                              precio = p.precio,
                              margen = p.margen,
                              costo_promedio = p.costo_promedio,
                              maximo = p.maximo,
                              minimo = p.minimo,
                              codigo_barra = p.codigo_barra,
                              kit = p.kit,
                              maneja_series = p.maneja_series,
                              costeo = p.costeo,
                              caducidad = p.caducidad,
                              tiempo_reposicion = p.tiempo_reposicion,
                              descripcion = p.descripcion,
                              grupo_id = p.grupo_id,
                              tasa_iva = p.tasa_iva,
                              tasa_ieps = p.tasa_ieps,
                              vender = p.vender,
                              permite_reservacion = p.permite_reservacion,
                              capacidad_presentacion_ieps = p.capacidad_presentacion_ieps,
                              importe_unidad_ieps = p.importe_unidad_ieps,
                              marca = p.marca,
                              imagen = p.imagen,
                              caracteristicas = p.caracteristicas,
                              idalmacen = e.idalmacen,
                              existencia = e.existencia1
                          }).ToList();


            return new Response<object>
            {
                Id = 0,
                Status = (int)StatusCodes.Status200OK,
                HasError = false,
                Message = "Ok",
                Data = result
            };
        }

        public Response<dynamic> ObtenerProveedores()
        {
            var clickbalance = new WSLISTMSClickbalance.WSLISTMSClickBalanceSoapClient(new WSLISTMSClickBalanceSoapClient.EndpointConfiguration());

            var x = clickbalance.GetProveedoresCBAsync(credencialsCB.UsuarioCB, credencialsCB.ContraseñaCB, credencialsCB.EmpresaCB, "2020-09-09|100|25").Result;

            if (x.HasError)
                throw new Exception(x.Message);

            return new Response<object>
            {
                Id = 0,
                Status = (int)StatusCodes.Status200OK,
                HasError = false,
                Message = "Ok",
                Data = x.Data
            };
        }

        public Response<dynamic> ObtenerEnviarFactura(int idAlmacen)
        {
            var clickbalance = new WSLISTMSClickbalance.WSLISTMSClickBalanceSoapClient(new WSLISTMSClickbalance.WSLISTMSClickBalanceSoapClient.EndpointConfiguration());
            var factura = new factura();

            //var factura = new ClickbalanceLocal.factura(
            //    tipodocumentoField = ,
            //    fechaField,
            //    fecha_entregaField,
            //    receptorField,
            //    iddireccionentregaField,
            //    razon_social_comp_idField,
            //    idagenteField,
            //    tipopagoField,
            //    metodoDePagoField,
            //    refDePagoField,
            //    subtotalField,
            //    descuentoField,
            //    iepsField,
            //    ivaField,
            //    isrretenidoField,
            //    ivaretenidoField,
            //    totalField,
            //    idaddendaField,
            //    addendaField,
            //    observacionesField,
            //    referenciaField,
            //    moneda_idField,
            //    tipo_cambioField,
            //    texto_adicional_1Field,
            //    texto_adicional_2Field,
            //    texto_adicional_3Field,
            //    texto_adicional_4Field,
            //    texto_adicional_5Field,
            //    texto_adicional_6Field,
            //    texto_adicional_7Field,
            //    texto_adicional_8Field,
            //    texto_adicional_9Field,
            //    texto_adicional_10Field,
            //    codigo_transaccionField,
            //    folioField,
            //    desglose_iepsField,
            //    sat_uso_cfdi_idField,
            //    clave_uso_cfdiField,
            //    asignar_folio_siguiente_si_esta_ocupadoField,
            //    comercio_exteriorField,
            //    nodo_addendaField,
            //    documento_produccion_idField,
            //    regimen_clave_satField,
            //    xmlField,
            //    uuidField,
            //    fecha_timbradoField,
            //    sello_satField,
            //    certificado_satField,
            //    certificadoField,
            //    version_timbreField,
            //    sello_digitalField,
            //    cadena_originalField,
            //    sat_exportacionField,
            //    carta_porteField,
            //    estatusField,
            //    [] conceptosField,
            //    [] implocalesField,
            //    [] ventaFormasDePagoField,
            //    [] documentos_relacionadosField,
            //    [] ventaLeyendasFiscalesField,
            //    );



            var respuesta = clickbalance.EnviaFactura2CBAsync(credencialsCB.UsuarioCB, credencialsCB.ContraseñaCB, credencialsCB.EmpresaCB, "1",factura).Result;

            if (respuesta.HasError)
                throw new Exception(respuesta.Message);

            return new Response<object>
            {
                Id = 0,
                Status = (int)StatusCodes.Status200OK,
                HasError = false,
                Message = "Ok",
                Data = respuesta.Data
            };
        }
    }
}
