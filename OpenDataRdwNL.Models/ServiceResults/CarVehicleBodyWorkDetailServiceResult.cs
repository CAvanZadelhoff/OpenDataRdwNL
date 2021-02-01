using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarVehicleBodyWorkDetailServiceResult
    {
        public CarVehicleBodyWorkDetailServiceResult ToServiceResult(OpenDataRdwNlLanguage lang,CarVehicleBodyWorkDetailApiResponse ap)
        {
            return lang == OpenDataRdwNlLanguage.En
                ? (CarVehicleBodyWorkDetailServiceResult) new CarVehicleBodyWorkDetailEnServiceResult(ap)
                : new CarVehicleBodyWorkDetailNlServiceResult(ap);
        }
    }

    public class CarVehicleBodyWorkDetailNlServiceResult : CarVehicleBodyWorkDetailServiceResult
    {
        public string Kentaken { get; set; }
        public int CarrosserieVolgnummer { get; set; }
        public string Carrosserietype { get; set; }
        public string TypeCarrosserieEuropeseOmschrijving { get; set; }
        public CarVehicleBodyWorkDetailNlServiceResult(CarVehicleBodyWorkDetailApiResponse ap)
        {
            Kentaken = ap.kentaken;
            CarrosserieVolgnummer = ap.carrosserie_volgnummer;
            Carrosserietype = ap.carrosserietype;
            TypeCarrosserieEuropeseOmschrijving = ap.type_carrosserie_europese_omschrijving;
        }
    }

    public class CarVehicleBodyWorkDetailEnServiceResult : CarVehicleBodyWorkDetailServiceResult
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