using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarVehicleBodyWorkDetailEnServiceResult
    {
        public string LicensePlate { get; set; }
        public int BodyworkSequenceNumber { get; set; }
        public string BodyType { get; set; }
        public string BodyworkTypeEuropeanDescription { get; set; }
        public CarVehicleBodyWorkDetailEnServiceResult(CarVehicleBodyWorkDetailApiResponse ap)
        {
            LicensePlate = ap.kentaken;
            BodyworkSequenceNumber = ap.carrosserie_volgnummer;
            BodyType = ap.carrosserietype;
            BodyworkTypeEuropeanDescription = ap.type_carrosserie_europese_omschrijving;
        }
    }
}