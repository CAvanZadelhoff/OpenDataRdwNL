namespace OpenDataRdwNL.Models.ApiResponses
{
    public class CarFuelTypeDetailApiResponse
    {
        public string kenteken { get; set; }
        public int brandstof_volgnummer { get; set; }
        public string brandstof_omschrijving { get; set; }
        
        public decimal brandstofverbruik_buiten { get; set; }
        public decimal brandstofverbruik_gecombineerd { get; set; }
        public decimal brandstofverbruik_stad { get; set; }
        public decimal co2_uitstoot_gecombineerd { get; set; }
        public int geluidsniveau_rijdend { get; set; }
        public int geluidsniveau_stationair { get; set; }
        public string milieuklasse_eg_goedkeuring_licht { get; set; }
        public decimal nettomaximumvermogen { get; set; }
        public int toerental_geluidsniveau { get; set; }
        public string emissiecode_omschrijving { get; set; }
        public double nominaal_continu_maximumvermogen { get; set; }
        public int elektrisch_verbruik_extern_opladen_wltp { get; set; }
        public int actie_radius_extern_opladen_wltp { get; set; }
        public int actie_radius_extern_opladen_stad_wltp { get; set; }
        public int max_vermogen_60_minuten { get; set; }
        public decimal netto_max_vermogen_elektrisch { get; set; }
        public string klasse_hybride_elektrisch_voertuig { get; set; }
    }
}