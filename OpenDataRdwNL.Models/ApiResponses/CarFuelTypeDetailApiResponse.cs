namespace OpenDataRdwNL.Models.ApiResponses
{
    public class CarFuelTypeDetailApiResponse
    {
        public string kenteken { get; set; }
        public int brandstof_volgnummer { get; set; }
        public string brandstof_omschrijving { get; set; }
        public string emissiecode_omschrijving { get; set; }
        public double nominaal_continu_maximumvermogen { get; set; }
        public int elektrisch_verbruik_extern_opladen_wltp { get; set; }
        public int actie_radius_extern_opladen_wltp { get; set; }
        public int actie_radius_extern_opladen_stad_wltp { get; set; }
        public int max_vermogen_60_minuten { get; set; }
        public int netto_max_vermogen_elektrisch { get; set; }
        public string klasse_hybride_elektrisch_voertuig { get; set; }
    }
}