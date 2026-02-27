using System;
using System.Collections.Generic;

namespace ElectronicDataInterchange.API.Classes.Modelo.EDI204
{

    /// <summary>
    /// Clase raíz que representa el mensaje de licitación de carga (Load Tender - 204).
    /// Basado en Schneider JSON 204 Load Tender Specifications.
    /// </summary>
    public class LoadTenderTransaction
    {
        /// <summary>
        /// Detalles del mensaje y enrutamiento.
        /// Requerido: Mandatorio.
        /// </summary>
        public MessageDetails messageDetails { get; set; }

        /// <summary>
        /// Segmento de inicio para la información del envío.
        /// Requerido: Mandatorio.
        /// </summary>
        public BeginningSegment beginningSegmentForShipmentInformationTransaction { get; set; }

        /// <summary>
        /// Propósito del conjunto de transacciones.
        /// Requerido: Mandatorio.
        /// </summary>
        public SetPurpose setPurpose { get; set; }

        /// <summary>
        /// Instrucciones comerciales y números de referencia.
        /// Requerido: Mandatorio. Ocurrencia: Múltiple.
        /// </summary>
        public List<BusinessInstruction> businessInstructionsAndReferenceNumber { get; set; }

        /// <summary>
        /// Información de fecha y hora del encabezado.
        /// Requerido: Mandatorio.
        /// </summary>
        public DateTimeDetail dateTime { get; set; }

        /// <summary>
        /// Notas o instrucciones especiales.
        /// Requerido: Opcional. Max Ocurrencia: 10.
        /// </summary>
        public NoteSpecialInstruction noteSpecialInstruction { get; set; }

        /// <summary>
        /// Identificación de las partes involucradas (ej. Shipper, Receiver).
        /// Requerido: Opcional.
        /// </summary>
        public PartyIdentification partyIdentification { get; set; }

        /// <summary>
        /// Ubicación física de la parte.
        /// Requerido: Opcional.
        /// </summary>
        public PartyLocation? partyLocation { get; set; }

        /// <summary>
        /// Ubicación geográfica (Ciudad, Estado, CP).
        /// Requerido: Opcional.
        /// </summary>
        public GeographicLocation geographicLocation { get; set; }

        /// <summary>
        /// Detalles del equipo requerido para el transporte.
        /// Requerido: Mandatorio.
        /// </summary>
        public EquipmentDetails equipmentDetails { get; set; }

        /// <summary>
        /// Lista de paradas (Stops) detalladas.
        /// Requerido: Mandatorio.
        /// </summary>
        public List<StopDetailWrapper> stopDetails { get; set; }

        /// <summary>
        /// Pesos y cargos totales.
        /// Requerido: Opcional.
        /// </summary>
        public List<TotalWeightAndCharges> totalWeightAndCharges { get; set; }
    }

    /// <summary>
    /// Detalles de cabecera del mensaje.
    /// </summary>
    public class MessageDetails
    {
        /// <summary>
        /// Código de identificación publicado por el remitente.
        /// </summary>
        public string sender { get; set; }

        /// <summary>
        /// Código de identificación publicado por el receptor.
        /// </summary>
        public string receiver { get; set; }

        /// <summary>
        /// Mensaje de transacción que se transmite.
        /// </summary>
        public string name { get; set; }
    }

    /// <summary>
    /// Segmento inicial de información del envío.
    /// </summary>
    public class BeginningSegment
    {
        public string standardCarrierAlphaCode { get; set; }
        public string shipmentIdentificationNumber { get; set; }
        public string shipmentMethodOfPaymentCode { get; set; }
    }

    /// <summary>
    /// Propósito y tipo de aplicación de la transacción.
    /// </summary>
    public class SetPurpose
    {
        public string transactionSetPurposeCode { get; set; }
        public string applicationTypeCode { get; set; }
    }

