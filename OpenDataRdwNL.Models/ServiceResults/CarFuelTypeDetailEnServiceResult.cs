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
        public decimal NetMaxPowerElectric  { get; set; }
        public string ClassHybridElectricVehicle  { get; set; }
        public CarFuelTypeDetailEnServiceResult(CarFuelTypeDetailApiResponse ap)
        {
            LicensePlate = ap.kenteken;
            FuelSequenceNumber = ap.brandstof_volgnummer;
            FuelDescription = ap.brandstof_omschrijving;
            
            FuelConsumptionOutside = ap.brandstofverbruik_buiten;
            FuelConsumptionCombined = ap.brandstofverbruik_gecombineerd;
            FuelConsumptionCity = ap.brandstofverbruik_stad;
            Co2EmissionsCombined = ap.co2_uitstoot_gecombineerd;
            DrivingNoiseLevel = ap.geluidsniveau_rijdend;
            NoiseLevelStationary = ap.geluidsniveau_stationair;
            SpeedNoiseLevel = ap.toerental_geluidsniveau;
            EnvironmentalClassEgApprovalLight = ap.milieuklasse_eg_goedkeuring_licht;
            MaximumNetEquity = ap.nettomaximumvermogen;
            
            EmissionCodeDescription = ap.emissiecode_omschrijving;
            RatedContinuousMaximumPower = ap.nominaal_continu_maximumvermogen;
            ElectricalConsumptionExternChargingWltp = ap.elektrisch_verbruik_extern_opladen_wltp;
            ActionRadiusExternChargingWltp = ap.actie_radius_extern_opladen_wltp;
            ActionRadiusExternChargingCityWltp = ap.actie_radius_extern_opladen_stad_wltp;
            MaxPower60Minutes = ap.max_vermogen_60_minuten;
            NetMaxPowerElectric = ap.netto_max_vermogen_elektrisch;
            ClassHybridElectricVehicle = ap.klasse_hybride_elektrisch_voertuig;
        }

        public decimal MaximumNetEquity { get; set; }

        public int SpeedNoiseLevel { get; set; }

        public string EnvironmentalClassEgApprovalLight { get; set; }

        public int NoiseLevelStationary { get; set; }

        public int DrivingNoiseLevel { get; set; }

        public decimal Co2EmissionsCombined { get; set; }

        public decimal FuelConsumptionCity { get; set; }

        public decimal FuelConsumptionCombined { get; set; }

        public decimal FuelConsumptionOutside { get; set; }
    }
}