using System;
using System.Collections.Generic;

namespace ElectronicDataInterchange.API.Classes.Modelo.EDI214
{
    /// <summary>
    /// Clase raíz basada en "214 Shipment Status Sample JSON"[cite: 141].
                /// Representa la estructura completa del mensaje de estado de envío.
                /// </summary>
    public class ShipmentStatusMessage
    {
        /// <summary>
        /// Objeto contenedor del mensaje.
        /// Max Occurrence: 1
        /// Required: Mandatory
        /// [cite: 18, 143]
                    /// </summary>
        public MessageDetails messageDetails { get; set; }


        /// <summary>
        /// Segmento de inicio para el mensaje de estado.
        /// Max Occurrence: S
        /// Required: Mandatory
        /// [cite: 30, 148]
                    /// </summary>
        public List<BeginningSegment> beginningSegmentForTransportationCarrierShipmentStatusMessage { get; set; }

        /// <summary>
        /// Instrucciones de negocio y números de referencia.
        /// Max Occurrence: S
        /// Required: Mandatory
        /// [cite: 41, 155]
                    /// </summary>
        public List<BusinessInstruction> businessInstructionsAndReferenceNumber { get; set; }

        /// <summary>
        /// Identificación de las partes involucradas (Shipper, Consignee, etc).
        /// Max Occurrence: 1
        /// Required: Mandatory
        /// [cite: 52, 161]
                    /// Nota: El nombre preserva la 'l' minúscula en 'Identification' como aparece en el PDF original.
                    /// </summary>
        public List<PartyIdentification> partyldentification { get; set; }

        /// <summary>
        /// Ubicación física de la parte.
        /// Max Occurrence: 1
        /// Required: Mandatory
        /// [cite: 65, 169]
                    /// </summary>
        public List<PartyLocation> partyLocation { get; set; }

        /// <summary>
        /// Ubicación geográfica (Ciudad, Estado, CP).
        /// Max Occurrence: 1
        /// Required: Mandatory
        /// [cite: 75, 175]
                    /// </summary>
        public List<GeographicLocation> geographicLocation { get; set; }

        /// <summary>
        /// Información de Fecha y Hora.
        /// Max Occurrence: 1
        /// Required: Mandatory
        /// [cite: 87, 183]
                    /// </summary>
        public List<DateTimeInfo> dateTime { get; set; }

        /// <summary>
        /// Detalles de línea (eventos de estado).
        /// Max Occurrence: S
        /// Requirement: Mandatory (at least one status event)
        /// [cite: 101, 192]
                    /// </summary>
        public List<LineNumberDetail> lineNumber { get; set; }
    }

    /// <summary>
    /// Segmento de inicio del mensaje.
    /// [cite: 30]
                /// </summary>
    public class BeginningSegment
    {
        /// <summary>
        /// Reference identification is the carrier's PRO Number that identifies the shipment.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 1, Max: 10
        /// [cite: 40, 150]
        /// </summary>
        public string referenceIdentification { get; set; }

        /// <summary>
        /// Identification number assigned to the shipment by the shipper.
        /// Uniquely identifies the shipment from origin to ultimate destination.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 1, Max: 30
        /// [cite: 40, 153]
                    /// </summary>
        public string shipmentIdentificationNumber { get; set; }

        /// <summary>
        /// SCAC code identifying the carrier.
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 4
        /// [cite: 40, 154]
                    /// </summary>
        public string standardCarrierAlphaCode { get; set; }
    }
    
    public class MessageDetails
    {
        /// <summary>
        /// Identification code published by the sender for other parties to use as the receiver ID.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 15, Max: 15
        /// [cite: 28, 145]
        /// </summary>
        public string sender { get; set; }

        /// <summary>
        /// Identification code published by the receiver of the data.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 15, Max: 15
        /// [cite: 28, 146]
        /// </summary>
        public string receiver { get; set; }

        /// <summary>
        /// Message type being translated.
        /// Value: TRANSPORTATION_CARRIER_SHIPMENT_STATUS_MESSAGE
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 15, Max: 80
        /// [cite: 28, 147]
        /// </summary>
        public string name { get; set; }

        public string transmitDate { get; set; }

        public string transmitTime { get; set; }
    }


