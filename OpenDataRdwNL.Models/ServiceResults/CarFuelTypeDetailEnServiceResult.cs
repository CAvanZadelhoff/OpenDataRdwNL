using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarFuelTypeDetailEnServiceResult
    {
        public string LicensePlate { get; set; }
        public int FuelSequenceNumber  { get; set; }
        public string FuelDescription { get; set; }
        public string EmissionCodeDescription  { get; set; }
        public double RatedContinuousMaximumPower  { get; set; }
        public int ElectricalConsumptionExternChargingWltp  { get; set; }
        public int ActionRadiusExternChargingWltp  { get; set; }
        public int ActionRadiusExternChargingCityWltp  { get; set; }
        public int MaxPower60Minutes  { get; set; }
        public int NetMaxPowerElectric  { get; set; }
        public string ClassHybridElectricVehicle  { get; set; }
        public CarFuelTypeDetailEnServiceResult(CarFuelTypeDetailApiResponse ap)
        {
            LicensePlate = ap.kenteken;
            FuelSequenceNumber = ap.brandstof_volgnummer;
            FuelDescription = ap.brandstof_omschrijving;
            EmissionCodeDescription = ap.emissiecode_omschrijving;
            RatedContinuousMaximumPower = ap.nominaal_continu_maximumvermogen;
            ElectricalConsumptionExternChargingWltp = ap.elektrisch_verbruik_extern_opladen_wltp;
            ActionRadiusExternChargingWltp = ap.actie_radius_extern_opladen_wltp;
            ActionRadiusExternChargingCityWltp = ap.actie_radius_extern_opladen_stad_wltp;
            MaxPower60Minutes = ap.max_vermogen_60_minuten;
            NetMaxPowerElectric = ap.netto_max_vermogen_elektrisch;
            ClassHybridElectricVehicle = ap.klasse_hybride_elektrisch_voertuig;
        }
    }
}