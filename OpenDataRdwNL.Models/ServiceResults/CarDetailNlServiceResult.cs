using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarDetailNlServiceResult
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