    /// <summary>
    /// Instrucciones de negocio y referencias.
    /// [cite: 41, 51]
                /// </summary>
    public class BusinessInstruction
    {
        /// <summary>
        /// Reference information as defined for a particular Transaction Set.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 1, Max: 30
        /// [cite: 51, 157]
                    /// </summary>
        public string referenceValue { get; set; }

        /// <summary>
        /// Code identifying the Reference Identification.
        /// Examples: BM (BOL), CN (Consignee Ref), PO (Purchase Order).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 3
        /// [cite: 51, 158]
                    /// </summary>
        public string referenceType { get; set; }
    }

    /// <summary>
    /// Identificación de la entidad/parte.
    /// [cite: 52, 63]
                /// </summary>
    public class PartyIdentification
    {
        /// <summary>
        /// Code identifying an organizational entity, a physical location, or an individual.
        /// Examples: SH (Shipper), CN (Consignee).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 3
        /// [cite: 63, 163]
                    /// </summary>
        public string entityIdentifierCode { get; set; }

        /// <summary>
        /// Free-form name.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 1, Max: 60
        /// [cite: 63, 164]
                    /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Code specifying the system/method of code structure used for Identification Code.
        /// Example: 93 (Code assigned by the organization originating the transaction).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 1, Max: 2
        /// [cite: 63, 165]
                    /// </summary>
        public string identificationCodeQualifier { get; set; }

        /// <summary>
        /// Code identifying a party or other code.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 2, Max: 80
        /// [cite: 64, 166]
                    /// </summary>
        public string identificationCode { get; set; }
    }

    /// <summary>
    /// Ubicación de la parte (Dirección).
    /// [cite: 65, 74]
                /// </summary>
    public class PartyLocation
    {
        /// <summary>
        /// Address information.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 1, Max: 55
        /// [cite: 74, 171]
                    /// </summary>
        public string addressInformation { get; set; }

        /// <summary>
        /// Línea adicional de dirección.
        /// [cite: 172]
                    /// </summary>
        public string addressInformation1 { get; set; }
    }

    /// <summary>
    /// Ubicación Geográfica.
    /// [cite: 75, 86]
                /// </summary>
    public class GeographicLocation
    {
        /// <summary>
        /// Free-form text for city name.
        /// Type: Alphanumeric
        /// Required: Mandatory
        /// Min: 2, Max: 30
        /// [cite: 86, 177]
                    /// </summary>
        public string cityName { get; set; }

        /// <summary>
        /// Code specifying the Standard State/Province.
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 2
        /// [cite: 86, 180]
                    /// </summary>
        public string stateOrProvinceCode { get; set; }

        /// <summary>
        /// Code specifying international postal zone code (Zip code).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 3, Max: 15
        /// [cite: 86, 181]
                    /// </summary>
        public string postalCode { get; set; }

        /// <summary>
        /// Code identifying the country.
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 3
        /// [cite: 86, 182]
                    /// </summary>
        public string countryCode { get; set; }
    }

    /// <summary>
    /// Información de fecha y hora del mensaje.
    /// [cite: 87, 100]
                /// </summary>
    public class DateTimeInfo
    {
        /// <summary>
        /// Code specifying type of date.
        /// Examples: 54 (Deliver No Later Than), 53 (Deliver Not Before).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 2
        /// [cite: 100, 185]
                    /// </summary>
        public string dateQualifier { get; set; }

        /// <summary>
        /// Date expressed as CCYYMMDD.
        /// Type: Date (String in JSON)
        /// Required: Mandatory
        /// Min: 8, Max: 8
        /// [cite: 100, 186]
                    /// </summary>
        public string date { get; set; }

        /// <summary>
        /// Code specifying the reported time.
        /// Examples: 1 (Must Respond By), 2 (Pickup Appt), 3 (Delivery Appt).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 1, Max: 2
        /// [cite: 100, 187]
                    /// </summary>
        public string timeQualifier { get; set; }

        /// <summary>
        /// Time expressed in 24-hour clock time (HHMM or HHMMSS).
        /// Type: Time (String in JSON)
        /// Required: Optional
        /// Min: 4, Max: 8
        /// [cite: 100, 188]
                    /// </summary>
        public string time { get; set; }

        /// <summary>
        /// Time code (Zone).
        /// Example: GM, LT.
        /// [cite: 96, 189]
                    /// </summary>
        public string timeCode { get; set; }
    }

