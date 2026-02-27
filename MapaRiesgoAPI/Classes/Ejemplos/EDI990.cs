namespace ElectronicDataInterchange.API.Classes.Ejemplos
{
    public class EDI990Data
    {
        public string json990 = "{\r\n  \"message\": {\r\n  },\r\n  \"sender\": \"XXXX\", \r\n  \"receiver\": \"YYYY\", \r\n  \"name\": \"990_CarrierLoadTender Response\", \r\n  \"transmitDate\": \"20251126\", \r\n  \"transmitTime\": \"1205\", \r\n  \"beginningSegment ForBooking OrPickup Delivery\": [ \r\n    {\r\n      \"standardCarrier AlphaCode\": \"ZZZZ\", \r\n      \"shipmentIdentification Number\": \"SH1234\", \r\n      \"date\": \"20200831\", \r\n      \"reservationActionCode\": \"А\" \r\n    }\r\n  ],\r\n  \"businessInstructionsAndReferenceNumber\": [ \r\n    {\r\n      \"referenceValue\": \"ODFS11112\", \r\n      \"referenceType\": \"IT\" \r\n    }\r\n  ],\r\n  \"equipmentDetails\": { \r\n    \"equipmentNumber\": \"AFD678899\" \r\n  }\r\n}";
    }
}
