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
}