    /// <summary>
    /// Detalle de la línea (Line Number).
    /// Contiene el estado del envío y la ubicación del equipo.
    /// [cite: 101]
                /// </summary>
    public class LineNumberDetail
    {
        /// <summary>
        /// Assigned number for the line.
        /// [cite: 106, 195]
                    /// </summary>
        public string assigned_number { get; set; }

        /// <summary>
        /// Detalles específicos del estado del envío.
        /// [cite: 107, 196]
                    /// </summary>
        public List<ShipmentStatusDetail> shipmentStatusDetails { get; set; }

        /// <summary>
        /// Ubicación del equipo o propiedad real.
        /// Max Occurrence: 1
        /// Required: Mandatory
        /// [cite: 120, 209]
                    /// </summary>
        public List<EquipmentLocation> equipmentShipmentOrRealPropertyLocation { get; set; }

        /// <summary>
        /// Instrucciones de negocio asociadas a la línea.
        /// [cite: 218]
                    /// </summary>
        public List<BusinessInstruction> businessInstructionsAndReferenceNumber { get; set; }
    }

    /// <summary>
    /// Detalles del estado del envío.
    /// [cite: 107, 114]
                /// </summary>
    public class ShipmentStatusDetail
    {
        /// <summary>
        /// Shipment status code (aligned with AT7 codes).
        /// Examples: X1 (Arrived Pickup), X3 (Arrived Delivery), AF (Delivered), D1 (Departed).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 2
        /// [cite: 114, 137, 198]
                    /// </summary>
        public string shipmentStatusIndicatorCode { get; set; }

        /// <summary>
        /// Code indicating the reason a shipment status or appointment reason was transmitted.
        /// Example: NS (No Show).
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 1, Max: 2
        /// [cite: 114, 199]
                    /// </summary>
        public string shipmentStatusOrAppointmentReasonCode { get; set; }

        /// <summary>
        /// Code indicates the status of an appointment to pickup or deliver a shipment.
        /// Type: Identifier
        /// Required: Conditional
        /// Min: 2, Max: 2
        /// [cite: 114, 200]
                    /// </summary>
        public string shipmentAppointmentStatusCode { get; set; }

        /// <summary>
        /// Code indicating the reason a shipment status... (Variation 1).
        /// [cite: 115, 201]
                    /// </summary>
        public string shipmentStatusOrAppointmentReasonCode1 { get; set; }

        /// <summary>
        /// Date of the status event (CCYYMMDD).
        /// Type: Date
        /// Required: Mandatory
        /// [cite: 114, 202]
                    /// </summary>
        public string date { get; set; }

        /// <summary>
        /// Time of the status event (HHMM).
        /// Type: Time
        /// Required: Mandatory
        /// [cite: 114, 203]
                    /// </summary>
        public string time { get; set; }

        /// <summary>
        /// Time code (Zone).
        /// Example: LT, GM.
        /// Type: Identifier
        /// Required: Optional
        /// Min: 2, Max: 2
        /// [cite: 114, 204]
                    /// </summary>
        public string timeCode { get; set; }
    }

    /// <summary>
    /// Ubicación física del equipo.
    /// [cite: 120, 132]
                /// </summary>
    public class EquipmentLocation
    {
        /// <summary>
        /// Free-form text for city name.
        /// Type: Identifier (String)
        /// Required: Mandatory
        /// Min: 2, Max: 3
        /// [cite: 132, 211]
                    /// </summary>
        public string cityName { get; set; }

        /// <summary>
        /// Code specifying the Standard State/Province.
        /// Type: Identifier
        /// Required: Mandatory
        /// Min: 2, Max: 2
        /// [cite: 132, 212]
                    /// </summary>
        public string stateOrProvinceCode { get; set; }

        /// <summary>
        /// Code specifying international postal zone code.
        /// Type: Identifier
        /// Required: Optional
        /// Min: 2, Max: 3
        /// [cite: 134, 213]
                    /// </summary>
        public string countryCode { get; set; }

        /// <summary>
        /// Code indicating the longitude (DDDMMSS).
        /// Type: Identifier
        /// Required: Conditional
        /// Min: 7, Max: 10
        /// [cite: 134, 214]
                    /// </summary>
        public string longitudeCode { get; set; }

        /// <summary>
        /// Code indicating the latitude (DDDMMSS).
        /// Type: Identifier
        /// Required: Conditional
        /// Min: 7, Max: 10
        /// [cite: 134, 215]
                    /// </summary>
        public string latitudeCode { get; set; }
    }
}
