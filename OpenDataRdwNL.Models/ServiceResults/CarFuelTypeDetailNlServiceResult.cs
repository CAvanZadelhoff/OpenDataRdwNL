using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarFuelTypeDetailNlServiceResult
    {
        public string Kenteken { get; set; }
        public string BrandstofVolgnummer { get; set; }
        public string BrandstofOmschrijving { get; set; }
        public string BrandstofverbruikBuitenDeStad { get; set; }
        public string BrandstofverbruikGecombineerd { get; set; }
        public string BrandstofverbruikStad { get; set; }
        public string CO2UitstootGecombineerd { get; set; }
        public string CO2UitstootGewogen { get; set; }
        public string GeluidsniveauRijdend { get; set; }
        public string GeluidsniveauStationair { get; set; }
        public string Emissieklasse { get; set; }
        public string MilieuklasseEgGoedkeuringLicht { get; set; }
        public string MilieuklasseEgGoedkeuringZwaar { get; set; }
        public string UitstootDeeltjesLicht { get; set; }
        public string UitstootDeeltjesZwaar { get; set; }
        public string NettoMaximumVermogen { get; set; }
        public string NominaalContinuMaximumvermogen { get; set; }
        public string Roetuitstoot { get; set; }
        public string ToerentalGeluidsniveau { get; set; }
        public int EmissieDeeltjesType1Wltp { get; set; }
        public int EmissieCo2GecombineerdWltp { get; set; }
        public int EmissieCo2GewogenGecombineerdWltp { get; set; }
        public decimal BrandstofVerbruikGecombineerdWltp { get; set; }
        public decimal BrandstofVerbruikGewogenGecombineerdWltp { get; set; }
        public decimal ElektrischVerbruikEnkelElektrischWltp { get; set; }
        public int ActieRadiusEnkelElektrischWltp { get; set; }
        public int ActieRadiusEnkelElektrischStadWltp { get; set; }
        public decimal ElektrischVerbruikExternOpladenWltp { get; set; }
        public int ActieRadiusExternOpladenWltp { get; set; }
        public int ActieRadiusExternOpladenStadWltp { get; set; }
        public decimal MaxVermogen15Minuten { get; set; }
        public decimal MaxVermogen60Minuten { get; set; }
        public decimal NettoMaxVermogenElektrisch { get; set; }
        public string KlasseHybrideElektrischVoertuig { get; set; }
        public int OpgegevenMaximumSnelheid { get; set; }
        public string UitlaatEmissieNiveau { get; set; }

        public CarFuelTypeDetailNlServiceResult(CarFuelTypeDetailApiResponse ap)
        {
            Kenteken = ap.kenteken;
            BrandstofVolgnummer = ap.brandstof_volgnummer;
            BrandstofOmschrijving = ap.brandstof_omschrijving;
            BrandstofverbruikBuitenDeStad = ap.brandstofverbruik_buiten_de_stad;
            BrandstofverbruikGecombineerd = ap.brandstofverbruik_gecombineerd;
            BrandstofverbruikStad = ap.brandstofverbruik_stad;
            CO2UitstootGecombineerd = ap.co2_uitstoot_gecombineerd;
            CO2UitstootGewogen = ap.co2_uitstoot_gewogen;
            GeluidsniveauRijdend = ap.geluidsniveau_rijdend;
            GeluidsniveauStationair = ap.geluidsniveau_stationair;
            Emissieklasse = ap.emissieklasse;
            MilieuklasseEgGoedkeuringLicht = ap.milieuklasse_eg_goedkeuring_licht;
            MilieuklasseEgGoedkeuringZwaar = ap.milieuklasse_eg_goedkeuring_zwaar;
            UitstootDeeltjesLicht = ap.uitstoot_deeltjes_licht;
            UitstootDeeltjesZwaar = ap.uitstoot_deeltjes_zwaar;
            NettoMaximumVermogen = ap.nettomaximumvermogen;
            NominaalContinuMaximumvermogen = ap.nominaal_continu_maximumvermogen;
            Roetuitstoot = ap.roetuitstoot;
            ToerentalGeluidsniveau = ap.toerental_geluidsniveau;
            EmissieDeeltjesType1Wltp = ap.emissie_deeltjes_type1_wltp;
            EmissieCo2GecombineerdWltp = ap.emissie_co2_gecombineerd_wltp;
            EmissieCo2GewogenGecombineerdWltp = ap.emissie_co2_gewogen_gecombineerd_wltp;
            BrandstofVerbruikGecombineerdWltp = ap.brandstof_verbruik_gecombineerd_wltp;
            BrandstofVerbruikGewogenGecombineerdWltp = ap.brandstof_verbruik_gewogen_gecombineerd_wltp;
            ElektrischVerbruikEnkelElektrischWltp = ap.elektrisch_verbruik_enkel_elektrisch_wltp;
            ActieRadiusEnkelElektrischWltp = ap.actie_radius_enkel_elektrisch_wltp;
            ActieRadiusEnkelElektrischStadWltp = ap.actie_radius_enkel_elektrisch_stad_wltp;
            ElektrischVerbruikExternOpladenWltp = ap.elektrisch_verbruik_extern_opladen_wltp;
            ActieRadiusExternOpladenWltp = ap.actie_radius_extern_opladen_wltp;
            ActieRadiusExternOpladenStadWltp = ap.actie_radius_extern_opladen_stad_wltp;
            MaxVermogen15Minuten = ap.max_vermogen_15_minuten;
            MaxVermogen60Minuten = ap.max_vermogen_60_minuten;
            NettoMaxVermogenElektrisch = ap.netto_max_vermogen_elektrisch;
            KlasseHybrideElektrischVoertuig = ap.klasse_hybride_elektrisch_voertuig;
            OpgegevenMaximumSnelheid = ap.opgegeven_maximum_snelheid;
            UitlaatEmissieNiveau = ap.uitlaatemissieniveau;
        }
    }
}