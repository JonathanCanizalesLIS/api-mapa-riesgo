namespace ElectronicDataInterchange.API.Constants
{
    public class EncabezadosExcel
    {
        public string[] ConsultaViajeHeaders = new string[]
        {
            "NO. DE VIAJE",
            "UNIDAD",
            "REMOLQUE",
            "OPERADOR",
            "RUTA",
            "km RECORRIDOS",
            "FECHA SALIDA",
            "GUIAS / CP",
            "CLIENTE",
            "ESTATUS",
            "ESTATUS ROUTECH",
            "FECHA INGRESO",
        };

        public string[] ConsultaUnidadesDisponiblesHeaders = new string[]
        {
            "UNIDAD",
            "ÚLTIMO DESTINO",
            "ULTIMA POSICION",
            "TIPO DE UNIDAD",
            "PEDIDO",
        };

        public string[] ConsultaUnidadesTallerHeaders = new string[]
        {
            "ORDEN DE TRABAJO",
            "UNIDAD",
            "ESTATUS",
            "FECHA INGRESO TALLER",
            "DIAS EN TALLER",
        };

        public string[] ConsultaPedidosHeaders = new string[]
        {
            "PEDIDO",
            "CLIENTE",
            "REMITENTE",
            "DESTINATARIO",
            "RUTA",
        };

    }
}
