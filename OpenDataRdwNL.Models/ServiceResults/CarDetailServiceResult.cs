using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarDetailServiceResult
    {
        public CarDetailServiceResult ToServiceResult(OpenDataRdwNlLanguage lang,CarDetailApiResponse ap)
        {
            return lang == OpenDataRdwNlLanguage.En
                ? (CarDetailServiceResult) new CarDetailEnServiceResult(ap)
                : new CarDetailNlServiceResult(ap);
        }
    }

    public class CarDetailEnServiceResult : CarDetailServiceResult
    {
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public string TradeName { get; set; }
        public int DateRegistration { get; set; }
        public int GrossBpm { get; set; }
        public string Design { get; set; }
        public string FirstColor { get; set; }
        public string SecondColor { get; set; }
        public int MassEmptyVehicle { get; set; }
        public int PermittedMaximumMassOfVehicle { get; set; }
        public int DateOfFirstAdmission { get; set; }
        public int DateOfFirstIssueInTheNetherlands { get; set; }
        public string WaitForInspection { get; set; }
        public string WamInsured { get; set; }
        public int LoadCapacity { get; set; }
        public int AantalDeuren { get; set; }
        public int NumberOfDoors { get; set; }
        public int DistanceCenterCouplingToRearOfVehicle { get; set; }
        public int DistanceFrontVehicleToHeartLink { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string EuropeanVehicleCategory { get; set; }
        public string PlaceChassisNumber { get; set; }
        public int TechnicalMaxMassVehicle { get; set; }
        public int SequenceNumberChangeEuTypeApproval { get; set; }
        public int Wheelbase { get; set; }
        public string ExportIndicator { get; set; }
        public string PendingRecallIndicator { get; set; }
        public string TaxiIndicator { get; set; }
        public int MaximumMassComposition { get; set; }
        
        public CarDetailEnServiceResult(CarDetailApiResponse ap)
        {
            LicensePlate = ap.kenteken;
            VehicleType = ap.voertuigsoort;
            Brand = ap.merk;
            TradeName = ap.handelsbenaming;
            DateRegistration = ap.datum_tenaamstelling;
            GrossBpm = ap.bruto_bpm;
            Design = ap.inrichting;
            FirstColor = ap.eerste_kleur;
            SecondColor = ap.tweede_kleur;
            MassEmptyVehicle = ap.massa_ledig_voertuig;
            PermittedMaximumMassOfVehicle = ap.toegestane_maximum_massa_voertuig;
            DateOfFirstAdmission = ap.datum_eerste_toelating;
            DateOfFirstIssueInTheNetherlands = ap.datum_eerste_afgifte_nederland;
            WaitForInspection = ap.wacht_op_keuren;
            WamInsured = ap.wam_verzekerd;
            LoadCapacity = ap.laadvermogen;
            AantalDeuren = ap.aantal_deuren;
            NumberOfDoors = ap.aantal_wielen;
            DistanceCenterCouplingToRearOfVehicle =ap.afstand_hart_koppeling_tot_achterzijde_voertuig ;
            DistanceFrontVehicleToHeartLink = ap.afstand_voorzijde_voertuig_tot_hart_koppeling;
            Length = ap.lengte;
            Width = ap.breedte;
            EuropeanVehicleCategory = ap.europese_voertuigcategorie;
            PlaceChassisNumber = ap.plaats_chassisnummer;
            TechnicalMaxMassVehicle = ap.technische_max_massa_voertuig;
            SequenceNumberChangeEuTypeApproval = ap.volgnummer_wijziging_eu_typegoedkeuring;
            Wheelbase = ap.wielbasis;
            ExportIndicator = ap.export_indicator;
            PendingRecallIndicator = ap.openstaande_terugroepactie_indicator;
            TaxiIndicator = ap.taxi_indicator;
            MaximumMassComposition = ap.maximum_massa_samenstelling;
        }
    }

    public class CarDetailNlServiceResult : CarDetailServiceResult
    {
        public string Kenteken { get; set; }
        public string Voertuigsoort { get; set; }
        public string Merk { get; set; }
        public string Handelsbenaming { get; set; }
        public int DatumTenaamstelling { get; set; }
        public int BrutoBpm { get; set; }
        public string Inrichting { get; set; }
        public string EersteKleur { get; set; }
        public string TweedeKleur { get; set; }
        public int MassaLedigVoertuig { get; set; }
        public int ToegestaneMaximumMassaVoertuig { get; set; }
        public int DatumEersteToelating { get; set; }
        public int DatumEersteAfgifteNederland { get; set; }
        public string WachtOpKeuren { get; set; }
        public string WamVerzekerd { get; set; }
        public int Laadvermogen { get; set; }
        public int AantalDeuren { get; set; }
        public int AantalWielen { get; set; }
        public int AfstandHartKoppelingTotAchterzijdeVoertuig { get; set; }
        public int AfstandVoorzijdeVoertuigTotHartKoppeling { get; set; }
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public string EuropeseVoertuigcategorie { get; set; }
        public string PlaatsChassisnummer { get; set; }
        public int TechnischeMaxMassaVoertuig { get; set; }
        public int VolgnummerWijzigingEuTypegoedkeuring { get; set; }
        public int Wielbasis { get; set; }
        public string ExportIndicator { get; set; }
        public string OpenstaandeTerugroepactieIndicator { get; set; }
        public string TaxiIndicator { get; set; }
        public int MaximumMassaSamenstelling { get; set; }

        public CarDetailNlServiceResult(CarDetailApiResponse ap)
        {
            Kenteken = ap.kenteken;
            Voertuigsoort = ap.voertuigsoort;
            Merk = ap.merk;
            Handelsbenaming = ap.handelsbenaming;
            DatumTenaamstelling = ap.datum_tenaamstelling;
            BrutoBpm = ap.bruto_bpm;
            Inrichting = ap.inrichting;
            EersteKleur = ap.eerste_kleur;
            TweedeKleur = ap.tweede_kleur;
            MassaLedigVoertuig = ap.massa_ledig_voertuig;
            ToegestaneMaximumMassaVoertuig = ap.toegestane_maximum_massa_voertuig;
            DatumEersteToelating = ap.datum_eerste_toelating;
            DatumEersteAfgifteNederland = ap.datum_eerste_afgifte_nederland;
            WachtOpKeuren = ap.wacht_op_keuren;
            WamVerzekerd = ap.wam_verzekerd;
            Laadvermogen = ap.laadvermogen;
            AantalDeuren = ap.aantal_deuren;
            AantalWielen = ap.aantal_wielen;
            AfstandHartKoppelingTotAchterzijdeVoertuig =ap.afstand_hart_koppeling_tot_achterzijde_voertuig ;
            AfstandVoorzijdeVoertuigTotHartKoppeling = ap.afstand_voorzijde_voertuig_tot_hart_koppeling;
            Lengte = ap.lengte;
            Breedte = ap.breedte;
            EuropeseVoertuigcategorie = ap.europese_voertuigcategorie;
            PlaatsChassisnummer = ap.plaats_chassisnummer;
            TechnischeMaxMassaVoertuig = ap.technische_max_massa_voertuig;
            VolgnummerWijzigingEuTypegoedkeuring = ap.volgnummer_wijziging_eu_typegoedkeuring;
            Wielbasis = ap.wielbasis;
            ExportIndicator = ap.export_indicator;
            OpenstaandeTerugroepactieIndicator = ap.openstaande_terugroepactie_indicator;
            TaxiIndicator = ap.taxi_indicator;
            MaximumMassaSamenstelling = ap.maximum_massa_samenstelling;
        }
    }
}