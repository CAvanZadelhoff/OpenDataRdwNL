using OpenDataRdwNL.Models.ApiResponses;
using System;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarDetailNlServiceResult
    {
        public string Kenteken { get; set; }
        public string Voertuigsoort { get; set; }
        public string Merk { get; set; }
        public string Handelsbenaming { get; set; }
        public int VervaldatumApk { get; set; }
        public int DatumTenaamstelling { get; set; }
        public int BrutoBpm { get; set; }
        public string Inrichting { get; set; }
        public int AantalZitplaatsen { get; set; }
        public string EersteKleur { get; set; }
        public string TweedeKleur { get; set; }
        public int AantalCilinders { get; set; }
        public int Cilinderinhoud { get; set; }
        public int MassaLedigVoertuig { get; set; }
        public int ToegestaneMaximumMassaVoertuig { get; set; }
        public int MassaRijklaar { get; set; }
        public int MaximumMassaTrekkenOngeremd { get; set; }
        public int MaximumTrekkenMassaGeremd { get; set; }
        public int DatumEersteToelating { get; set; }
        public int DatumEersteTenaamstellingInNederland { get; set; }
        public string WachtOpKeuren { get; set; }
        public int Catalogusprijs { get; set; }
        public string WamVerzekerd { get; set; }
        public int MaximaleConstructiesnelheid { get; set; }
        public int Laadvermogen { get; set; }
        public int OpleggerGeremd { get; set; }
        public int AanhangwagenAutonoomGeremd { get; set; }
        public int AanhangwagenMiddenasGeremd { get; set; }
        public int AantalStaanplaatsen { get; set; }
        public int AantalDeuren { get; set; }
        public int AantalWielen { get; set; }
        public int AfstandHartKoppelingTotAchterzijdeVoertuig { get; set; }
        public int AfstandVoorzijdeVoertuigTotHartKoppeling { get; set; }
        public int AfwijkendeMaximumSnelheid { get; set; }
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public string EuropeseVoertuigcategorie { get; set; }
        public string EuropeseVoertuigcategorieToevoeging { get; set; }
        public string EuropeseUitvoeringcategorieToevoeging { get; set; }
        public string PlaatsChassisnummer { get; set; }
        public int TechnischeMaxMassaVoertuig { get; set; }
        public string Type { get; set; }
        public string TypeGasinstallatie { get; set; }
        public string Typegoedkeuringsnummer { get; set; }
        public string Variant { get; set; }
        public string Uitvoering { get; set; }
        public int VolgnummerWijzigingEuTypegoedkeuring { get; set; }
        public decimal VermogenMassarijklaar { get; set; }
        public int Wielbasis { get; set; }
        public string ExportIndicator { get; set; }
        public string OpenstaandeTerugroepactieIndicator { get; set; }
        public int VervaldatumTachograaf { get; set; }
        public string TaxiIndicator { get; set; }
        public int MaximumMassaSamenstelling { get; set; }
        public int AantalRolstoelplaatsen { get; set; }
        public decimal MaximumOndersteunendeSnelheid { get; set; }
        public int JaarLaatsteRegistratieTellerstand { get; set; }
        public string Tellerstandoordeel { get; set; }
        public string CodeToelichtingTellerstandoordeel { get; set; }
        public string TenaamstellenMogelijk { get; set; }
        public DateTime VervaldatumAPKDT { get; set; }
        public DateTime DatumTenaamstellingDT { get; set; }
        public DateTime DatumEersteToelatingDT { get; set; }
        public DateTime DatumEersteTenaamstellingInNederlandDT { get; set; }
        public DateTime VervaldatumTachograafDT { get; set; }
        public int MaximumLastOnderDeVoorassenTezamenKoppeling { get; set; }
        public string TypeRemsysteemVoertuigCode { get; set; }
        public string Rupsonderstelconfiguratiecode { get; set; }
        public int WielbasisVoertuigMinimum { get; set; }
        public int WielbasisVoertuigMaximum { get; set; }
        public int LengteVoertuigMinimum { get; set; }
        public int LengteVoertuigMaximum { get; set; }
        public int BreedteVoertuigMinimum { get; set; }
        public int BreedteVoertuigMaximum { get; set; }
        public int HoogteVoertuig { get; set; }
        public int HoogteVoertuigMinimum { get; set; }
        public int HoogteVoertuigMaximum { get; set; }
        public int MassaBedrijfsklaarMinimaal { get; set; }
        public int MassaBedrijfsklaarMaximaal { get; set; }
        public int TechnischToelaatbaarMassaKoppelpunt { get; set; }
        public int MaximumMassaTechnischMaximaal { get; set; }
        public int MaximumMassaTechnischMinimaal { get; set; }
        public string SubcategorieNederland { get; set; }
        public int VerticaleBelastingKoppelpuntGetrokkenVoertuig { get; set; }
        public string Zuinigheidsclassificatie { get; set; }
        public int RegistratieDatumGoedkeuring_afschrijvingsmomentBPM { get; set; }
        public DateTime RegistratieDatumGoedkeuring_afschrijvingsmomentBPMDT { get; set; }
        public int GemiddeldeLadingWaarde { get; set; }
        public string AerodynamischeVoorzieningOfUitrusting { get; set; }
        public int AdditioneleMassaAlternatieveAandrijving { get; set; }
        public string VerlengdeCabineIndicator { get; set; }
        public string APIGekentekendeVoertuigenAssen { get; set; }
        public string APIGekentekendeVoertuigenBrandstof { get; set; }
        public string APIGekentekendeVoertuigenCarrosserie { get; set; }
        public string APIGekentekendeVoertuigenCarrosserieSpecifiek { get; set; }
        public string APIGekentekendeVoertuigenVoertuigklasse { get; set; }




        public CarDetailNlServiceResult(CarDetailApiResponse ap)
        {
            Kenteken = ap.kenteken;
            Voertuigsoort = ap.voertuigsoort;
            Merk = ap.merk;
            Handelsbenaming = ap.handelsbenaming;
            VervaldatumApk = ap.vervaldatum_apk;
            DatumTenaamstelling = ap.datum_tenaamstelling;
            BrutoBpm = ap.bruto_bpm;
            Inrichting = ap.inrichting;
            AantalZitplaatsen = ap.aantal_zitplaatsen;
            EersteKleur = ap.eerste_kleur;
            TweedeKleur = ap.tweede_kleur;
            AantalCilinders = ap.aantal_cilinders;
            Cilinderinhoud = ap.cilinderinhoud;
            MassaLedigVoertuig = ap.massa_ledig_voertuig;
            ToegestaneMaximumMassaVoertuig = ap.toegestane_maximum_massa_voertuig;
            MassaRijklaar = ap.massa_rijklaar;
            MaximumMassaTrekkenOngeremd = ap.maximum_massa_trekken_ongeremd;
            MaximumTrekkenMassaGeremd = ap.maximum_trekken_massa_geremd;
            DatumEersteToelating = ap.datum_eerste_toelating;
            DatumEersteTenaamstellingInNederland = ap.datum_eerste_tenaamstelling_in_nederland;
            WachtOpKeuren = ap.wacht_op_keuren;
            Catalogusprijs = ap.catalogusprijs;
            WamVerzekerd = ap.wam_verzekerd;
            MaximaleConstructiesnelheid = ap.maximale_constructiesnelheid;
            Laadvermogen = ap.laadvermogen;
            OpleggerGeremd = ap.oplegger_geremd;
            AanhangwagenAutonoomGeremd = ap.aanhangwagen_autonoom_geremd;
            AanhangwagenMiddenasGeremd = ap.aanhangwagen_middenas_geremd;
            AantalStaanplaatsen = ap.aantal_staanplaatsen;
            AantalDeuren = ap.aantal_deuren;
            AantalWielen = ap.aantal_wielen;
            AfstandHartKoppelingTotAchterzijdeVoertuig = ap.afstand_hart_koppeling_tot_achterzijde_voertuig;
            AfstandVoorzijdeVoertuigTotHartKoppeling = ap.afstand_voorzijde_voertuig_tot_hart_koppeling;
            AfwijkendeMaximumSnelheid = ap.afwijkende_maximum_snelheid;
            Lengte = ap.lengte;
            Breedte = ap.breedte;
            EuropeseVoertuigcategorie = ap.europese_voertuigcategorie;
            EuropeseVoertuigcategorieToevoeging = ap.europese_voertuigcategorie_toevoeging;
            EuropeseUitvoeringcategorieToevoeging = ap.europese_uitvoeringcategorie_toevoeging;
            PlaatsChassisnummer = ap.plaats_chassisnummer;
            TechnischeMaxMassaVoertuig = ap.technische_max_massa_voertuig;
            Type = ap.type;
            TypeGasinstallatie = ap.type_gasinstallatie;
            Typegoedkeuringsnummer = ap.typegoedkeuringsnummer;
            Variant = ap.variant;
            Uitvoering = ap.uitvoering;
            VolgnummerWijzigingEuTypegoedkeuring = ap.volgnummer_wijziging_eu_typegoedkeuring;
            VermogenMassarijklaar = ap.vermogen_massarijklaar;
            Wielbasis = ap.wielbasis;
            ExportIndicator = ap.export_indicator;
            OpenstaandeTerugroepactieIndicator = ap.openstaande_terugroepactie_indicator;
            VervaldatumTachograaf = ap.vervaldatum_tachograaf;
            TaxiIndicator = ap.taxi_indicator;
            MaximumMassaSamenstelling = ap.maximum_massa_samenstelling;
            AantalRolstoelplaatsen = ap.aantal_rolstoelplaatsen;
            MaximumOndersteunendeSnelheid = ap.maximum_ondersteunende_snelheid;
            JaarLaatsteRegistratieTellerstand = ap.jaar_laatste_registratie_tellerstand;
            Tellerstandoordeel = ap.tellerstandoordeel;
            CodeToelichtingTellerstandoordeel = ap.code_toelichting_tellerstandoordeel;
            TenaamstellenMogelijk = ap.tenaamstellen_mogelijk;
            VervaldatumAPKDT = ap.vervaldatum_apk_dt;
            DatumTenaamstellingDT = ap.datum_tenaamstelling_dt;
            DatumEersteToelatingDT = ap.datum_eerste_toelating_dt;
            DatumEersteTenaamstellingInNederlandDT = ap.datum_eerste_tenaamstelling_in_nederland_dt;
            VervaldatumTachograafDT = ap.vervaldatum_tachograaf_dt;
            MaximumLastOnderDeVoorassenTezamenKoppeling = ap.maximum_last_onder_de_vooras_sen_tezamen_koppeling;
            TypeRemsysteemVoertuigCode = ap.type_remsysteem_voertuig_code;
            Rupsonderstelconfiguratiecode = ap.rupsonderstelconfiguratiecode;
            WielbasisVoertuigMinimum = ap.wielbasis_voertuig_minimum;
            WielbasisVoertuigMaximum = ap.wielbasis_voertuig_maximum;
            LengteVoertuigMinimum = ap.lengte_voertuig_minimum;
            LengteVoertuigMaximum = ap.lengte_voertuig_maximum;
            BreedteVoertuigMinimum = ap.breedte_voertuig_minimum;
            BreedteVoertuigMaximum = ap.breedte_voertuig_maximum;
            HoogteVoertuig = ap.hoogte_voertuig;
            HoogteVoertuigMinimum = ap.hoogte_voertuig_minimum;
            HoogteVoertuigMaximum = ap.hoogte_voertuig_maximum;
            MassaBedrijfsklaarMinimaal = ap.massa_bedrijfsklaar_minimaal;
            MassaBedrijfsklaarMaximaal = ap.massa_bedrijfsklaar_maximaal;
            TechnischToelaatbaarMassaKoppelpunt = ap.technisch_toelaatbaar_massa_koppelpunt;
            MaximumMassaTechnischMaximaal = ap.maximum_massa_technisch_maximaal;
            MaximumMassaTechnischMinimaal = ap.maximum_massa_technisch_minimaal;
            SubcategorieNederland = ap.subcategorie_nederland;
            VerticaleBelastingKoppelpuntGetrokkenVoertuig = ap.verticale_belasting_koppelpunt_getrokken_voertuig;
            Zuinigheidsclassificatie = ap.zuinigheidsclassificatie;
            RegistratieDatumGoedkeuring_afschrijvingsmomentBPM = ap.registratie_datum_goedkeuring_afschrijvingsmoment_bpm;
            RegistratieDatumGoedkeuring_afschrijvingsmomentBPMDT = ap.registratie_datum_goedkeuring_afschrijvingsmoment_bpm_dt;
            GemiddeldeLadingWaarde = ap.gem_lading_wrde;
            AerodynamischeVoorzieningOfUitrusting = ap.aerodyn_voorz;
            AdditioneleMassaAlternatieveAandrijving = ap.massa_alt_aandr;
            VerlengdeCabineIndicator = ap.verl_cab_ind;
            APIGekentekendeVoertuigenAssen = ap.api_gekentekende_voertuigen_assen;
            APIGekentekendeVoertuigenBrandstof = ap.api_gekentekende_voertuigen_brandstof;
            APIGekentekendeVoertuigenCarrosserie = ap.api_gekentekende_voertuigen_carrosserie;
            APIGekentekendeVoertuigenCarrosserieSpecifiek = ap.api_gekentekende_voertuigen_carrosserie_specifiek;
            APIGekentekendeVoertuigenVoertuigklasse = ap.api_gekentekende_voertuigen_voertuigklasse;
        }
    }
}