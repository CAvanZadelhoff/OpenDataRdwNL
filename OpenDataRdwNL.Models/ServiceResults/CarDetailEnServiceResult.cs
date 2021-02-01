using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarDetailEnServiceResult
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
}