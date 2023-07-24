using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarFuelTypeDetailEnServiceResult
    {
        public string LicensePlate { get; set; }
        public string FuelSequenceNumber { get; set; }
        public string FuelDescription { get; set; }
        public string FuelConsumptionOutOfCity { get; set; }
        public string FuelConsumptionCombined { get; set; }
        public string FuelConsumptionCity { get; set; }
        public string CO2EmissionsCombined { get; set; }
        public string CO2EmissionsWeighing { get; set; }
        public string NoiseLevelDriving { get; set; }
        public string NoiselevelStationary { get; set; }
        public string Emissionclass { get; set; }
        public string EnvironmentalClassEgApprovalLight { get; set; }
        public string EnvironmentalClassEgApprovalHeavy { get; set; }
        public string EmissionsParticlesLight { get; set; }
        public string EmissionParticlesHeavy { get; set; }
        public string NetMaximumPower { get; set; }
        public string RatedContinuousMaximumPower { get; set; }
        public string SootEmissions { get; set; }
        public string SpeedNoiselevel { get; set; }
        public int EmissionParticlesType1Wltp { get; set; }
        public int EmissionCo2CombinedWltp { get; set; }
        public int EmissionsCo2WeighedCombinedWltp { get; set; }
        public decimal FuelConsumptionCombinedWltp { get; set; }
        public decimal FuelConsumptionWeightCombinedWltp { get; set; }
        public decimal ElectricalConsumptionOnlyElectricWltp { get; set; }
        public int ActionRadiusOnlyElectricWltp { get; set; }
        public int ActionRadiusOnlyElectricCityWltp { get; set; }
        public decimal ElectricalConsumptionExternChargingWltp { get; set; }
        public int ActionRadiusExternChargingWltp { get; set; }
        public int ActionRadiusExternChargingCityWltp { get; set; }
        public decimal MaxPower15Minutes { get; set; }
        public decimal MaxPower60Minutes { get; set; }
        public decimal NetMaxPowerElectric { get; set; }
        public string ClassHybridElectricVehicle { get; set; }
        public int StatedMaximumSpeed { get; set; }
        public string ExhaustEmissionLevel { get; set; }

        public CarFuelTypeDetailEnServiceResult(CarFuelTypeDetailApiResponse ap)
        {
            LicensePlate = ap.kenteken;
            FuelSequenceNumber = ap.brandstof_volgnummer;
            FuelDescription = ap.brandstof_omschrijving;
            FuelConsumptionOutOfCity = ap.brandstofverbruik_buiten_de_stad;
            FuelConsumptionCombined = ap.brandstofverbruik_gecombineerd;
            FuelConsumptionCity = ap.brandstofverbruik_stad;
            CO2EmissionsCombined = ap.co2_uitstoot_gecombineerd;
            CO2EmissionsWeighing = ap.co2_uitstoot_gewogen;
            NoiseLevelDriving = ap.geluidsniveau_rijdend;
            NoiselevelStationary = ap.geluidsniveau_stationair;
            Emissionclass = ap.emissieklasse;
            EnvironmentalClassEgApprovalLight = ap.milieuklasse_eg_goedkeuring_licht;
            EnvironmentalClassEgApprovalHeavy = ap.milieuklasse_eg_goedkeuring_zwaar;
            EmissionsParticlesLight = ap.uitstoot_deeltjes_licht;
            EmissionParticlesHeavy = ap.uitstoot_deeltjes_zwaar;
            NetMaximumPower = ap.nettomaximumvermogen;
            RatedContinuousMaximumPower = ap.nominaal_continu_maximumvermogen;
            SootEmissions = ap.roetuitstoot;
            SpeedNoiselevel = ap.toerental_geluidsniveau;
            EmissionParticlesType1Wltp = ap.emissie_deeltjes_type1_wltp;
            EmissionCo2CombinedWltp = ap.emissie_co2_gecombineerd_wltp;
            EmissionsCo2WeighedCombinedWltp = ap.emissie_co2_gewogen_gecombineerd_wltp;
            FuelConsumptionCombinedWltp = ap.brandstof_verbruik_gecombineerd_wltp;
            FuelConsumptionWeightCombinedWltp = ap.brandstof_verbruik_gewogen_gecombineerd_wltp;
            ElectricalConsumptionOnlyElectricWltp = ap.elektrisch_verbruik_enkel_elektrisch_wltp;
            ActionRadiusOnlyElectricWltp = ap.actie_radius_enkel_elektrisch_wltp;
            ActionRadiusOnlyElectricCityWltp = ap.actie_radius_enkel_elektrisch_stad_wltp;
            ElectricalConsumptionExternChargingWltp = ap.elektrisch_verbruik_extern_opladen_wltp;
            ActionRadiusExternChargingWltp = ap.actie_radius_extern_opladen_wltp;
            ActionRadiusExternChargingCityWltp = ap.actie_radius_extern_opladen_stad_wltp;
            MaxPower15Minutes = ap.max_vermogen_15_minuten;
            MaxPower60Minutes = ap.max_vermogen_60_minuten;
            NetMaxPowerElectric = ap.netto_max_vermogen_elektrisch;
            ClassHybridElectricVehicle = ap.klasse_hybride_elektrisch_voertuig;
            StatedMaximumSpeed = ap.opgegeven_maximum_snelheid;
            ExhaustEmissionLevel = ap.uitlaatemissieniveau;
        }
    }
}