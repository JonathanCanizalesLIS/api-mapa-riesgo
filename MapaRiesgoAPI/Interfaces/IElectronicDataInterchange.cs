using ElectronicDataInterchange.API.Classes.Modelo.EDI204;
using ElectronicDataInterchange.API.Classes.Modelo.EDI214;
using ElectronicDataInterchange.API.Classes.Modelo.EDI990;
using ElectronicDataInterchange.API.Classes;

namespace ElectronicDataInterchange.Interfaces
{
    public interface IElectronicDataInterchange
    {
        /// <summary>
        /// Create a new Load Tender on LISTMS system from a JSON EDI 204 schema
        /// </summary>
        /// <param name="loadTender">JSON EDI 204 schema</param>
        /// <returns></returns>
        public Response<String> LoadTenderRequest(LoadTenderTransaction loadTender);

        /// <summary>
        /// Retrieve a JSON equivalent of an EDI 990 Load Tender Response for a given shipment identification number.
        /// </summary>
        /// <param name="shipmentIdentificationNumber">e.g. SID3002345 </param>
        /// <returns></returns>
        public Response<LoadTenderResponse> RetrieveTenderConfirmationResponse(string shipmentIdentificationNumber);


        /// <summary>
        /// Retrieve a list of JSON items equivalent of an EDI 214 Shipment Status(es) for a given shipment identification number
        /// </summary>
        /// <param name="shipmentIdentificationNumber">e.g. SID3002345 </param>
        /// <returns></returns>
        public Response<IEnumerable<ShipmentStatusMessage>> RetrieveShipmentStatus(string shipmentIdentificationNumber);





    }
}
