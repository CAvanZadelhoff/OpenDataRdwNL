using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarVehicleBodyWorkDetailNlServiceResult
    {
        public string Kenteken { get; set; }
        public int CarrosserieVolgnummer { get; set; }
        public string Carrosserietype { get; set; }
        public string TypeCarrosserieEuropeseOmschrijving { get; set; }
        public CarVehicleBodyWorkDetailNlServiceResult(CarVehicleBodyWorkDetailApiResponse ap)
        {
            Kenteken = ap.kenteken;
            CarrosserieVolgnummer = ap.carrosserie_volgnummer;
            Carrosserietype = ap.carrosserietype;
            TypeCarrosserieEuropeseOmschrijving = ap.type_carrosserie_europese_omschrijving;
        }
    }
}