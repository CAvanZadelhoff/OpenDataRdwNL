using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarFuelTypeDetailServiceResult
    {
        public CarFuelTypeDetailServiceResult ToServiceResult(OpenDataRdwNlLanguage lang,CarFuelTypeDetailApiResponse ap)
        {
            return lang == OpenDataRdwNlLanguage.En
                ? (CarFuelTypeDetailServiceResult) new CarFuelTypeDetailEnServiceResult(ap)
                : new CarFuelTypeDetailNlServiceResult(ap);
        }
    }

    public class CarFuelTypeDetailNlServiceResult : CarFuelTypeDetailServiceResult
    {
        public string Kenteken { get; set; }
        public int BrandstofVolgnummer { get; set; }
        public string BrandstofOmschrijving { get; set; }
        public string EmissiecodeOmschrijving { get; set; }
        public double NominaalContinuMaximumvermogen { get; set; }
        public int ElektrischVerbruikExternOpladenWltp { get; set; }
        public int ActieRadiusExternOpladenWltp { get; set; }
        public int ActieRadiusExternOpladenStadWltp { get; set; }
        public int MaxVermogen60Minuten { get; set; }
        public int NettoMaxVermogenElektrisch { get; set; }
        public string KlasseHybrideElektrischVoertuig { get; set; }
        public CarFuelTypeDetailNlServiceResult(CarFuelTypeDetailApiResponse ap)
        {
            Kenteken = ap.kenteken;
            BrandstofVolgnummer = ap.brandstof_volgnummer;
            BrandstofOmschrijving = ap.brandstof_omschrijving;
            EmissiecodeOmschrijving = ap.emissiecode_omschrijving;
            NominaalContinuMaximumvermogen = ap.nominaal_continu_maximumvermogen;
            ElektrischVerbruikExternOpladenWltp = ap.elektrisch_verbruik_extern_opladen_wltp;
            ActieRadiusExternOpladenWltp = ap.actie_radius_extern_opladen_wltp;
            ActieRadiusExternOpladenStadWltp = ap.actie_radius_extern_opladen_stad_wltp;
            MaxVermogen60Minuten = ap.max_vermogen_60_minuten;
            NettoMaxVermogenElektrisch = ap.netto_max_vermogen_elektrisch;
            KlasseHybrideElektrischVoertuig = ap.klasse_hybride_elektrisch_voertuig;
        }
    }

    public class CarFuelTypeDetailEnServiceResult : CarFuelTypeDetailServiceResult
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