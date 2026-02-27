namespace ElectronicDataInterchange.API.Classes.Modelo.EDI990
{
    /// <summary>
    /// Clase raíz para la respuesta de carga (Load Tender Response).
    /// Estructura basada en la especificación JSON 990.
    /// </summary>
    public class LoadTenderResponse
    {
        // --- SECCIÓN: Message Details (Detalles del Mensaje) ---
        public MessageDetails messageDetails { get; set; }
        

        // --- SECCIÓN: Segmentos y Detalles ---

        /// <summary>
        /// Segmento de inicio para Reserva o Entrega de Recogida.
        /// </summary>
        public IEnumerable<BeginningSegment> beginningSegment { get; set; }

        ///// <summary>
        ///// Instrucciones de negocio y números de referencia.
        ///// </summary>
        public IEnumerable<BusinessInstruction> BusinessInstructions { get; set; }

        ///// <summary>
        ///// Detalles del equipo (camión/remolque).
        ///// </summary>
        public EquipmentDetails EquipmentDetails { get; set; }

        ///// <summary>
        ///// Comentarios o notas de forma libre.
        ///// </summary>
        public IEnumerable<Remark> Remarks { get; set; }

        ///// <summary>
        ///// Fechas y horas específicas.
        ///// </summary>
        public List<DateTimeInfo> DateTimes { get; set; }
    }

    public class MessageDetails
    {
        /// <summary>
        /// Código de identificación publicado por el remitente.
        /// Requisito: Obligatorio (Mandatory)
        /// </summary>

        public string Sender { get; set; }

        /// <summary>
        /// Código de identificación publicado por el receptor.
        /// Requisito: Obligatorio (Mandatory)
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Tipo de mensaje (ej. "990_CarrierLoadTenderResponse").
        /// Requisito: Obligatorio (Mandatory)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fecha de procesamiento del remitente (CCYYMMDD).
        /// Requisito: Obligatorio (Mandatory)
        /// </summary>
        public string TransmitDate { get; set; }

        /// <summary>
        /// Hora de procesamiento del remitente (HHMMSS).
        /// Requisito: Obligatorio (Mandatory)
        /// </summary>
        public string TransmitTime { get; set; }
    }



    /// <summary>
    /// Representa el segmento de inicio (Beginning Segment).
    /// </summary>
    public class BeginningSegment
    {
        /// <summary>
        /// Código SCAC (Standard Carrier Alpha Code).
        /// </summary>
        public string StandardCarrierAlphaCode { get; set; }

        /// <summary>
        /// Identificador único del envío (Shipment ID).
        /// </summary>
        public string ShipmentIdentificationNumber { get; set; }

        /// <summary>
        /// Fecha expresada como CCYYMMDD.
        /// </summary>
        public string DateValue { get; set; }

        /// <summary>
        /// Código de acción: A = Aceptado, D = Declinado, R = Rechazado.
        /// </summary>
        public string ReservationActionCode { get; set; }
    }

    /// <summary>
    /// Representa instrucciones de negocio y referencias.
    /// </summary>
    public class BusinessInstruction
    {
        public string ReferenceValue { get; set; }

        public string ReferenceType { get; set; }
    }

    /// <summary>
    /// Detalles del equipo.
    /// </summary>
    public class EquipmentDetails
    {
        public string EquipmentNumber { get; set; }
    }

    /// <summary>
    /// Comentarios de forma libre.
    /// </summary>
    public class Remark
    {
        public string FreeFormMessage { get; set; }
    }

    /// <summary>
    /// Información de Fechas y Horas.
    /// </summary>
    public class DateTimeInfo
    {
        public string DateQualifier { get; set; }

        public string DateValue { get; set; }

        public string TimeQualifier { get; set; }

        public string TimeValue { get; set; }
    }
}