    /// <summary>
    /// Instrucciones de negocio y números de referencia.
    /// </summary>
    public class BusinessInstruction
    {
        public string referenceValue { get; set; }
        public string referenceType { get; set; }
    }

    /// <summary>
    /// Estructura común para fecha y hora.
    /// </summary>
    public class DateTimeDetail
    {
        public string dateQualifier { get; set; }

        // En C# 'date' no es palabra reservada, pero se puede usar @ si se desea.
        public string date { get; set; }
        public string timeQualifier { get; set; }
        public string? time { get; set; }
        public string? timeCode { get; set; }
    }

    /// <summary>
    /// Instrucciones especiales.
    /// </summary>
    public class NoteSpecialInstruction
    {
        public string noteReferenceCode { get; set; }
    }

    /// <summary>
    /// Identificación de una parte (organización, entidad).
    /// </summary>
    public class PartyIdentification
    {
        public string entityIdentifierCode { get; set; }
        public string name { get; set; }
        public string identificationCodeQualifier { get; set; }
        public string identificationCode { get; set; }
    }

    /// <summary>
    /// Ubicación física de una parte.
    /// </summary>
    public class PartyLocation
    {
        public string? addressInformation { get; set; }
        public string? addressInformation1 { get; set; }
        public string? addressInformation2 { get; set; }
        public string? addressInformation3 { get; set; }
    }

    /// <summary>
    /// Ubicación geográfica estándar.
    /// </summary>
    public class GeographicLocation
    {
        public string cityName { get; set; }
        public string stateOrProvinceCode { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
    }

    /// <summary>
    /// Detalles del equipo (camión/contenedor).
    /// </summary>
    public class EquipmentDetails
    {
        public string equipmentNumber { get; set; }
        public string equipmentDescriptionCode { get; set; }
        public string equipmentLength { get; set; }
    }

    /// <summary>
    /// Contenedor para los detalles de una parada (Stop).
    /// </summary>
    public class StopDetailWrapper
    {
        public List<StopOffDetail> stopOffDetails { get; set; }
        public List<DateTimeDetail> dateTime { get; set; }
        public List<LadingDetail> ladingDetail { get; set; }
        public List<LocationDetail> locations { get; set; }
    }

    /// <summary>
    /// Detalles de secuencia y razón de la parada.
    /// </summary>
    public class StopOffDetail
    {
        public string stopSequenceNumber { get; set; }
        public string stopReasonCode { get; set; }
    }

    /// <summary>
    /// Detalle de la mercancía (Lading).
    /// </summary>
    public class LadingDetail
    {
        public string packagingFormCode { get; set; }
        public string ladingQuantity { get; set; }
        public string weightUnitCode { get; set; }
        public string weight { get; set; }
        public string productServiceIdType { get; set; }
        public string productServiceId { get; set; }
        public string ladingDescription { get; set; }
    }

    /// <summary>
    /// Detalles de ubicación dentro de una parada (Stop).
    /// </summary>
    public class LocationDetail
    {
        public List<PartyIdentification> partyIdentification { get; set; }
        public List<PartyLocation> partyLocation { get; set; }
        public List<GeographicLocation> geographicLocation { get; set; }
        public List<Contact> contact { get; set; }
    }

    /// <summary>
    /// Información de contacto.
    /// </summary>
    public class Contact
    {
        public string contactFunctionCode { get; set; }
        public string name { get; set; }
        public string communicationNumberQualifier { get; set; }
        public string communicationNumber { get; set; }
    }

    /// <summary>
    /// Resumen de pesos y cargos totales.
    /// </summary>
    public class TotalWeightAndCharges
    {
        public string? weight { get; set; }
        public string? weightQualifier { get; set; }
        public string? volume { get; set; }
        public string? volumeUnitQualifier { get; set; }
        public string? ladingQuantity { get; set; }
        public string? amountCharged { get; set; }
        public string? freightRate { get; set; }
    }
}

