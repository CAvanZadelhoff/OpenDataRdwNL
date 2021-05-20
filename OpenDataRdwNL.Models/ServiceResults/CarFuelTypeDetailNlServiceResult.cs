using OpenDataRdwNL.Models.ApiResponses;

namespace OpenDataRdwNL.Models.ServiceResults
{
    public class CarFuelTypeDetailNlServiceResult
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
        public decimal NettoMaxVermogenElektrisch { get; set; }
        public string KlasseHybrideElektrischVoertuig { get; set; }
        public CarFuelTypeDetailNlServiceResult(CarFuelTypeDetailApiResponse ap)
        {
            Kenteken = ap.kenteken;
            BrandstofVolgnummer = ap.brandstof_volgnummer;
            BrandstofOmschrijving = ap.brandstof_omschrijving;
            EmissiecodeOmschrijving = ap.emissiecode_omschrijving;
            
            
            BrandStofverbruikBuiten = ap.brandstofverbruik_buiten;
            BrandStofverbruikGecombineerd = ap.brandstofverbruik_gecombineerd;
            BrandStofverbruikStad = ap.brandstofverbruik_stad;
            Co2UitstootGecombineerd = ap.co2_uitstoot_gecombineerd;
            GeluidsniveauRijdend = ap.geluidsniveau_rijdend;
            GeluidsniveauStationair = ap.geluidsniveau_stationair;
            ToerentalGeluidsniveau = ap.toerental_geluidsniveau;
            MilieuklasseEgGoedkeuringLicht = ap.milieuklasse_eg_goedkeuring_licht;
            NettoMaximumVermogen = ap.nettomaximumvermogen;
            
            NominaalContinuMaximumvermogen = ap.nominaal_continu_maximumvermogen;
            ElektrischVerbruikExternOpladenWltp = ap.elektrisch_verbruik_extern_opladen_wltp;
            ActieRadiusExternOpladenWltp = ap.actie_radius_extern_opladen_wltp;
            ActieRadiusExternOpladenStadWltp = ap.actie_radius_extern_opladen_stad_wltp;
            MaxVermogen60Minuten = ap.max_vermogen_60_minuten;
            NettoMaxVermogenElektrisch = ap.netto_max_vermogen_elektrisch;
            KlasseHybrideElektrischVoertuig = ap.klasse_hybride_elektrisch_voertuig;
        }

        public decimal NettoMaximumVermogen { get; set; }

        public string MilieuklasseEgGoedkeuringLicht { get; set; }

        public int ToerentalGeluidsniveau { get; set; }

        public int GeluidsniveauStationair { get; set; }

        public int GeluidsniveauRijdend { get; set; }

        public decimal Co2UitstootGecombineerd { get; set; }

        public decimal BrandStofverbruikStad { get; set; }

        public decimal BrandStofverbruikGecombineerd { get; set; }

        public decimal BrandStofverbruikBuiten { get; set; }
    }
}