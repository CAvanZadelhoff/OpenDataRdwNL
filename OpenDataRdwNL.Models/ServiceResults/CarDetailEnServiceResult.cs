using OpenDataRdwNL.Models.ApiResponses;
using System;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarDetailEnServiceResult
    {
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public string Brand { get; set; }
        public string TradeName { get; set; }
        public int ExpiryDateMot { get; set; }
        public int DateRegistration { get; set; }
        public int GrossBpm { get; set; }
        public string Design { get; set; }
        public int NumberOfSeats { get; set; }
        public string FirstColor { get; set; }
        public string SecondColor { get; set; }
        public int AmountOfCylinders { get; set; }
        public int CylinderCapacity { get; set; }
        public int MassEmptyVehicle { get; set; }
        public int PermittedMaximumMassOfVehicle { get; set; }
        public int MassRoadworthy { get; set; }
        public int MaximumMassPullingUnbraked { get; set; }
        public int MaximumPullingMassBraked { get; set; }
        public int DateOfFirstAdmission { get; set; }
        public int DateOfFirstIssueInTheNetherlands { get; set; }
        public string WaitForInspection { get; set; }
        public int CatalogPrice { get; set; }
        public string WamInsured { get; set; }
        public int MaximumConstructionSpeed { get; set; }
        public int LoadCapacity { get; set; }
        public int SemiTrailerBraked { get; set; }
        public int TrailerAutonomousBraked { get; set; }
        public int TrailerMidAxleBraked { get; set; }
        public int NumberOfStandingPlaces { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public int DistanceCenterClutchToRearOfVehicle { get; set; }
        public int DistanceFrontVehicleToCenterClutch { get; set; }
        public int DifferentMaximumSpeed { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string EuropeanVehicleCategory { get; set; }
        public string EuropeanVehicleCategoryAddition { get; set; }
        public string EuropeanConstructionCategoryAddition { get; set; }
        public string PlaceChassisNumber { get; set; }
        public int TechnicalMaxMassVehicle { get; set; }
        public string Type { get; set; }
        public string TypeGasplant { get; set; }
        public string TypeApprovalNumber { get; set; }
        public string Variant { get; set; }
        public string Performance { get; set; }
        public int SequenceNumberChangeEuTypeApproval { get; set; }
        public decimal PowerReadyForUse { get; set; }
        public int Wheelbase { get; set; }
        public string ExportIndicator { get; set; }
        public string PendingRecallIndicator { get; set; }
        public int ExpiryDateTachograph { get; set; }
        public string TaxiIndicator { get; set; }
        public int MaximumMassComposition { get; set; }
        public int NumberOfWheelchairSpaces { get; set; }
        public decimal MaximumSupportingSpeed { get; set; }
        public int YearLastRegistrationCounterMileage { get; set; }
        public string OdometerVerdict { get; set; }
        public string CodeReferenceOdometerVerdict { get; set; }
        public string RegistrationPossible { get; set; }
        public DateTime ExpirationDateAPK_DT { get; set; }
        public DateTime DateOfRegistration_DT { get; set; }
        public DateTime DateOfFirstAdmission_DT { get; set; }
        public DateTime DateOfFirstIssueInTheNetherlands_DT { get; set; }
        public DateTime ExpiryDateTachograph_DT { get; set; }
        public int MaximumLoadUnderTheFrontAxlesTogetherClutch { get; set; }
        public string TypeBrakeSystemVehicleCode { get; set; }
        public string CaterpillarUndercarriageConfigurationCode { get; set; }
        public int WheelbaseVehicleMinimum { get; set; }
        public int WheelbaseVehicleMaximum { get; set; }
        public int LengthVehicleMinimum { get; set; }
        public int LengthVehicleMaximum { get; set; }
        public int WidthVehicleMinimum { get; set; }
        public int WidthVehicleMaximum { get; set; }
        public int VehicleHeightMaximum { get; set; }
        public int HeightVehicleMinimum { get; set; }
        public int HeightVehicleMaximum { get; set; }
        public int MassOperationalMinimum { get; set; }
        public int MassOperationalMaximum { get; set; }
        public int TechnicallyPermissibleMassCouplingPoint { get; set; }
        public int MaximumMassTechnicalMaximum { get; set; }
        public int MaximumMassTechnicalMinimum { get; set; }
        public string SubcategoryNetherlands { get; set; }
        public int VerticalLoadCouplingPointPulledVehicle { get; set; }
        public string EconomyRating { get; set; }
        public int RegistrationDateApprovalDepreciationMomentBPM { get; set; }
        public DateTime RegistrationDateApprovalDepreciationMomentBPM_DT { get; set; }
        public int AverageLoadValue { get; set; }
        public string AerodynamicFeatureOfEquipment { get; set; }
        public int AdditionalMassAlternativeDrive { get; set; }
        public string ExtendedCabIndicator { get; set; }
        public string APISignedVehiclesAxis { get; set; }
        public string APISignedVehiclesFuel { get; set; }
        public string APISignedVehiclesBodyWork { get; set; }
        public string APISignedVehiclesBodyWorkSpecific { get; set; }
        public string APISignedVehiclesClass { get; set; }


        public CarDetailEnServiceResult(CarDetailApiResponse ap)
        {
            LicensePlate = ap.kenteken;
            VehicleType = ap.voertuigsoort;
            Brand = ap.merk;
            TradeName = ap.handelsbenaming;
            ExpiryDateMot = ap.vervaldatum_apk;
            DateRegistration = ap.datum_tenaamstelling;
            GrossBpm = ap.bruto_bpm;
            Design = ap.inrichting;
            NumberOfSeats = ap.aantal_zitplaatsen;
            FirstColor = ap.eerste_kleur;
            SecondColor = ap.tweede_kleur;
            AmountOfCylinders = ap.aantal_cilinders;
            CylinderCapacity = ap.cilinderinhoud;
            MassEmptyVehicle = ap.massa_ledig_voertuig;
            PermittedMaximumMassOfVehicle = ap.toegestane_maximum_massa_voertuig;
            MassRoadworthy = ap.massa_rijklaar;
            MaximumMassPullingUnbraked = ap.maximum_massa_trekken_ongeremd;
            MaximumPullingMassBraked = ap.maximum_trekken_massa_geremd;
            DateOfFirstAdmission = ap.datum_eerste_toelating;
            DateOfFirstIssueInTheNetherlands = ap.datum_eerste_tenaamstelling_in_nederland;
            WaitForInspection = ap.wacht_op_keuren;
            CatalogPrice = ap.catalogusprijs;
            WamInsured = ap.wam_verzekerd;
            MaximumConstructionSpeed = ap.maximale_constructiesnelheid;
            LoadCapacity = ap.laadvermogen;
            SemiTrailerBraked = ap.oplegger_geremd;
            TrailerAutonomousBraked = ap.aanhangwagen_autonoom_geremd;
            TrailerMidAxleBraked = ap.aanhangwagen_middenas_geremd;
            NumberOfStandingPlaces = ap.aantal_staanplaatsen;
            NumberOfDoors = ap.aantal_deuren;
            NumberOfWheels = ap.aantal_wielen;
            DistanceCenterClutchToRearOfVehicle = ap.afstand_hart_koppeling_tot_achterzijde_voertuig;
            DistanceFrontVehicleToCenterClutch = ap.afstand_voorzijde_voertuig_tot_hart_koppeling;
            DifferentMaximumSpeed = ap.afwijkende_maximum_snelheid;
            Length = ap.lengte;
            Width = ap.breedte;
            EuropeanVehicleCategory = ap.europese_voertuigcategorie;
            EuropeanVehicleCategoryAddition = ap.europese_voertuigcategorie_toevoeging;
            EuropeanConstructionCategoryAddition = ap.europese_uitvoeringcategorie_toevoeging;
            PlaceChassisNumber = ap.plaats_chassisnummer;
            TechnicalMaxMassVehicle = ap.technische_max_massa_voertuig;
            Type = ap.type;
            TypeGasplant = ap.type_gasinstallatie;
            TypeApprovalNumber = ap.typegoedkeuringsnummer;
            Variant = ap.variant;
            Performance = ap.uitvoering;
            SequenceNumberChangeEuTypeApproval = ap.volgnummer_wijziging_eu_typegoedkeuring;
            PowerReadyForUse = ap.vermogen_massarijklaar;
            Wheelbase = ap.wielbasis;
            ExportIndicator = ap.export_indicator;
            PendingRecallIndicator = ap.openstaande_terugroepactie_indicator;
            ExpiryDateTachograph = ap.vervaldatum_tachograaf;
            TaxiIndicator = ap.taxi_indicator;
            MaximumMassComposition = ap.maximum_massa_samenstelling;
            NumberOfWheelchairSpaces = ap.aantal_rolstoelplaatsen;
            MaximumSupportingSpeed = ap.maximum_ondersteunende_snelheid;
            YearLastRegistrationCounterMileage = ap.jaar_laatste_registratie_tellerstand;
            OdometerVerdict = ap.tellerstandoordeel;
            CodeReferenceOdometerVerdict = ap.code_toelichting_tellerstandoordeel;
            RegistrationPossible = ap.tenaamstellen_mogelijk;
            ExpirationDateAPK_DT = ap.vervaldatum_apk_dt;
            DateOfRegistration_DT = ap.datum_tenaamstelling_dt;
            DateOfFirstAdmission_DT = ap.datum_eerste_toelating_dt;
            DateOfFirstIssueInTheNetherlands_DT = ap.datum_eerste_tenaamstelling_in_nederland_dt;
            ExpiryDateTachograph_DT = ap.vervaldatum_tachograaf_dt;
            MaximumLoadUnderTheFrontAxlesTogetherClutch = ap.maximum_last_onder_de_vooras_sen_tezamen_koppeling;
            TypeBrakeSystemVehicleCode = ap.type_remsysteem_voertuig_code;
            CaterpillarUndercarriageConfigurationCode = ap.rupsonderstelconfiguratiecode;
            WheelbaseVehicleMinimum = ap.wielbasis_voertuig_minimum;
            WheelbaseVehicleMaximum = ap.wielbasis_voertuig_maximum;
            LengthVehicleMinimum = ap.lengte_voertuig_minimum;
            LengthVehicleMaximum = ap.lengte_voertuig_maximum;
            WidthVehicleMinimum = ap.breedte_voertuig_minimum;
            WidthVehicleMaximum = ap.breedte_voertuig_maximum;
            VehicleHeightMaximum = ap.hoogte_voertuig;
            HeightVehicleMinimum = ap.hoogte_voertuig_minimum;
            HeightVehicleMaximum = ap.hoogte_voertuig_maximum;
            MassOperationalMinimum = ap.massa_bedrijfsklaar_minimaal;
            MassOperationalMaximum = ap.massa_bedrijfsklaar_maximaal;
            TechnicallyPermissibleMassCouplingPoint = ap.technisch_toelaatbaar_massa_koppelpunt;
            MaximumMassTechnicalMaximum = ap.maximum_massa_technisch_maximaal;
            MaximumMassTechnicalMinimum = ap.maximum_massa_technisch_minimaal;
            SubcategoryNetherlands = ap.subcategorie_nederland;
            VerticalLoadCouplingPointPulledVehicle = ap.verticale_belasting_koppelpunt_getrokken_voertuig;
            EconomyRating = ap.zuinigheidsclassificatie;
            RegistrationDateApprovalDepreciationMomentBPM = ap.registratie_datum_goedkeuring_afschrijvingsmoment_bpm;
            RegistrationDateApprovalDepreciationMomentBPM_DT = ap.registratie_datum_goedkeuring_afschrijvingsmoment_bpm_dt;
            AverageLoadValue = ap.gem_lading_wrde;
            AerodynamicFeatureOfEquipment = ap.aerodyn_voorz;
            AdditionalMassAlternativeDrive = ap.massa_alt_aandr;
            ExtendedCabIndicator = ap.verl_cab_ind;
            APISignedVehiclesAxis = ap.api_gekentekende_voertuigen_assen;
            APISignedVehiclesFuel = ap.api_gekentekende_voertuigen_brandstof;
            APISignedVehiclesBodyWork = ap.api_gekentekende_voertuigen_carrosserie;
            APISignedVehiclesBodyWorkSpecific = ap.api_gekentekende_voertuigen_carrosserie_specifiek;
            APISignedVehiclesClass = ap.api_gekentekende_voertuigen_voertuigklasse;
        }
    }
}